using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
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

        public ViewResult CKEditor()
        {
            return View();
        }

        [HttpGet]
        public void HTMLfile(string s)
        {
            
        }
		
	public void PradnyaFunction(object o)
	{
			//donothing
	}

	public void SalilFun1(printdto p)
  {
  }

	
	public bool Pradnya2Fun()

	{
	}
    }
}
