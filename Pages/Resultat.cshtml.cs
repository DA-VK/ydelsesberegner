using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ydelsesberegner.Pages
{
    public class ResultatModel : PageModel
    {
        public string Text1 { get; set; }
        public string Text2 { get; set; }

        public string Image { get; set; }

        
        class Udfald { 

            public string mnd, time, type; 
            public Udfald(string m, string t, string ty) 
            { 
                mnd = m; 
                time = t;
                type = ty;
            } 
  
        }


        public const string Text1Del1 = "På baggrund af de oplysninger, du har indtastet, ser det ud til, at du kan få ";
        
        
        public const string KHText1Del2 = " kroner i kontanthjælp om måneden før skat.<br/>" +
                    "Når du modtager kontanthjælp skal du stå til rådighed for aktiviteter op til 37 timer om ugen.<br/>" +
                    "Det svarer til en timeløn på ";

        public const string UYText1Del2 = " kroner i uddannelseshjælp om måneden før skat.<br/>" +
                    "Når du modtager uddannelseshjælp skal du stå til rådighed for aktiviteter op til 37 timer om ugen.<br/>" +
                    "Det svarer til en timeløn på ";

         public const string IYText1Del2 = " kroner i integrationsydelse om måneden før skat. <br/>" +
                    "Når du modtager integrationsydelse skal stå til rådighed for aktiviteter op til 37 timer om ugen. <br/>" +
                    "Det svarer til en timeløn på ";

        public const string Text1Del3 = " kroner før skat. Det betyder, at du eksempelvis kan blive bedt om at deltage i nyttejob, hvor du skal hjælpe med at vedligeholde kommunens grønne arealer." +
                    "<br/><br/>" +

                    "<b> Det kan betale sig at arbejde </b><br/>" +
                    "Vælger du i stedet at tage et job, kan du tjene flere penge i timen.<br/>" +
                    "• Et avisbud får ca. 100 kroner i timen.<br/>" +
                    "• En kassemedarbejder får ca. 130 kroner i timen.<br/>" +
                    "• En faglært får ca. 200 kroner i timen.<br/><br/>";

        public const string KHText1Del4 ="<b> Så få timer om ugen skal du arbejde for at tjene det, der svarer til kontanthjælp. </b><br/>" +
                    "Hvis du tager et job i stedet for kontanthjælp kan du nøjes med at arbejde færre timer, end du skal stå til rådighed.<br/>";

        public const string UYText1Del4 ="<b> Så få timer om ugen skal du arbejde for at tjene det, der svarer til uddannelseshjælp </b><br/>" +
                    "Hvis du tager et job i stedet for uddannelseshjælp kan du nøjes med at arbejde færre timer, end du skal stå til rådighed.<br/>";

        public const string IYText1Del4 ="<b> Så få timer om ugen skal du arbejde for at tjene det, der svarer til integrationsydelse </b><br/>" +
                    "Hvis du tager et job i stedet for integrationsydelse kan du nøjes med at arbejde færre timer, end du skal stå til rådighed <br/>";
                    

        public const string KHText2 = "<br/><b> Sådan søger du kontanthjælp </b><br/>" +
                "Du søger om kontanthjælp ved at møde op i Jobbutikken hos Jobcenter Vejle i Havneparken 16C. Du kan først få kontanthjælp fra den dag, hvor du har henvendt dig, og meldt dig ledig.<br/><br/>" +
                "Det er kun i jobcenteret, du kan få den præcise beregning af, hvad du kan få i kontanthjælp.";

        public const string UYText2 = "<br/><b> Sådan søger du uddannelseshjælp</b><br/>" +
                "Du søger om uddannelseshjælp ved at møde op i Jobbutikken hos Jobcenter Vejle i Havneparken 16C. Du kan først få uddannelseshjælp fra den dag, hvor du har henvendt dig, og meldt dig ledig.<br/><br/>" +
                "Det er kun i jobcenteret, du kan få den præcise beregning af, hvad du kan få i uddannelseshjælp.";

        public const string IYText2 = "<br/><b> Sådan søger du integrationsydelse </b><br/>" +
            "Du søger om integrationsydelse ved at møde op i Jobbutikken hos Jobcenter Vejle i Havneparken 16C. Du kan først få integrationsydelse fra den dag, hvor du har henvendt dig, og meldt dig ledig.<br/><br/>" +
            "Det er kun i jobcenteret, du kan få den præcise beregning af, hvad du kan få i integrationsydelse.<br/>";
        
        public void OnGet()
        {


            // "Request.Query[variable]" fanger den query string, som bliver passed fra forrige side med Response.Redirect()
            String Resultat = Request.Query["Name"];

            // Hvis string "Resultat" er "IkkeBerettiget" --> 
            if (Resultat == "IkkeBerettiget")
            {
           
                Text1 = "Ud fra dine oplysninger er du ikke berettiget til at modtage økonomisk hjælp fra kommunen. " +
                "<br/>" +
                "Denne vurdering er vejledende. I Jobcenter Vejle kan vi hjælpe dig med en endelig vurdering.";
            }
            else {

            
            //Alle udfald gemmes i et hashtable med månedelig ydelse, timeløn og ydelsestype 
            Hashtable muligeUdfald = new Hashtable();
        

            muligeUdfald.Add("A", new Udfald("15.355", "96", "kh"));
            muligeUdfald.Add("B", new Udfald("11.554", "72", "kh"));
            muligeUdfald.Add("C", new Udfald("14.677", "92", "kh"));
            muligeUdfald.Add("D", new Udfald("10.268", "64", "kh"));
            muligeUdfald.Add("E", new Udfald("7.448", "46", "kh"));
            muligeUdfald.Add("F", new Udfald("3.594", "22", "kh"));
            muligeUdfald.Add("G", new Udfald("6.331", "39", "uy"));
            muligeUdfald.Add("H", new Udfald("2.728", "17",  "uy"));
            muligeUdfald.Add("I", new Udfald("12.663", "79", "uy"));
            muligeUdfald.Add("K", new Udfald("8.862", "55", "uy"));
            muligeUdfald.Add("L", new Udfald("12.283", "77", "iy"));
            muligeUdfald.Add("M", new Udfald("8.596", "54", "iy"));
            muligeUdfald.Add("N", new Udfald("6.142", "38", "iy"));
            muligeUdfald.Add("O", new Udfald("2.646", "17", "iy"));

       
            //Tjekker i hashtable hvilket udfald det er pga af resultatet fra queryString, og henter de relevante data:
            Udfald aktueltUdfald = (Udfald)muligeUdfald[Resultat];

            string ydelsesType = aktueltUdfald.type;
            string ydelseMnd = aktueltUdfald.mnd;
            string ydelseTime = aktueltUdfald.time;

            

            //Bygger tekststrenge til resultatsiden baseret på type og med de aktuelle værdier
            switch (ydelsesType)
            {
                case "kh": //Kontanthjælp
                    Text1 = Text1Del1 + ydelseMnd + KHText1Del2 + ydelseTime + Text1Del3 + KHText1Del4;
                    Text2 = KHText2;
                    break;

                case "uy": //Uddannelsesydelse
                    Text1 = Text1Del1 + ydelseMnd + UYText1Del2 + ydelseTime + Text1Del3 + UYText1Del4;
                    Text2 = UYText2; 
                    break;

                case "iy": //Integrationsydelse
                    Text1 = Text1Del1 + ydelseMnd + IYText1Del2 + ydelseTime + Text1Del3 + IYText1Del4;
                    Text2 = IYText2; 
                    break;

            }

            Image = Resultat;
            
            }
            
        }
    }
}
