using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ydelsesberegner.Pages
{
    public class ChildrenExtModel : PageModel
    {
        [BindProperty]
         public string ChildrenExt { get; set; }

         public string[] ChildrenExtSvar = new[] { "Ja", "Nej" };
        public void OnGet()
        {
        }

        public void OnPost()
        {
            String Status = Request.Query["Name"];

            if(Status == "IYJa"){       //Integrationsydelse
                if(ChildrenExt == "Ja"){
                    Response.Redirect("Resultat" + "?Name=L");
                    
                }else if(ChildrenExt == "Nej"){
                    Response.Redirect("Resultat" + "?Name=M");
                }
            }
            else if(Status == "UYUnderJa"){       //Uddannelsesydelse
                if(ChildrenExt == "Ja"){
                    Response.Redirect("Resultat" + "?Name=I");
                    
                }else if(ChildrenExt == "Nej"){
                    Response.Redirect("Resultat" + "?Name=K");
                }
            }
            else if(Status == "KHUnderJa"){       //Kontanthjælp
                if(ChildrenExt == "Ja"){
                    Response.Redirect("Resultat" + "?Name=C");
                    
                }else if(ChildrenExt == "Nej"){
                    Response.Redirect("Resultat" + "?Name=D");
                }
            }
            else{
                Response.Redirect("Error" + "?Name=ChildrenExt_" + Status);
            }
        }
    }
}
