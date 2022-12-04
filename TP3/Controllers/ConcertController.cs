using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TP3.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TP3.Controllers
{
    public class ConcertController : Controller
    {
        
        
        public IActionResult Index()
        {
            return View(ConcertData.Concerts);
        }

        [HttpGet]
        public IActionResult AddConcert()
        {
            ConcertViewModel model = new ConcertViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult AddConcert(ConcertViewModel model)
        {
            if (ModelState.IsValid)
            {
                ConcertData.Concerts.Add(model);
            }
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            ConcertViewModel conc = ConcertData.Concerts.Find(con => con.ConcertId == id);
            return View(conc);
        }

        [HttpPost]
        public IActionResult Edit(int id,ConcertViewModel model)
        {
            if (ModelState.IsValid)
            {
                ConcertViewModel conc = ConcertData.Concerts.Find(con => con.ConcertId == id);
                conc.ConcertName = model.ConcertName;
                conc.ConcertDescription= model.ConcertDescription;
                conc.Date = model.Date;
            }
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            ConcertViewModel conc = ConcertData.Concerts.Find(con => con.ConcertId == id);
            return View(conc);
        }

       

        public ActionResult Delete(int id)
        {
            ConcertViewModel empDelete = ConcertData.Concerts.Find(x => x.ConcertId == id);
            ConcertData.Concerts.Remove(empDelete);
            return RedirectToAction("Index");
        }

    }
}
