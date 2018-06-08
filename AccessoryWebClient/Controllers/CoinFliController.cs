using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccessoryWebClient.NSwagClient;

namespace AccessoryWebClient.Controllers
{
    public class CoinFliController : Controller
    {

        [Route("/coinfli")]
        [HttpGet]
        public IActionResult Index()
        {
            string newLine = "<br>";
            ViewBag.Message = newLine + "Click GO to flip a coin!" + newLine;
            return View("Index");

        }


        [Route("/coinfli")]
        [HttpPost]
        public async Task<IActionResult> FlipCoin()
        {
            string newline = "<br />";
            string headsimage = "";
            string message = "";

            Choice choice = new Choice();
            ChoiceClient choiceClient = new ChoiceClient();
            choice = await choiceClient.GetCoinAsync();

            switch (choice.Result.ToLower())
            {
                case "heads":
                    headsimage = "<img src =\"img/mo-coin-heads.png\" alt=\"HEADS!\" style=\"width: 128px; height: 128px; \" >";
                    break;
                case "tails":
                    headsimage = "<img src =\"img/mo-coin-tails.png\" alt=\"TAILS!\" style=\"width: 128px; height: 128px; \" >";
                    break;
            }

            message = "You got " + newline + newline;
            message = message + headsimage + newline;
            ViewBag.Message = message;

            return View("Index");

        }
    }
}



