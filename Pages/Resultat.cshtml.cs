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
        public void OnGet()
        {
            /* // Erklærer en string med navnet "Resultat" og dens funktion.
            // "Request.QueryString[variable]" fanger variablen's værdi, som bliver passed fra forrige side med Response.Redirect()
            String Resultat = Request.QueryString["Name"];

            // Hvis string "Resultat" indeholder teksten "IkkeBerettiget" --> Kør koden heri
            if (Resultat == "IkkeBerettiget")
            {
                // Definerer Label1's Text attribut.
                // Nedenstående tekst i anførselstegn er blevet delt op for nemmere læselighed. Der skal være anførsels- og additionstegn 
                // på hver linje for at kæde teksten sammen.
                Label1.Text = "Ud fra dine oplysninger er du ikke berettiget til at modtage økonomisk hjælp fra kommunen." +
                    "<br/> Denne vurdering er vejledende.<br/> I Jobcenter Vejle, " +
                    "Kan vi hjælpe dig med en endelig vurdering.";
            }

            // Godkendt resultat A
            #region
            if (Resultat == "JaNejOverJa" || Resultat == "JaJaOverJa") // <-- "JaJaOverJa" er brugerens svar på hvert spørgsmål
            {
                Label1.Text = "På baggrund af de oplysninger, du har indtastet, ser det ud til, at du kan få 14.993 kroner i kontanthjælp om måneden før skat.<br/>" +
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

                ImageA.Visible = true;  // <-- Alle billederne ligger i designeren, men er skjult. Ved resultat A bliver det tilsvarende                                        
                                        // billede gjort synlig
                Label2.Text = "<br/><b> Sådan søger du kontanthjælp </b><br/>" +
                    "Du søger om kontanthjælp ved at møde op i Modtagelsen i Jobcenter Vejle i Havneparken 16C. Du kan først få kontanthjælp fra den dag, du har udfyldt en ansøgning i jobcenteret og meldt dig ledig på Jobnet.<br/>" +
                    "Det er kun i jobcenteret, du kan få den præcise beregning af, hvad du kan få i kontanthjælp.";
            }
            #endregion

            // Godkendt resultat B
            #region
            if (Resultat == "JaNejOverNej" || Resultat == "JaJaOverNej") // <-- "JaJaOverNej" er brugerens svar på hvert spørgsmål
            {
                Label1.Text = "På baggrund af de oplysninger, du har indtastet, ser det ud til, at du kan få 11.282 kroner i kontanthjælp om måneden før skat." +
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

                ImageB.Visible = true;

                Label2.Text = "<br/><b> Sådan søger du kontanthjælp </b><br/>" +
                    "Du søger om kontanthjælp ved at møde op i Modtagelsen i Jobcenter Vejle i Havneparken 16C. Du kan først få kontanthjælp fra den dag, du har udfyldt en ansøgning i jobcenteret og meldt dig ledig på Jobnet. <br/>" +
                    "Det er kun i jobcenteret, du kan få den præcise beregning af, hvad du kan få i kontanthjælp.";
            }
            #endregion

            // Godkendt resultat C
            #region
            if (Resultat == "JaJaUnderJaJa") // <-- "JaJaUnderJa" er brugerens svar på hvert spørgsmål
            {
                Label1.Text = "På baggrund af de oplysninger, du har indtastet, ser det ud til, at du kan få 14.331 kroner i kontanthjælp om måneden før skat. <br/>" +
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

                    ImageC.Visible = true;

                Label2.Text = "<br/><b> Sådan søger du kontanthjælp </b><br/>" +
                    "Du søger om kontanthjælp ved at møde op i Modtagelsen i Jobcenter Vejle i Havneparken 16C. Du kan først få kontanthjælp fra den dag, du har udfyldt en ansøgning i jobcenteret og meldt dig ledig på Jobnet.<br/>" +
                    "Det er kun i jobcenteret, du kan få den præcise beregning af, hvad du kan få i kontanthjælp.";
            }
                #endregion

            // Godkendt resultat D
            #region
            if (Resultat == "JaJaUnderJaNej" ) // <-- "JaJaUnderNejOverUde" er brugerens svar på hvert spørgsmål
            {
                Label1.Text = "På baggrund af de oplysninger, du har indtastet, ser det ud til, at du kan få 10.026 kroner i kontanthjælp om måneden før skat.<br/>" +
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

                ImageD.Visible = true;

                Label2.Text = "<br/><b> Sådan søger du kontanthjælp </b><br/>" +
                "Du søger om kontanthjælp ved at møde op i Modtagelsen i Jobcenter Vejle i Havneparken 16C. Du kan først få kontanthjælp fra den dag, du har udfyldt en ansøgning i jobcenteret og meldt dig ledig på Jobnet.<br/>" +
                "Det er kun i jobcenteret, du kan få den præcise beregning af, hvad du kan få i kontanthjælp.<br/>";
            }
            #endregion

            // Godkendt resultat E
            #region
            if (Resultat == "JaJaUnderNejOverUde" || Resultat == "JaJaUnderNejUnderUde") // <-- "JaJaUnderNejOverHjemme" er brugerens svar på hvert spørgsmål
            {
                Label1.Text = "På baggrund af de oplysninger, du har indtastet, ser det ud til, at du kan få 7.272 kroner i kontanthjælp om måneden før skat.<br/>" +
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

                ImageE.Visible = true;

                Label2.Text = "<br/><b> Sådan søger du kontanthjælp </b><br/>" +
                    "Du søger om kontanthjælp ved at møde op i Modtagelsen i Jobcenter Vejle i Havneparken 16C. Du kan først få kontanthjælp fra den dag, du har udfyldt en ansøgning i jobcenteret og meldt dig ledig på Jobnet. <br/>" +
                "Det er kun i jobcenteret, du kan få den præcise beregning af, hvad du kan få i kontanthjælp.";
            }
            #endregion

            // Godkendt resultat F
            #region
            if (Resultat == "JaJaUnderNejUnderHjemme" || Resultat == "JaJaUnderNejOverHjemme") // <-- "JaNejJa" er brugerens svar på hvert spørgsmål
            {
                Label1.Text = "På baggrund af de oplysninger, du har indtastet, ser det ud til, at du kan få 3.509 kroner i kontanthjælp om måneden før skat.<br/>" +
                    "Når du modtager kontanthjælp skal stå til rådighed for aktiviteter op til 37 timer om ugen.<br/>" +
                    ". Det svarer til en timeløn på 22 kroner før skat. Det betyder, at du eksempelvis kan blive bedt om at deltage i nyttejob, hvor du skal hjælpe med at vedligeholde kommunens grønne arealer.<br/>" +

                    "<b> Det kan betale sig at arbejde </b><br/>" +
                    "Vælger du i stedet at tage et job, kan du tjene flere penge i timen.<br/>" +
                    "•	Et avisbud får ca. 100 kroner i timen.<br/>" +
                    "•	En kassemedarbejder får ca. 130 kroner i timen<br/>" +
                    "•	En faglært får ca. 200 kroner i timen<br/><br/>" +

                    "<b> Så få timer om ugen skal du arbejde for at tjene det, der svarer til kontanthjælp. </b><br/>" +
                    "Hvis du tager et job i stedet for kontanthjælp kan du nøjes med at arbejde færre timer, end du skal stå til rådighed<br/>";


                ImageF.Visible = true;

                Label2.Text = "<br/><b> Sådan søger du kontanthjælp </b><br/>" +
                "Du søger om kontanthjælp ved at møde op i Modtagelsen i Jobcenter Vejle i Havneparken 16C. Du kan først få kontanthjælp fra den dag, du har udfyldt en ansøgning i jobcenteret og meldt dig ledig på Jobnet.<br/>" +
                "Det er kun i jobcenteret, du kan få den præcise beregning af, hvad du kan få i kontanthjælp.";

            }
            #endregion

            // Godkendt resultat G
            #region
            if (Resultat == "JaNejUnderNejOverUde" || Resultat == "JaNejUnderNejUnderUde") // <-- "JaNejNejOverUde" er brugerens svar på hvert spørgsmål
            {
                Label1.Text = "På baggrund af de oplysninger, du har indtastet, ser det ud til, at du kan få 6.182 kroner i uddannelseshjælp om måneden før skat.<br/>" +
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

                ImageG.Visible = true;

                    Label2.Text = "<br/><b> Sådan søger du uddannelseshjælp</b><br/>" +
                    "Du søger om uddannelseshjælp ved at møde op i Modtagelsen i Jobcenter Vejle i Havneparken 16C. Du kan først få uddannelseshjælp fra den dag, du har udfyldt en ansøgning i jobcenteret og meldt dig ledig på Jobnet.<br/>" +
                    "Det er kun i jobcenteret, du kan få den præcise beregning af, hvad du kan få i uddannelseshjælp.";
            }
            #endregion

            // Godkendt resultat H
            #region
            if (Resultat == "JaNejUnderNejOverHjemme" || Resultat == "JaNejUnderNejUnderHjemme") // <-- "JaNejNejOverHjemme" er brugerens svar på hvert spørgsmål
            {
                Label1.Text = "På baggrund af de oplysninger, du har indtastet, ser det ud til, at du kan få 2.664 kroner i uddannelseshjælp om måneden før skat.<br/>" +
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


                ImageH.Visible = true;

                Label2.Text = "<br/><b> Sådan søger du uddannelseshjælp </b><br/>" +
                "Du søger om uddannelseshjælp ved at møde op i Modtagelsen i Jobcenter Vejle i Havneparken 16C. Du kan først få uddannelseshjælp fra den dag, du har udfyldt en ansøgning i jobcenteret og meldt dig ledig på Jobnet.<br/>" +
                "Det er kun i jobcenteret, du kan få den præcise beregning af, hvad du kan få i uddannelseshjælp.<br/>";
            }
            #endregion

            // Godkendt resultat I
            #region
            if (Resultat == "JaNejUnderJaJa") // <-- "NejJa" er brugerens svar på hvert spørgsmål
            {
                Label1.Text = "På baggrund af de oplysninger, du har indtastet, ser det ud til, at du kan få 12.364 kroner i uddannelseshjælp om måneden før skat.<br/>" +
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

                ImageI.Visible = true;

               Label2.Text = "<br/><b>Sådan søger du uddannelseshjælp</b><br/>" +
                "Du søger om uddannelseshjælp ved at møde op i Modtagelsen i Jobcenter Vejle i Havneparken 16C. Du kan først få uddannelseshjælp fra den dag, du har udfyldt en ansøgning i jobcenteret og meldt dig ledig på Jobnet. <br/>" +
                "Det er kun i jobcenteret, du kan få den præcise beregning af, hvad du kan få i uddannelseshjælp. <br/>";
            }
            #endregion

            // Godkendt resultat K (Kopi af I)
            #region
            if (Resultat == "JaNejUnderJaNej") // <-- "NejJa" er brugerens svar på hvert spørgsmål
            {
                Label1.Text = "På baggrund af de oplysninger, du har indtastet, ser det ud til, at du kan få 8.653 kroner i uddannelseshjælp om måneden før skat.<br/>" +
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

                ImageK.Visible = true;

                Label2.Text = "<br/><b>Sådan søger du uddannelseshjælp</b><br/>" +
                 "Du søger om uddannelseshjælp ved at møde op i Modtagelsen i Jobcenter Vejle i Havneparken 16C. Du kan først få uddannelseshjælp fra den dag, du har udfyldt en ansøgning i jobcenteret og meldt dig ledig på Jobnet. <br/>" +
                 "Det er kun i jobcenteret, du kan få den præcise beregning af, hvad du kan få i uddannelseshjælp. <br/>";
            }
            #endregion

            // Godkendt resultat L
            #region
            if (Resultat == "NejNejJaJa") // <-- "NejNejOver" er brugerens svar på hvert spørgsmål
            {
                Label1.Text = "På baggrund af de oplysninger, du har indtastet, ser det ud til, at du kan få 12.364 kroner i integrationsydelse om måneden før skat. <br/>" +
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

                ImageL.Visible = true;

                Label2.Text = "<br/><b> Sådan søger du integrationsydelse </b><br/>" +
                "Du søger om integrationsydelse ved at møde op i Modtagelsen i Jobcenter Vejle i Havneparken 16C. Du kan først få integrationsydelse fra den dag, du har udfyldt en ansøgning i jobcenteret og meldt dig ledig på Jobnet. <br/><br/>" +
                "Det er kun i jobcenteret, du kan få den præcise beregning af, hvad du kan få i integrationsydelse.<br/>";
            }
            #endregion

            // Godkendt resultat M
            #region
            if (Resultat == "NejNejJaNej") // <-- "NejNejUnderUde" er brugerens svar på hvert spørgsmål
            {
                Label1.Text = "På baggrund af de oplysninger, du har indtastet, ser det ud til, at du kan få 8.653 kroner i integrationsydelse om måneden før skat.<br/>" +
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

                ImageM.Visible = true;

               Label2.Text = "<br/><b> Sådan søger du integrationsydelse </b><br/>" +
                "Du søger om integrationsydelse ved at møde op i Modtagelsen i Jobcenter Vejle i Havneparken 16C. Du kan først få integrationsydelse fra den dag, du har udfyldt en ansøgning i jobcenteret og meldt dig ledig på Jobnet.<br/><br/>" +
                "Det er kun i jobcenteret, du kan få den præcise beregning af, hvad du kan få i integrationsydelse. <br/>";
            }
            #endregion

            // Godkendt resultat N
            #region
            if (Resultat == "NejNejNejUnderUde" || Resultat == "NejNejNejOver") // <-- "NejNejUnderHjemme" er brugerens svar på hvert spørgsmål
            {
                Label1.Text = "På baggrund af de oplysninger, du har indtastet, ser det ud til, at du kan få 6.182 kroner i integrationsydelse om måneden før skat. <br/>" +
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

                ImageN.Visible = true;

                Label2.Text = "<br/><b> Sådan søger du integrationsydelse </b><br/>" +
                "Du søger om integrationsydelse ved at møde op i Modtagelsen i Jobcenter Vejle i Havneparken 16C. Du kan først få integrationsydelse fra den dag, du har udfyldt en ansøgning i jobcenteret og meldt dig ledig på Jobnet. <br/><br/>" +
                "Det er kun i jobcenteret, du kan få den præcise beregning af, hvad du kan få i integrationsydelse.<br/>";
            }
            #endregion

            // Godkendt resultat O (Kopi af N)
            #region
            if (Resultat == "NejNejNejUnderHjemme") // <-- "NejNejUnderHjemme" er brugerens svar på hvert spørgsmål
            {
                Label1.Text = "På baggrund af de oplysninger, du har indtastet, ser det ud til, at du kan få 2.664 kroner i integrationsydelse om måneden før skat. <br/>" +
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

                ImageO.Visible = true;

                Label2.Text = "<br/><b> Sådan søger du integrationsydelse </b><br/>" +
                "Du søger om integrationsydelse ved at møde op i Modtagelsen i Jobcenter Vejle i Havneparken 16C. Du kan først få integrationsydelse fra den dag, du har udfyldt en ansøgning i jobcenteret og meldt dig ledig på Jobnet. <br/><br/>" +
                "Det er kun i jobcenteret, du kan få den præcise beregning af, hvad du kan få i integrationsydelse.<br/>";
            }
            #endregion */
        }
    }
}
