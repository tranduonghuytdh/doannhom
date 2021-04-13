using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.EF;
using Model.Dao;
using COFFEE.Common;
using PagedList;

namespace COFFEE.Areas.Admin.Controllers
{
   
    public class UserController : BaseController
    {
        // GET: Admin/User
        public ActionResult Index(string seachString, int page = 1, int pageSize = 5)
        {
            var dao = new UserDao();
            var model = dao.ListAllPaging(seachString, page, pageSize);
            ViewBag.SeachString = seachString;
            return View(model);
        }
        [HttpGet]
        //khoi tao
        public ActionResult Create()
        {
            return View();
        }
        //sua
        public ActionResult Edit(int id)
        {
            var user = new UserDao().ViewDetail(id);
            return View(user);

        }
        [HttpPost]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();

                    var encryptorMD5Hash = Encryptor.MD5Hash(user.PassWord);
                    user.PassWord = encryptorMD5Hash;
                    long id = dao.Insert(user);
                    if (id > 0)
                    {
                        return RedirectToAction("Index", "User");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Thêm  User Thành Công");
                    }
                }

            return View("Index");
        }
        [HttpPost]
        public ActionResult Edit(User user)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                if (!string.IsNullOrEmpty(user.PassWord))
                {
                    var encryptorMD5Hash = Encryptor.MD5Hash(user.PassWord);
                    user.PassWord = encryptorMD5Hash;
                }
                var result = dao.Update(user);
                if (result)
                {
                    return RedirectToAction("Index", "User");
                }
                else
                {
                    ModelState.AddModelError("", "Cập Nhật User Thành Công");
                }
            }
            return View("Index");
        }
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            new UserDao().Delete(id);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public JsonResult ChangeStatus(long id)
        {
            var result = new UserDao().ChangeStatus(id);
            return Json(new
            {
                status = result
            }); ;
        }
    }
}