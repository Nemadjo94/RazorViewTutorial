using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RazorViewTutorial.Models;

namespace RazorViewTutorial.Controllers
{
    public class HomeController : Controller
    {
        //GET: /<controller>/
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult Sample()
        {
            return View();
        }

        public IActionResult Index()
        {
            var view = View();
            view.ViewData["Layout"] =
                "~/Views/Shared/_Layout.cshtml";
            return view;
        }

        public IActionResult Index2()
        {
            ViewBag.Title = "This is Index2";

            var employees = new List<Employee>
            {
                new Employee { Id = 10012, Name = "Nemanjaaaa Djordjevic"},
                new Employee { Id = 10013, Name = "Mihajlo Djordjevic"},
            };


            return View(employees);
        }

        public IActionResult Index3()
        {
            ViewBag.Title = "This is Index3";
            Person person = new Person();
            return View(person);
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        //create a new action method called ValidateAge.
        //In this method, we will create an empty Person 
        //class and pass the model to the view.We will 
        //also create a dynamic property called Title 
        //in ViewBag so that we can display this value
        //in the view
        [HttpGet]
        public IActionResult ValidateAge()
        {
            ViewBag.Title = "Validate Age for voting";
            Person person = new Person();
            return View(person);
        }

        [HttpPost]
        public IActionResult ValidateAge(Person person)
        {
            //For textbox but since we use checkbox this is deprecated
            //if(person.Age >= 18)
            //{
            //    ViewBag.Message = "You are eligible to Vote";
            //}
            //else
            //{
            //    ViewBag.Message = "Sorry. You are not old enough to vote";
            //}

            if(Convert.ToBoolean(
                Request.Form["OlderThan18"][0]))
            {
                ViewData["OlderThan18"] = true;
                ViewBag.Message = "You are eligible to vote";
            }
            else
            {
                ViewBag.Message = "Sorry. You are not old enough to vote";
            }

            return View();
        }
    }
}