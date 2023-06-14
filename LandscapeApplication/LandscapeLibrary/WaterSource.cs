using System;
using System.Collections.Generic;
using System.Text;

namespace LandscapeLibrary
{
    class WaterSource : Entity
    {
        public override void moveEntity(List<Cell> neighbours)
        {
            for(int i = 0; i < 4; i++)
            {
                int counterWater = neighbours[4].getCounterEntity();
                if ((neighbours[4].getBlock() != neighbours[i].getBlock()) && (neighbours[4].getHeight() > neighbours[i].getHeight()))
                {
                    continue;
                }
                else if (neighbours[4].getBlock() == neighbours[i].getBlock())
                {
                    counterWater--;
                }

                if ((neighbours[i].getEntityType() == FactoryEntity.getEntity(EntityType.WATER_SOURCE, PlantType.CACTUS)) && (neighbours[i].getCounterEntity() >= counterWater))
                {
                    continue;
                }
                else if(neighbours[i].getEntityType() != FactoryEntity.getEntity(EntityType.WATER_SOURCE, PlantType.CACTUS))
                {
                    neighbours[i].setEntityType(FactoryEntity.getEntity(EntityType.WATER_SOURCE, PlantType.CACTUS));
                }

                neighbours[i].setCounterEntity(counterWater);
            }
        }
    }
}
