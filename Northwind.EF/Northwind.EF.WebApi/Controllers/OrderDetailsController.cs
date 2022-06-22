using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Northwind.EF.Logic;
using Northwind.EF.Entities;
using Northwind.EF.MVC.Models;

namespace Northwind.EF.WebApi.Controllers
{
    public class OrderDetailsController : ApiController
    {
        OrderDetailsLogic orderDetailsLogic = new OrderDetailsLogic();

        // GET: All OrderDetails https://localhost:44383/api/orderdetails/
        public IHttpActionResult Get(int page = 1)
        {
            List<Order_Details> orderDetailsList = orderDetailsLogic.GetAll();
            
            List<OrderDetailView> orderDetailView = orderDetailsList.Select(o => new OrderDetailView
            {
                Id = o.OrderID,
                PrdId = o.ProductID,
                UnitPrice = o.UnitPrice,
                Discount = o.Discount,
                Quantity = o.Quantity,
            }).ToList();

            OrderDetailViewPaginated orderDetailsPaginated = new OrderDetailViewPaginated
            {
                OrdersPerPage = 10,
                OrderDetails = orderDetailView,
                CurrentPage = page
            };

            return Ok(orderDetailsPaginated);
        }

        //GET: Order Detail Ej:https://localhost:44383/api/orderdetails/10250?prdId=51
        public IHttpActionResult Get(int id, int prdId)
        {
            try
            {
                Order_Details orderDetail = orderDetailsLogic.GetOrderDetail(id, prdId);
                if (orderDetail != null)
                {
                    OrderDetailView orderView = new OrderDetailView
                    {
                        Id = orderDetail.OrderID,
                        PrdId = orderDetail.ProductID,
                        UnitPrice = orderDetail.UnitPrice,
                        Quantity = orderDetail.Quantity,
                        Discount = orderDetail.Discount,
                    };

                    return Ok(orderView);
                }
            }
            catch (Exception)
            {
                return BadRequest();
            }
            return BadRequest();
        }

        //Put: Order Detail
        [HttpPut]
        public IHttpActionResult Put(int id, int prdId, [FromBody] OrderDetailView orderDetailView)
        {
            try
            {
                Order_Details orderDetail = orderDetailsLogic.GetOrderDetail(id, prdId);
                if (orderDetail != null && ModelState.IsValid)
                {
                    orderDetailsLogic.Update(new Order_Details
                    {
                        OrderID = id,
                        ProductID = prdId,
                        UnitPrice = orderDetailView.UnitPrice,
                        Quantity = orderDetailView.Quantity,
                        Discount = orderDetailView.Discount,
                    });

                    orderDetailView.Id = id;
                    orderDetailView.PrdId = prdId;

                    return Ok(orderDetailView);
                }
            }
            catch (Exception)
            {
                return BadRequest();
            }
            return BadRequest();
        }

        //DELETE: Order Detail
        [HttpDelete]
        public IHttpActionResult Delete(int id, int prdId)
        {
            try
            {
                orderDetailsLogic.Delete(id, prdId);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
