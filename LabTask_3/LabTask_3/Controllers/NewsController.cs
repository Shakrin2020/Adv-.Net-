using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LabTask_3.Models;
using System.Data.SqlClient;
using LabTask_3.Models.Database;

namespace LabTask_3.Controllers
{
    public class NewsController : Controller
    {
        public ActionResult Index()
        {
            advNetEntities2 db = new advNetEntities2();

            var data = db.Newdatabases.ToList();

            return View(data); 
        }


        // GET: News
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Newdatabas()); 
        }

        [HttpPost]
        public ActionResult Create(Newdatabas n)
        {
            
            if (ModelState.IsValid)
            {
                advNetEntities2 db = new advNetEntities2();

                db.Newdatabases.Add(n);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(n);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            advNetEntities2 db = new advNetEntities2();

            var news = (from n in db.Newdatabases where n.Id == id select n).FirstOrDefault();

            return View(news);                  

        }

        [HttpPost]
        public ActionResult Edit(Newdatabas n_news)
        {
            if (ModelState.IsValid)
            {
                advNetEntities2 db = new advNetEntities2();

                var news = (from n in db.Newdatabases 
                            where n.Id == n_news.Id 
                            select n).FirstOrDefault();

                db.Entry(news).CurrentValues.SetValues(n_news);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            advNetEntities2 db = new advNetEntities2();

            var data = db.Newdatabases.ToList();

            var news = (from n in data
                        where n.Id == id 
                        select n).FirstOrDefault();

            db.Newdatabases.Remove(news);
            db.SaveChanges();
            
            return RedirectToAction("Index");
           // return View();                 

        }
    }
}