using System;
using System.Collections.Generic;
using System.Text;

namespace LandscapeLibrary
{
    public class Cell
    {
        private double height = 0;
        private List<Cell> neighbours;
        private Entity entity;
        private BlockType blockType;

        public Cell(double height)
        {
            this.height = height;
            this.CreateBlockTypeAndEntity();
        }

        private void CreateBlockTypeAndEntity()
        {
            Random rnd = new Random();
            if (this.height < 0.3)
            {
                this.blockType = BlockFactoryType.getBlockType(BlockCreateType.BEACH);

                if (this.height < 0.2)
                {
                    this.entity = FactoryEntity.getEntity(EntityType.WATER_SOURCE, PlantType.CACTUS);
                }
                else
                {
                    if(rnd.NextDouble() > 0.83)
                    {
                        this.entity = FactoryEntity.getEntity(EntityType.PLANT, PlantType.CACTUS);
                    }
                }
            }
            else if(this.height < 0.5)
            {
                this.blockType = BlockFactoryType.getBlockType(BlockCreateType.FOREST);

                if (rnd.NextDouble() > 0.3)
                {
                    this.entity = FactoryEntity.getEntity(EntityType.PLANT, PlantType.OAK);
                }
            }
            else if(this.height < 0.7)
            {
                this.blockType = BlockFactoryType.getBlockType(BlockCreateType.JUNGLE);

                if (rnd.NextDouble() > 0.2)
                {
                    this.entity = FactoryEntity.getEntity(EntityType.PLANT, PlantType.JUNGLE_TREE);
                }
            }
            else if (this.height < 0.9)
            {
                this.blockType = BlockFactoryType.getBlockType(BlockCreateType.SAVANNAH);

                if (rnd.NextDouble() > 0.6)
                {
                    this.entity = FactoryEntity.getEntity(EntityType.PLANT, PlantType.ACACIA);
                }
            }
            else
            {
                this.blockType = BlockFactoryType.getBlockType(BlockCreateType.TUNDRA);

                if (rnd.NextDouble() > 0.7)
                {
                    this.entity = FactoryEntity.getEntity(EntityType.PLANT, PlantType.SPRUCE);
                }
            }
        }

        public void setHeight(double height)
        {
            this.height = height;
        }

        public Entity getEntity()
        {
            return this.entity;
        }
        public double getHeight()
        {
            return this.height;
        }
        public void  setNeighboursCell(List<Cell> neighbours)
        {
            this.neighbours = neighbours;
        }
        public List<Cell> getNeighboursCell() 
        {
            return this.neighbours;
        }
    }
}
