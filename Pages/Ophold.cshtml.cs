using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ydelsesberegner.Pages
{
    public class OpholdModel : PageModel
    {
        [BindProperty]
         public string Ophold { get; set; }

         public string[] OpholdSvar = new[] { "Ja", "Nej" };
        
        public void OnGet()
        {
        }

        public void OnPost()
        {
            if(Ophold == "Ja"){
                Response.Redirect("Uddannelse" + "?Name=Ja");
                
            }else if(Ophold == "Nej"){
                Response.Redirect("EUBorgerskab" + "?Name=Nej");
            }
        }
    }
}
