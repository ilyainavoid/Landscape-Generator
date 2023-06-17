using System;
using System.Collections.Generic;
using System.Text;

namespace LandscapeLibrary
{
    public interface IDisaster
    {
        void startDisaster(int x, int y, Cell[,] matrixHeight, int radius);
    }
}
