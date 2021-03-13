using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using HairSalon.Models;

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

    public ActionResult Details(int stylistId)
    {
      ViewBag.thisStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == stylistId);
      ViewBag.clients = _db.Clients.Where(client => client.StylistId == stylistId).ToList();
      return View();
    }

    public ActionResult Edit(int stylistId)
    {
      var thisStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == stylistId);
      return View(thisStylist);
    }

    [HttpPost]
    public ActionResult Edit(Stylist stylist)
    {
      _db.Entry(stylist).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int stylistId)
    {
      var thisStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == stylistId);
      return View(thisStylist);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int stylistId)
    {
      var thisStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == stylistId);
      _db.Stylists.Remove(thisStylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}
