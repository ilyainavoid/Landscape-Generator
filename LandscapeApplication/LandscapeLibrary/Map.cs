using System;
using System.Collections.Generic;
using System.Text;

namespace LandscapeLibrary
{
    public class Map
    {
        private int size;
        private Cell[,] matrixHeight;

        public Map(int size)
        {
            this.size = size;
            this.matrixHeight = new Cell[size, size];
            for (int i = 0; i < this.size; i++)
            {
                for (int j = 0; j < this.size; j++)
                {
                    Cell cell = new Cell();
                    this.matrixHeight[i, j] = cell;
                }
            }
        }

        public int getSize()
        {
            return this.size;
        }

        public Cell[,] getMap()
        {
            return this.matrixHeight;
        }

        public void drawMap()
        {
            for (int i = 0; i < this.size; i++)
            {
                for (int j = 0; j < this.size; j++)
                {
                    Console.Write(matrixHeight[i, j].getHeight() + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
