using System;
using System.Collections.Generic;
using ISPDemo.GameEntity;
using ISPDemo.GameEntity.Collectable.Wood;
using ISPDemo.GameEntity.Player;

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

            foreach (var entity in entities)
            {
                if (entity is IGrowable growableEntity)
                    growableEntity.Grow();
                if (entity is IRunnable runnableEntity)
                    runnableEntity.Run();
            }
        }
    }
}
