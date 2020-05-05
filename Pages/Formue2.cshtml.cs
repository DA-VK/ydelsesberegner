using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ydelsesberegner.Pages
{
    public class Formue2Model : PageModel
    {
        [BindProperty]
         public string Formue2 { get; set; }

         public string[] Formue2Svar = new[] { "Ja", "Nej" };

        public void OnGet()
        {
        }

        public void OnPost()
        {
            if(Formue2 == "Ja"){
                Response.Redirect("Resultat" + "?Name=IkkeBerettiget");
                
            }else if(Formue2 == "Nej"){
                Response.Redirect("EUBorgerskab");
            }
        }
    }
}
