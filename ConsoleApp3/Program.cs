using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\t $$$   My Exchange   $$$");
            Console.WriteLine("\t *********************** \n ");

            Console.WriteLine("*Useful* Dear user, please enter the exchange rate separated by commas: 0,00 ; 1,1111");
            //Console.WriteLine("");

            Console.WriteLine("\n 1.Settig up official rates \n ");

            Console.WriteLine("Please enter the current exchange rate of 1 USD to KGS :");
            Console.Write("> ");
            decimal usdRate = Convert.ToDecimal(Console.ReadLine());


            Console.WriteLine("\n Please enter the current exchange rate of 1 EUR to KGS :");
            Console.Write("> ");
            decimal eurRate = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("\n\t Oficial rates:");
            Console.WriteLine($"\t 1 USD = {usdRate} KGS");
            Console.WriteLine($"\t 1 EUR = {eurRate} KGS \n");

            Console.WriteLine("2.Settig up our exchange rate margin");

            Console.WriteLine("\n Please enter margin on USD operations: ");
            Console.Write("> ");
            decimal usdMargin = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("\n Please enter margin on EUR operations: ");
            Console.Write("> ");
            decimal eurMargin = Convert.ToDecimal(Console.ReadLine());

            decimal usdBuy = usdRate - (usdRate * usdMargin);
            decimal usdSell = usdRate + (usdRate*usdMargin);
            decimal eurBuy = eurRate - (eurRate*eurMargin);
            decimal eurSell = eurRate + (eurRate*eurMargin);
            
            Console.WriteLine("\n\t Our exchange rates:");
            Console.WriteLine("\t\tBuy\tSell  ");
            Console.WriteLine($"\tUSD\t{usdBuy}\t{usdSell} ");
            Console.WriteLine($"\tEUR\t{eurBuy}\t{eurSell} ");









        }
    }
}
