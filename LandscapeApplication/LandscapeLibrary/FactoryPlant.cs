using System;
using System.Collections.Generic;
using System.Text;

namespace LandscapeLibrary
{
    class FactoryPlant
    {
        public static Plant getPlant(PlantType type)
        {
            Plant toReturn = null;
            switch (type)
            {
                case PlantType.ACACIA:
                    toReturn = new Acacia();
                    break;
                case PlantType.CACTUS:
                    toReturn = new Cactus();
                    break;
                case PlantType.JUNGLE_TREE:
                    toReturn = new JungleTree();
                    break;
                case PlantType.OAK:
                    toReturn = new Oak();
                    break;
                case PlantType.SPRUCE:
                    toReturn = new Spruce();
                    break;
            }
            return toReturn;
        }
    }
}
