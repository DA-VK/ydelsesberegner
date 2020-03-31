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

            if(Status == "IYNej"){          //Integrationsydelse - ingen børn
                if(Alder30 == "Over 30 år"){
                    Response.Redirect("Resultat" + "?Name=N");
                    
                }else if(Alder30 == "Under 30 år"){
                    Response.Redirect("Place" + "?Name=IYNejUnder");
                }
            }
            else if (Status == "UY"){         //Uddannelsesydelse
                if(Alder30 == "Over 30 år"){
                   Response.Redirect("Children2" + "?Name=UYOver"); //Videre til samme som KH Over 30 (Children2)
                    
                }else if(Alder30 == "Under 30 år"){
                    Response.Redirect("Children1" + "?Name=UYUnder");
                }
            }
            else if (Status == "KH"){        //Kontanthjælp
                if(Alder30 == "Over 30 år"){
                   Response.Redirect("Children2" + "?Name=KHOver");
                    
                }else if(Alder30 == "Under 30 år"){
                    Response.Redirect("Children1" + "?Name=KHUnder");
                }
            }
            else{
                Response.Redirect("Error" + "?Name=Alder30_" + Status);
            }
        }
    }
}
