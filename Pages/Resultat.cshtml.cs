using System;
using System.Collections.Generic;
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
        
        public void OnGet()
        {
             
            // "Request.Query[variable]" fanger den query string, som bliver passed fra forrige side med Response.Redirect()
            String Resultat = Request.Query["Name"];

            
            
            // Hvis string "Resultat" indeholder teksten "IkkeBerettiget" --> Kør koden heri
            if (Resultat == "IkkeBerettiget")
            {
           
                Text1 = "Ud fra dine oplysninger er du ikke berettiget til at modtage økonomisk hjælp fra kommunen. " +
                "<br/>" +
                "Denne vurdering er vejledende. I Jobcenter Vejle kan vi hjælpe dig med en endelig vurdering.";
            }
            
            // Godkendt resultat A
            #region
            if (Resultat == "A" ) // <-- Samme resultat for JaJa og JaNej, hvis de er over 30 og har børn
            {
                Text1 = "På baggrund af de oplysninger, du har indtastet, ser det ud til, at du kan få 14.993 kroner i kontanthjælp om måneden før skat.<br/>" +
                    "Når du modtager kontanthjælp skal stå til rådighed for aktiviteter op til 37 timer om ugen.<br/>" +
                    "Det svarer til en timeløn på 94 kroner før skat. Det betyder, at du eksempelvis kan blive bedt om at deltage i nyttejob, hvor du skal hjælpe med at vedligeholde kommunens grønne arealer." +
                    "<br/><br/>" +

                    "<b> Det kan betale sig at arbejde </b><br/>" +
                    "Vælger du i stedet at tage et job, kan du tjene flere penge i timen.<br/>" +
                    "• Et avisbud får ca. 100 kroner i timen.<br/>" +
                    "• En kassemedarbejder får ca. 130 kroner i timen.<br/>" +
                    "• En faglært får ca. 200 kroner i timen.<br/><br/>" +

                    "<b> Så få timer om ugen skal du arbejde for at tjene det, der svarer til kontanthjælp. </b><br/>" +
                    "Hvis du tager et job i stedet for kontanthjælp kan du nøjes med at arbejde færre timer, end du skal stå til rådighed.<br/>";

                Image = "A"; //Sti til billedet konstrueres i razor-siden ved hjælp af denne

                Text2 = "<br/><b> Sådan søger du kontanthjælp </b><br/>" +
                    "Du søger om kontanthjælp ved at møde op i Modtagelsen i Jobcenter Vejle i Havneparken 16C. Du kan først få kontanthjælp fra den dag, du har udfyldt en ansøgning i jobcenteret og meldt dig ledig på Jobnet.<br/>" +
                    "Det er kun i jobcenteret, du kan få den præcise beregning af, hvad du kan få i kontanthjælp.";
            }
            #endregion
            
            // Godkendt resultat B
            #region
            if (Resultat == "B") // <-- Samme resultat for JaJa og JaNej, hvis de er over 30 og ikke har børn
            {
                Text1 = "På baggrund af de oplysninger, du har indtastet, ser det ud til, at du kan få 11.282 kroner i kontanthjælp om måneden før skat." +
                    "Når du modtager kontanthjælp skal stå til rådighed for aktiviteter op til 37 timer om ugen.<br/>" +
                    "Det svarer til en timeløn på 70 kroner før skat. Det betyder, at du eksempelvis kan blive bedt om at deltage i nyttejob, hvor du skal hjælpe med at vedligeholde kommunens grønne arealer." +
                    "<br/><br/>" +

                    "<b> Det kan betale sig at arbejde </b><br/>" +
                    "Vælger du i stedet at tage et job, kan du tjene flere penge i timen. <br/>" +
                    "• Et avisbud får ca. 100 kroner i timen. <br/>" +
                    "•	En kassemedarbejder får ca. 130 kroner i timen <br/>" +
                    "•	En faglært får ca. 200 kroner i timen <br/><br/>" +

                    "<b> Så få timer om ugen skal du arbejde for at tjene det, der svarer til kontanthjælp </b><br/>" +
                    "Hvis du tager et job i stedet for kontanthjælp kan du nøjes med at arbejde færre timer, end du skal stå til rådighed. <br/>";

                Image = "B";

                Text2 = "<br/><b> Sådan søger du kontanthjælp </b><br/>" +
                    "Du søger om kontanthjælp ved at møde op i Modtagelsen i Jobcenter Vejle i Havneparken 16C. Du kan først få kontanthjælp fra den dag, du har udfyldt en ansøgning i jobcenteret og meldt dig ledig på Jobnet. <br/>" +
                    "Det er kun i jobcenteret, du kan få den præcise beregning af, hvad du kan få i kontanthjælp.";
            }
            #endregion
            
            // Godkendt resultat C
            #region
            if (Resultat == "C") // Kontanthjælp - børnetillæg
            {
                Text1 = "På baggrund af de oplysninger, du har indtastet, ser det ud til, at du kan få 14.331 kroner i kontanthjælp om måneden før skat. <br/>" +
                    "Når du modtager kontanthjælp skal stå til rådighed for aktiviteter op til 37 timer om ugen.<br/>" +
                    "Det svarer til en timeløn på 89 kroner før skat. Det betyder, at du eksempelvis kan blive bedt om at deltage i nyttejob, hvor du skal hjælpe med at vedligeholde kommunens grønne arealer." +
                    "<br/><br/>" +

                    "<b> Det kan betale sig at arbejde </b><br/>" +
                    "Vælger du i stedet at tage et job, kan du tjene flere penge i timen.<br/>" +
                    "•	Et avisbud får ca. 100 kroner i timen. <br/>" +
                    "•	En kassemedarbejder får ca. 130 kroner i timen <br/>" +
                    "•	En faglært får ca. 200 kroner i timen <br/><br/>" +

                    "<b> Så få timer om ugen skal du arbejde for at tjene det, der svarer til kontanthjælp </b><br/>" +
                    "Hvis du tager et job i stedet for kontanthjælp kan du nøjes med at arbejde færre timer, end du skal stå til rådighed.<br/>";

                Image = "C";

                Text2 = "<br/><b> Sådan søger du kontanthjælp </b><br/>" +
                    "Du søger om kontanthjælp ved at møde op i Modtagelsen i Jobcenter Vejle i Havneparken 16C. Du kan først få kontanthjælp fra den dag, du har udfyldt en ansøgning i jobcenteret og meldt dig ledig på Jobnet.<br/>" +
                    "Det er kun i jobcenteret, du kan få den præcise beregning af, hvad du kan få i kontanthjælp.";
            }
                #endregion

            // Godkendt resultat D
            #region
            if (Resultat == "D" ) // Kontanthjælp - ikke børnetillæg
            {
                Text1 = "På baggrund af de oplysninger, du har indtastet, ser det ud til, at du kan få 10.026 kroner i kontanthjælp om måneden før skat.<br/>" +
                    "Når du modtager kontanthjælp skal stå til rådighed for aktiviteter op til 37 timer om ugen.<br/>" +
                    "Det svarer til en timeløn på 63 kroner før skat. Det betyder, at du eksempelvis kan blive bedt om at deltage i nyttejob, hvor du skal hjælpe med at vedligeholde kommunens grønne arealer." +
                    "<br/><br/>" +

                    "<b> Det kan betale sig at arbejde </b><br/>" +
                    "Vælger du i stedet at tage et job, kan du tjene flere penge i timen.<br/>" +
                    "•	Et avisbud får ca. 100 kroner i timen.<br/>" +
                    "•	En kassemedarbejder får ca. 130 kroner i timen<br/>" +
                    "•	En faglært får ca. 200 kroner i timen <br/><br/>" +

                    "<b> Så få timer om ugen skal du arbejde for at tjene det, der svarer til kontanthjælp</b><br/>" +
                    "Hvis du tager et job i stedet for kontanthjælp kan du nøjes med at arbejde færre timer, end du skal stå til rådighed<br/>";

                Image = "D";

                Text2 = "<br/><b> Sådan søger du kontanthjælp </b><br/>" +
                "Du søger om kontanthjælp ved at møde op i Modtagelsen i Jobcenter Vejle i Havneparken 16C. Du kan først få kontanthjælp fra den dag, du har udfyldt en ansøgning i jobcenteret og meldt dig ledig på Jobnet.<br/>" +
                "Det er kun i jobcenteret, du kan få den præcise beregning af, hvad du kan få i kontanthjælp.<br/>";
            }
            #endregion

            // Godkendt resultat E
            #region
            if (Resultat == "E") // Kontanthjælp - ingen børn - udeboende
            {
                Text1 = "På baggrund af de oplysninger, du har indtastet, ser det ud til, at du kan få 7.272 kroner i kontanthjælp om måneden før skat.<br/>" +
                    "Når du modtager kontanthjælp skal du stå til rådighed for aktiviteter op til 37 timer om ugen.<br/>" +
                    "Det svarer til en timeløn på 45 kroner før skat. Det betyder, at du eksempelvis kan blive bedt om at deltage i nyttejob, hvor du skal hjælpe med at vedligeholde kommunens grønne arealer." +
                    "<br/><br/>" +

                    "<b> Det kan betale sig at arbejde </b><br/>" +
                    "Vælger du i stedet at tage et job, kan du tjene flere penge i timen.<br/>" +
                    "•	Et avisbud får ca. 100 kroner i timen. <br/>" +
                    "•	En kassemedarbejder får ca. 130 kroner i timen.<br/>" +
                    "•	En faglært får ca. 200 kroner i timen <br/><br/>" +

                    "<b> Så få timer om ugen skal du arbejde for at tjene det, der svarer til kontanthjælp. </b><br/>" +
                    "Hvis du tager et job i stedet for kontanthjælp kan du nøjes med at arbejde færre timer, end du skal stå til rådighed<br/>";

                Image = "E";

                Text2 = "<br/><b> Sådan søger du kontanthjælp </b><br/>" +
                    "Du søger om kontanthjælp ved at møde op i Modtagelsen i Jobcenter Vejle i Havneparken 16C. Du kan først få kontanthjælp fra den dag, du har udfyldt en ansøgning i jobcenteret og meldt dig ledig på Jobnet. <br/>" +
                "Det er kun i jobcenteret, du kan få den præcise beregning af, hvad du kan få i kontanthjælp.";
            }
            #endregion

            // Godkendt resultat F
            #region
            if (Resultat == "F") // Kontanthjælp - ingen børn - hjemmeboende
            {
                Text1 = "På baggrund af de oplysninger, du har indtastet, ser det ud til, at du kan få 3.509 kroner i kontanthjælp om måneden før skat.<br/>" +
                    "Når du modtager kontanthjælp skal stå til rådighed for aktiviteter op til 37 timer om ugen.<br/>" +
                    ". Det svarer til en timeløn på 22 kroner før skat. Det betyder, at du eksempelvis kan blive bedt om at deltage i nyttejob, hvor du skal hjælpe med at vedligeholde kommunens grønne arealer.<br/>" +

                    "<b> Det kan betale sig at arbejde </b><br/>" +
                    "Vælger du i stedet at tage et job, kan du tjene flere penge i timen.<br/>" +
                    "•	Et avisbud får ca. 100 kroner i timen.<br/>" +
                    "•	En kassemedarbejder får ca. 130 kroner i timen<br/>" +
                    "•	En faglært får ca. 200 kroner i timen<br/><br/>" +

                    "<b> Så få timer om ugen skal du arbejde for at tjene det, der svarer til kontanthjælp. </b><br/>" +
                    "Hvis du tager et job i stedet for kontanthjælp kan du nøjes med at arbejde færre timer, end du skal stå til rådighed<br/>";


                Image = "F";

                Text2 = "<br/><b> Sådan søger du kontanthjælp </b><br/>" +
                "Du søger om kontanthjælp ved at møde op i Modtagelsen i Jobcenter Vejle i Havneparken 16C. Du kan først få kontanthjælp fra den dag, du har udfyldt en ansøgning i jobcenteret og meldt dig ledig på Jobnet.<br/>" +
                "Det er kun i jobcenteret, du kan få den præcise beregning af, hvad du kan få i kontanthjælp.";

            }
            #endregion

            // Godkendt resultat G
            #region
            if (Resultat == "G") // <-- Uddannelsesydelse - under 30 udeboende
            {
                Text1 = "På baggrund af de oplysninger, du har indtastet, ser det ud til, at du kan få 6.182 kroner i uddannelseshjælp om måneden før skat.<br/>" +
                    "Når du modtager uddannelseshjælp skal stå til rådighed for aktiviteter op til 37 timer om ugen.<br/>" +
                    "Det svarer til en timeløn på 39 kroner før skat. Det betyder, at du eksempelvis kan blive bedt om at deltage i nyttejob, hvor du skal hjælpe med at vedligeholde kommunens grønne arealer." +
                    "<br/><br/>" +

                    "<b> Det kan betale sig at arbejde </b><br/>" +
                    "Vælger du i stedet at tage et job, kan du tjene flere penge i timen. <br/>" +
                    "•	Et avisbud får ca. 100 kroner i timen.<br/>" +
                    "•	En kassemedarbejder får ca. 130 kroner i timen <br/>" +
                    "•	En faglært får ca. 200 kroner i timen<br/><br/>" +

                    "<b> Så få timer om ugen skal du arbejde for at tjene det, der svarer til uddannelseshjælp </b><br/>" +
                    "Hvis du tager et job i stedet for uddannelseshjælp kan du nøjes med at arbejde færre timer, end du skal stå til rådighed.<br/>";

                Image = "G";

                Text2 = "<br/><b> Sådan søger du uddannelseshjælp</b><br/>" +
                    "Du søger om uddannelseshjælp ved at møde op i Modtagelsen i Jobcenter Vejle i Havneparken 16C. Du kan først få uddannelseshjælp fra den dag, du har udfyldt en ansøgning i jobcenteret og meldt dig ledig på Jobnet.<br/>" +
                    "Det er kun i jobcenteret, du kan få den præcise beregning af, hvad du kan få i uddannelseshjælp.";
            }
            #endregion

            // Godkendt resultat H
            #region
            if (Resultat == "H") // <-- Uddannelsesydelse - under 30 hjemme
            {
                Text1 = "På baggrund af de oplysninger, du har indtastet, ser det ud til, at du kan få 2.664 kroner i uddannelseshjælp om måneden før skat.<br/>" +
                    "Når du modtager uddannelseshjælp skal stå til rådighed for aktiviteter op til 37 timer om ugen.<br/>" +
                    "Det svarer til en timeløn på 17 kroner før skat. Det betyder, at du eksempelvis kan blive bedt om at deltage i nyttejob, hvor du skal hjælpe med at vedligeholde kommunens grønne arealer." +
                    "<br/><br/>" +


                    "<b> Det kan betale sig at arbejde </b><br/>" +
                    "Vælger du i stedet at tage et job, kan du tjene flere penge i timen. <br/>" +
                    "•	Et avisbud får ca. 100 kroner i timen. <br/>" +
                    "•	En kassemedarbejder får ca. 130 kroner i timen <br/>" +
                    "•	En faglært får ca. 200 kroner i timen <br/><br/>" +


                    "<b> Så få timer om ugen skal du arbejde for at tjene det, der svarer til uddannelseshjælp </b><br/>" +
                    "Hvis du tager et job i stedet for uddannelseshjælp kan du nøjes med at arbejde færre timer, end du skal stå til rådighed.<br/>";


                Image = "H";

                Text2 = "<br/><b> Sådan søger du uddannelseshjælp </b><br/>" +
                "Du søger om uddannelseshjælp ved at møde op i Modtagelsen i Jobcenter Vejle i Havneparken 16C. Du kan først få uddannelseshjælp fra den dag, du har udfyldt en ansøgning i jobcenteret og meldt dig ledig på Jobnet.<br/>" +
                "Det er kun i jobcenteret, du kan få den præcise beregning af, hvad du kan få i uddannelseshjælp.<br/>";
            }
            #endregion
           
            // Godkendt resultat I
            #region
            if (Resultat == "I") // <-- Uddannelsesydelse - børn - tillæg
            {
                Text1 = "På baggrund af de oplysninger, du har indtastet, ser det ud til, at du kan få 12.364 kroner i uddannelseshjælp om måneden før skat.<br/>" +
                    "Når du modtager uddannelseshjælp skal stå til rådighed for aktiviteter op til 37 timer om ugen.<br/>" +
                    "Det svarer til en timeløn på 77 kroner før skat. Det betyder, at du eksempelvis kan blive bedt om at deltage i nyttejob, hvor du skal hjælpe med at vedligeholde kommunens grønne arealer." +
                    "<br/><br/>" +

                    "<b> Det kan betale sig at arbejde </b><br/>" +
                    "Vælger du i stedet at tage et job, kan du tjene flere penge i timen.<br/>" +
                    "•	Et avisbud får ca. 100 kroner i timen. <br/>" +
                    "•	En kassemedarbejder får ca. 130 kroner i timen <br/>" +
                    "•	En faglært får ca. 200 kroner i timen <br/><br/>" +

                    "<b> Så få timer om ugen skal du arbejde for at tjene det, der svarer til uddannelseshjælp</b><br/>" +
                    "Hvis du tager et job i stedet for uddannelseshjælp kan du nøjes med at arbejde færre timer, end du skal stå til rådighed. <br/>";

                Image = "I";

               Text2 = "<br/><b>Sådan søger du uddannelseshjælp</b><br/>" +
                "Du søger om uddannelseshjælp ved at møde op i Modtagelsen i Jobcenter Vejle i Havneparken 16C. Du kan først få uddannelseshjælp fra den dag, du har udfyldt en ansøgning i jobcenteret og meldt dig ledig på Jobnet. <br/>" +
                "Det er kun i jobcenteret, du kan få den præcise beregning af, hvad du kan få i uddannelseshjælp. <br/>";
            }
            #endregion

            // Godkendt resultat K (Kopi af I)
            #region
            if (Resultat == "K") // <-- Uddannelsesydelse - børn - ikke tillæg
            {
                Text1 = "På baggrund af de oplysninger, du har indtastet, ser det ud til, at du kan få 8.653 kroner i uddannelseshjælp om måneden før skat.<br/>" +
                    "Når du modtager uddannelseshjælp skal stå til rådighed for aktiviteter op til 37 timer om ugen.<br/>" +
                    "Det svarer til en timeløn på 54 kroner før skat. Det betyder, at du eksempelvis kan blive bedt om at deltage i nyttejob, hvor du skal hjælpe med at vedligeholde kommunens grønne arealer." +
                    "<br/><br/>" +

                    "<b> Det kan betale sig at arbejde </b><br/>" +
                    "Vælger du i stedet at tage et job, kan du tjene flere penge i timen.<br/>" +
                    "•	Et avisbud får ca. 100 kroner i timen. <br/>" +
                    "•	En kassemedarbejder får ca. 130 kroner i timen <br/>" +
                    "•	En faglært får ca. 200 kroner i timen <br/><br/>" +

                    "<b> Så få timer om ugen skal du arbejde for at tjene det, der svarer til uddannelseshjælp</b><br/>" +
                    "Hvis du tager et job i stedet for uddannelseshjælp kan du nøjes med at arbejde færre timer, end du skal stå til rådighed. <br/>";

                Image = "K";

               Text2 = "<br/><b>Sådan søger du uddannelseshjælp</b><br/>" +
                 "Du søger om uddannelseshjælp ved at møde op i Modtagelsen i Jobcenter Vejle i Havneparken 16C. Du kan først få uddannelseshjælp fra den dag, du har udfyldt en ansøgning i jobcenteret og meldt dig ledig på Jobnet. <br/>" +
                 "Det er kun i jobcenteret, du kan få den præcise beregning af, hvad du kan få i uddannelseshjælp. <br/>";
            }
            #endregion
            
            // Godkendt resultat L
            #region
            if (Resultat == "NejNejJaJa") // <-- Integrationsydelse -  børn a
            {
                Text1 = "På baggrund af de oplysninger, du har indtastet, ser det ud til, at du kan få 12.364 kroner i integrationsydelse om måneden før skat. <br/>" +
                    "Når du modtager integrationsydelse skal stå til rådighed for aktiviteter op til 37 timer om ugen. <br/>" +
                    "Det svarer til en timeløn på 77 kroner før skat. Det betyder, at du eksempelvis kan blive bedt om at deltage i nyttejob, hvor du skal hjælpe med at vedligeholde kommunens grønne arealer. <br/>" +
                    "<br/><br/>" +


                    "<b> Det kan betale sig at arbejde </b><br/>" +
                    "Vælger du i stedet at tage et job, kan du tjene flere penge i timen. <br/>" +
                    "•	Et avisbud får ca. 100 kroner i timen. <br/>" +
                    "•	En kassemedarbejder får ca. 130 kroner i timen <br/>" +
                    "•	En faglært får ca. 200 kroner i timen <br/><br/>" +

                    "<b> Så få timer om ugen skal du arbejde for at tjene det, der svarer til integrationsydelse </b><br/>" +
                    "Hvis du tager et job i stedet for integrationsydelse kan du nøjes med at arbejde færre timer, end du skal stå til rådighed <br/>";

                Image = "L";

                Text2 = "<br/><b> Sådan søger du integrationsydelse </b><br/>" +
                "Du søger om integrationsydelse ved at møde op i Modtagelsen i Jobcenter Vejle i Havneparken 16C. Du kan først få integrationsydelse fra den dag, du har udfyldt en ansøgning i jobcenteret og meldt dig ledig på Jobnet. <br/><br/>" +
                "Det er kun i jobcenteret, du kan få den præcise beregning af, hvad du kan få i integrationsydelse.<br/>";
            }
            #endregion
            
            // Godkendt resultat M
            #region
            if (Resultat == "NejNejJaNej") // <-- Integrationsydelse -  børn b
            {
                Text1 = "På baggrund af de oplysninger, du har indtastet, ser det ud til, at du kan få 8.653 kroner i integrationsydelse om måneden før skat.<br/>" +
                    "Når du modtager integrationsydelse skal stå til rådighed for aktiviteter op til 37 timer om ugen. <br/>" +
                    "Det svarer til en timeløn på 54 kroner før skat. Det betyder, at du eksempelvis kan blive bedt om at deltage i nyttejob, hvor du skal hjælpe med at vedligeholde kommunens grønne arealer. <br/>" +
                    "<br/><br/>" +


                    "<b> Det kan betale sig at arbejde </b><br/>" +
                    "Vælger du i stedet at tage et job, kan du tjene flere penge i timen. <br/>" +
                    "•	Et avisbud får ca. 100 kroner i timen. <br/>" +
                    "•	En kassemedarbejder får ca. 130 kroner i timen <br/>" +
                    "•	En faglært får ca. 200 kroner i timen <br/><br/>" +

                   "<b> Så få timer om ugen skal du arbejde for at tjene det, der svarer til integrationsydelse </b><br/>" +
                   "Hvis du tager et job i stedet for integrationsydelse kan du nøjes med at arbejde færre timer, end du skal stå til rådighed.<br/>";

                Image = "M";

               Text2 = "<br/><b> Sådan søger du integrationsydelse </b><br/>" +
                "Du søger om integrationsydelse ved at møde op i Modtagelsen i Jobcenter Vejle i Havneparken 16C. Du kan først få integrationsydelse fra den dag, du har udfyldt en ansøgning i jobcenteret og meldt dig ledig på Jobnet.<br/><br/>" +
                "Det er kun i jobcenteret, du kan få den præcise beregning af, hvad du kan få i integrationsydelse. <br/>";
            }
            #endregion
    
            // Godkendt resultat N
            #region
            if (Resultat == "NejNejNejUnderUde" || Resultat == "NejNejNejOver") // <-- Integrationsydelse - ingen børn a
            {
                Text1 = "På baggrund af de oplysninger, du har indtastet, ser det ud til, at du kan få 6.182 kroner i integrationsydelse om måneden før skat. <br/>" +
                    "Når du modtager integrationsydelse skal stå til rådighed for aktiviteter op til 37 timer om ugen. <br/>" +
                    "Det svarer til en timeløn på 39 kroner før skat. Det betyder, at du eksempelvis kan blive bedt om at deltage i nyttejob, hvor du skal hjælpe med at vedligeholde kommunens grønne arealer." +
                    "<br/><br/>" +


                    "<b> Det kan betale sig at arbejde </b><br/>" +
                    "Vælger du i stedet at tage et job, kan du tjene flere penge i timen. <br/>" +
                    "•	Et avisbud får ca. 100 kroner i timen. <br/>" +
                    "•	En kassemedarbejder får ca. 130 kroner i timen <br/>" +
                    "•	En faglært får ca. 200 kroner i timen <br/><br/>" +

                    "<b> Så få timer om ugen skal du arbejde for at tjene det, der svarer til integrationsydelse </b><br/>" +
                    "Hvis du tager et job i stedet for integrationsydelse kan du nøjes med at arbejde færre timer, end du skal stå til rådighed.<br/>";

                Image = "N";

                Text2 = "<br/><b> Sådan søger du integrationsydelse </b><br/>" +
                "Du søger om integrationsydelse ved at møde op i Modtagelsen i Jobcenter Vejle i Havneparken 16C. Du kan først få integrationsydelse fra den dag, du har udfyldt en ansøgning i jobcenteret og meldt dig ledig på Jobnet. <br/><br/>" +
                "Det er kun i jobcenteret, du kan få den præcise beregning af, hvad du kan få i integrationsydelse.<br/>";
            }
            #endregion

            // Godkendt resultat O (Kopi af N)
            #region
            if (Resultat == "NejNejNejUnderHjemme") //  <-- Integrationsydelse - ingen børn b
            {
                Text1 = "På baggrund af de oplysninger, du har indtastet, ser det ud til, at du kan få 2.664 kroner i integrationsydelse om måneden før skat. <br/>" +
                    "Når du modtager integrationsydelse skal stå til rådighed for aktiviteter op til 37 timer om ugen.  <br/>" +
                    "Det svarer til en timeløn på 17 kroner før skat. Det betyder, at du eksempelvis kan blive bedt om at deltage i nyttejob, hvor du skal hjælpe med at vedligeholde kommunens grønne arealer." +
                    "<br/><br/>" +


                    "<b> Det kan betale sig at arbejde </b><br/>" +
                    "Vælger du i stedet at tage et job, kan du tjene flere penge i timen. <br/>" +
                    "•	Et avisbud får ca. 100 kroner i timen. <br/>" +
                    "•	En kassemedarbejder får ca. 130 kroner i timen <br/>" +
                    "•	En faglært får ca. 200 kroner i timen <br/><br/>" +

                    "<b> Så få timer om ugen skal du arbejde for at tjene det, der svarer til integrationsydelse </b><br/>" +
                    "Hvis du tager et job i stedet for integrationsydelse kan du nøjes med at arbejde færre timer, end du skal stå til rådighed.<br/>";

                Image = "O";

                Text2 = "<br/><b> Sådan søger du integrationsydelse </b><br/>" +
                "Du søger om integrationsydelse ved at møde op i Modtagelsen i Jobcenter Vejle i Havneparken 16C. Du kan først få integrationsydelse fra den dag, du har udfyldt en ansøgning i jobcenteret og meldt dig ledig på Jobnet. <br/><br/>" +
                "Det er kun i jobcenteret, du kan få den præcise beregning af, hvad du kan få i integrationsydelse.<br/>";
            }
            #endregion 
        }
    }
}
