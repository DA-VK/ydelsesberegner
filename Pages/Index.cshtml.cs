using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Ydelsesberegner.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        public string Navn {get; set;}

        [BindProperty]
         public string Civilstand { get; set; }

         public string[] Civilstande = new[] { "Gift", "Ugift" };


           

    public void OnGet()
        {
            
        }

    public void OnPost()
        {
            if(Civilstand == "Gift"){
                Response.Redirect("Error");
            }
        }
    }
}
