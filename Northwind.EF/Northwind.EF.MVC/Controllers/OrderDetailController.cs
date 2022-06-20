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
    public class OrderDetailController : Controller
    {
        OrderDetailsLogic orderDetailsLogic = new OrderDetailsLogic();

        // GET: OrderDetail
        public ActionResult Index(int page=1)
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

            return View(orderDetailsPaginated);
        }

        //GET: Shipper/Update
        public ActionResult Update(int ordId, int prdId)
        {
            Order_Details orderDetail = orderDetailsLogic.GetOrderDetail(ordId, prdId);

            OrderDetailView orderView = new OrderDetailView
            {
                Id = orderDetail.OrderID,
                PrdId = orderDetail.ProductID,
                UnitPrice = orderDetail.UnitPrice,
                Quantity = orderDetail.Quantity,
                Discount = orderDetail.Discount,
            };

            return View(orderView);
        }

        //POST: OrderDetail/Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(int ordId, int prdId, OrderDetailView orderDetailView)
        {
            try
            {
                Order_Details orderDetail = orderDetailsLogic.GetOrderDetail(ordId,prdId);
                if (orderDetail != null && orderDetail.OrderID == orderDetailView.Id && orderDetail.ProductID == orderDetailView.PrdId  && ModelState.IsValid)
                {
                    orderDetailsLogic.Update(new Order_Details
                    {
                        OrderID = ordId,
                        ProductID = prdId,
                        UnitPrice = orderDetailView.UnitPrice,
                        Quantity = orderDetailView.Quantity,
                        Discount = orderDetailView.Discount,
                    });
                    return RedirectToAction("Index");
                }
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Error");
            }
            return View(orderDetailView);
        }

        //POST: OrderDetail/Delete
        [HttpPost, ActionName("Delete")]
        public JsonResult Delete(int ordId, int prdId)
        {
            try
            {
                orderDetailsLogic.Delete(ordId, prdId);
                return Json(new { message = "The order have been deleted successfully." }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {
                Response.StatusCode = 400;
                return Json(new { message = "The order couldn't be deleted." });
            }
        }
    }
}