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
            if(Uddannelse == "Ja"){     //B Uddannelsesydelse
                Response.Redirect("Alder30" + "?Name=JaJa");
                
            }else if(Uddannelse == "Nej"){  //C Kontanthjælp
                Response.Redirect("Alder30" + "?Name=JaNej");
            }
        }
    }
}
