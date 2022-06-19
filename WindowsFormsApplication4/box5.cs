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
    public partial class box5 : Form
    {
        Random r = new Random();
        public int xx, yy;
        public int mins;
        //bool[,] b;
        int[,] bomb;

        public box5()
        {
            InitializeComponent();

        }


        private void box5_Load(object sender, EventArgs e)
        {
            bomb = new int[5, 5];
            int x1 = 0;
            while (x1 < mins)
            {
                int x = point();
                int y = point();
                bomb[x, y] = -1;
                ++x1;
            }

            for (int i = 0; i < 5; i++)
            {

                for (int j = 0; j < 5; j++)
                {
                    int s = 0;


                    try { if (bomb[i - 1, j - 1] == -1) ++s; }
                    catch { }

                    try { if (bomb[i, j - 1] == -1) ++s; }
                    catch { }
                    try { if (bomb[i + 1, j - 1] == -1) ++s; }
                    catch { }

                    try { if (bomb[i - 1, j] == -1) ++s; }
                    catch { }
                    try { if (bomb[i + 1, j] == -1) ++s; }
                    catch { }

                    try { if (bomb[i - 1, j + 1] == -1) ++s; }
                    catch { }
                    try { if (bomb[i, j + 1] == -1) ++s; }
                    catch { }
                    try { if (bomb[i + 1, j + 1] == -1) ++s; }
                    catch { }


                    if (bomb[i, j] != -1)
                    {
                        bomb[i, j] = s;
                    }


                }

            }
        }


        void free_right(int x, int y)
        {
            bool flag = false;
            while ((x<4)&&!flag)
            {
                ++x;
                if (bomb[x, y] == 0)
                {
                    string st = "b" + x + "_" + y;
                    foreach (Button b in this.Controls)
                    {
                        if (b.Name == st)
                        {
                            b.BackColor = Color.White;
                            b.Text = bomb[x, y].ToString();
                        }
                    }
                }
                else flag = true;
            }
        }

        void free_down(int x, int y)
        {
            bool flag = false;
            while ((y < 4) && !flag)
            {
                ++y;
                if (bomb[x, y] == 0)
                {
                    string st = "b" + x + "_" + y;
                    foreach (Button b in this.Controls)
                    {
                        if (b.Name == st)
                        {
                            b.BackColor = Color.White;
                            b.Text = bomb[x, y].ToString();
                        }
                    }
                }
                else flag = true;
            }
        }


        void free_up(int x, int y)
        {
            bool flag = false;
            while ((y > 0) && !flag)
            {
                --y;
                if (bomb[x, y] == 0)
                {
                    string st = "b" + x + "_" + y;
                    foreach (Button b in this.Controls)
                    {
                        if (b.Name == st)
                        {
                            b.BackColor = Color.White;
                            b.Text = bomb[x, y].ToString();
                        }
                    }
                }
                else flag = true;
            }
        }


        void free_left(int x, int y)
        {
            bool flag = false;
            while ((x > 0) && !flag)
            {
                --x;
                if (bomb[x, y] == 0)
                {
                    string st = "b" + x + "_" + y;
                    foreach (Button b in this.Controls)
                    {
                        if (b.Name == st)
                        {
                            b.BackColor = Color.White;
                            b.Text = bomb[x, y].ToString();
                        }
                    }
                }
                else flag = true;
            }
        }


        int point()
        {

            return r.Next(0, 5);
        }

        private void b0_0_Click(object sender, EventArgs e)
        {
            if (b0_0.Text != "P")
            {
                xx = 0;
                yy = 0;
                b0_0.Text = bomb[xx, yy].ToString();
                if (b0_0.Text == "-1") b0_0.BackColor = Color.Red;
                else b0_0.BackColor = Color.White;
                if (b0_0.BackColor == Color.Red) MessageBox.Show("Game over");
            }
            if (b0_0.Text == "0")
            {
                free_right(0, 0);
                free_down(0, 0);
                free_left(0, 0);
                free_up(0, 0);
            }
        }

        private void b1_0_Click(object sender, EventArgs e)
        {
            if (b1_0.Text != "P")
            {

                xx = 1;
                yy = 0;
                b1_0.Text = bomb[xx, yy].ToString();
                if (b1_0.Text == "-1") b1_0.BackColor = Color.Red;
                else b1_0.BackColor = Color.White;
                if (b1_0.BackColor == Color.Red) MessageBox.Show("Game over");
            }

            if (b1_0.Text == "0")
            {
                free_right(1, 0);
                free_down(1, 0);
                free_left(1, 0);
                free_up(1, 0);
            }
        }

        private void b2_0_Click(object sender, EventArgs e)
        {
            if (b2_0.Text != "P")
            {

                xx = 2;
                yy = 0;
                b2_0.Text = bomb[xx, yy].ToString();

                if (b2_0.Text == "-1") b2_0.BackColor = Color.Red;
                else b2_0.BackColor = Color.White;

                if (b2_0.BackColor == Color.Red) MessageBox.Show("Game over");
            }
            if (b2_0.Text == "0")
            {
                free_right(2, 0);
                free_down(2, 0);
                free_left(2, 0);
                free_up(2, 0);
            }
        }

        private void b3_0_Click(object sender, EventArgs e)
        {
            if (b3_0.Text != "P")
            {

                xx = 3;
                yy = 0;
                b3_0.Text = bomb[xx, yy].ToString();
                if (b3_0.Text == "-1") b3_0.BackColor = Color.Red;
                else b3_0.BackColor = Color.White;

                if (b3_0.BackColor == Color.Red) MessageBox.Show("Game over");
            }
            if (b3_0.Text == "0")
            {
                free_right(3, 0);
                free_down(3, 0);
                free_left(3, 0);
                free_up(3, 0);
            }
        }

        private void b4_0_Click(object sender, EventArgs e)
        {
            if (b4_0.Text != "P")
            {

                xx = 4;
                yy = 0;
                b4_0.Text = bomb[xx, yy].ToString();

                if (b4_0.Text == "-1") b4_0.BackColor = Color.Red;
                else b4_0.BackColor = Color.White;

                if (b4_0.BackColor == Color.Red) MessageBox.Show("Game over");
            }
            if (b4_0.Text == "0")
            {
                free_right(4, 0);
                free_down(4, 0);
                free_left(4, 0);
                free_up(4, 0);
            }
        }

        private void b0_1_Click(object sender, EventArgs e)
        {
            if (b0_1.Text != "P")
            {

                xx = 0;
                yy = 1;
                b0_1.Text = bomb[xx, yy].ToString();

                if (b0_1.Text == "-1") b0_1.BackColor = Color.Red;
                else b0_1.BackColor = Color.White;
            }
            if (b0_1.Text == "0")
            {
                free_right(0, 1);
                free_down(0, 1);
                free_left(0, 1);
                free_up(0, 1);
            }
        }

        private void b1_1_Click(object sender, EventArgs e)
        {
            if (b1_1.Text != "P")
            {

                xx = 1;
                yy = 1;
                b1_1.Text = bomb[xx, yy].ToString();

                if (b1_1.Text == "-1") b1_1.BackColor = Color.Red;
                else b1_1.BackColor = Color.White;
                if (b1_1.BackColor == Color.Red) MessageBox.Show("Game over");
            }
            if (b1_1.Text == "0")
            {
                free_right(1, 1);
                free_down(1, 1);
                free_left(1, 1);
                free_up(1, 1);
            }
        }

        private void b2_1_Click(object sender, EventArgs e)
        {
            if (b2_1.Text != "P")
            {

                xx = 2;
                yy = 1;
                b2_1.Text = bomb[xx, yy].ToString();

                if (b2_1.Text == "-1") b2_1.BackColor = Color.Red;
                else b2_1.BackColor = Color.White;
                if (b2_1.BackColor == Color.Red) MessageBox.Show("Game over");
            }

            if (b2_1.Text == "0")
            {
                free_right(2, 1);
                free_down(2, 1);
                free_left(2, 1);
                free_up(2, 1);
            }
        }

        private void b3_1_Click(object sender, EventArgs e)
        {
            if (b3_1.Text != "P")
            {

                xx = 3;
                yy = 1;
                b3_1.Text = bomb[xx, yy].ToString();

                if (b3_1.Text == "-1") b3_1.BackColor = Color.Red;
                else b3_1.BackColor = Color.White;

                if (b3_1.BackColor == Color.Red) MessageBox.Show("Game over");
            }

            if (b3_1.Text == "0")
            {
                free_right(3, 1);
                free_down(3, 1);
                free_left(3, 1);
                free_up(3, 1);
            }
        }

        private void b4_1_Click(object sender, EventArgs e)
        {
            if (b4_1.Text != "P")
            {

                xx = 4;
                yy = 1;
                b4_1.Text = bomb[xx, yy].ToString();

                if (b4_1.Text == "-1") b4_1.BackColor = Color.Red;
                else b4_1.BackColor = Color.White;

                if (b4_1.BackColor == Color.Red) MessageBox.Show("Game over");
            }

            if (b4_1.Text == "0")
            {
                free_right(4, 1);
                free_down(4, 1);
                free_left(4, 1);
                free_up(4, 1);
            }
        }

        private void b0_2_Click(object sender, EventArgs e)
        {
            if (b0_2.Text != "P")
            {

                xx = 0;
                yy = 2;
                b0_2.Text = bomb[xx, yy].ToString();

                if (b0_2.Text == "-1") b0_2.BackColor = Color.Red;
                else b0_2.BackColor = Color.White;

                if (b0_2.BackColor == Color.Red) MessageBox.Show("Game over");
            }

            if (b0_2.Text == "0")
            {
                free_right(0, 2);
                free_down(0, 2);
                free_left(0, 2);
                free_up(0, 2);
            }
        }

        private void b1_2_Click(object sender, EventArgs e)
        {
            if (b1_2.Text != "P")
            {

                xx = 1;
                yy = 2;
                b1_2.Text = bomb[xx, yy].ToString();

                if (b1_2.Text == "-1") b2_0.BackColor = Color.Red;
                else b1_2.BackColor = Color.White;

                if (b1_2.BackColor == Color.Red) MessageBox.Show("Game over");
            }

            if (b1_2.Text == "0")
            {
                free_right(1, 2);
                free_down(1, 2);
                free_left(1, 2);
                free_up(1, 2);
            }
        }

        private void b2_2_Click(object sender, EventArgs e)
        {
            if (b2_2.Text != "P")
            {

                xx = 2;
                yy = 2;
                b2_2.Text = bomb[xx, yy].ToString();

                if (b2_2.Text == "-1") b2_2.BackColor = Color.Red;
                else b2_2.BackColor = Color.White;

                if (b2_2.BackColor == Color.Red) MessageBox.Show("Game over");
            }

            if (b2_2.Text == "0")
            {
                free_right(2, 2);
                free_down(2, 2);
                free_left(2, 2);
                free_up(2, 2);
            }
        }

        private void b3_2_Click(object sender, EventArgs e)
        {
            xx = 3;
            yy = 2;
            b3_2.Text = bomb[xx, yy].ToString();

            if (b3_2.Text == "-1") b3_2.BackColor = Color.Red;
            else b3_2.BackColor = Color.White;

            if (b3_2.BackColor == Color.Red) MessageBox.Show("Game over");

            if (b3_2.Text == "0")
            {
                free_right(3, 2);
                free_down(3, 2);
                free_left(3, 2);
                free_up(3, 2);
            }
        }

        private void b4_2_Click(object sender, EventArgs e)
        {
            xx = 4;
            yy = 2;
            b4_2.Text = bomb[xx, yy].ToString();

            if (b4_2.Text == "-1") b4_2.BackColor = Color.Red;
            else b4_2.BackColor = Color.White;

            if (b4_2.BackColor == Color.Red) MessageBox.Show("Game over");

            if (b4_2.Text == "0")
            {
                free_right(4, 2);
                free_down(4, 2);
                free_left(4, 2);
                free_up(4, 2);
            }
        }

        private void b0_3_Click(object sender, EventArgs e)
        {
            if (b0_3.Text != "P")
            {

                xx = 0;
                yy = 3;
                b0_3.Text = bomb[xx, yy].ToString();


                if (b0_3.Text == "-1") b0_3.BackColor = Color.Red;
                else b0_3.BackColor = Color.White;

                if (b0_3.BackColor == Color.Red) MessageBox.Show("Game over");
            }

            if (b0_3.Text == "0")
            {
                free_right(0, 3);
                free_down(0, 3);
                free_left(0, 3);
                free_up(0, 3);
            }
        }

        private void b1_3_Click(object sender, EventArgs e)
        {
            if (b1_3.Text != "P")
            {

                xx = 1;
                yy = 3;
                b1_3.Text = bomb[xx, yy].ToString();


                if (b1_3.Text == "-1") b1_3.BackColor = Color.Red;
                else b1_3.BackColor = Color.White;

                if (b1_3.BackColor == Color.Red) MessageBox.Show("Game over");
            }

            if (b1_3.Text == "0")
            {
                free_right(1, 3);
                free_down(1, 3);
                free_left(1, 3);
                free_up(1, 3);
            }
        }

        private void b2_3_Click(object sender, EventArgs e)
        {
            if (b2_3.Text != "P")
            {

                xx = 2;
                yy = 3;
                b2_3.Text = bomb[xx, yy].ToString();


                if (b2_3.Text == "-1") b2_3.BackColor = Color.Red;
                else b2_3.BackColor = Color.White;

                if (b2_3.BackColor == Color.Red) MessageBox.Show("Game over");
            }

            if (b2_3.Text == "0")
            {
                free_right(2, 3);
                free_down(2, 3);
                free_left(2, 3);
                free_up(2, 3);
            }
        }

        private void b3_3_Click(object sender, EventArgs e)
        {
            if (b3_3.Text != "P")
            {

                xx = 3;
                yy = 3;
                b3_3.Text = bomb[xx, yy].ToString();


                if (b3_3.Text == "-1") b3_3.BackColor = Color.Red;
                else b3_3.BackColor = Color.White;

                if (b3_3.BackColor == Color.Red) MessageBox.Show("Game over");
            }

            if (b3_3.Text == "0")
            {
                free_right(3, 3);
                free_down(3, 3);
                free_left(3, 3);
                free_up(3, 3);
            }
        }

        private void b4_3_Click(object sender, EventArgs e)
        {
            xx = 4;
            yy = 3;
            b4_3.Text = bomb[xx, yy].ToString();
            if (b4_3.Text == "-1") b4_3.BackColor = Color.Red;
            else b4_3.BackColor = Color.White;

        }

        private void b0_4_Click(object sender, EventArgs e)
        {

            if (b0_4.Text != "P")
            {
                xx = 0;
                yy = 4;
                b0_4.Text = bomb[xx, yy].ToString();
                if (b0_4.Text == "-1") b0_4.BackColor = Color.Red;
                else b0_4.BackColor = Color.White;

                if (b0_4.BackColor == Color.Red) MessageBox.Show("Game over");
            }


            if (b0_4.Text == "0")
            {
                free_right(0, 4);
                free_down(0, 4);
                free_left(0, 4);
                free_up(0, 4);
            }
        }

        private void b1_4_Click(object sender, EventArgs e)
        {
            if (b1_4.Text != "P")
            {

                xx = 0;
                yy = 0;
                b1_4.Text = bomb[xx, yy].ToString();

                if (b1_4.Text == "-1") b1_4.BackColor = Color.Red;
                else b1_4.BackColor = Color.White;

                if (b1_4.BackColor == Color.Red) MessageBox.Show("Game over");
            }


            if (b1_4.Text == "0")
            {
                free_right(1, 4);
                free_down(1, 4);
                free_left(1, 4);
                free_up(1, 4);
            }
        }

        private void b2_4_Click(object sender, EventArgs e)
        {
            if (b2_4.Text != "P")
            {

                xx = 2;
                yy = 4;
                b2_4.Text = bomb[xx, yy].ToString();


                if (b2_4.Text == "-1") b2_4.BackColor = Color.Red;
                else b2_4.BackColor = Color.White;

                if (b2_4.BackColor == Color.Red) MessageBox.Show("Game over");
            }


            if (b2_4.Text == "0")
            {
                free_right(2, 4);
                free_down(2, 4);
                free_left(2, 4);
                free_up(2, 4);
            }
        }

        private void b3_4_Click(object sender, EventArgs e)
        {
            if (b3_4.Text != "P")
            {

                if (b3_4.Text != "P")
                {

                    xx = 3;
                    yy = 4;
                    b3_4.Text = bomb[xx, yy].ToString();


                    if (b3_4.Text == "-1") b3_4.BackColor = Color.Red;
                    else b3_4.BackColor = Color.White;
                    if (b3_4.BackColor == Color.Red) MessageBox.Show("Game over");
                }
            }


            if (b3_4.Text == "0")
            {
                free_right(3, 4);
                free_down(3, 4);
                free_left(3, 4);
                free_up(3, 4);
            }
        }

        private void b4_4_Click(object sender, EventArgs e)
        {

            if (b4_4.Text != "P")
            {

                xx = 4;
                yy = 4;
                b4_4.Text = bomb[xx, yy].ToString();


                if (b4_4.Text == "-1") b4_4.BackColor = Color.Red;
                else b4_4.BackColor = Color.White;
                if (b4_4.BackColor == Color.Red) MessageBox.Show("Game over");
            }


            if (b4_4.Text == "0")
            {
                free_right(4, 4);
                free_down(4, 4);
                free_left(4, 4);
                free_up(4, 4);
            }
        }


        private void b4_0_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (b4_0.Text == "") b4_0.Text = "P";
                else b4_0.Text = "";
            }
        }

        private void b0_0_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (b0_0.Text == "") b0_0.Text = "P";
                else b0_0.Text = "";
            }

        }

        private void b1_0_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (b1_0.Text == "") b1_0.Text = "P";
                else b1_0.Text = "";
            }
        }

        private void b2_0_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void b3_0_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (b3_0.Text == "") b3_0.Text = "P";
                else b3_0.Text = "";
            }
        }

        private void b4_1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (b4_1.Text == "") b4_1.Text = "P";
                else b4_1.Text = "";
            }
        }

        private void b3_1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (b3_1.Text == "") b3_1.Text = "P";
                else b3_1.Text = "";
            }
        }

        private void b2_1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (b2_1.Text == "") b2_0.Text = "P";
                else b1_1.Text = "";
            }
        }

        private void b1_1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (b1_1.Text == "") b1_1.Text = "P";
                else b1_1.Text = "";
            }
        }

        private void b0_1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (b0_1.Text == "") b0_1.Text = "P";
                else b0_1.Text = "";
            }
        }

        private void b0_2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (b0_2.Text == "") b0_2.Text = "P";
                else b0_2.Text = "";
            }
        }

        private void b1_2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (b1_2.Text == "") b1_2.Text = "P";
                else b1_2.Text = "";
            }
        }

        private void b0_3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (b0_3.Text == "") b0_3.Text = "P";
                else b0_3.Text = "";
            }
        }

        private void b1_3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (b1_3.Text == "") b1_3.Text = "P";
                else b1_3.Text = "";
            }
        }

        private void b2_3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (b2_3.Text == "") b2_3.Text = "P";
                else b2_3.Text = "";
            }
        }

        private void b3_3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (b3_3.Text == "") b3_3.Text = "P";
                else b3_3.Text = "";
            }
        }

        private void b4_3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (b4_3.Text == "") b4_3.Text = "P";
                else b4_3.Text = "";
            }
        }

        private void b0_4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (b0_4.Text == "") b0_4.Text = "P";
                else b0_4.Text = "";
            }
        }

        private void b1_4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (b1_4.Text == "") b1_4.Text = "P";
                else b1_4.Text = "";
            }
        }

        private void b2_4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (b2_4.Text == "") b2_4.Text = "P";
                else b2_4.Text = "";
            }
        }

        private void b3_4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (b3_4.Text == "") b3_4.Text = "P";
                else b3_4.Text = "";
            }
        }

        private void b4_4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (b4_4.Text == "") b4_4.Text = "P";
                else b4_4.Text = "";
            }
        }

        private void b4_3_Click_1(object sender, EventArgs e)
        {
            if (b4_3.Text != "P")
            {

                xx = 4;
                yy = 3;
                b4_3.Text = bomb[xx, yy].ToString();

                if (b4_3.Text == "-1") b4_3.BackColor = Color.Red;
                else b4_3.BackColor = Color.White;

                if (b4_3.BackColor == Color.Red) MessageBox.Show("Game over");
            }

            if (b4_3.Text == "0")
            {
                free_right(4, 3);
                free_down(4, 3);
                free_left(4, 3);
                free_up(4, 3);
            }
        }

        private void b4_2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (b4_2.Text == "") b4_2.Text = "P";
                else b4_2.Text = "";
            }
        }

        private void b2_0_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (b2_0.Text == "") b2_0.Text = "P";
                else b2_0.Text = "";
            }   
        }

        private void b2_2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (b2_2.Text == "") b2_2.Text = "P";
                else b2_2.Text = "";
            }
        }


        //Color display(int x, int y)
        //{

        //    return null;
        //}

        //Color display(int x, int y)
        //{
        //    Color c = (b[x, y] == true ? Color.Red : Color.White);
        //    if (b[x, y] == false)
        //    {


        //        while ((b[x, y] == false) && (x <= 4))
        //        {

        //            string n = "b" + x + "_" + y;
        //            foreach (Button b1 in this.Controls)
        //            {
        //                if (b1.Name == n) b1.BackColor = Color.White;

        //            }
        //            if (x == 4) break;
        //            else
        //            {
        //                ++x;
        //                if (x <= 4) display(x, y);
        //            }
        //        }
        //        x = base_x;
        //        y = base_y;

        //        while ((b[x, y] == false) && (x >= 0))
        //        {

        //            string n = "b" + x + "_" + y;
        //            foreach (Button b1 in this.Controls)
        //            {
        //                if (b1.Name == n) b1.BackColor = Color.White;

        //            }
        //            if (x == 0) break;
        //              else
        //            {
        //                --x;
        //                if (x >= 0) display(x, y);
        //            }
        //        }

        //        x = base_x;
        //        y = base_y;
        //        while ((b[x, y] == false) && (y <= 4))
        //        {
        //            if (b[x, y] != true)
        //                b[x, y] = false;

        //            string n = "b" + x + "_" + y;
        //            foreach (Button b1 in this.Controls)
        //            {
        //                if (b1.Name == n) b1.BackColor = Color.White;

        //            }
        //            if (y == 4) break;
        //            else
        //            {
        //                ++y;
        //                if (y <= 4) display(x, y);
        //            }

        //        }

        //        x = base_x;
        //        y = base_y;
        //        while ((b[x, y] == false) && (y >= 0))
        //        {
        //            if (b[x, y] != true)
        //                b[x, y] = false;
        //            string n = "b" + x + "_" + y;
        //            foreach (Button b1 in this.Controls)
        //            {
        //                if (b1.Name == n) b1.BackColor = Color.White;

        //            }
        //            if (y == 0) break;
        //            else --y;

        //        }
        //    }

        //    return (c);

        //}
        //bool r_x = true, l_x = true, t_y = true, b_y = true;
        //Color display(int x, int y)
        //{
        //    int base_x = x;
        //    int base_y = y;

        //    Color c = (b[x, y] == true ? Color.Red : Color.White);
        //    if ((x <= 4) && r_x)
        //    {
        //        if (x != 4) ++x;
        //        else r_x = false;
        //        if (c == Color.White)
        //            display(x, y);

        //    }

        //x = base_x;
        //y = base_y;

        //if ((x >= 0) && l_x)
        //{
        //    if (x != 0) --x;
        //    else l_x = false;
        //    if (c == Color.White)
        //        display(x, y);
        //}

        //x = base_x;
        //y = base_y;

        //if ((y <= 4) && b_y)
        //{
        //    if (y != 4) ++y;
        //    else b_y = false;
        //    if (c == Color.White)
        //        display(x, y);
        //}
        //x = base_x;
        //y = base_y;

        //--y;
        //if ((y >= 0) && t_y)
        //{
        //    if (y != 0) --x;
        //    else t_y = false;

        //    if (c == Color.White)
        //        display(x, y);
        //}

        //    return c;
        //}

        //void set_color()
        //{

        //    for (int i = 0; i < 5; i++)
        //    {
        //        for (int j = 0; j < 5; j++)
        //        {
        //            string st = "b" + i + "_" + j;

        //            if (b[i, j] == true)
        //            {


        //                foreach (Button c in this.Controls)
        //                {
        //                        if (c.Name == st) c.BackColor = Color.Red;

        //                }
        //            }
        //            else
        //            {


        //                foreach (Button c in this.Controls)
        //                {
        //                    try
        //                    {
        //                        if ((c).Name == st) c.BackColor = Color.Red;
        //                    }
        //                    catch { }
        //                }
        //            }

        //        }
        //    }


        //}
        //private void button3_Click(object sender, EventArgs e)
        //{

        //}

    }
}