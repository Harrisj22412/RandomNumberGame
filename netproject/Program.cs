using System;

//Namespace
namespace netproject
{
    //Main Class
    class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo();

            GreetUser();

            while(true){

            //Set correct number

            //Create a random object
            Random random = new Random();

            
            int correctNumber = random.Next(1, 10);

            // Init guess var

            int guess = 0;

            // Ask user for number
            Console.WriteLine("Guess a number between 1 and 10");

            //While guess is not correct
            while(guess != correctNumber){

                //Get users input
                string input = Console.ReadLine();

                //Make sure it's a number
                if(!int.TryParse(input, out guess)){

                    //Output success message
                    Console.ForegroundColor =
                    ConsoleColor.Red;
                    
                    //Write out success message 
                    Console.WriteLine("Please enter an actually number.");
                    
                    //Reset Color
                    Console.ResetColor();

                    continue;
                    
                }

                //Cast to int and put in guess
                guess = Int32.Parse(input);

                //Match guess to correct number

                if(guess != correctNumber){

                    //Change text color
                    Console.ForegroundColor = ConsoleColor.Red;

                    //Tell user it's the wrong number
                    Console.WriteLine("Wrong number please try again.");

                    //Reset Color
                    Console.ResetColor(); 
                }
            }

            //Output success message
            Console.ForegroundColor = ConsoleColor.Yellow;

            //Write out success message 
            Console.WriteLine("You are CORRECT!!!");

            //Reset Color
            Console.ResetColor();

            //Ask to play again

            Console.WriteLine("Play Again? [Y or N]");

            //Get answer
            string answer = Console.ReadLine().ToUpper();

            if(answer == "Y"){
                continue;
            }
            else if (answer == "N"){
                return;
            }
            }
        }

        static void GetAppInfo(){
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Jalen Harris";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset Color
            Console.ResetColor();
        }
        static void GreetUser(){
             //Ask users name
             Console.WriteLine("What is your name?");
             //Get user input
             string inputName = Console.ReadLine();
             Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }
    }
}
