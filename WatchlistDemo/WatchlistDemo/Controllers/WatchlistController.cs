using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WatchlistDemo.Models;

namespace WatchlistDemo.Controllers
{
    public class WatchlistController : Controller
       

    {

        Lists l = new Lists();
        // GET: Watchlist
        public ActionResult Index()
        {

            return View();

        }
        [HttpPost]
        public ActionResult Index(string programingId)
        {

            var result = l.list.Where(l => l.UserId == 2 && l.ProgramId == Convert.ToInt32(programingId)).Select(t => t.isActive).FirstOrDefault();
            if(result==true)
            {
                return Json("true");
            }
            else
            {
                return Json("false");
            }
           
        }

        public ActionResult Update(string programingId, bool isActive)
        {
            var result = l.list.Where(l => l.UserId == 3 && l.ProgramId == Convert.ToInt32(programingId)).ToList();
            if(result.Count==0)
            {
                l.list.Add(new Wathlist { isActive = isActive, ProgramId = Convert.ToInt32(programingId), UserId = 1 });
                return Json("add new");
            }
            else
            {
                result.First().isActive = isActive;
                return Json("change isActive");
            }

        }


    }
}