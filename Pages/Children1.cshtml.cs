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

            if(Status == "Nej"){

                if(Children1 == "Ja"){
                    //Response.Redirect();
                    
                }else if(Children1 == "Nej"){
                    //Response.Redirect();
                }
            }
            else if(Status == "NejNej"){ //Integrationsydelse

                if(Children1 == "Ja"){
                    Response.Redirect("ChildrenExt" + "?Name=NejNejJa");
                    
                }else if(Children1 == "Nej"){
                    Response.Redirect("Alder30" + "?Name=NejNejNej");
                }
            }
            else if(Status == "JaJaUnder"){ //Uddannelsesydelse

                if(Children1 == "Ja"){
                    Response.Redirect("ChildrenExt" + "?Name=JaJaUnderJa");
                    
                }else if(Children1 == "Nej"){
                    Response.Redirect("Place" + "?Name=JaJaUnderNej");
                }
            }
            else if(Status == "JaNejUnder"){ //Kontanthjælp

                if(Children1 == "Ja"){
                    Response.Redirect("ChildrenExt" + "JaNejUnderJa");
                    
                }else if(Children1 == "Nej"){
                    Response.Redirect("Place" + "JaNejUnderNej");
                }
            }
            else{

            }

        }
    }
}
