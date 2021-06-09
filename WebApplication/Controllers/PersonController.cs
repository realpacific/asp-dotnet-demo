using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class PersonController : Controller
    {
        private static List<PersonViewModel> persons = new()
        {
            new PersonViewModel
            {
                Name = "Prashant",
                Id = Guid.NewGuid().ToString(),
                Location = "Nepal"
            }
        };


        // GET: Person
        public ActionResult Index()
        {
            return View(model: persons);
        }

        // GET: Person/Detail/4
        public ActionResult Detail(string id)
        {
            var person = persons.First(p => p.Id.Equals(id));
            return View(person);
        }
    }
}