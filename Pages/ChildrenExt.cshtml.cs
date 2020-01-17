using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ydelsesberegner.Pages
{
    public class ChildrenExtModel : PageModel
    {
        [BindProperty]
         public string ChildrenExt { get; set; }

         public string[] ChildrenExtSvar = new[] { "Ja", "Nej" };
        public void OnGet()
        {
        }

        public void OnPost()
        {
            String Status = Request.Query["Name"];

            if(Status == "NejNejJa"){       //Ikke EU-borger eller ophold
                if(ChildrenExt == "Ja"){
                    Response.Redirect("Resultat" + "?Name=NejNejJaJa");
                    
                }else if(ChildrenExt == "Nej"){
                    Response.Redirect("Resultat" + "?Name=NejNejJaNej");
                }
            }
        }
    }
}
