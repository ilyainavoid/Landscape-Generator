using System;
using System.Collections.Generic;
using System.Text;

namespace LandscapeLibrary
{
     public class Chess : CreateMap
    {
        public void createMapHeight(Cell[,] matrixHeight, int size)
        {
            int blockSize = size/8;
            int numBlock = size/blockSize;

            for(int i = 0; i < numBlock; i++)
            {
                for(int j = 0; j < numBlock; j++)
                {
                    for(int r = 0; r < blockSize; r++)
                    {
                        for(int c = 0; c < blockSize; c++)
                        {
                            if((i + j) % 2 == 0)
                            {
                                Random x = new Random();
                                matrixHeight[i, j].setHeight(Convert.ToDouble(x.Next(0.2,1)));
                            }
                            else
                            {
                                Random y = new Random();
                                matrixHeight[i, j].setHeight(Convert.ToDouble(y.Next(0,2)));
                            }
                        }
                    }
                }
            }
        }
    }
}