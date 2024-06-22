using Game;

namespace Core
{
    internal class Core
    {
        static void Main(string[] args)
        {
            // Create some characters
            Character c1 = new Warrior("Arthur", 100, 20, 10);
            Character c2 = new Mage("Merlin", 80, 15, 5);
            Character c3 = new Dragon("Smaug", 200, 30, 20);

            // Create a new game and simulate some battles
            Game.Game game = new Game.Game();
            game.Battle(c1, c2);
            game.Battle(c3, c1);
            game.Battle(c2, c3);
        }
    }
}