namespace vector.net
{
    public partial class vector : Form
    {
        private bool isVectorCreator = false;
        private Point PreviousClick;
        private bool hasClicked = false;
        private Brush brush;
        private Pen Pencil = new Pen(Color.Black);
        private Graphics graphics;
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

        private void brightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frame.BackColor = Color.FromArgb(235, 235, 235);
            TopStrip.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void topToolbarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog picker = new ColorDialog();
            if (picker.ShowDialog() == DialogResult.OK)
            {
                TopStrip.BackColor = picker.Color;
            }
        }

        private void mainWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog picker = new ColorDialog();
            if (picker.ShowDialog() == DialogResult.OK)
            {
                Frame.BackColor = picker.Color;
            }
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isVectorCreator)
            {
                isVectorCreator = false;
            }
            else
            {
                isVectorCreator = true;
            }
        }

        private void Image_Click(object sender, EventArgs e)
        {
            if (isVectorCreator)
            {
                Point ScreenLocation = Cursor.Position;
                Point ElementLocation = Image.PointToClient(ScreenLocation);
                if (hasClicked)
                {
                    graphics.DrawLine(Pencil, PreviousClick, ElementLocation);
                }
                PreviousClick = ElementLocation;
                hasClicked = true;
            }
            else
            {
                hasClicked = false;
            }
        }

        private void vector_Load(object sender, EventArgs e)
        {
            graphics = Image.CreateGraphics();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void thicknessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IntValueDialog intValueDialog = new IntValueDialog();
            intValueDialog.title = "Pixels";
            intValueDialog.suffix = "pixels";
            intValueDialog.ShowDialog();
            if (intValueDialog.result != -1234567890)
            {
                int result = (int)intValueDialog.result;
                Pencil.Width = result;
            }
        }

        private void pickerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ColorDialog picker = new ColorDialog();
            if (picker.ShowDialog() == DialogResult.OK)
            {
                Pencil.Color = picker.Color;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image.Image = null;
            graphics.Clear(Color.FromArgb(255, 255, 255));
            graphics = Image.CreateGraphics();
            hasClicked = false;
        }
    }
}