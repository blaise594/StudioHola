using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace StudioHola.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method='post'>" +
                "<input type='text' name='name' />" +
                "<select name='language'><option value='english' selected>English</option>" +
                "<option value='spanish'>Spanish</spanish>" +
                "<option value='french'>French</french>" +
                "<option value='italian'>Italian</italian>" +
                "<option value='german'>German</german>" +
                "<input type='submit' value='Greet Me!'/>"+
                "</form>";
            return Content(html, "text/html");
        }
        [Route ("/Hello")]
        [HttpPost]
        public IActionResult Display (string name="world", string language="English")
        {
            return Content(CreateMessage(name,language));
        }
        public static string CreateMessage(string name, string language)
        {
            string helloTranslation = "";
            switch(language)
            {
                case "spanish":
                    helloTranslation = "Hola ";
                    break;
                case "french":
                    helloTranslation = "Bonjour ";
                    break;
                case "italian":
                    helloTranslation = "Ciao ";
                    break;
                case "german":
                    helloTranslation = "Hallo ";
                    break;

            }
            return helloTranslation + name;
        }
    }
}