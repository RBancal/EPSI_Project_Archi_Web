using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SystemExpert.WebUI.Models;

namespace SystemExpert.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Question()
        {
            return View(new QuestionViewModel());
        }

        [HttpPost]
        public ActionResult Question(QuestionViewModel model)
        {
            // handle question 

            return View();
        }
    }
}
