using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

//namespace, class methods

namespace HairSalon.Controllers
{
    public class StylistsController : Controller
    {

        private readonly HairSalonContext _db;

        public StylistsController(HairSalonContext db)
        {
            _db = db;
        }
        public ActionResult Index()
        {
            List<Stylist> model = _db.Stylists.ToList();
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Stylist stylist)
        {
            _db.Stylists.Add(stylist);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            Stylist foundStylist = _db.Stylists
            .Include(stylist => stylist.Clients)
            .FirstOrDefault(stylist => stylist.StylistId == id);
            return View(foundStylist);
        }

        //need details aka clients of one specific stylist
    }
}