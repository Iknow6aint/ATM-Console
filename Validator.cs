using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

public static class Validator
{
    public static T Convert<T>(string prompt)
    {
        bool valid = false;
        string userInput;

        while (!valid)
        {
            userInput = Utility.GetUserInput(prompt);

            try
            {
                var converter = TypeDescriptor.GetConverter(typeof(T));
                if (converter != null)
                {
                    return (T)converter.ConvertFromString(userInput);
                }
                else
                {
                    return default;
                }
            }
            catch
            {
                Utility.PrintError("invalid input .try again", false);
            }
        }
        return default;
    }
}