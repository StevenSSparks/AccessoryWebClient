using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccessoryWebClient.NSwagClient;


namespace AccessoryWebClient.Controllers
{
    public class DefaultController : Controller
    {

        [Route("/")]
        public IActionResult Index()
        {
            ViewBag.RandomNumButton = "Random Number Demo";
            ViewBag.RandomNumInfo = "Pick a random number between two random numbers.";
            ViewBag.CoinFliButton = "Flip a Quarter";
            ViewBag.CoinFliInfo = "Flip and coin and reveal heads or tails!";
            ViewBag.FortuneTelButton = "Fortune Teller";
            ViewBag.FortuneTelInfo = "Get you API fortune!";

            return View("Index");
        }
    }
}
