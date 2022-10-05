using System;
namespace Uppgift_3._16
{
    class program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Hur många minuter är låten");
            int minuter  = int.Parse(Console.ReadLine());
            Console.WriteLine("hur många sekunder är låten?");
            int sekunder = int.Parse(Console.ReadLine());
            int totalasekunder =minuter * 60 + sekunder;
            int mingräns = 2 * 60 + 45;
            int maxgräns = 4 * 60 + 20;

            if ( totalasekunder >= mingräns && totalasekunder <= maxgräns)
            {
                Console.WriteLine("det ska spelas låten");    
            }
            else
            {
                Console.WriteLine("låten får inte spelas");
            }
    }
}