using ISPDemo.GameEntity.Collectable.Rock;
using ISPDemo.GameEntity.Collectable.Wood;
using ISPDemo.GameEntity.Collectable;
using ISPDemo.GameEntity.Player;
using ISPDemo.GameEntity;
using System;
using System.Collections.Generic;

namespace ISPDemo
{
    public class GameWorld
    {
        private List<IGameEntity> entities = new List<IGameEntity>();

        public GameWorld()
        {
            entities.Add(new Player());
            entities.Add(new Wood());
            entities.Add(new Wood());
            entities.Add(new Rock());
        }

        public void Run()
        {
            foreach (var entity in entities)
            {
                if (entity is IGrowable growableEntity)
                    growableEntity.Grow();
                if (entity is IRunnable runnableEntity)
                    runnableEntity.Run();
                if (entity is ICollectable collectableEntity)
                    collectableEntity.Collect();
                if (entity is IAttackable attackableEntity)
                    attackableEntity.Attack();
            }
        }
    }
}