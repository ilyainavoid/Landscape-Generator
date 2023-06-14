using System;
using System.Collections.Generic;
using System.Text;

namespace LandscapeLibrary
{
    public class Map
    {
        private int size;
        private Cell[,] matrixHeight;
        private IMapCreator createMap;

        public Map(int size, MapCreatorType type)
        {
            this.size = size;
            this.matrixHeight = new Cell[size, size];

            for (int i = 0; i < this.size; i++)
            {
                for (int j = 0; j < this.size; j++)
                {
                    this.matrixHeight[i, j] = new Cell();
                }
            }

            this.createMap = FactoryMapCreator.getMapCreator(type);
            createMap.createMapHeight(this.matrixHeight);

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
                    //Console.Write(matrixHeight[i, j].getHeight() + " ");
                    if (matrixHeight[i, j].getHeight() < 0.2)
                    {
                        Console.Write(0);
                    }
                    else if (matrixHeight[i, j].getHeight() > 0.9)
                    {
                        Console.Write(2);
                    }
                    else
                    {
                        Console.Write(1);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
