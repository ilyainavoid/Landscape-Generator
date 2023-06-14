using System;
using System.Collections.Generic;
using System.Text;

namespace LandscapeLibrary
{
    public class Cell
    {
        private double height = 0;
        private List<Cell> neighbours;

        public void setHeight(double height)
        {
            this.height = height;
        }

        public double getHeight()
        {
            return this.height;
        }

        public void getNeighboursCell(List<Cell> neighbours) 
        {
            this.neighbours = neighbours;
        }
    }
}
