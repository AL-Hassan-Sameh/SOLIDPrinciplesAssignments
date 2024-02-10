using ISPDemo.GameEntity.Collectable.Rock;
using ISPDemo.GameEntity.Collectable.Wood;
using ISPDemo.GameEntity.Player;
using System;

namespace ISPDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create game world    
            GameWorld gameWorld = new GameWorld();

            // Test collecting wood
            Console.WriteLine("\n--- Collecting Wood ---");
            Wood wood = new Wood();
            Player player = new Player();
            player.Collect(wood);

            // Test collecting rock
            Console.WriteLine("\n--- Collecting Rock ---");
            Rock rock = new Rock();
            player.Collect(rock);

            // Test player attacking and running
            Console.WriteLine("\n--- Player Actions ---");
            player.Attack();
            player.Run();
        }
    }
}
