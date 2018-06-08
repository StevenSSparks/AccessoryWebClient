using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccessoryWebClient.NSwagClient;

namespace AccessoryWebClient.Controllers
{
    public class RandomNumController : Controller
    {
        [Route("/RandomNum")]
        [HttpGet]
        public IActionResult IndexAsync()
        {
            string newLine = "<br>";
            ViewBag.Message =  newLine + "Click GO to view a Random Number" + newLine;
            return View("Index");

        }

        [Route("/RandomNum")]
        [HttpPost]
        public async Task<IActionResult> ShowNumber()
        {
            RandomNumber randomNumber = new RandomNumber();
            RandomNumberClient randomNumberClient = new RandomNumberClient();
            randomNumber = await randomNumberClient.NumberAsync();

            string newLine = "<br>";

            string message = ""; 
            message = "The random number " + randomNumber.Number.ToString() + " was selected." + newLine + newLine;
            message = message + "The random number generator pick your number from within the following range " + randomNumber.BottomOfRange.ToString() + " to " + randomNumber.TopOfRange.ToString() + ". <br />";
            ViewBag.Message = message; 

            return View("Index");

        }



    }
}
