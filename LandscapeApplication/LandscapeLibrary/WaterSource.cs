using System;
using System.Collections.Generic;
using System.Text;

namespace LandscapeLibrary
{
    class WaterSource : Entity
    {
        bool ageEntity = false;
        int waterCounter = 9;
        public override bool AgeEntity { get => ageEntity; set => ageEntity = value; }
        public override int CounterEntity { get => waterCounter; set => waterCounter = value; }

        public override void moveEntity(List<Cell> neighbours)
        {
            if (!AgeEntity)
            {
                AgeEntity = true;
                return;
            }
            else
            {
                for (int i = 0; i < neighbours.Count - 1; i++)
                {
                    int counterWater = neighbours[neighbours.Count - 1].getEntityType().CounterEntity;
                    if (!(((neighbours[neighbours.Count - 1].getBlock() is WaterBlock) && (neighbours[i].getBlock() is WaterBlock)) ||
                        ((neighbours[neighbours.Count - 1].getBlock() is Beach) && (neighbours[i].getBlock() is Beach)) ||
                        ((neighbours[neighbours.Count - 1].getBlock() is Forest) && (neighbours[i].getBlock() is Forest)) ||
                        ((neighbours[neighbours.Count - 1].getBlock() is Jungle) && (neighbours[i].getBlock() is Jungle)) ||
                        ((neighbours[neighbours.Count - 1].getBlock() is Savannah) && (neighbours[i].getBlock() is Savannah)) ||
                        ((neighbours[neighbours.Count - 1].getBlock() is Tundra) && (neighbours[i].getBlock() is Tundra)))
                        && (neighbours[neighbours.Count - 1].getHeight() < neighbours[i].getHeight()))
                    {
                        continue;
                    }
                    else if (((neighbours[neighbours.Count - 1].getBlock() is WaterBlock) && (neighbours[i].getBlock() is WaterBlock)) ||
                        ((neighbours[neighbours.Count - 1].getBlock() is Beach) && (neighbours[i].getBlock() is Beach)) ||
                        ((neighbours[neighbours.Count - 1].getBlock() is Forest) && (neighbours[i].getBlock() is Forest)) ||
                        ((neighbours[neighbours.Count - 1].getBlock() is Jungle) && (neighbours[i].getBlock() is Jungle)) ||
                        ((neighbours[neighbours.Count - 1].getBlock() is Savannah) && (neighbours[i].getBlock() is Savannah)) ||
                        ((neighbours[neighbours.Count - 1].getBlock() is Tundra) && (neighbours[i].getBlock() is Tundra)))
                    {
                        counterWater--;
                    }

                    if (counterWater == 0)
                    {
                        continue;
                    }

                    if ((neighbours[i].getEntityType() is WaterSource) && (neighbours[i].getEntityType().CounterEntity >= counterWater))
                    {
                        continue;
                    }
                    else if (neighbours[i].getEntityType() != FactoryEntity.getEntity(EntityType.WATER_SOURCE, PlantType.CACTUS))
                    {
                        neighbours[i].setEntityType(FactoryEntity.getEntity(EntityType.WATER_SOURCE, PlantType.CACTUS));
                        neighbours[i].getEntityType().AgeEntity = false;
                    }

                    neighbours[i].getEntityType().CounterEntity = counterWater;
                }
            }
        }
    }
}
