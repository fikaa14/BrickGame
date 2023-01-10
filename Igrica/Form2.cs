using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Igrica
{
    public partial class Form2 : Form
    {
        public static String name = "";

        public Form2()
        {
            InitializeComponent();
            FormClosed += Form2_FormClosed;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // RichTextBox richTextBoxName = new RichTextBox();

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            Igrica igrica = new Igrica();
            name = richTextBoxName.Text;
            igrica.Show();
            Visible = false;
        }

    }
}
