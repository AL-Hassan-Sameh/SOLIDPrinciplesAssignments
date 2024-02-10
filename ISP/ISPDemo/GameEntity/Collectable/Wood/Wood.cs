using System;

namespace ISPDemo.GameEntity.Collectable.Wood
{
    public class Wood : IGameEntity, ICollectable, IGrowable
    {
        public string Name => "Wood";

        public void Collect()
        {
            Console.WriteLine($"{Name} collected.");
        }

        public void Grow()
        {
            Console.WriteLine("Wood is growing");
        }
    }
}
