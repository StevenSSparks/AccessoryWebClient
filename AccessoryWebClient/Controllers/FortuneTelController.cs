using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccessoryWebClient.NSwagClient;

namespace AccessoryWebClient.Controllers
{
    public class FortuneTelController : Controller
    {

        [Route("/fortunetel")]
        [HttpGet]
        public IActionResult Index()
        {
            string newLine = "<br>";
            ViewBag.Message = newLine + "Click go ahead, be brave! Click the Truth button!" + newLine;
            return View("Index");

        }

        [HttpPost]
        [Route("/fortunetel")]
        public async Task<IActionResult> ReturnFortune()
        {
            string newline = "<br />";
            string message = "";

            Fortune fortune = new NSwagClient.Fortune();
            FortuneClient fortuneClient = new FortuneClient();
            fortune = await fortuneClient.GetFortuneAsync();

            message = "The bits have spoken. The truth is:" + newline + "<b><i> " + fortune.Phrase.ToString() + "</b></i>" + newline;
            ViewBag.Message = message; 

            return View("Index");

        }
       
        
        

    }
}
