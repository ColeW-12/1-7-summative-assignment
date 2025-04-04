using System.ComponentModel.Design;
using System.Web;

namespace _1_7_summative_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Console.Title = "Cole's Casino";
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Black;
            //    Console.WriteLine("Welcome to my casino! We play rock, paper, scissors here! if you don't already know the rules, the winner is determined by who can crush, cut or cover the other person. You, the player, will pick your play and the winner will be determined by the computer! Good Luck!");
            //    Console.WriteLine("Do you understand? Press enter.");
            //    Console.ReadLine();

            bool done = false;
            Random generator = new Random();
            double bank = 100.00, bet;
            int rps, rock = 1, paper = 2, scissors = 3;
            string answer, choice;

            while (!done) 
            {
                Console.WriteLine("Bank amount: " + bank);
                Console.WriteLine("Please place your bet:");
                

                while (!double.TryParse(Console.ReadLine(), out bet) || bet <= 0 || bet > bank)
                {    
                    Console.WriteLine("Bet invalid, try again.");
                }

                Console.WriteLine("Choose rock paper or scissors");
                Console.WriteLine("Make your choice: ");
                choice = Console.ReadLine();

                rps = generator.Next(1, 4);

                if (rps == rock && choice.ToLower() == "paper")
                {
                    Console.WriteLine("You win! You now earn what you bet");
                    bank = bank + bet;
                    Console.WriteLine("Bank: " + bank.ToString("c"));
                }
                else if (rps == paper && choice.ToLower() == "scissors")
                {
                    Console.WriteLine("You win! now you earn what you bet");
                    bank = bank + bet;
                    Console.WriteLine("Bank: " + bank.ToString("c"));
                }
                else if (rps == scissors && choice.ToLower() == "rock")
                {
                    Console.WriteLine("You win! now you earn what you bet");
                    bank = bank + bet;
                    Console.WriteLine("Bank: " + bank.ToString("c"));
                }
                else if (rps == paper && choice.ToLower() == "rock")
                {
                    Console.WriteLine("You lose. What you bet is lost");
                    bank = bank - bet;
                    Console.WriteLine("Bank: " + bank.ToString("c"));
                }
                else if (rps == scissors && choice.ToLower() == "paper")
                {
                    Console.WriteLine("You lose. What you bet is lost");
                    bank = bank - bet;
                    Console.WriteLine("Bank: " + bank.ToString("c"));
                }
                else if (rps == rock && choice.ToLower() == "scissors")
                {
                    Console.WriteLine("You lose. What you bet is lost");
                    bank = bank - bet;
                    Console.WriteLine("Bank: " + bank.ToString("c"));
                }
                else if (rps == rock && choice.ToLower() == "rock")
                    Console.WriteLine("Tie. Try again");

                else if (rps == paper && choice.ToLower() == "paper")
                    Console.WriteLine("Tie. Try again");

                else if (rps == scissors && choice.ToLower() == "scissors")
                    Console.WriteLine("Tie. Try again");

                else
                    Console.WriteLine("Answer is invalid");

                if (bank == 0)
                {
                    Console.WriteLine("You ran out of money. Thank you for playing");
                    done = true;
                }
                Console.WriteLine("Would you like to quit?");
                answer = Console.ReadLine();
                if (answer == "yes")
                {
                    Console.WriteLine("Thank you for playing!");
                    done = true;
                }
                
               
                
            }
        }
    }
}
