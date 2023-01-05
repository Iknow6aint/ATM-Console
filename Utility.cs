using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Utility
{
    public static void PrintError(string message, bool sucess = true)
    {
        if (sucess)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        Console.WriteLine(message);
        Console.ResetColor();
        PressEnterToContinue();
    }
    public static string GetUserInput(string Prompt)
    {
        Console.WriteLine($"Enter {Prompt}");
        return Console.ReadLine();
    }
    public static void PressEnterToContinue()
    {
        Console.WriteLine("\n\n Press Enter TO continue");
        Console.ReadLine();
    }
}