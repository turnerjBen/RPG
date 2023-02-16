using RPG.Interfaces;
using RPG.Wrappers.Interfaces;

namespace RPG
{
    public class Player : IPlayer
    {
        public String Name { get; private set; }
        private IConsoleWrapper _console;

        public Player(IConsoleWrapper console) => _console = console;

        public void SetName(String name)
        {
            if (name.Length > 20)
            {
                _console.WriteLine("Name exceeds 20 characters. Please enter a name that is 20 characters or less.");
            }
            this.Name = name;
        }

    }
}
