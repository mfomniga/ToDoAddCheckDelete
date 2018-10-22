using System;
using System.Collections.Generic;


namespace ToDoAddCheckDelete
{
    class Program
    {
        private static List<string> namen = new List<string>();

        static void Main(string[] args)
        {
            

            Console.WriteLine("Benutze die Befehle Add, Check und Delete!");
            
            // add mathias
            string userInput = Console.ReadLine();

            if(userInput.StartsWith("add "))
            {
                Console.WriteLine("Gib den Namen der Person ein die zu hinzufügen willst:");
                //string userInputName = Console.ReadLine();
                namen.Add(Console.ReadLine());
            }
            else if(userInput.StartsWith("delete "))
            {

            }






            Console.ReadKey();
        }
    }
}
