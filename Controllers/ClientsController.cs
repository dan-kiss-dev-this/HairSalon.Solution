using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

//namespace, class methods

namespace HairSalon.Controllers
{
    public class ClientsController : Controller
    {

        private readonly HairSalonContext _db;

        public ClientsController(HairSalonContext db)
        {
            _db = db;
        }
        // public ActionResult Index()
        // {
        //     List<Client> model = _db.Clients
        //     .Include(client => client.Stylist)
        //     .ToList();
        //     return View(model);
        // }

        public ActionResult Create()
        {
            ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
            int StylistCount = _db.Stylists.ToList().Count;
            ViewBag.StylistCount = StylistCount;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Client client)
        {
            // ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
            _db.Clients.Add(client);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        // public ActionResult Details(int id)
        // {
        //     Stylist foundStylist = _db.Clients
        //     .Include(stylist => stylist.Clients)
        //     .FirstOrDefault(stylist => stylist.StylistId == id);
        //     return View(foundStylist);
        // }

        //need details aka clients of one specific stylist
    }
}