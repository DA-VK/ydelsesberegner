using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ydelsesberegner.Pages
{
    public class UddannelseModel : PageModel
    {
         [BindProperty]
         public string Uddannelse { get; set; }

         public string[] UddannelseSvar = new[] { "Ja", "Nej" };
        public void OnGet()
        {
        }

        public void OnPost()
        {
            if(Uddannelse == "Ja"){
                Response.Redirect("Alder30");
                
            }else if(Uddannelse == "Nej"){
                Response.Redirect("Alder30");
            }
        }
    }
}
