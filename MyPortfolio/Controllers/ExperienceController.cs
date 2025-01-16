using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class ExperienceController : Controller
    {
        MyPrtfolioContext context = new MyPrtfolioContext();
        public IActionResult ExperienceList()
        {
            var values = context.Esperiences.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateExperience()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateExperience(Esperience experience)
        {
            context.Esperiences.Add(experience);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        public IActionResult DeleteExperience(int id)
        {
            var value = context.Esperiences.Find(id);
            context.Esperiences.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var value = context.Esperiences.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateExperience(Esperience esperience)
        {
            context.Esperiences.Update(esperience);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
    }
}
