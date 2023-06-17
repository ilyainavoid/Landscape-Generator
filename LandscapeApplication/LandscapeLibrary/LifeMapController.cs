using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace LandscapeLibrary
{

    public class LifeMapControler
    {
        public void StartMovingEntity(Cell[,] cells)
        {
            Thread thread = new Thread(() => MovingEntity(cells));
            thread.Start();
        }

        private void MovingEntity(Cell[,] cells)
        {
            Random rnd = new Random();
            while (true)
            {
                IDisaster disaster;

                if (rnd.NextDouble() > 0.999)
                {
                    disaster = FactoryDisaster.getDisaster(DisasterType.METEOR_FALLING);
                    disaster.startDisaster(rnd.Next(cells.GetLength(0)), rnd.Next(cells.GetLength(0)), cells, rnd.Next(5));
                }

                if (rnd.NextDouble() > 0.99)
                {
                    disaster = FactoryDisaster.getDisaster(DisasterType.TORNADO);
                    disaster.startDisaster(rnd.Next(cells.GetLength(0)), rnd.Next(cells.GetLength(0)), cells, rnd.Next(10));
                }

                if (rnd.NextDouble() > 0.99)
                {
                    disaster = FactoryDisaster.getDisaster(DisasterType.CONFLAGRATION);
                    disaster.startDisaster(rnd.Next(cells.GetLength(0)), rnd.Next(cells.GetLength(0)), cells, rnd.Next(15));
                }

                foreach (Cell cell in cells)
                {
                    if (cell.getEntityType() != null) 
                    {
                        cell.getEntityType().moveEntity(cell.getNeighboursCell());
                    }
                }

                Thread.Sleep(2000);
            }
        }


    }
}
