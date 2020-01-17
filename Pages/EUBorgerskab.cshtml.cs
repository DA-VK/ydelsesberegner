using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ydelsesberegner.Pages
{
    public class EUBorgerskabModel : PageModel
    {
[BindProperty]
        public string EUBorgerskab { get; set; }

        public string[] EUBorgerskabSvar = new[] { "Ja", "Nej" };
        public void OnGet()
        {
        }

        public void OnPost()
        {
            if(EUBorgerskab == "Ja"){
                //Response.Redirect();
                
            }else if(EUBorgerskab == "Nej"){
                //Response.Redirect();
            }
        }
    }
}
