using System;
using System.Collections.Generic;
using System.Text;

namespace LandscapeLibrary
{
    class Cobblestone : Entity
    {
        bool ageEntity = true;
        int cobblestoneCounter;
        public override bool AgeEntity { get => ageEntity; set => ageEntity = value; }
        public override int CounterEntity { get => cobblestoneCounter; set => cobblestoneCounter = value; }

        public override void moveEntity(List<Cell> neighbours)
        {

        }
    }
}
