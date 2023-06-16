using System;
using System.Collections.Generic;
using System.Text;

namespace LandscapeLibrary
{
    public class Tornado : IDisaster
    {
        public void startDisaster(int x, int y, Cell[,] matrixHeight, int radius)
        {
            int size = matrixHeight.GetLength(0);
            for (int i= 0; i < size; i++) 
            {
                for(int j = 0; j < size; j++) 
                {
                    double distance = Math.Sqrt(Math.Pow(i-x, 2)+Math.Pow(j-y, 2));
                    if (radius >= distance)
                    {
                        matrixHeight[i, j].setEntityType(null);
                    }
                }
            }
        }
    }
}
