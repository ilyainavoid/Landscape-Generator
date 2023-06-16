using System;
using System.Collections.Generic;
using System.Text;

namespace LandscapeLibrary
{
    class Fire : Entity
    {
        bool ageEntity = false;
        int fireCounter = 5;
        public override bool AgeEntity { get => ageEntity; set => ageEntity = value; }
        public override int CounterEntity { get => fireCounter; set => fireCounter = value; }

        public override void moveEntity(List<Cell> neighbours)
        {
            Random rnd = new Random();
            if (!AgeEntity)
            {
                AgeEntity = true;
                return;
            }
            else
            {
                for (int i = 0; i < neighbours.Count - 1; i++)
                {
                    if (neighbours[i].getEntityType() is Plant)
                    {
                        if (rnd.NextDouble() >= 0.8)
                        {
                            neighbours[i].setEntityType(FactoryEntity.getEntity(EntityType.FIRE, PlantType.ACACIA));
                        }
                    }
                }

                fireCounter--;
            }
        }
    }
}
