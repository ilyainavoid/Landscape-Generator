using System;
using LandscapeLibrary;

namespace LandscapeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            FabricaCreateMap factory = new FabricaCreateMap();
            Map mapHeight = new Map(100);

            CreateMap island = factory.getCreateMap(CreateMapType.ISLAND);

            island.createMapHeight(mapHeight.getMap(), mapHeight.getSize());

            mapHeight.drawMap();
            //Console.WriteLine("Hello World!");
        }
    }
}
