namespace WinFormsApp1
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel5 = new Panel();
            panel3 = new Panel();
            Refresh = new Button();
            CloseAppButton = new Button();
            AddAcaciaButton = new Button();
            AddOakButton = new Button();
            AddJungleTreeButton = new Button();
            AddSpruceButton = new Button();
            AddCactusButton = new Button();
            AddCobblestoneButton = new Button();
            AddFireButton = new Button();
            AddWaterButton = new Button();
            label4 = new Label();
            label3 = new Label();
            StartTornado = new Button();
            StartConflagration = new Button();
            MeteorFalling = new Button();
            CreationTypeChoice = new CheckedListBox();
            CreationTypeLabel = new Label();
            GenerateMapButton = new Button();
            panel4 = new Panel();
            textBox1 = new TextBox();
            MapSizeLabel = new Label();
            panel2 = new Panel();
            MapControllerLabel = new Label();
            NameOfApplicationLabel = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(NameOfApplicationLabel);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1980, 1080);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Location = new Point(789, 149);
            panel5.Name = "panel5";
            panel5.Size = new Size(900, 900);
            panel5.TabIndex = 27;
            // 
            // panel3
            // 
            panel3.BackColor = Color.OliveDrab;
            panel3.Controls.Add(Refresh);
            panel3.Controls.Add(CloseAppButton);
            panel3.Controls.Add(AddAcaciaButton);
            panel3.Controls.Add(AddOakButton);
            panel3.Controls.Add(AddJungleTreeButton);
            panel3.Controls.Add(AddSpruceButton);
            panel3.Controls.Add(AddCactusButton);
            panel3.Controls.Add(AddCobblestoneButton);
            panel3.Controls.Add(AddFireButton);
            panel3.Controls.Add(AddWaterButton);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(StartTornado);
            panel3.Controls.Add(StartConflagration);
            panel3.Controls.Add(MeteorFalling);
            panel3.Controls.Add(CreationTypeChoice);
            panel3.Controls.Add(CreationTypeLabel);
            panel3.Controls.Add(GenerateMapButton);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(MapSizeLabel);
            panel3.Location = new Point(12, 241);
            panel3.Name = "panel3";
            panel3.Size = new Size(548, 820);
            panel3.TabIndex = 3;
            panel3.Paint += panel3_Paint;
            // 
            // Refresh
            // 
            Refresh.BackColor = Color.LemonChiffon;
            Refresh.Font = new Font("Bebas Neue", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            Refresh.ForeColor = SystemColors.ControlText;
            Refresh.Location = new Point(249, 378);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(283, 50);
            Refresh.TabIndex = 28;
            Refresh.Text = "Refresh";
            Refresh.UseVisualStyleBackColor = false;
            Refresh.Click += StartLife_Click;
            // 
            // CloseAppButton
            // 
            CloseAppButton.BackColor = Color.LemonChiffon;
            CloseAppButton.Font = new Font("Bebas Neue", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            CloseAppButton.ForeColor = SystemColors.ControlText;
            CloseAppButton.Location = new Point(16, 730);
            CloseAppButton.Name = "CloseAppButton";
            CloseAppButton.Size = new Size(516, 50);
            CloseAppButton.TabIndex = 26;
            CloseAppButton.Text = "Close app";
            CloseAppButton.UseVisualStyleBackColor = false;
            CloseAppButton.Click += CloseAppButton_Click;
            // 
            // AddAcaciaButton
            // 
            AddAcaciaButton.BackColor = Color.BurlyWood;
            AddAcaciaButton.Font = new Font("Bebas Neue", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            AddAcaciaButton.ForeColor = SystemColors.ControlText;
            AddAcaciaButton.Location = new Point(421, 640);
            AddAcaciaButton.Name = "AddAcaciaButton";
            AddAcaciaButton.Size = new Size(111, 50);
            AddAcaciaButton.TabIndex = 25;
            AddAcaciaButton.Text = "Acacia";
            AddAcaciaButton.UseVisualStyleBackColor = false;
            AddAcaciaButton.Click += AddAcaciaButton_Click;
            // 
            // AddOakButton
            // 
            AddOakButton.BackColor = Color.BurlyWood;
            AddOakButton.Font = new Font("Bebas Neue", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            AddOakButton.ForeColor = SystemColors.ControlText;
            AddOakButton.Location = new Point(281, 640);
            AddOakButton.Name = "AddOakButton";
            AddOakButton.Size = new Size(131, 50);
            AddOakButton.TabIndex = 24;
            AddOakButton.Text = "Oak";
            AddOakButton.UseVisualStyleBackColor = false;
            AddOakButton.Click += AddOakButton_Click;
            // 
            // AddJungleTreeButton
            // 
            AddJungleTreeButton.BackColor = Color.BurlyWood;
            AddJungleTreeButton.Font = new Font("Bebas Neue", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            AddJungleTreeButton.ForeColor = SystemColors.ControlText;
            AddJungleTreeButton.Location = new Point(136, 640);
            AddJungleTreeButton.Name = "AddJungleTreeButton";
            AddJungleTreeButton.Size = new Size(132, 50);
            AddJungleTreeButton.TabIndex = 23;
            AddJungleTreeButton.Text = "Jungle tree";
            AddJungleTreeButton.UseVisualStyleBackColor = false;
            AddJungleTreeButton.Click += AddJungleTreeButton_Click;
            // 
            // AddSpruceButton
            // 
            AddSpruceButton.BackColor = Color.BurlyWood;
            AddSpruceButton.Font = new Font("Bebas Neue", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            AddSpruceButton.ForeColor = SystemColors.ControlText;
            AddSpruceButton.Location = new Point(16, 640);
            AddSpruceButton.Name = "AddSpruceButton";
            AddSpruceButton.Size = new Size(111, 50);
            AddSpruceButton.TabIndex = 22;
            AddSpruceButton.Text = "Spruce";
            AddSpruceButton.UseVisualStyleBackColor = false;
            AddSpruceButton.Click += AddSpruceButton_Click;
            // 
            // AddCactusButton
            // 
            AddCactusButton.BackColor = Color.SeaGreen;
            AddCactusButton.Font = new Font("Bebas Neue", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            AddCactusButton.ForeColor = SystemColors.ControlText;
            AddCactusButton.Location = new Point(421, 584);
            AddCactusButton.Name = "AddCactusButton";
            AddCactusButton.Size = new Size(111, 50);
            AddCactusButton.TabIndex = 21;
            AddCactusButton.Text = "Cactus";
            AddCactusButton.UseVisualStyleBackColor = false;
            AddCactusButton.Click += button7_Click;
            // 
            // AddCobblestoneButton
            // 
            AddCobblestoneButton.BackColor = Color.Gray;
            AddCobblestoneButton.Font = new Font("Bebas Neue", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            AddCobblestoneButton.ForeColor = SystemColors.ControlText;
            AddCobblestoneButton.Location = new Point(249, 584);
            AddCobblestoneButton.Name = "AddCobblestoneButton";
            AddCobblestoneButton.Size = new Size(163, 50);
            AddCobblestoneButton.TabIndex = 20;
            AddCobblestoneButton.Text = "Cobblestone";
            AddCobblestoneButton.UseVisualStyleBackColor = false;
            AddCobblestoneButton.Click += AddCobblestoneButton_Click;
            // 
            // AddFireButton
            // 
            AddFireButton.BackColor = Color.Goldenrod;
            AddFireButton.Font = new Font("Bebas Neue", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            AddFireButton.ForeColor = SystemColors.ControlText;
            AddFireButton.Location = new Point(136, 584);
            AddFireButton.Name = "AddFireButton";
            AddFireButton.Size = new Size(107, 50);
            AddFireButton.TabIndex = 19;
            AddFireButton.Text = "Fire";
            AddFireButton.UseVisualStyleBackColor = false;
            AddFireButton.Click += AddFireButton_Click;
            // 
            // AddWaterButton
            // 
            AddWaterButton.BackColor = Color.DarkSlateBlue;
            AddWaterButton.Font = new Font("Bebas Neue", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            AddWaterButton.ForeColor = SystemColors.ControlText;
            AddWaterButton.Location = new Point(16, 584);
            AddWaterButton.Name = "AddWaterButton";
            AddWaterButton.Size = new Size(111, 50);
            AddWaterButton.TabIndex = 18;
            AddWaterButton.Text = "Water";
            AddWaterButton.UseVisualStyleBackColor = false;
            AddWaterButton.Click += AddWaterButton_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Bebas Neue", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(13, 534);
            label4.Name = "label4";
            label4.Size = new Size(522, 47);
            label4.TabIndex = 17;
            label4.Text = "Add entity";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Bebas Neue", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(10, 431);
            label3.Name = "label3";
            label3.Size = new Size(522, 47);
            label3.TabIndex = 16;
            label3.Text = "Start disaster";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // StartTornado
            // 
            StartTornado.BackColor = Color.LemonChiffon;
            StartTornado.Font = new Font("Bebas Neue", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            StartTornado.ForeColor = SystemColors.ControlText;
            StartTornado.Location = new Point(364, 481);
            StartTornado.Name = "StartTornado";
            StartTornado.Size = new Size(170, 50);
            StartTornado.TabIndex = 15;
            StartTornado.Text = "Tornado";
            StartTornado.UseVisualStyleBackColor = false;
            StartTornado.Click += StartTornado_Click;
            // 
            // StartConflagration
            // 
            StartConflagration.BackColor = Color.LemonChiffon;
            StartConflagration.Font = new Font("Bebas Neue", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            StartConflagration.ForeColor = SystemColors.ControlText;
            StartConflagration.Location = new Point(191, 481);
            StartConflagration.Name = "StartConflagration";
            StartConflagration.Size = new Size(167, 50);
            StartConflagration.TabIndex = 14;
            StartConflagration.Text = "Conflagration";
            StartConflagration.UseVisualStyleBackColor = false;
            StartConflagration.Click += StartConflagration_Click;
            // 
            // MeteorFalling
            // 
            MeteorFalling.BackColor = Color.LemonChiffon;
            MeteorFalling.Font = new Font("Bebas Neue", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            MeteorFalling.ForeColor = SystemColors.ControlText;
            MeteorFalling.Location = new Point(15, 481);
            MeteorFalling.Name = "MeteorFalling";
            MeteorFalling.Size = new Size(170, 50);
            MeteorFalling.TabIndex = 13;
            MeteorFalling.Text = "Meteor";
            MeteorFalling.UseVisualStyleBackColor = false;
            MeteorFalling.Click += MeteorFalling_Click;
            // 
            // CreationTypeChoice
            // 
            CreationTypeChoice.BackColor = Color.LemonChiffon;
            CreationTypeChoice.Cursor = Cursors.Hand;
            CreationTypeChoice.Font = new Font("Bebas Neue", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            CreationTypeChoice.FormattingEnabled = true;
            CreationTypeChoice.Items.AddRange(new object[] { "Diagonal Creation", "Hills and Holes", "Island Creation", "Chess Creation", "Smoothing" });
            CreationTypeChoice.Location = new Point(16, 113);
            CreationTypeChoice.Name = "CreationTypeChoice";
            CreationTypeChoice.Size = new Size(519, 259);
            CreationTypeChoice.TabIndex = 12;
            // 
            // CreationTypeLabel
            // 
            CreationTypeLabel.Font = new Font("Bebas Neue", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            CreationTypeLabel.ForeColor = SystemColors.ButtonHighlight;
            CreationTypeLabel.Location = new Point(13, 63);
            CreationTypeLabel.Name = "CreationTypeLabel";
            CreationTypeLabel.Size = new Size(522, 47);
            CreationTypeLabel.TabIndex = 11;
            CreationTypeLabel.Text = "Choose creation type";
            CreationTypeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GenerateMapButton
            // 
            GenerateMapButton.BackColor = Color.LemonChiffon;
            GenerateMapButton.Font = new Font("Bebas Neue", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            GenerateMapButton.ForeColor = SystemColors.ControlText;
            GenerateMapButton.Location = new Point(16, 378);
            GenerateMapButton.Name = "GenerateMapButton";
            GenerateMapButton.Size = new Size(227, 50);
            GenerateMapButton.TabIndex = 2;
            GenerateMapButton.Text = "Generate";
            GenerateMapButton.UseVisualStyleBackColor = false;
            GenerateMapButton.Click += CreateMapButton_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LemonChiffon;
            panel4.Controls.Add(textBox1);
            panel4.Location = new Point(133, 13);
            panel4.Name = "panel4";
            panel4.Size = new Size(402, 50);
            panel4.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Bebas Neue", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(3, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(396, 44);
            textBox1.TabIndex = 2;
            // 
            // MapSizeLabel
            // 
            MapSizeLabel.Font = new Font("Bebas Neue", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            MapSizeLabel.ForeColor = SystemColors.ButtonHighlight;
            MapSizeLabel.Location = new Point(3, 16);
            MapSizeLabel.Name = "MapSizeLabel";
            MapSizeLabel.Size = new Size(124, 47);
            MapSizeLabel.TabIndex = 0;
            MapSizeLabel.Text = "Map size";
            // 
            // panel2
            // 
            panel2.Controls.Add(MapControllerLabel);
            panel2.Location = new Point(12, 135);
            panel2.Name = "panel2";
            panel2.Size = new Size(548, 100);
            panel2.TabIndex = 2;
            // 
            // MapControllerLabel
            // 
            MapControllerLabel.Anchor = AnchorStyles.None;
            MapControllerLabel.BackColor = Color.OliveDrab;
            MapControllerLabel.Font = new Font("Bebas Neue", 48F, FontStyle.Regular, GraphicsUnit.Point);
            MapControllerLabel.ForeColor = SystemColors.ButtonHighlight;
            MapControllerLabel.Location = new Point(0, 0);
            MapControllerLabel.Name = "MapControllerLabel";
            MapControllerLabel.Size = new Size(548, 100);
            MapControllerLabel.TabIndex = 0;
            MapControllerLabel.Text = "Controller";
            MapControllerLabel.TextAlign = ContentAlignment.MiddleCenter;
            MapControllerLabel.Click += MapControllerLabel_Click;
            // 
            // NameOfApplicationLabel
            // 
            NameOfApplicationLabel.BackColor = Color.OliveDrab;
            NameOfApplicationLabel.Dock = DockStyle.Top;
            NameOfApplicationLabel.Font = new Font("Bebas Neue", 71.99999F, FontStyle.Regular, GraphicsUnit.Point);
            NameOfApplicationLabel.ForeColor = SystemColors.ButtonHighlight;
            NameOfApplicationLabel.Location = new Point(0, 0);
            NameOfApplicationLabel.Margin = new Padding(0);
            NameOfApplicationLabel.Name = "NameOfApplicationLabel";
            NameOfApplicationLabel.Size = new Size(1980, 112);
            NameOfApplicationLabel.TabIndex = 1;
            NameOfApplicationLabel.Text = "Landscape Generator";
            NameOfApplicationLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = LandscapeApplicationUI.Properties.Resources.background;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1980, 1080);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1061);
            Controls.Add(panel1);
            Name = "MainMenu";
            Text = "LandscapeGenerator";
            Load += MainMenuLoad;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label NameOfApplicationLabel;
        private Panel panel2;
        private Label MapControllerLabel;
        private Panel panel3;
        private Label MapSizeLabel;
        private Panel panel4;
        private TextBox textBox1;
        private Button GenerateMapButton;
        private Label CreationTypeLabel;
        private CheckedListBox CreationTypeChoice;
        private Button MeteorFalling;
        private Label label3;
        private Button StartTornado;
        private Button StartConflagration;
        private Label label4;
        private Button AddWaterButton;
        private Button AddAcaciaButton;
        private Button AddOakButton;
        private Button AddJungleTreeButton;
        private Button AddSpruceButton;
        private Button AddCactusButton;
        private Button AddCobblestoneButton;
        private Button AddFireButton;
        private Button CloseAppButton;
        private Panel panel5;
        private Button StopLife;
        private Button Refresh;
    }
}