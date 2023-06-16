using System;
using System.Collections.Generic;
using System.Text;

namespace LandscapeLibrary
{
    class BlockFactoryType
    {
        public static BlockType getBlockType(BlockCreateType type)
        {
            BlockType toReturn = null;
            switch (type)
            {
                case BlockCreateType.TUNDRA:
                    toReturn = new Tundra();
                    break;
                case BlockCreateType.BEACH:
                    toReturn = new Beach();
                    break;
                case BlockCreateType.SAVANNAH:
                    toReturn = new Savannah();
                    break;
                case BlockCreateType.JUNGLE:
                    toReturn = new Jungle();
                    break;
                case BlockCreateType.FOREST:
                    toReturn = new Forest();
                    break;
                case BlockCreateType.WATER:
                    toReturn = new WaterBlock();
                    break;
            }
            return toReturn;
        }
    }
}
