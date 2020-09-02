using System;
using System.Collections.Generic;
using System.Text;

namespace Util
{
    class AskAQuestion
    {
        static public string Ask(string question)
        {
            //class function 'Ask' poses questin and returns
            //user input on next line
            //see line 28 of Program.cs
            //for refactored code that replaces Write and Read Lines
            Console.Write(question);
            return Console.ReadLine();
        }
    }
}
