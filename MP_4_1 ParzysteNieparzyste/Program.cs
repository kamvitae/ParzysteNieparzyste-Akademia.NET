using System;

namespace MP_4_1_ParzysteNieparzyste
{
    class Program
    {
        static void Main(string[] args)
        {
            string request = $"Proszę wprowadzić liczbę całkowitą w przedziale {Int32.MinValue} a {Int32.MaxValue}\n";
            Console.WriteLine(request);
            
            while (true)
            {
                var userInput = Console.ReadLine();
                bool success = int.TryParse(userInput , out int result);

                if (success)
                {
                    int number = int.Parse(userInput);
                    if (number % 2!= 0 || number == 0) 
                    Console.WriteLine("Jest to liczba nieparzysta");
                    else if(number % 2==0)
                    Console.WriteLine("Jest to liczba parzysta");
                }
                else
                {
                    Console.WriteLine(request);
                }
            } 
        }
    }
}
