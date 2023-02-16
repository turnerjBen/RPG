using NSubstitute;
using NSubstitute.Core;
using RPG;
using RPG.Interfaces;
using RPG.Wrappers.Interfaces;

namespace RPGTests
{
    public class Tests
    {
        private Game _game;
        private IPlayer _player;
        private IConsoleWrapper _console;

        [SetUp]
        public void Setup()
        {
            _player = Substitute.For<IPlayer>();
            _console = Substitute.For<IConsoleWrapper>();
            _game = new Game(_player, _console);
        }

        [Test]
        public void Launch_Prompts_And_Corresponds_With_User()
        {
            // Arrange
            _console.ReadLine().Returns("Benjamin");

            // Act
            _game.Launch();

            // Assert
            _console.Received().WriteLine("Hello Stranger, what's your name?");
            _player.Received().SetName("Benjamin");
            _console.Received().WriteLine("Nice to meet you, Benjamin. I look forward to traveling with you.");
        }
    }
}