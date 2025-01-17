class RiddleGame
{
    static void Riddles()
    {
        //Defining different riddles
        string[] riddle = {
            "I speak without a mouth and hear without ears. I have no body, but I come alive with wind. What am I?",
            "The more of this you take, the more you leave behind. What is it?",
            "I am not alive, but I can grow; I don’t have lungs, but I need air; I don’t have a mouth, but water kills me. What am I?" };
        //Defining the answers to the riddles
        string[] answers = { "echo", "footsteps", "fire" };

        //loop through the riddles
        for (int i = 0; i < riddle.Length;i++)
        {
            Console.WriteLine($"Riddle {i + 1} : {riddle[i]}");
            int attempts = 3;

            while (attempts > 0)
            {
                Console.WriteLine("Enter your answer to the riddle : ");
                string userAnswer = Console.ReadLine().ToLower();

                //check if the user is correct
                if (userAnswer == answers[i])
                {
                    Console.WriteLine("Congratulation you're correct.Well done!!");
                    break;
                }
                else 
                {
                    attempts--;

                    if (attempts > 0)
                    {
                        Console.WriteLine($"Wrong!!! You have {attempts} attempts left,If you fail to provide us with the right answer you die.");

                    }
                    else 
                    {
                        Console.WriteLine($"Out of attempts! The correct answer was: {answers[i]}");
                    }
                }
            }
            
        }

        Console.WriteLine("Thanks for participating in the Riddle Game");

    }


    static void Main(string[] args)
    {
        // Display a welcome message to the user
        Console.WriteLine("Welcome to the Three Difficult Riddles Game!");
        Console.WriteLine("You will have 3 attempts to solve each riddle.");
        Console.WriteLine("Good luck!\n");

        // Call the PlayRiddleGame function to start the game
        Riddles();
    }

}