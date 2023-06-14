using System;
using System.Collections.Generic;
using System.Text;

namespace LandscapeLibrary
{
    class HillsAndHoles : IMapCreator
    {
        private double[,] plain;

        private void makeHillOrHole(int x, int y, double heightH, int radius)
        {
            for (int i = 0; i < this.plain.GetLength(0); i++)
            {
                for (int j = 0; j < this.plain.GetLength(0); j++)
                {
                    double dist = 1 - Math.Sqrt(Math.Pow(x - j, 2) + Math.Pow(y - i, 2)) / radius;

                    if (dist >= 0)
                    {
                        this.plain[i, j] += dist * heightH;
                    }
                }
            }
        }

        public void createMapHeight(Cell[,] matrixHeight)
        {
            this.plain = new double[matrixHeight.GetLength(0), matrixHeight.GetLength(0)];
            Random rnd = new Random();

            for (int i = 0; i < matrixHeight.GetLength(0); i++)
            {
                for (int j = 0; j < matrixHeight.GetLength(0); j++)
                {
                    this.plain[i, j] = 0.4 + rnd.NextDouble() * 0.1;
                }
            }

            for (int i = 0; i < rnd.Next(matrixHeight.GetLength(0)); i++)
            {
                this.makeHillOrHole(rnd.Next(matrixHeight.GetLength(0)), rnd.Next(matrixHeight.GetLength(0)), rnd.NextDouble() * 0.5, rnd.Next(14, 28));
            }
            for (int i = 0; i < rnd.Next(matrixHeight.GetLength(0)); i++)
            {
                this.makeHillOrHole(rnd.Next(matrixHeight.GetLength(0)), rnd.Next(matrixHeight.GetLength(0)), rnd.NextDouble() * -0.5, rnd.Next(7, 11));
            }

            for (int i = 0; i < matrixHeight.GetLength(0); i++)
            {
                for (int j = 0; j < matrixHeight.GetLength(0); j++)
                {
                    matrixHeight[i, j] = new Cell(this.plain[i, j]);
                }
            }
        }
    }
}
