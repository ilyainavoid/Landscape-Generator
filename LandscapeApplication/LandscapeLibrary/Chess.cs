using System;
using System.Collections.Generic;
using System.Text;

namespace LandscapeLibrary
{
     public class Chess : CreateMap
    {
        public void createMapHeight(Cell[,] matrixHeight)
        {
            int blockSize = matrixHeight.GetLength(0) / 8;
            int numBlock = matrixHeight.GetLength(0) / blockSize;

            for(int i = 0; i < numBlock; i++)
            {
                for(int j = 0; j < numBlock; j++)
                {
                    for(int r = 0; r < blockSize; r++)
                    {
                        for(int c = 0; c < blockSize; c++)
                        {
                            int currentRow = i * blockSize + r;
                            int currentCol = j * blockSize + c;
                            Random y = new Random();
                            if ((i + j) % 2 == 0)
                            {
                                matrixHeight[currentRow, currentCol].setHeight(0.2 + y.NextDouble() * 0.8);
                            }
                            else
                            {
                                matrixHeight[currentRow, currentCol].setHeight(y.NextDouble() * 0.2);
                            }
                        }
                    }
                }
            }
        }
    }
}