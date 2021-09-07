using System;

namespace PermanentDivingLisence
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat
            //programm kontrollib kasutaja vanust
            //programm teatab kasutajat, kas ta on piisavalt vana
            //et juhiluba saada



            Console.WriteLine("Mis on sinu sünniaasta");

            int YearOfBirth = Int32.Parse(Console.ReadLine());
            int age = 2021 - YearOfBirth;
            
            if(age > 18)
            {
                Console.WriteLine("Oled piisavalt vana, et juhiluba saada.");

            }
            else if(age < 18)
            {
                Console.WriteLine("Oled liiga noor, et juhiluba saada");
            }
            else
            {
                Console.WriteLine("Oled 18, nüüd saad juhiluba saada.");
            }
        }
    }
}
