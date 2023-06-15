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

        }
    }
}
