using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Assignment_MVC_Thanh.Data;
using Assignment_MVC_Thanh.Models;

namespace Assignment_MVC_Thanh.Controllers
{
    public class HomeController : Controller
    {

        private Assignment_MVC_ThanhContext db = new Assignment_MVC_ThanhContext();

        public ActionResult Index(string key)
        {
            if (key == "" || key == null)
            {
                return View(db.Products.ToList());
            }
            return View(db.Products.Where(p => p.Name.Contains(key)).ToList());
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            List<Product> listProduct = (List<Product>)Session["listProduct"] ?? new List<Product>();
            var productExist = false;
            if (listProduct.Count > 0)
            {
                foreach (var item in listProduct)
                {
                    if (item.Id == product.Id)
                    {
                        productExist = true;
                    }
                }
                if (!productExist)
                {
                    listProduct.Add(product);
                }
            }
            else
            {
                listProduct.Add(product);
            }
            Session.Add("listProduct", listProduct);

            return View(product);
        }

        public ActionResult ResendView()
        {
            var list = Session["Session"] as List<Product>;
            if (list != null)
            {
                return HttpNotFound();
            }
            return View(list);
        }
    }
}