using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITScheduleChecking.Models;
using ITScheduleChecking.Others;
using System.Net.Mail;

namespace ITScheduleChecking.Controllers
{
    public class ITController : Controller
    {
        //
        // GET: /IT/

        private Entities db;
        public ITController()
        {
            this.db = new Entities(Others.Utility.getConnection());
        }


        //public ActionResult Index()
        //{

        //    ViewData["CurrentDate"] = DateTime.Today.Date.ToShortDateString();
        //    return View();
        //}

        public ActionResult Index()
        {

            ViewData["CurrentDate"] = DateTime.Today.Date.ToShortDateString();
            return View(db.getAllTask());
        }

        //catching the parameters.doneAt100 has all the textBox values i.e. those which are shown and those which are hidden in the view page.
        //for the hidden textBoxes these values are null. 
        [HttpPost]
        public ActionResult EditTasks(List<String> doneAt100, List<String> doneAt600, List<String> doneAt400)
        {
            db.saveTaskRecord(doneAt100, doneAt600, doneAt400);//sending to dbHelper class to edit the task.
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult SubmitMail()
        {
            List<Task> t = db.getAllTask();
            String s = "";
            for (int i = 0; i < 17; i++)
            {
                s = s + "<h1>" + t.ElementAt(i).tName + "</h1>\n";

            }
            
           // String body = s;

            Utility.sendMail(s);
            return RedirectToAction("Index");
        }


       

    }
}










