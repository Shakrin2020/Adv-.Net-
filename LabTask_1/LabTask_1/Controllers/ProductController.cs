using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LabTask_1.Models;

namespace LabTask_1.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Home()
        {

            Product p = new Product();

            p.Name = "Laptop";
            p.Id = 124;
           
            return View(p);   // pass the object as the parameter of view
        }

        public ActionResult List()
        {
            List<Product> products = new List<Product>();

            for (int i = 0; i < 100; i++)
            {
                var p = new Product
                {
                    Id = i + 1,
                    Name = "Product " + (i + 1),
                };

                products.Add(p);
            }

            return View(products);
        }
    }
}
