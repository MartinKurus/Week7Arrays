using System;

namespace Week7Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kkuvab kasutajale hommikusöögi menüüd
            //programm palub kasutajal teha valikut
            //programm juvab kasutaja valikut konsoolis

            string[] menu = { "omlett", "pannkoogid", "keedumuna", "neljaviljapuder", "singivõileib" };
            Console.WriteLine($"Meie menüüs on {menu.Length} valikut.");
            menu[3] = "kaerapuder";
            menu[4] = "juustuvõileib";

            Console.WriteLine("Tänases menüüs:");

            for(int i = 0; i < menu.Length; i++)
            {
                if(menu[i] == "neljaviljapuder")
                {
                    menu[i] = "kaerapuder";
                }
                else if (menu[i] == "singivõileib")
                {
                    menu[i] = "juustuvõileib";
                }
                
                Console.WriteLine(menu[i]);
            }
            Console.WriteLine("Tee oma valikut (sisesta numbrit 1 -5 ):");
            int userChoice = Convert.ToInt32(Console.ReadLine())-1;

            Console.WriteLine($"Olete valinud: {menu[userChoice]}");

           /* foreach(string menuElement in menu)
            {
                if(menuElement == "neljaviljapuder")
                {
                   
                }
                Console.WriteLine(menuElement);
            }*/


        }
    }
}
