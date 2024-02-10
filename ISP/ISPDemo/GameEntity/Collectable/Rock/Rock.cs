using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPDemo.GameEntity.Collectable.Rock
{
    public class Rock : IGameEntity, ICollectable
    {
        public string Name => "Rock";

        public void Collect()
        {
            Console.WriteLine($"{Name} collected.");
        }
    }
}
