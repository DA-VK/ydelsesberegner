using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;



//Denne bliver pt ikke kaldt, da resultatet uanset bliver det samme
//Måske er den et levn fra tidligere?


namespace Ydelsesberegner.Pages
{
    public class Alder25Model : PageModel
    {
      [BindProperty]
         public string Alder25 { get; set; }

         public string[] Alder25Svar = new[] { "Over 25 år", "Under 25 år" };
        public void OnGet()
        {
        }

        public void OnPost()
        {
            if(Alder25 == "Over 25 år"){
                //Response.Redirect();
                
            }else if(Alder25 == "Under 25 år"){
                //Response.Redirect();
            }
        }
    }
}
