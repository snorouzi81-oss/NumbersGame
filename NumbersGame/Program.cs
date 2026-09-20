namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");

            Random random = new Random();
            int number = random.Next(1, 20);

            int counter = 0;
            int input = 0;
            bool isCorrect;

            do
            {
                isCorrect = int.TryParse(Console.ReadLine(), out input); 

                if (isCorrect)
                {
                    if (!CheckGuess(input, number))
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }
                else {
                        Console.WriteLine("Skriv ett giltigt nummer!");
                        continue;
                }
                

                if (counter ==5)
                    Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök!");

            } while (counter < 5);

            
        }
        static bool CheckGuess(int a,int b)
        {
            if (a < b)
            {
                Console.WriteLine("Tyvärr, du gissade för lågt!");
                return false;
            }
            else if (a > b)
            {
                Console.WriteLine("Tyvärr, du gissade för högt!");
                return false;
            }
            else {
                Console.WriteLine("Wohoo! Du klarade det!");
                return true;
            }
        }
    }
}
