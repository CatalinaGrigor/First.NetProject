using ExamIntraCatalina.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;

namespace ExamIntraCatalina.Controllers
{
    public class ActiviteController : Controller
    {

        private static List<Activite> activites = new List<Activite>()
        {
            new Activite("Cinema",2,13.5,0),
            new Activite("Ski",4,70,0),
            new Activite("Randonnee", 3,15,0),
            new Activite("Bricolage", 2,5,0),
        };
        // GET: ActiviteController
        public ActionResult Index()
        {
            return View(activites);
        }

        // GET: ActiviteController/Details/5
        public ActionResult Details(string id)
        {
            Activite activite = activites.Find(a=>a.Nom== id);
            return View(activite);
        }

        // GET: ActiviteController/Create
        public ActionResult Create()
        {
            
            Activite activite=new Activite();
          
            return View(activite);
        }

        // POST: ActiviteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ActiviteController/Create
        public ActionResult List()
        {
            List<Activite> activiteTries = activites.OrderByDescending(o => o.Vote).ToList();
            return View(activiteTries);
        }

       

        // GET: ActiviteController/Edit/5
        public ActionResult Voter (string id)
        {
            Activite activite = activites.Find(a => a.Nom == id);
            activite.Vote++;
           
          
            return View(activite);
        }

        // POST: ActiviteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Voter (string id, Activite activite)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

      
    }
}
