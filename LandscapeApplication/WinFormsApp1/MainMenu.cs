using System.Collections.Generic;
using System.Data.Common;
using System.Windows.Forms;
using LandscapeLibrary;
using TheArtOfDevHtmlRenderer.Adapters;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class MainMenu : Form
    {
        Map mapCreator;
        Panel[,] displayedCells;
        Panel[,] displayedEntities;
        Cell[,] matrix;
        TableLayoutPanel Map;

        bool isTornado = false;
        bool isConflagration = false;
        bool isMeteorFalling = false;

        bool isOak = false;
        bool isFire = false;
        bool isWaterSource = false;
        bool isCobblestone = false;
        bool isSpruce = false;
        bool isAcacia = false;
        bool isJungleTree = false;
        bool isCactus = false;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void Drawer(int gridSize)
        {
            Map.Controls.Clear();

            Dictionary<Type, Color> blockColors = new Dictionary<Type, Color>
            {
                { typeof(WaterBlock), Color.DarkBlue },
                { typeof(Beach), Color.Beige },
                { typeof(Forest), Color.LightGreen },
                { typeof(Jungle), Color.DarkOliveGreen },
                { typeof(Savannah), Color.YellowGreen },
                { typeof(Tundra), Color.White }
            };

            Dictionary<Type, Color> entityColors = new Dictionary<Type, Color>
            {
                { typeof(Oak), Color.Green },
                { typeof(Cactus), Color.Pink },
                { typeof(Acacia), Color.Orange },
                { typeof(JungleTree), Color.DarkGreen },
                { typeof(Cobblestone), Color.Gray },
                { typeof(Spruce), Color.DarkTurquoise },
                { typeof(Fire), Color.Red },
                { typeof(WaterSource), Color.DarkBlue }
            };

            Panel[,] displayedCells = new Panel[gridSize, gridSize];
            Panel[,] displayedEntities = new Panel[gridSize, gridSize];

            Parallel.For(0, gridSize, i =>
            {
                for (int j = 0; j < gridSize; ++j)
                {
                    Panel displayedCell = displayedCells[i, j];

                    if (displayedCell == null)
                    {
                        displayedCell = new Panel();
                        displayedCell.Margin = new Padding(0);
                        displayedCell.Click += CellSelect;
                        displayedCells[i, j] = displayedCell;
                    }

                    Type blockType = matrix[i, j].getBlock().GetType();
                    if (blockColors.TryGetValue(blockType, out Color blockColor))
                    {
                        displayedCell.BackColor = blockColor;
                    }

                    Type entityType = matrix[i, j].getEntityType()?.GetType();
                    if (entityType != null && entityColors.TryGetValue(entityType, out Color entityColor))
                    {
                        Panel displayedEntity = displayedEntities[i, j];
                        if (displayedEntity == null)
                        {
                            displayedEntity = new Panel();
                            displayedEntity.Width = 10;
                            displayedEntity.Height = 10;
                            displayedEntities[i, j] = displayedEntity;
                        }
                        displayedEntity.BackColor = entityColor;
                        displayedCell.Controls.Add(displayedEntity);
                    }

                    int rowIndex = i;
                    int columnIndex = j;
                    Map.Invoke(new MethodInvoker(() => Map.Controls.Add(displayedCell, rowIndex, columnIndex)));
                }
            });
        }

        private void CellSelect(object sender, EventArgs e)
        {
            Panel selectedPanel = (Panel)sender;
            int x = Map.GetColumn(selectedPanel);
            int y = Map.GetRow(selectedPanel);
            IDisaster disaster = null;
            Entity entity = FactoryEntity.getEntity(EntityType.COBBLESTONE, PlantType.SPRUCE);
            if (isConflagration)
            {
                disaster = FactoryDisaster.getDisaster(DisasterType.CONFLAGRATION);
            }
            else if (isMeteorFalling)
            {
                disaster = FactoryDisaster.getDisaster(DisasterType.METEOR_FALLING);
            }
            else if (isTornado)
            {
                disaster = FactoryDisaster.getDisaster(DisasterType.TORNADO);
            }
            else if (isSpruce)
            {
                entity = FactoryEntity.getEntity(EntityType.PLANT, PlantType.SPRUCE);
            }
            else if (isOak)
            {
                entity = FactoryEntity.getEntity(EntityType.PLANT, PlantType.OAK);
            }
            else if (isCactus)
            {
                entity = FactoryEntity.getEntity(EntityType.PLANT, PlantType.CACTUS);
            }
            else if (isJungleTree)
            {
                entity = FactoryEntity.getEntity(EntityType.PLANT, PlantType.JUNGLE_TREE);
            }
            else if (isAcacia)
            {
                entity = FactoryEntity.getEntity(EntityType.PLANT, PlantType.ACACIA);
            }
            else if (isCobblestone)
            {
                entity = FactoryEntity.getEntity(EntityType.COBBLESTONE, PlantType.SPRUCE);
            }
            else if (isWaterSource)
            {
                entity = FactoryEntity.getEntity(EntityType.WATER_SOURCE, PlantType.SPRUCE);
            }
            else if (isFire)
            {
                entity = FactoryEntity.getEntity(EntityType.FIRE, PlantType.SPRUCE);
            }

            if (disaster == null)
            {
                matrix[x, y].setEntityType(entity);
            }
            else
            {
                disaster.startDisaster(x, y, matrix, 10);
            }
        }

        private void CreateVisualMap(int gridSize)
        {
            if (panel5.Controls.Count > 0)
            {
                panel5.Controls[0].Dispose();
            }
            Map = new TableLayoutPanel();

            Map.RowCount = gridSize;
            Map.ColumnCount = gridSize;
            Map.AutoSize = true;
            Map.Dock = DockStyle.Fill;
            Map.RowStyles.Clear();
            Map.ColumnStyles.Clear();
            Map.Size = new System.Drawing.Size(894, 894);
            Map.Margin = new System.Windows.Forms.Padding(0);
            panel5.Controls.Add(Map);

            for (int i = 0; i < gridSize; i++)
            {
                Map.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, gridSize));
            }

            for (int i = 0; i < gridSize; i++)
            {
                Map.RowStyles.Add(new RowStyle(SizeType.Percent, gridSize));
            }
        }

        private void MainMenuLoad(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void MapControllerLabel_Click(object sender, EventArgs e)
        {

        }

        private void CreateMapButton_Click(object sender, EventArgs e)
        {
            int gridSize = Convert.ToInt32(textBox1.Text);
            MapCreatorType type = MapCreatorType.ISLAND;
            foreach (Object item in CreationTypeChoice.CheckedItems)
            {
                if (item.ToString() == "Diagonal Creation")
                {
                    type = MapCreatorType.DIAGONAL_CREATION;
                }
                if (item.ToString() == "Hills and Holes")
                {
                    type = MapCreatorType.HILLS_AND_HOLES;
                }
                if (item.ToString() == "Island Creation")
                {
                    type = MapCreatorType.ISLAND;
                }
                if (item.ToString() == "Chess Creation")
                {
                    type = MapCreatorType.CHESS_CREATION;
                }
                if (item.ToString() == "Smoothing")
                {
                    type = MapCreatorType.SMOOTHING;
                }
            }

            mapCreator = new Map(gridSize, type);
            matrix = mapCreator.getMap();

            displayedCells = new Panel[gridSize, gridSize];
            displayedEntities = new Panel[gridSize, gridSize];

            CreateVisualMap(gridSize);
            Drawer(gridSize);
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            isTornado = false;
            isConflagration = false;
            isMeteorFalling = false;

            isOak = false;
            isFire = false;
            isWaterSource = false;
            isCobblestone = false;
            isSpruce = false;
            isAcacia = false;
            isJungleTree = false;
            isCactus = true;
        }

        private void CloseAppButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartLife_Click(object sender, EventArgs e)
        {
            LifeMapControler controller = new LifeMapControler();
            controller.StartMovingEntity(mapCreator.getMap());
            int size = mapCreator.getMap().GetLength(0);
            CreateVisualMap(size);
            Drawer(size);
        }

        private void MeteorFalling_Click(object sender, EventArgs e)
        {
            isMeteorFalling = true;
            isConflagration = false;
            isTornado = false;

            isOak = false;
            isFire = false;
            isWaterSource = false;
            isCobblestone = false;
            isSpruce = false;
            isAcacia = false;
            isJungleTree = false;
            isCactus = false;
        }

        private void StartConflagration_Click(object sender, EventArgs e)
        {
            isConflagration = true;
            isMeteorFalling = false;
            isTornado = false;

            isOak = false;
            isFire = false;
            isWaterSource = false;
            isCobblestone = false;
            isSpruce = false;
            isAcacia = false;
            isJungleTree = false;
            isCactus = false;
        }

        private void StartTornado_Click(object sender, EventArgs e)
        {
            isTornado = true;
            isConflagration = false;
            isMeteorFalling = false;

            isOak = false;
            isFire = false;
            isWaterSource = false;
            isCobblestone = false;
            isSpruce = false;
            isAcacia = false;
            isJungleTree = false;
            isCactus = false;
        }

        private void AddWaterButton_Click(object sender, EventArgs e)
        {
            isTornado = false;
            isConflagration = false;
            isMeteorFalling = false;

            isOak = false;
            isFire = false;
            isWaterSource = true;
            isCobblestone = false;
            isSpruce = false;
            isAcacia = false;
            isJungleTree = false;
            isCactus = false;
        }

        private void AddFireButton_Click(object sender, EventArgs e)
        {
            isTornado = false;
            isConflagration = false;
            isMeteorFalling = false;

            isOak = false;
            isFire = true;
            isWaterSource = false;
            isCobblestone = false;
            isSpruce = false;
            isAcacia = false;
            isJungleTree = false;
            isCactus = false;
        }

        private void AddCobblestoneButton_Click(object sender, EventArgs e)
        {
            isTornado = false;
            isConflagration = false;
            isMeteorFalling = false;

            isOak = false;
            isFire = false;
            isWaterSource = false;
            isCobblestone = true;
            isSpruce = false;
            isAcacia = false;
            isJungleTree = false;
            isCactus = false;
        }

        private void AddSpruceButton_Click(object sender, EventArgs e)
        {
            isTornado = false;
            isConflagration = false;
            isMeteorFalling = false;

            isOak = false;
            isFire = false;
            isWaterSource = false;
            isCobblestone = false;
            isSpruce = true;
            isAcacia = false;
            isJungleTree = false;
            isCactus = false;
        }

        private void AddJungleTreeButton_Click(object sender, EventArgs e)
        {
            isTornado = false;
            isConflagration = false;
            isMeteorFalling = false;

            isOak = false;
            isFire = false;
            isWaterSource = false;
            isCobblestone = false;
            isSpruce = false;
            isAcacia = false;
            isJungleTree = true;
            isCactus = false;
        }

        private void AddOakButton_Click(object sender, EventArgs e)
        {
            isTornado = false;
            isConflagration = false;
            isMeteorFalling = false;

            isOak = true;
            isFire = false;
            isWaterSource = false;
            isCobblestone = false;
            isSpruce = false;
            isAcacia = false;
            isJungleTree = false;
            isCactus = false;
        }

        private void AddAcaciaButton_Click(object sender, EventArgs e)
        {
            isTornado = false;
            isConflagration = false;
            isMeteorFalling = false;

            isOak = false;
            isFire = false;
            isWaterSource = false;
            isCobblestone = false;
            isSpruce = false;
            isAcacia = true;
            isJungleTree = false;
            isCactus = false;
        }

    }
}