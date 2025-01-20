using System.ComponentModel.Design;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var favNumber = random.Next(1,11);
            int response = 0;

            while (response != favNumber)
            {
                Console.WriteLine("Give me a number between 1 and 10");
                int reponse = int.Parse(Console.ReadLine());

                if (reponse < favNumber)
                {
                    Console.WriteLine($"Too low!\nYour guess: {reponse}");
                }
                else if (reponse > favNumber)
                {
                    Console.WriteLine($"Too high!\nYour guess: {reponse}");  
                }
                else
                {
                    Console.WriteLine($"You guessed it!\nThe favorite number was {favNumber}!");
                }   
            }
            
            
        }
    }
}
