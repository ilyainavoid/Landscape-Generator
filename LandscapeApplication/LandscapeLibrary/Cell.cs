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
        private int counterEntity = 10;

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
                this.blockType = BlockFabricaType.getBlockType(BlockCreateType.BEACH);

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
                this.blockType = BlockFabricaType.getBlockType(BlockCreateType.FOREST);

                if (rnd.NextDouble() > 0.3)
                {
                    this.entity = FactoryEntity.getEntity(EntityType.PLANT, PlantType.OAK);
                }
            }
            else if(this.height < 0.7)
            {
                this.blockType = BlockFabricaType.getBlockType(BlockCreateType.JUNGLE);

                if (rnd.NextDouble() > 0.2)
                {
                    this.entity = FactoryEntity.getEntity(EntityType.PLANT, PlantType.JUNGLE_TREE);
                }
            }
            else if (this.height < 0.9)
            {
                this.blockType = BlockFabricaType.getBlockType(BlockCreateType.SAVANNAH);

                if (rnd.NextDouble() > 0.6)
                {
                    this.entity = FactoryEntity.getEntity(EntityType.PLANT, PlantType.ACACIA);
                }
            }
            else
            {
                this.blockType = BlockFabricaType.getBlockType(BlockCreateType.TUNDRA);

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

        public int getCounterEntity()
        {
            return this.counterEntity;
        }

        public void setCounterEntity(int counterEntity)
        {
            this.counterEntity = counterEntity;
        }

        public void setNeighboursCell(List<Cell> neighbours) 
        {
            this.neighbours = neighbours;
        }
    }
}
