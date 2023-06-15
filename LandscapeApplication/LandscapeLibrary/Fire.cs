using System;
using System.Collections.Generic;
using System.Text;

namespace LandscapeLibrary
{
    class Fire : Entity
    {
        bool ageEntity = true;
        int fireCounter;
        public override bool AgeEntity { get => ageEntity; set => ageEntity = value; }
        public override int CounterEntity { get => fireCounter; set => fireCounter = value; }

        public override void moveEntity(List<Cell> neighbours)
        {

        }
    }
}
