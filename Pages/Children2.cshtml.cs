using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ydelsesberegner.Pages
{
    public class Children2Model : PageModel
    {
        [BindProperty]
         public string Children2 { get; set; }

         public string[] Children2Svar = new[] { "Ja", "Nej" };
        public void OnGet()
        {
        }

        public void OnPost()
        {
            if(Children2 == "Ja"){
                //Response.Redirect();
                
            }else if(Children2 == "Nej"){
                //Response.Redirect();
            }
        }
    }
}
