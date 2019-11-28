using RegistrationWithImage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistrationWithImage.Controllers
{
    public class ProductController : Controller
    {
        OnlineShopEntities db = new OnlineShopEntities();
        public ActionResult AddNewProduct()
        {
            return View();
        }

        public ActionResult SaveData(tblProduct item)
        {
            return View();
        }
    }
}