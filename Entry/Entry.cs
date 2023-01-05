using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Entry
{
    static void Main(string[] arrgs)
    {
        AppScreen.Welcome();
        ATMAPP atmApp = new ATMAPP();

        atmApp.CheckUserCardNumberAndPassword();

        Utility.PressEnterToContinue();
    }
}