using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Dao;
using Model.EF;

namespace COFFEE.Areas.Admin.Controllers
{
    public class OrderController : Controller
    {
        // GET: Admin/Product
        public ActionResult Index(string seachString, int page = 1, int pageSize = 5)
        {
            var dao = new OrderDao();
            var model = dao.ListAllPaging(seachString, page, pageSize);
            ViewBag.SeachString = seachString;
            SetViewBag();
            return View(model);
        }
        [HttpGet]
        public ActionResult Create()
        {
            SetViewBag();
            return View();
        }
        [HttpGet]
        public ActionResult Edit(long id)
        {
            var dao = new OrderDao();
            SetViewBag();
            return View();
        }
        [HttpPost]
        public ActionResult Create(Order model)
        {
            if (ModelState.IsValid)
            {
                var dao = new OrderDao();
                long id = dao.Insert(model);
                if (id > 0)
                {
                    return RedirectToAction("Index", "Order");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm  sản phẩm Thành Công");
                }
            }
            return View("Index");
        }
        [HttpPost]
        public ActionResult Edit(Order model)
        {
            if (ModelState.IsValid)
            {

            }
            return View();
        }
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            new OrderDao().Delete(id);
            return RedirectToAction("Index");

        }

        public void SetViewBag(long? selectID = null)
        {
            var dao = new StatusOrderDao();
            ViewBag.StatusOrder = new SelectList(dao.ListAll(),"ID","Name",selectID);
        }
    }
}