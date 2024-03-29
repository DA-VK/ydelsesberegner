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

        public string ChartTitle { get; set; } 
        public string ChartText { get; set; }


        public string Image { get; set; }

        
        class Udfald { 

            public string mnd, time, type;
            public int avis, kasse, fag;
            public Udfald(string m, string t, string ty, int av, int ka, int fa) 
            { 
                mnd = m; 
                time = t;
                type = ty;
                avis = av;
                kasse = ka;
                fag = fa;
            } 
  
        }


        public const string Text1Del1 = "<p>På baggrund af de oplysninger, du har indtastet, ser det ud til, at du kan få <b>";
        
        
        public const string KHText1Del2 = "</b> kroner i kontanthjælp om måneden før skat.</p>" +
                    "<p>Når du modtager kontanthjælp skal du stå til rådighed for aktiviteter op til 37 timer om ugen." +
                    "Det svarer til en timeløn på <b>";

        public const string UYText1Del2 = "</b> kroner i uddannelseshjælp om måneden før skat.</p>" +
                    "<p>Når du modtager uddannelseshjælp skal du stå til rådighed for aktiviteter op til 37 timer om ugen." +
                    "Det svarer til en timeløn på <b>";

         public const string SHText1Del2 = "</b> kroner i <abbr title='selvforsørgelses- og hjemrejseydelse'>S&H-ydelse</abbr> om måneden før skat.</p>" +
                    "<p>Når du modtager <abbr title='selvforsørgelses- og hjemrejseydelse'>S&H-ydelse</abbr> skal stå til rådighed for aktiviteter op til 37 timer om ugen. <br/>" +
                    "Det svarer til en timeløn på <b>";

        public const string Text1Del3 = "</b> kroner før skat. Det betyder, at du eksempelvis kan blive bedt om at deltage i nyttejob, hvor du skal hjælpe med at vedligeholde kommunens grønne arealer." +
                    "</p>" +
                    "<div class=\"flex-important\">" +
                    "<div class=\"important\">" +
                    "<h3>Det kan betale sig at arbejde!</h3>" +
                    "<p>Vælger du i stedet at tage et job, kan du tjene flere penge i timen.</p>" +
                    "<ul>" +
                    "<li>Et avisbud får ca. 115 kroner i timen.</li>" +
                    "<li>En kassemedarbejder får ca. 130 kroner i timen.</li>" +
                    "<li>En faglært får ca. 200 kroner i timen.</li>" +
                    "</ul>" +
                    "</div>" +
                    "</div>";

        public const string KHText1Del4 ="<h3>Så få timer om ugen skal du arbejde for at tjene det, der svarer til kontanthjælp. </h3>" +
                    "<p>Hvis du tager et job i stedet for kontanthjælp kan du nøjes med at arbejde færre timer, end du skal stå til rådighed.</p>";

        public const string UYText1Del4 ="<h3>Så få timer om ugen skal du arbejde for at tjene det, der svarer til uddannelseshjælp </h3>" +
                    "<p>Hvis du tager et job i stedet for uddannelseshjælp kan du nøjes med at arbejde færre timer, end du skal stå til rådighed.</p>";

        public const string SHText1Del4 ="<h3>Så få timer om ugen skal du arbejde for at tjene det, der svarer til <abbr title='selvforsørgelses- og hjemrejseydelse'>S&H-ydelse</abbr> </h3>" +
                    "<p>Hvis du tager et job i stedet for <abbr title='selvforsørgelses- og hjemrejseydelse'>S&H-ydelse</abbr> kan du nøjes med at arbejde færre timer, end du skal stå til rådighed </p>";
                    

        public const string KHText2 = "<h3>Sådan søger du kontanthjælp </h3>" +
                "<p>Du søger om kontanthjælp ved at møde op i Jobbutikken hos Jobcenter Vejle i Havneparken 16C. Du kan først få kontanthjælp fra den dag, hvor du har henvendt dig, og meldt dig ledig.</p>" +
                "<p>Det er kun i jobcenteret, du kan få den præcise beregning af, hvad du kan få i kontanthjælp.</p>";

        public const string UYText2 = "<h3>Sådan søger du uddannelseshjælp</h3>" +
                "<p>Du søger om uddannelseshjælp ved at møde op i Jobbutikken hos Jobcenter Vejle i Havneparken 16C. Du kan først få uddannelseshjælp fra den dag, hvor du har henvendt dig, og meldt dig ledig.</p>" +
                "<p>Det er kun i jobcenteret, du kan få den præcise beregning af, hvad du kan få i uddannelseshjælp.</p>";

        public const string SHText2 = "<h3>Sådan søger du <abbr title='selvforsørgelses- og hjemrejseydelse'>S&H-ydelse</abbr></h3>" +
            "<p>Du søger om S&H-ydelse ved at møde op i Jobbutikken hos Jobcenter Vejle i Havneparken 16C. Du kan først få S&H-ydelse fra den dag, hvor du har henvendt dig, og meldt dig ledig.</p>" +
            "<p>Det er kun i jobcenteret, du kan få den præcise beregning af, hvad du kan få i S&H-ydelse.</p>";
        
        public void OnGet()
        {


            // "Request.Query[variable]" fanger den query string, som bliver passed fra forrige side med Response.Redirect()
            String Resultat = Request.Query["Name"];

            // Hvis string "Resultat" er "IkkeBerettiget" --> 
            if (Resultat == "IkkeBerettiget")
            {
           
                Text1 = "<p>Ud fra dine oplysninger er du ikke berettiget til at modtage økonomisk hjælp fra kommunen. " +
                "Denne vurdering er vejledende. I Jobcenter Vejle kan vi hjælpe dig med en endelig vurdering.</p>";
            }
            else {

            
            //Alle udfald gemmes i et hashtable med månedelig ydelse, timeløn og ydelsestype 
            Hashtable muligeUdfald = new Hashtable();
        

            muligeUdfald.Add("A", new Udfald("15.874", "96", "kh", 32, 28, 18));
            muligeUdfald.Add("B", new Udfald("11.944", "72", "kh", 24, 21, 14));
            muligeUdfald.Add("C", new Udfald("15.172", "92", "kh", 30, 27, 18));
            muligeUdfald.Add("D", new Udfald("10.615", "64", "kh", 21, 19, 12));
            muligeUdfald.Add("E", new Udfald("7.699", "46", "kh", 15, 14, 9));
            muligeUdfald.Add("F", new Udfald("3.715", "22", "kh", 7, 7, 4));
            muligeUdfald.Add("G", new Udfald("6.545", "39", "uy", 13, 12, 8));
            muligeUdfald.Add("H", new Udfald("2.820", "17",  "uy", 6, 5, 3));
            muligeUdfald.Add("I", new Udfald("13.090", "79", "uy", 26, 23, 15));
            muligeUdfald.Add("K", new Udfald("9.161", "55", "uy", 18, 16, 11));
            muligeUdfald.Add("L", new Udfald("12.699", "79", "sh", 25, 23, 15));
            muligeUdfald.Add("M", new Udfald("8.886", "55", "sh", 18, 16, 10));
            muligeUdfald.Add("N", new Udfald("6.350", "40", "sh", 13, 11, 7));
            muligeUdfald.Add("O", new Udfald("2.735", "17", "sh", 5, 4, 3));

       
            //Tjekker i hashtable hvilket udfald det er pga af resultatet fra queryString, og henter de relevante data:
            Udfald aktueltUdfald = (Udfald)muligeUdfald[Resultat];

            string ydelsesType = aktueltUdfald.type;
            string ydelseMnd = aktueltUdfald.mnd;
            string ydelseTime = aktueltUdfald.time;
            
            int timerAvis = aktueltUdfald.avis;
            int timerKasse = aktueltUdfald.kasse;
            int timerFag = aktueltUdfald.fag;

            

            //Bygger tekststrenge til resultatsiden baseret på type og med de aktuelle værdier
            switch (ydelsesType)
            {
                case "kh": //Kontanthjælp
                    Text1 = Text1Del1 + ydelseMnd + KHText1Del2 + ydelseTime + Text1Del3 + KHText1Del4;
                    Text2 = KHText2;
                    ChartTitle = "Kontanthjælp: " + ydelseMnd + " kr./md";
                    ChartText = "Diagrammet viser at du blot skal arbejde " +
                                    timerAvis.ToString() +
                                    " timer som avisbud, " +
                                    timerKasse.ToString() +
                                    " timer som kassemedarbejder, eller "+
                                    timerFag.ToString() +
                                    " timer som faglært, for at tjene det der svarer til" +
                                    " kontanthjælpsydelsen" +
                                    ", hvor du skal stå til rådighed i 37 timer.";
                    break;

                case "uy": //Uddannelsesydelse
                    Text1 = Text1Del1 + ydelseMnd + UYText1Del2 + ydelseTime + Text1Del3 + UYText1Del4;
                    Text2 = UYText2;
                    ChartTitle = "Uddannelseshjælp: " + ydelseMnd + " kr./md";
                    ChartText = "Diagrammet viser at du blot skal arbejde " +
                            timerAvis.ToString() +
                            " timer som avisbud, " +
                            timerKasse.ToString() +
                            " timer som kassemedarbejder, eller "+
                            timerFag.ToString() +
                            " timer som faglært, for at tjene det der svarer til" +
                            " uddannelseshjælpen" +
                            ", hvor du skal stå til rådighed i 37 timer.";
                    break;

                case "sh": //selvforsørgelses- og hjemrejseydelse (S&H-ydelse)
                    Text1 = Text1Del1 + ydelseMnd + SHText1Del2 + ydelseTime + Text1Del3 + SHText1Del4;
                    Text2 = SHText2;
                    ChartTitle = "S&H-ydelse: " + ydelseMnd + " kr./md";
                    ChartText = "Diagrammet viser at du blot skal arbejde " +
                            timerAvis.ToString() +
                            " timer som avisbud, " +
                            timerKasse.ToString() +
                            " timer som kassemedarbejder, eller "+
                            timerFag.ToString() +
                            " timer som faglært, for at tjene det der svarer til" +
                            " S&H-ydelsen" +
                            ", hvor du skal stå til rådighed i 37 timer.";
                    break;

            }

            Image = Resultat;
            
            
            }
            
        }
    }
}
