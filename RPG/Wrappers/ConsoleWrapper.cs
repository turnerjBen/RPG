using RPG.Wrappers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Wrappers
{
    public class ConsoleWrapper : IConsoleWrapper
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public void WriteLine(string output)
        {
            Console.WriteLine(output);
        }
    }
}
