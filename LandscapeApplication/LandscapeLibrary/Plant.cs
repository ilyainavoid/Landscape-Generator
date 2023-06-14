using System;
using System.Collections.Generic;
using System.Text;

namespace LandscapeLibrary
{
    abstract class Plant : Entity
    {
        public int counterWater = 10;
        public override void moveEntity(List<Cell> neighbours)
        {

        }
    }
}
