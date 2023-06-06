using System;
using System.Collections.Generic;
using System.Text;

namespace LandscapeLibrary
{
    public class FabricaCreateMap
    {
        public CreateMap getCreateMap(CreateMapType type)
        {
            CreateMap toReturn = null;
            switch (type)
            {
                case CreateMapType.DIAGONAL_CREATION:
                    toReturn = null;
                    break;
                case CreateMapType.HILLS_AND_HOLES:
                    toReturn = null;
                    break;
                case CreateMapType.SMOOTHING:
                    toReturn = null;
                    break;
                case CreateMapType.ISLAND:
                    toReturn = new Island();
                    break;
                case CreateMapType.CHESS_CREATION:
                    toReturn = null;
                    break;
            }
            return toReturn;
        }
    }
}
