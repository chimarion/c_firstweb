using System;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class NumController : Controller
    {
        [HttpGet]
        public ActionResult Squareroot()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Squareroot(int firstnumber, int secondnumber)
        {
           
            double inputOne = (Math.Sqrt(firstnumber));
            double inputTwo = (Math.Sqrt(secondnumber));
            double max = Math.Max(inputOne, inputTwo); 
            double min = Math.Min(inputOne, inputTwo);
            if (firstnumber > secondnumber)
            {
                ViewBag.Result = "The number " + firstnumber + " with square root " + inputOne + " has a higher square root than the number " + secondnumber + " with square root " + inputTwo;
            }
            else
            {
                ViewBag.Result = "The number " + secondnumber + " with square root " + inputTwo + " has a higher square root than the number " + firstnumber + " with square root " + inputOne;
            }
        
            return View();
        }
    }
}