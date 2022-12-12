using System;

namespace lab3ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex 3
            //Scrieti o functie care va determina daca un numar este sau nu patrat perfect. Apelati - o si afisati-i rezultatu

            bool testPatratPerfect = PatratPerfect(81);
            Console.WriteLine(testPatratPerfect);

            static bool PatratPerfect(int number)
            {
                return (Math.Sqrt(number) % 1 == 0);
            }
        }
    }
}
