using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Wrappers.Interfaces
{
    public interface IConsoleWrapper
    {
        string ReadLine();
        void WriteLine(string output);
    }
}
