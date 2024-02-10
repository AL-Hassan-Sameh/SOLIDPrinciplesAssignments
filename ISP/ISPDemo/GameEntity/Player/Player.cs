using ISPDemo.GameEntity;
using ISPDemo.GameEntity.Collectable;
using System;

namespace ISPDemo.GameEntity.Player
{
    public class Player : IGameEntity, IAttackble, IRunnable
    {
        public string Name => "Normal Player";

        // Player that can attack and run


        public void Attack()
        {
            Console.WriteLine("Player is attacking");
        }

        public void Run()
        {
            Console.WriteLine("Player is running");
        }

        // Player can collect a collectable that could be collected.
        public void Collect(ICollectable collectable)
        {
            collectable.Collect();
        }
    }
}

