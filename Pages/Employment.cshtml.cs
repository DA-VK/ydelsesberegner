using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ydelsesberegner.Pages
{
    public class EmploymentModel : PageModel
    {
        [BindProperty]
         public string Employment { get; set; }

         public string[] EmploymentSvar = new[] { "Ja", "Nej" };
        public void OnGet()
        {
        }

        public void OnPost()
        {
            if(Employment == "Ja"){
                Response.Redirect("Uddannelse");
                
            }else if(Employment == "Nej"){
                Response.Redirect("Children1" + "?Name=IY");
            }
        }
    }
}