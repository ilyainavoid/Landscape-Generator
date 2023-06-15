using System;
using System.Collections.Generic;
using System.Text;

namespace LandscapeLibrary
{
    public abstract class Entity
    {
        public abstract int CounterEntity { get; set; }
        public abstract bool AgeEntity { get; set; }
        public abstract void moveEntity(List<Cell> neighbours);
    }
}
