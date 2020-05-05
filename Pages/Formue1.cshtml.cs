using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ydelsesberegner.Pages
{
    public class Formue1Model : PageModel
    {
        
        [BindProperty]
         public string Formue1 { get; set; }

         public string[] Formue1Svar = new[] { "Ja", "Nej" };

        public void OnGet()
        {
        }

        public void OnPost()
        {
            if(Formue1 == "Ja"){
                Response.Redirect("Resultat" + "?Name=IkkeBerettiget");
                
            }else if(Formue1 == "Nej"){
                Response.Redirect("EUBorgerskab");
            }
        }
    }
}
