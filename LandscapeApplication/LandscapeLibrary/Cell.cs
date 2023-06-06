using System;
using System.Collections.Generic;
using System.Text;

namespace LandscapeLibrary
{
    public class Cell
    {
        private double height = 0;

        public void setHeight(double height)
        {
            this.height = height;
        }

        public double getHeight()
        {
            return this.height;
        }
    }
}
