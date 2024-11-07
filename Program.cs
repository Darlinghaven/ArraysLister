namespace ArraysLister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array med spørgsmål
            string[] questions = { "Text1", "Text2", "Text3", "Text4" };

            // Array med svar til de respektive spørgsmål
            string[][] options = {
            new string[] { "1) Incorrect", "2) Correct", "3) Incorrect", "4) Incorrect" },
            new string[] { "1) Correct", "2) Incorrect", "3) Incorrect", "4) Incorrect" },
            new string[] { "1) Incorrect", "2) Incorrect", "3) Correct", "4) Incorrect" },
            new string[] { "1) Incorrect", "2) Incorrect", "3) Incorrect", "4) Correct" }
    };

            // Array med korrekte svar
            int[] correctAnswers = { 2, 1, 3, 4 };

            // Variabel til at holde styr på brugerens point.
            int score = 0;

            /* Loop igennem hvert spørgsmål. Efter hvert spørgsmål tilføjes 1 til i,
               indtil i ikke længere er mindre end antallet af spørgsmål. 
               i++ betyder i = i + 1 og sørger for at værdien i stiger med 1 efter hver iteration af loopet */
            for (int i = 0; i < questions.Length; i++)
            {
                // Vis spørgsmålets nummer og selve spørgsmålet. 
                Console.WriteLine($"Question {i + 1}: {questions[i]}");

                // Vis hvert svar til det aktuelle spørgsmål
                foreach (string option in options[i])
                    Console.WriteLine(option);

                // Variabel til at lagre brugerens svar. Bliver relevant når programmet parser senere.
                int userChoice;

                // Bool til at vurdere om brugerens input er gyldigt
                bool isValidInput = false;

                /* Loop indtil brugeren indtaster et gyldigt svar. ! betyder NOT, hvilket betyder at udgangspunktet er false når loopet starter.
                   Loopet fortsætter imens betingelsen er false (while the condition is false) og stopper når betingelsen er true, 
                   altså et gyldigt input skrives. */
                while (!isValidInput)
                {
                    // Giv brugeren mulighed for at svare på spørgsmålet.
                    Console.WriteLine("Your answer (enter the number 1, 2, 3, or 4): ");

                    /* Forsøg at konvertere/parse brugerens svar til et tal. out bruges til at lagre resultatet as konverteringen. 
                       Hvis konverteringen er succesfuld tildeler programmet værdien til userChocice variablen. && forbinder vestre 
                       og højre side af koden og sætter et kriterie for at begge sider skal være sande for at hele koden er true. 
                       Højre side undersøger om bruger inputtet ligger inden for tallene 1 til 4 (begge inklusiv "="). */
                    if (int.TryParse(Console.ReadLine(), out userChoice) && userChoice >= 1 && userChoice <= 4)
                    {
                        isValidInput = true; // Input er gyldigt, afslut while-loopet.

                        // Sammenhold brugerens svar med det korrekte svar
                        if (userChoice == correctAnswers[i])
                        {
                            // Hvis svaret er korrekt får brugeren en bekræftelse på at svaret er rigtigt og der tilføjes 1 til score variablen.
                            Console.WriteLine("Correct!\n");
                            score++;
                        }
                        else
                        {
                            // Hvis svaret er forkert får brugeren en besked.
                            Console.WriteLine("Incorrect.\n");
                        }
                    }
                    else
                    {
                        // Fejlbesked ved ugyldigt input
                        Console.WriteLine("Invalid input. Please enter a number between 1 and 4.\n");
                    }
                }
            }
            // Vis antallet af rigtige svar ud af antallet af spørgsmål.
            Console.WriteLine($"Your final score: {score} out of {questions.Length}");
            Console.ReadKey();
        }
    }
}
