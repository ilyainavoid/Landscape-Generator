using System;
using System.Collections.Generic;
using System.Text;

namespace LandscapeLibrary
{
     public class Island : CreateMap
    {
        public void createMapHeight(Cell[,] matrixHeight, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    double distance = Math.Sqrt(Math.Pow(size / 2 - i, 2) + Math.Pow(size / 2 - j, 2));

                    matrixHeight[i, j].setHeight(1 - distance / Math.Sqrt(Math.Pow(size / 2, 2) + Math.Pow(size / 2, 2)));
                }
            }
        }
    }
}
