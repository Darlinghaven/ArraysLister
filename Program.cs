namespace ArraysLister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] questions = { "Text1", "Text2", "Text3", "Text4" };
            string[][] options = {
                new string[] { "1) Incorrect", "2) Correct", "3) Incorrect", "4) Incorrect" },
                new string[] { "1) Correct", "2) Incorrect", "3) Incorrect", "4) Incorrect" },
                new string[] { "1) Incorrect", "2) Incorrect", "3) Correct", "4) Incorrect" },
                new string[] { "1) Incorrect", "2) Incorrect", "3) Incorrect", "4) Correct" }
            };

            int[] correctAnswers = { 2, 1, 3, 4 };
            int score = 0;

            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine($"Question {i + 1}: {questions[i]}");
                foreach (string option in options[i])
                    Console.WriteLine(option);

                Console.WriteLine("Your answer (enter the number): ");

                if (int.TryParse(Console.ReadLine(), out int userChoice))
                {
                    if (userChoice == correctAnswers[i])
                    {
                        Console.WriteLine("Correct!\n");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect.\n");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.\n");
                }
            }

            Console.WriteLine($"Your final score: {score} out of {questions.Length}");
            Console.ReadKey();
        }
    }
}
