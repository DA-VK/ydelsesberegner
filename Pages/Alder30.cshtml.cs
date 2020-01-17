using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ydelsesberegner.Pages
{
    public class Alder30Model : PageModel
    {
        [BindProperty]
         public string Alder30 { get; set; }

         public string[] Alder30Svar = new[] { "Over 30 år", "Under 30 år" };
        public void OnGet()
        {
        }

        public void OnPost()
        {
            String Status = Request.Query["Name"];

            if(Status == "NejNejNej"){          //Integrationsydelse - ingen børn
                if(Alder30 == "Over 30 år"){
                    Response.Redirect("Resultat" + "?Name=NejNejNejOver");
                    
                }else if(Alder30 == "Under 30 år"){
                    Response.Redirect("Place" + "?Name=NejNejNejUnder");
                }
            }
            else if (Status == "JaJa"){         //Uddannelsesydelse
                if(Alder30 == "Over 30 år"){
                   Response.Redirect("Children2" + "?Name=JaJaOver");
                    
                }else if(Alder30 == "Under 30 år"){
                    Response.Redirect("Children1" + "?Name=JaJaUnder");
                }
            }
            else if (Status == "JaNej"){        //Kontanthjælp
                if(Alder30 == "Over 30 år"){
                   Response.Redirect("Children2" + "?Name=JaNejOver");
                    
                }else if(Alder30 == "Under 30 år"){
                    Response.Redirect("Children1" + "?Name=JaNejUnder");
                }
            }
        }
    }
}
