using System;
using System.Collections.Generic;
using System.Text;

namespace Util
{
    class AskAQuestion
    {
        static public string Ask(string question)
        {
        
            Console.Write(question);
            return Console.ReadLine();
        }
    }
}
