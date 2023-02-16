using RPG.Interfaces;
using RPG.Wrappers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class Game : IGame
    {

        private IPlayer _player;
        private IConsoleWrapper _console;

        public Game(IPlayer player, IConsoleWrapper console)
        {
            _player = player;
            _console = console;
        }
        public void Launch()
        {
            _console.WriteLine("Hello Stranger, what's your name?");

            var name = _console.ReadLine();

            _player.SetName(name);
           _console.WriteLine(String.Format("Nice to meet you, {0}. I look forward to traveling with you.", name));
        }
    }
}
