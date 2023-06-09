using System;
using System.Collections.Generic;
using System.Text;

namespace LandscapeLibrary
{
     public class Diagonal : CreateMap
    {
        public void createMapHeight(Cell[,] matrixHeight)
        {
            int size = matrixHeight.GetLength(0);
            int maxDistance = size - 1;
            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    int distanceToCenter = Math.Abs(i - size / 2) + Math.Abs(j - size / 2);
                    matrixHeight[i,j].setHeight(1 - (double)distanceToCenter / maxDistance);
                }
            }
        }
    }
}
