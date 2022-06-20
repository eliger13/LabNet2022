using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Northwind.EF.Logic;
using Northwind.EF.Entities;
using Northwind.EF.MVC.Models;

namespace Northwind.EF.MVC.Controllers
{
    public class ShipperController : Controller
    {
        ShippersLogic shippersLogic = new ShippersLogic();

        // GET: Shipper
        public ActionResult Index()
        {
            List<Shippers> shippersList = shippersLogic.GetAll();

            List<ShipperView> shippersView = shippersList.Select(s => new ShipperView
            {
                Id = s.ShipperID,
                CompanyName = s.CompanyName,
                Phone = s.Phone
            }).ToList();

            return View(shippersView);
        }

        //GET: Shipper/Insert
        public ActionResult Insert()
        {
            return View();
        }

        //POST: Shipper/Insert
        [HttpPost]
        public ActionResult Insert([Bind(Include = "CompanyName, Phone")] ShipperView shipperView)
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

                    return RedirectToAction("Index");
                }
            }
            catch(Exception)
            {
                ModelState.AddModelError("", "Unable to save changes, please, try again.");
            }
            return View(shipperView);
        }

        //GET: Shipper/Update
        public ActionResult Update(int id)
        {
            Shippers shipper = shippersLogic.GetShipper(id);

            ShipperView shipperView = new ShipperView
            {
                Id = shipper.ShipperID,
                CompanyName = shipper.CompanyName,
                Phone = shipper.Phone
            };

            return View(shipperView);
        }

        //POST: Shipper/Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(int id, ShipperView shipperView)
        {
            try
            {
                Shippers shipper = shippersLogic.GetShipper(id);

                if (shipper != null && shipper.ShipperID == shipperView.Id && ModelState.IsValid)
                {
                    shippersLogic.Update(new Shippers
                    {
                        ShipperID = id,
                        CompanyName = shipperView.CompanyName,
                        Phone = shipperView.Phone
                    });

                    return RedirectToAction("Index");
                }
            }
            catch (Exception)
            {

                return RedirectToAction("Index", "Error");
            }
            return View(shipperView);
        }

        //POST: Shipper/Delete
        [HttpPost, ActionName("Delete")]
        public JsonResult Delete(int id)
        {
            try
            {
                shippersLogic.Delete(id);
                return Json(new { message = "The shipper have been deleted successfully." }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {
                Response.StatusCode = 400;
                return Json(new { message = "The shipper couldn't be deleted." });
            }
        }
    }
}