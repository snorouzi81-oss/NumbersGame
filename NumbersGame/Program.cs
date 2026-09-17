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

            do
            {
                input = int.Parse(Console.ReadLine());
                if (input < number)
                {
                    Console.WriteLine("Tyvärr, du gissade för lågt!");
                    counter++;
                }  
                else if (input > number)
                {
                    Console.WriteLine("Tyvärr, du gissade för högt!");
                    counter++;
                } 
                else
                {
                    Console.WriteLine("Wohoo! Du klarade det!");
                    break;
                }
                if (counter ==5)
                    Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök!");

            } while (counter < 5);

            
        }
    }
}
