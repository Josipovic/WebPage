using Stranica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Stranica.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult SnowNews() {

            NovostiContext db = new NovostiContext();
            var news = db.Novosti.OrderByDescending(x=>x.Id).Take(3).ToList();
            return PartialView(news);
        }
        public ActionResult ShowSingleNews(int id) {
            NovostiContext db = new NovostiContext();
            var news = db.Novosti.Find(id);
            return View(news);
        }

        public ActionResult LeaveComment(string Message, string Name,int id) {
            NovostiContext db = new NovostiContext();
            Komentar comment = new Komentar();
            comment.Text = Message;
            comment.Author = Name;
            var news = db.Novosti.Find(id);
            news.Komentari.Add(comment);
            db.SaveChanges();
            return RedirectToAction("ShowSingleNews",new { id=id});
        }
    }
}