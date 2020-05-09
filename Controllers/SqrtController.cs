using System.Text.RegularExpressions;
using System.Dynamic;
using System;
using Microsoft.AspNetCore.Mvc;
using SquareRoot.Models;

namespace SquareRoot.Controllers
{
    public class SqrtController : Controller
    {
        public ActionResult GetSquareRoot()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetSquareRoot(int firstNumber, int secondNumber)
        {

            double firstRoot = Math.Sqrt(firstNumber);
            double secondRoot = Math.Sqrt(secondNumber);
            
            
            if ( firstRoot == secondRoot)
            {
                ViewBag.message = "Numbers Have Equal Square Root,\nEnter New Number";
            }
            else if (firstRoot > secondRoot)
            {
                //data.firstRoot = firstRoot;
                ViewBag.message = "Square Root of First Number is Greater";
            }
            else
            {
                //data.secondRoot = secondRoot;
                ViewBag.message = "Square Root of Second Number is Greater";
            }

            ViewBag.FirstNumber = firstNumber;
            ViewBag.SecondNumber = secondNumber;
            ViewBag.FirstRoot = firstRoot;
            ViewBag.SecondRoot = secondRoot;
            
            return View();

        }
    }
}