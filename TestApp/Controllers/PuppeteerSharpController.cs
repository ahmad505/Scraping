//using Microsoft.AspNetCore.Mvc;
//using PuppeteerSharp;
//using System.Collections.Generic;
//using System.Threading.Tasks;

//namespace TestApp.Controllers
//{
//    public class PuppeteerSharpController : Controller
//    {
//        public async Task<IActionResult> Index()
//        {
//            string fullUrl = "https://en.wikipedia.org/wiki/List_of_programmers";

//            List<string> programmerLinks = new List<string>();

//            var options = new LaunchOptions()
//            {
//                Headless = true,
//                ExecutablePath = "C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe"
//            };

//            var browser = await Puppeteer.LaunchAsync(options, null, Product.Chrome);
//            var page = await browser.NewPageAsync();
//            await page.GoToAsync(fullUrl);

//            var links = @"Array.from(document.querySelectorAll('li:not([class^=""toc""]) a')).map(a => a.href);";
//            var urls = await page.EvaluateExpressionAsync<string[]>(links);

//            foreach (string url in urls)
//            {
//                programmerLinks.Add(url);
//            }

//            WriteToCsv(programmerLinks);

//            return View();
//        }
//    }
//}
