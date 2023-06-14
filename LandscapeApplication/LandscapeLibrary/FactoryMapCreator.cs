using System;
using System.Collections.Generic;
using System.Text;

namespace LandscapeLibrary
{
    public class FactoryMapCreator
    {
        public static IMapCreator getMapCreator(MapCreatorType type)
        {
            IMapCreator toReturn = null;
            switch (type)
            {
                case CreateMapType.DIAGONAL_CREATION:
                    toReturn = new Diagonal();
                    break;
                case MapCreatorType.HILLS_AND_HOLES:
                    toReturn = new HillsAndHoles();
                    break;
                case MapCreatorType.SMOOTHING:
                    toReturn = new Smoothing();
                    break;
                case MapCreatorType.ISLAND:
                    toReturn = new Island();
                    break;
                case MapCreatorType.CHESS_CREATION:
                    toReturn = new Chess();
                    break;
            }
            return toReturn;
        }
    }
}
