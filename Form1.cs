using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDCNEW
{
    public partial class Form1 : Form
    {
        //分頁宣告
        UserControl1 A1 = new UserControl1();
        UserControl2 A2 = new UserControl2();
        UserControl3 A3 = new UserControl3();
        MainPage akou = new MainPage();
        //視窗移動
        bool drag = false;
        Point start_point = new Point(0, 0);

        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;

            if (!MainPanel.Controls.Contains(A1))
            {
                MainPanel.Controls.Add(A1);
                A1.Dock = DockStyle.Fill;
                A1.BringToFront();
            }
            else
            {
                A1.BringToFront();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;

            if (!MainPanel.Controls.Contains(A2))
            {
                MainPanel.Controls.Add(A2);
                A2.Dock = DockStyle.Fill;
                A2.BringToFront();
            }
            else
            {
                A2.BringToFront();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;

            if (!MainPanel.Controls.Contains(A3))
            {
                MainPanel.Controls.Add(A3);
                A3.Dock = DockStyle.Fill;
                A3.BringToFront();
            }
            else
            {
                A3.BringToFront();
            }
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!MainPanel.Controls.Contains(akou))
            {
                MainPanel.Controls.Add(akou);
                akou.Dock = DockStyle.Fill;
                akou.BringToFront();
            }
            else
            {
                akou.BringToFront();
            }
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void TOP_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point=new Point(e.X, e.Y);

        }

        private void TOP_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);

            }
        }

        private void TOP_MouseUp(object sender, MouseEventArgs e)
        {
            drag =false;

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!MainPanel.Controls.Contains(akou))
            {
                MainPanel.Controls.Add(akou);
                akou.Dock = DockStyle.Fill;
                akou.BringToFront();
            }
            else
            {
                akou.BringToFront();
            }
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);

            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);

            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void TOP_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
