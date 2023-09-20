using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace weblab1.Controllers
{
    public class Lab1Controller : Controller
    {
        // GET: Lab1
        public ActionResult FirstViewMethod()
        {
            List<string> fructs = GetFructsList();
            return View(fructs);
        }
        public ActionResult SecondViewMethod()
        {
            return View(GetFructsList().OrderBy(x => x).ToList());
        }
        public ActionResult ThirdViewMethod()
        {
            return View(GetFructsList().OrderBy(x => x).ToList());
        
        }
        public List<string> GetFructsList()
        {
            List<string> fructs = new List<string>();
            fructs.Add("Яблоко");
            fructs.Add("Ананас");
            fructs.Add("Киви");
            fructs.Add("Мандарин");
            fructs.Add("Манго");
            fructs.Add("Груша");
            fructs.Add("Персик");
            return fructs;
        }

        public ActionResult MyViewMethod()
        {
            return View(GetFructsList().OrderBy(x => x).ToList());

        }

        public List<string> GetCoffeeList()
        {
            List<string> coffee = new List<string>();
            coffee.Add("Эспрессо");
            coffee.Add("Американо");
            coffee.Add("Латте");
            coffee.Add("Капучино");
            coffee.Add("Раф");
            return coffee;
        }
        public ActionResult tusckviewMethod()
        {
           
            return View(GetCoffeeList().OrderByDescending(x=>x.Length).ToList());
        }
    }
}