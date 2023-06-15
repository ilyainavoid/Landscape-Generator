using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace LandscapeLibrary
{
    public class Diagonal : CreateMap
    {
        public void createMapHeight(Cell[,] matrixHeight)
        {
            int size = matrixHeight.GetLength(0);
            int maxDistance = size - 1;
            bool[,] usageLabel = new bool[size,size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    int distanceToCenter = Math.Abs(j - i);
                    matrixHeight[i, j].setHeight(1 - (double)Math.Pow(distanceToCenter, 1.5) / maxDistance);

                    int sideY = size - i - 1;
                    distanceToCenter = Math.Abs(j - sideY);
                    double height = 1 - (double)Math.Pow(distanceToCenter, 1.5) / maxDistance;
                    if (matrixHeight[i,j].getHeight() < height)
                        matrixHeight[i, j].setHeight(1 - (double)Math.Pow(distanceToCenter, 1.5) / maxDistance);
                }
            }
        }
    }
}
