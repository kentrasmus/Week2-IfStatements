using System;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja käest sisestada tema lemmikvärvi;
            //kui kasutaja sisestab "punana", konsool kuvab "oled romantiline",
            //kui kasutaja sisestab "sinine", konsool kuvab "oled töökas";
            //kui kasutaja sisestab "roheline", konsool kuvab "oled looduse sõber";
            //kui kasutaja sisestab "midagi muud", konsool kuvab "oled ükssarv";

            Console.WriteLine("Mis on su lemmikvärv");
            string UserColor = Console.ReadLine().ToLower();

            if (UserColor == "punane")
            {
                Console.WriteLine("Oled romantiline");
            }
            else if (UserColor == "Sinine")
            {
                Console.WriteLine("Oled Töökas");
            }
            else if (UserColor == "Roheline")
            {
                Console.WriteLine("Oled Looduse sõber");
            }
            else 
            {
                Console.WriteLine("Taun oled");
            }
        }
    }
}
