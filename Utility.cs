using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Utility
{
    public static string GetSecretInput(string prompt)
    {
        bool isPrompt = true;
        string asterics = "";

        StringBuilder input = new StringBuilder();

        while (true)
        {
            if (isPrompt)
            {
                Console.WriteLine(prompt);
            }
            ConsoleKeyInfo inputkey = Console.ReadKey(true);

            if (inputkey.Key == ConsoleKey.Enter)
            {
                if (input.Length == 6)
                {
                    break;
                }
                else
                {
                    PrintError("\nplease enter 6 digits.", false);
                    isPrompt = true;
                    input.Clear();
                }
            }
            if (inputkey.Key == ConsoleKey.Backspace && input.Length > 0)
            {
                input.Remove(input.Length - 1, 1);
            }
            else if (inputkey.Key != ConsoleKey.Backspace)
            {
                input.Append(inputkey.KeyChar);
                Console.Write(asterics + "*");
            }
        }
        return input.ToString();
    }
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