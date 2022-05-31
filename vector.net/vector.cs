namespace vector.net
{
    public partial class vector : Form
    {
        public vector()
        {
            InitializeComponent();
        }

        private void bt_file_Click(object sender, EventArgs e)
        {
            dropdown_File.Show();
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            dropdown_Edit.Show();
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frame.BackColor = Color.FromArgb(25, 25, 25);
            TopStrip.BackColor = Color.FromArgb(100, 100, 100);
        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frame.BackColor = Color.FromArgb(200, 200, 200);
            TopStrip.BackColor = Color.FromArgb(220, 220, 220);
        }

        private void bt_theme_Click(object sender, EventArgs e)
        {
            dropdown_Theme.Show();
        }

        private void grayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frame.BackColor = Color.FromArgb(75, 75, 75);
            TopStrip.BackColor = Color.FromArgb(125, 125, 125);
        }

        private void deepGrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frame.BackColor = Color.FromArgb(35, 35, 35);
            TopStrip.BackColor = Color.FromArgb(110, 110, 110);
        }

        private void lightGrayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frame.BackColor = Color.FromArgb(125, 125, 125);
            TopStrip.BackColor = Color.FromArgb(175, 175, 175);
        }
    }
}