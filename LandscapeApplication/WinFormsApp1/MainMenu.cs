namespace WinFormsApp1
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

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
            int width = Convert.ToInt32(textBox1.Text);
            int length = Convert.ToInt32(textBox1.Text);
            Panel map = new Panel();
            map.Width = width;
            map.Height = length;
            map.BackColor = Color.Yellow;
            panel5.Controls.Add(map);
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

        }

        private void CloseAppButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}