using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
            form1.BackColor = Color.Blue;
        }

        // Что то там
        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Beige;
        }
    }
}
