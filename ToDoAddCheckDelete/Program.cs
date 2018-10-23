using System;
using System.Collections.Generic;


namespace ToDoAddCheckDelete
{
    class Program
    {
        private static List<ToDo> meineMitglieder = new List<ToDo>();

        static void Main(string[] args)
        {
            string test;
            string test2;
            string test3;

            

            Console.WriteLine("Benutze die Befehle add, check und delete!");
            
            // add Michael Lohr
            string userInput = Console.ReadLine();

            if (userInput.StartsWith("add"))
            {
                
                string[] alleParts = userInput.Split(" ");
                string[] relevanteParts = new string[] { };
                alleParts.CopyTo(relevanteParts, 1);

                
                string name = string.Join(" ", relevanteParts);



                ToDo add = new ToDo(name, false);
                Console.WriteLine("{0} wurde der Liste hinzugefügt", name);



                // alle parts nach 0 aneinanderreihen
                //parts[1] = "Michael"
                //parts[2] = "Lohr"

                //test = userInput.Substring(4);
                // meineMitglieder.Add(userInput.Substring(4));

            }
            else if(userInput.StartsWith("delete"))
            {
                //test2 = userInput.Substring(7);
                
                
            }
            else if (userInput.StartsWith("check"))
            {
                test3 = userInput.Substring(6);
                
            }


       

            






            Console.ReadKey();
        }
    }
}
