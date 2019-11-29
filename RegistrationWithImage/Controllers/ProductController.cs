using RegistrationWithImage.Models;
using System;
using System.Collections.Generic;
using System.IO;
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
            if(item.ProductName!=null && item.Price!=null && item.ImageUpload != null)
            {
                string fileName = Path.GetFileNameWithoutExtension(item.ImageUpload.FileName);
                string extension = Path.GetExtension(item.ImageUpload.FileName);
                fileName = fileName + DateTime.Now.ToString("yymmssff") + extension;
                item.PicUrl = fileName;
                item.ImageUpload.SaveAs(Path.Combine(Server.MapPath("~/AppFile/Images"), fileName));
                db.tblProducts.Add(item);
                db.SaveChanges();
            }

            var result = "Successfully Added";
            return Json(result,JsonRequestBehavior.AllowGet);
        }
    }
}