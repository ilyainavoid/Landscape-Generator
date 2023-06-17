using System;
using System.Collections.Generic;
using System.Text;

namespace LandscapeLibrary
{
    public interface IMapCreator
    {
        void createMapHeight(Cell[,] matrixHeight);
    }
}
