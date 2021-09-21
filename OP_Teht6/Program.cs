using System;

namespace OP_Teht6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Summataan kaksi numeroa:
            int luku1, luku2;
            Console.Write("Anna ensimmäinen luku (int): ");
            string vastaanOtettu = Console.ReadLine();
            while(!Int32.TryParse(vastaanOtettu, out luku1))
            {
                Console.Write("Väärän tyyppinen tieto, yritä vielä: ");
                vastaanOtettu = Console.ReadLine();
            }
            Console.Write("Anna ensimmäinen luku (int): ");
            vastaanOtettu = Console.ReadLine();
            while (!Int32.TryParse(vastaanOtettu, out luku2))
            {
                Console.Write("Väärän tyyppinen tieto, yritä vielä: ");
                vastaanOtettu = Console.ReadLine();
            }
            int summa = luku1 + luku2;
            Console.WriteLine("Summaksi tuli {0}. ", summa);
            Console.WriteLine("Summaksi tuli {0}. ", luku1 + luku2);
        }
}
