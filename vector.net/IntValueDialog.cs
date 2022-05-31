using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vector.net
{
    public partial class IntValueDialog : Form
    {
        public string suffix;
        public string title;
        public decimal result = 0;
        public IntValueDialog()
        {
            InitializeComponent();
        }

        private void IntValueDialog_Load(object sender, EventArgs e)
        {
            this.Text = title;
            label1.Text = suffix;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result = numericUpDown1.Value;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result = -1234567890;
            this.Close();
        }
    }
}
