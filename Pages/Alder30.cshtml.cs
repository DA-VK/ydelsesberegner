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
            if(Alder30 == "Over 30 år"){
                //Response.Redirect();
                
            }else if(Alder30 == "Under 30 år"){
                //Response.Redirect();
            }
        }
    }
}
