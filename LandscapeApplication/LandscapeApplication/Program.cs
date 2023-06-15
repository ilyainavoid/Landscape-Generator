using System;
using LandscapeLibrary;
using static System.Net.Mime.MediaTypeNames;

namespace LandscapeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Map mapHeight = new Map(100, CreateMapType.CHESS_CREATION);
            mapHeight.drawMap();
            //Console.WriteLine("Hello World!");
        }
    }
}
