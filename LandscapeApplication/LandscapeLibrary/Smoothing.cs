using System;
using System.Collections.Generic;
using System.Text;

namespace LandscapeLibrary
{
    class Smoothing : CreateMap
    {
        private double[,] whiteNoise;

        public void createMapHeight(Cell[,] matrixHeight) 
        {
            this.whiteNoise = new double[matrixHeight.GetLength(0), matrixHeight.GetLength(0)];
            Random rnd = new Random();

            for (int i = 0; i < matrixHeight.GetLength(0); i++)
            {
                for (int j = 0; j < matrixHeight.GetLength(0); j++)
                {
                    this.whiteNoise[i, j] = rnd.NextDouble();
                }
            }

            for (int i = 0; i < matrixHeight.GetLength(0); i++)
            {
                for (int j = 0; j < matrixHeight.GetLength(0); j++)
                {
                    double sumDouble = 0;
                    int sumInt = 0;

                    for (int k = i - 1; k < i + 1; k++)
                    {
                        for (int u = j - 1; u < j + 1; u++)
                        {
                            if ((k >= 0) && (k < matrixHeight.GetLength(0)) && (u >= 0) && (u < matrixHeight.GetLength(0)))
                            {
                                sumDouble += this.whiteNoise[k, u];
                                sumInt++;
                            }
                        }
                    }

                    matrixHeight[i, j].setHeight(sumDouble / sumInt);
                }
            }
        }
    }
}
