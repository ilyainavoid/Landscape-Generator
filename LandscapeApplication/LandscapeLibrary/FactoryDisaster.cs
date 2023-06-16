using System;
using System.Collections.Generic;
using System.Text;

namespace LandscapeLibrary
{
    public class FactoryDisaster
    {
        public static IDisaster getDisaster(DisasterType type)
        {
            IDisaster toReturn = null;
            switch (type)
            {
                case DisasterType.CONFLAGRATION:
                    toReturn = new Conflagration();
                    break;
                case DisasterType.TORNADO:
                    toReturn = new Tornado();
                    break;
                case DisasterType.METEOR_FALLING:
                    toReturn = new MeteorFalling();
                    break;
                case DisasterType.FLOOD:
                    toReturn = new Flood();
                    break;
            }
            return toReturn;
        }
    }
}
