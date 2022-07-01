using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Northwind.EF.Logic;
using Northwind.EF.Entities;
using Northwind.EF.MVC.Models;

namespace Northwind.EF.WebApi.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class ShippersController : ApiController
    {
        ShippersLogic shippersLogic = new ShippersLogic();

        // GET: All Shippers https://localhost:44383/api/shippers/
        public IHttpActionResult Get()
        {
            List<Shippers> shippersList = shippersLogic.GetAll();

            List<ShipperView> shippersView = shippersList.Select(s => new ShipperView
            {
                Id = s.ShipperID,
                CompanyName = s.CompanyName,
                Phone = s.Phone
            }).ToList();

            return Ok(shippersView);
        }

        //GET: Shipper Ej:https://localhost:44383/api/shippers/3
        public IHttpActionResult Get(int id)
        {
            try
            {
                Shippers shipper = shippersLogic.GetShipper(id);

                if (shipper != null)
                {
                    ShipperView shipperView = new ShipperView
                    {
                        Id = shipper.ShipperID,
                        CompanyName = shipper.CompanyName,
                        Phone = shipper.Phone
                    };
                    return Ok(shipperView);
                }
            }
            catch (Exception)
            {
                return BadRequest();
            }
            return BadRequest();
        }

        //POST: Create
        [HttpPost]
        public IHttpActionResult Post([FromBody] ShipperView shipperView)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (shipperView.CompanyName == null || shipperView.Phone == null)
                    {
                        throw new Exception("Field company name or phone is empty");
                    }
                    else if (shipperView.CompanyName.Trim() == "" || shipperView.Phone.Trim() == "")
                    {
                        throw new Exception("Field company name or phone must be complete");
                    }

                    Shippers shipper = new Shippers
                    {
                        CompanyName = shipperView.CompanyName,
                        Phone = shipperView.Phone,
                    };

                    shippersLogic.Add(shipper);

                    Shippers newShipper = shippersLogic.GetLastShipper();
                    
                    return Ok(new ShipperView
                    {
                        Id = newShipper.ShipperID,
                        CompanyName = newShipper.CompanyName,
                        Phone = newShipper.Phone
                    });
                }
            }
            catch (Exception)
            {
                return BadRequest();
            }
            return BadRequest();
        }

        //PUT: Shipper
        [HttpPut]
        public IHttpActionResult Put(int id, [FromBody] ShipperView shipperView)
        {
            try
            {
                Shippers shipper = shippersLogic.GetShipper(id);

                if (shipper != null && ModelState.IsValid)
                {
                    shippersLogic.Update(new Shippers
                    {
                        ShipperID = id,
                        CompanyName = shipperView.CompanyName,
                        Phone = shipperView.Phone
                    });

                    shipperView.Id = id;

                    return Ok(shipperView);
                }
            }
            catch (Exception)
            {
                return BadRequest();
            }

            return BadRequest();
        }

        //DELETE: Shipper
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                shippersLogic.Delete(id);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
