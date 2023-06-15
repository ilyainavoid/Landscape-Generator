using System;
using System.Collections.Generic;
using System.Text;

namespace LandscapeLibrary
{
     public class Island : CreateMap
    {
        public void createMapHeight(Cell[,] matrixHeight)
        {
            for (int i = 0; i < matrixHeight.GetLength(0); i++)
            {
                for (int j = 0; j < matrixHeight.GetLength(0); j++)
                {
                    double distance = Math.Sqrt(Math.Pow(matrixHeight.GetLength(0) / 2 - i, 2) + Math.Pow(matrixHeight.GetLength(0) / 2 - j, 2));

                    matrixHeight[i, j].setHeight(1 - distance / Math.Sqrt(Math.Pow(matrixHeight.GetLength(0) / 2, 2) + Math.Pow(matrixHeight.GetLength(0) / 2, 2)));
                }
            }
        }
    }
}
