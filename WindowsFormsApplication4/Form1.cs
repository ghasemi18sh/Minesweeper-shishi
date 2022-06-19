using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            for (int i = 1; i < 5; i++)
            {
                comboBox1.Items.Add(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             if (rb5.Checked)
            {
                box5 b = new WindowsFormsApplication4.box5();
                b.mins = int.Parse(comboBox1.Text);
                b.Show();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            //Application.Exit();
        }

        private void rb5_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            for (int i = 1; i < 13; i++)
            {
                comboBox1.Items.Add(i);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
