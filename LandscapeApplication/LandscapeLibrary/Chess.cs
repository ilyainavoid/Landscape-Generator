using System;
using System.Collections.Generic;
using System.Text;

namespace LandscapeLibrary
{
     public class Chess : IMapCreator
    {
        private void blockFilling(int i, int j, int blockSize, Cell[,] matrixHeight, Random y)
        {
            for (int r = 0; r < blockSize; r++)
            {
                for (int c = 0; c < blockSize; c++)
                {
                    int currentRow = i * blockSize + r;
                    int currentCol = j * blockSize + c;
                    if ((i + j) % 2 == 0)
                    {
                        matrixHeight[currentRow, currentCol] = new Cell(0.2 + y.NextDouble() * 0.8);
                    }
                    else
                    {
                        matrixHeight[currentRow, currentCol] = new Cell(y.NextDouble() * 0.2);
                    }
                }
            }
        }

        public void createMapHeight(Cell[,] matrixHeight)
        {
            int blockSize = matrixHeight.GetLength(0) / 8;
            int numBlock = matrixHeight.GetLength(0) / blockSize;
            Random y = new Random();

            for (int i = 0; i < numBlock; i++)
            {
                for(int j = 0; j < numBlock; j++)
                {
                    this.blockFilling(i, j, blockSize, matrixHeight, y);
                }
            }
        }
    }
}