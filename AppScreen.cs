using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class AppScreen
{
    internal static void Welcome()
    {
        // clear terminal
        Console.Clear();
        Console.Title = "MY ATM App";
        // set Terminal Color
        Console.ForegroundColor = ConsoleColor.White;

        //set welcome message 
        Console.WriteLine("\n\n.......... Welcome To My ATM ........\n\n");
        // Prompt
        Console.WriteLine("Please insert your Atm Card");
        Console.WriteLine("Note: Actual Machine will validate a Physical ATM card");
        Utility.PressEnterToContinue();
    }

}
