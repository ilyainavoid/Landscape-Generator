using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace LandscapeLibrary
{

     class LifeMapControler
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
                foreach (Cell cell in cells)
                {
                    cell.getEntityType().moveEntity(cell.getNeighboursCell());
                }

                Thread.Sleep(rnd.Next(0, 60000));
            }
        }


    }
}
