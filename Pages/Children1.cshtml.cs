using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ydelsesberegner.Pages
{
    public class Children1Model : PageModel
    {
        [BindProperty]
         public string Children1 { get; set; }

         public string[] Children1Svar = new[] { "Ja", "Nej" };

         
        public void OnGet()
        {

        }

        public void OnPost()
        {
            
            String Status = Request.Query["Name"];

            if(Status == "SH"){ //SH-ydelse

                if(Children1 == "Ja"){
                    Response.Redirect("ChildrenExt" + "?Name=SHJa");
                    
                }else if(Children1 == "Nej"){
                    Response.Redirect("Alder30" + "?Name=SHNej");
                }
            }
            else if(Status == "UYUnder"){ //Uddannelsesydelse

                if(Children1 == "Ja"){
                    Response.Redirect("ChildrenExt" + "?Name=UYUnderJa");
                    
                }else if(Children1 == "Nej"){
                    Response.Redirect("Place" + "?Name=UYUnderNej");
                }
            }
            else if(Status == "KHUnder"){ //Kontanthjælp

                if(Children1 == "Ja"){
                    Response.Redirect("ChildrenExt" + "?Name=KHUnderJa");
                    
                }else if(Children1 == "Nej"){
                    Response.Redirect("Place" + "?Name=KHUnderNej");
                }
            }
            else{
                Response.Redirect("Error" + "?Name=Children1_" + Status);
            }

        }
    }
}
