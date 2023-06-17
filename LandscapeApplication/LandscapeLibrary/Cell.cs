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
        private int counterEntity = 9;

        public Cell(double height)
        {
            this.height = height;
            this.CreateBlockTypeAndEntity();
        }

        private void CreateBlockTypeAndEntity()
        {
            Random rnd = new Random();

            if (this.height < 0.2)
            {
                this.blockType = BlockFactoryType.getBlockType(BlockCreateType.WATER);
                this.entity = FactoryEntity.getEntity(EntityType.WATER_SOURCE, PlantType.CACTUS);
            }
            else if (this.height < 0.3)
            {
                this.blockType = BlockFactoryType.getBlockType(BlockCreateType.BEACH);
                this.entity = null;

                if (rnd.NextDouble() > 0.83)
                {
                    this.entity = FactoryEntity.getEntity(EntityType.PLANT, PlantType.CACTUS);
                }
            }
            else if (this.height < 0.5)
            {
                this.blockType = BlockFactoryType.getBlockType(BlockCreateType.FOREST);
                this.entity = null;

                if (rnd.NextDouble() > 0.3)
                {
                    this.entity = FactoryEntity.getEntity(EntityType.PLANT, PlantType.OAK);
                }
            }
            else if (this.height < 0.7)
            {
                this.blockType = BlockFactoryType.getBlockType(BlockCreateType.JUNGLE);
                this.entity = null;

                if (rnd.NextDouble() > 0.2)
                {
                    this.entity = FactoryEntity.getEntity(EntityType.PLANT, PlantType.JUNGLE_TREE);
                }
            }
            else if (this.height < 0.9)
            {
                this.blockType = BlockFactoryType.getBlockType(BlockCreateType.SAVANNAH);
                this.entity = null;

                if (rnd.NextDouble() > 0.7)
                {
                    this.entity = FactoryEntity.getEntity(EntityType.PLANT, PlantType.ACACIA);
                }
            }
            else
            {
                this.blockType = BlockFactoryType.getBlockType(BlockCreateType.TUNDRA);
                this.entity = null;

                if (rnd.NextDouble() > 0.9)
                {
                    this.entity = FactoryEntity.getEntity(EntityType.PLANT, PlantType.SPRUCE);
                }
            }
        }

        public void setHeight(double height)
        {
            this.height = height;
            this.CreateBlockTypeAndEntity();
        }

        public double getHeight()
        {
            return this.height;
        }

        public BlockType getBlock()
        {
            return this.blockType;
        }

        public Entity getEntityType()
        {
            return this.entity;
        }

        public void setEntityType(Entity entity)
        {
            this.entity = entity;
        }

        public List<Cell> getNeighboursCell()
        {
            return this.neighbours;
        }

        public void setNeighboursCell(List<Cell> neighbours)
        {
            this.neighbours = neighbours;
        }

    }
}
