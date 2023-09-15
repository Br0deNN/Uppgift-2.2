using System;
namespace Uppgift_2._2
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur långt mätt i meter hoppade du Elin?");
            string Elinshopp = Console.ReadLine();   
            double längdtext1 = double.Parse(Elinshopp);
            Console.WriteLine("Hur långt mätt i meter hoppade du Alva?");
            string Alvashopp = Console.ReadLine();
            double längtext2 = double.Parse(Alvashopp); 
            double Skillnad = längdtext1 - längtext2;
            Console.WriteLine("Elin hoppade " +  Skillnad + " meter längre än Alva"); 
            

        }
    }
}