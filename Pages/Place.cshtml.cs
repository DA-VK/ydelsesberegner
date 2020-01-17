using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ydelsesberegner.Pages
{
    public class PlaceModel : PageModel
    {
        [BindProperty]
         public string Place { get; set; }

         public string[] PlaceSvar = new[] { "Jeg er udeboende", "Jeg er hjemmeboende" };
        public void OnGet()
        {
        }

        public void OnPost()
        {
            String Status = Request.Query["Name"];

            if(Status == "NejNejNejUnder"){          //Integrationsydelse - ingen børn, under 30
                if(Place == "Jeg er udeboende"){
                    Response.Redirect("Resultat" + "?Name=NejNejNejUnderUde");
                    
                }else if(Place == "Jeg er hjemmeboende"){
                    Response.Redirect("Resultat" + "?Name=NejNejNejUnderHjemme");
                }
            }
        }
    }
}
