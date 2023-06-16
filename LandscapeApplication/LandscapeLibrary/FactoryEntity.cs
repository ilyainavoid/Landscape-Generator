using System;
using System.Collections.Generic;
using System.Text;

namespace LandscapeLibrary
{
    class FactoryEntity
    {
        public static Entity getEntity(EntityType type, PlantType plantType)
        {
            Entity toReturn = null;
            switch (type)
            {
                case EntityType.COBBLESTONE:
                    toReturn = new Cobblestone();
                    break;
                case EntityType.FIRE:
                    toReturn = new Fire();
                    break;
                case EntityType.WATER_SOURCE:
                    toReturn = new WaterSource();
                    break;
                case EntityType.PLANT:
                    toReturn = FactoryPlant.getPlant(plantType);
                    break;
            }
            return toReturn;
        }
    }
}
