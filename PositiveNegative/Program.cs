using System;

namespace PositiveNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            //rogramm palub sisestada nubrit
            //programm kontrollib numbrit
            //kui number on positiivne, konsool kuvab "number on positiivne
            //kui number on negatiivne, konsool kuvab "number on negtiivne
            //NB!int32.Parse asemel kasutame Convert.TotInt32(Console.ReadLine());

            Console.WriteLine("Palun sisesta number");

            int number = Convert.ToInt32(Console.ReadLine());
             if (number > 0)
            {
                Console.WriteLine("Number on positiivne");
            }
             else if(number < 0)
            {
                Console.WriteLine("Number on negatiivne");
            }
             else
            {
                Console.WriteLine("null");
            }

        }
    }
}
