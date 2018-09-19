using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        Form form2 = new Form2();
        public Form1()
        {
            InitializeComponent();
            form2.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("mFrame Loading form2(inventory)");
            form2.Hide();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.I)
            {
                if (form2.Visible)
                {
                    form2.Show();
                }
                else
                {
                    form2.Hide();
                }
            }
        }
    }
}
