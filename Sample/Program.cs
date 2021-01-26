
using System;
using System.Linq;
using System.Diagnostics;

namespace Sample
{

    

    class Program
    {   
        static int CountWords(string sentence)
        {
            int wordCount = sentence.Split(' ').Length;
            return wordCount;
        }

        static void Main(string[] args)

        {
            Console.WriteLine("Escribe una oración");
            string n1;
            n1 = Console.ReadLine();
            int result = CountWords(n1);
            Console.WriteLine("tu oracion tiene "+ result +" palabrass");

        }
    }
}
