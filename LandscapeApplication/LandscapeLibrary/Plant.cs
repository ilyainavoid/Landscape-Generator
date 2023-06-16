using System;
using System.Collections.Generic;
using System.Text;

namespace LandscapeLibrary
{
    abstract class Plant : Entity
    {
        bool ageEntity = true;
        int plantCounter;
        public override bool AgeEntity { get => ageEntity; set => ageEntity = value; }
        public override int CounterEntity { get => plantCounter; set => plantCounter = value; }

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
                    if (!((neighbours[i].getEntityType() is Plant) || (neighbours[i].getEntityType() is Fire) 
                        || (neighbours[i].getEntityType() is WaterSource) || (neighbours[i].getEntityType() is Cobblestone)))
                    {
                        if (rnd.NextDouble() >= 0.99)
                        {
                            neighbours[i].setEntityType(FactoryEntity.getEntity(EntityType.PLANT, PlantType.ACACIA));
                        }
                    }
                }
            }
        }
    }
}
