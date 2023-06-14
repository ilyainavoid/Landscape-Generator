using System;
using System.Collections.Generic;
using System.Text;

namespace LandscapeLibrary
{
    public abstract class Entity
    {
        public abstract void moveEntity(List<Cell> neighbours);
    }
}
