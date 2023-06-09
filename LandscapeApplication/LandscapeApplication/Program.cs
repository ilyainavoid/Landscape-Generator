using System;
using LandscapeLibrary;

namespace LandscapeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Map mapHeight = new Map(200, CreateMapType.ISLAND);
            mapHeight.drawMap();
            //Console.WriteLine("Hello World!");
        }
    }
}
