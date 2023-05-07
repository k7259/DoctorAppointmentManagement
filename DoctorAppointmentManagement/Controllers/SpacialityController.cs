using DoctorAppointmentManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace DoctorAppointmentManagement.Controllers
{
    public class SpacialityController : Controller

    {
        ApplicationDbContext _context;
        List<Speciality> specialities;
        public SpacialityController(ApplicationDbContext context)
        {
            _context = context;
            specialities= new List<Speciality>();
        }

        public IActionResult Index()
        {
            specialities=_context.Specialities.ToList();
            return View(specialities);
        }
        public IActionResult Create()
        {
            return View();  
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Speciality pl)
        {
            //Add to DB
            _context.Specialities.Add(pl);
            _context.SaveChanges();
            return RedirectToAction("Index", "Spaciality");
        }
    }
}
