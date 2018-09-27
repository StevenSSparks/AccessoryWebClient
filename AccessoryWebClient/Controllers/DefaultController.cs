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
            ViewBag.RandomNumButton = "Random Number";
            ViewBag.RandomNumInfo = "Pick a random number between two random numbers.";
            ViewBag.CoinFliButton = "Flip a Quarter";
            ViewBag.CoinFliInfo = "Flip a quarter and reveal heads or tails!";
            ViewBag.FortuneTelButton = "Fortune Teller";
            ViewBag.FortuneTelInfo = "Get your accurate API fortune!";

            return View("Index");
        }
    }
}
