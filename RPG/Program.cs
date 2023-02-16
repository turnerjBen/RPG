using RPG;
using RPG.Wrappers;

public class Program
{
    public static void Main(String[] args)
    {
        ConsoleWrapper console = new ConsoleWrapper();
        Game game = new Game(new Player(console),console);
        game.Launch();
    }
} 


