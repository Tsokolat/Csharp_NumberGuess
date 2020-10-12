using System;
using System.Collections.Generic;

namespace numberApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();

            int randomNumber = random.Next(1, 101);
            int pelaaja = 0;

            Console.WriteLine("\nArvaa luku 0 ja 100 välillä");

            List<int> arvausKerrat = new List<int>();
            
            while (pelaaja != randomNumber)
            {
                pelaaja = Convert.ToInt32(Console.ReadLine());
                arvausKerrat.Add(pelaaja);
                
                if(pelaaja < randomNumber)
                {
                        Console.WriteLine("Luku on suurempi kuin arvauksesi " + pelaaja + ". Arvaatko mikä se on?");
                }
                if(pelaaja > randomNumber)
                {
                        Console.WriteLine("Luku on pienempi kuin arvauksesi " + pelaaja + ". Arvaatko mikä se on?");
                }
                
            }


            Console.WriteLine("Onneksi olkoon! Oikea vastaus oli " + randomNumber + ".");
            Console.WriteLine(("Arvasit ") + arvausKerrat.Count + " kertaa.");
            Console.WriteLine("Arvauksesi olivat : ");
            arvausKerrat.ForEach(Console.WriteLine);

        }
        
      

    }
}
