using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
   
    class Program
    {
        static void Main(string[] args)
        {
            new RoshamboApp().BeginRoshambo();


        }
            public static string GetUserInput(string message)
            {
            Console.WriteLine(message);
            string userInput = Console.ReadLine();
            return userInput;
            }
    }
}
