using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 推箱子
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && panel1.GetChildAtPoint(new Point(button1.Location.X, button1.Location.Y - 74)) != null)
            {
                Control c1 = panel1.GetChildAtPoint(new Point(button1.Location.X, button1.Location.Y - 74));
                if (c1.GetType().ToString() == "System.Windows.Forms.Button")//判断面前是否是箱子
                {
                    Control c2 = panel1.GetChildAtPoint(new Point(button1.Location.X, button1.Location.Y - 148));
                    if (c2 != null && c2.GetType().ToString() != "System.Windows.Forms.Button")//禁止推多个箱子
                    {
                        c1.Location = new Point(button1.Location.X, button1.Location.Y - 148);
                    }
                    else//防止角色穿进箱子
                    {
                        return;
                    }
                }
                button1.Location = new Point(button1.Location.X, button1.Location.Y - 74);
            }
            else if (e.KeyCode == Keys.Down && panel1.GetChildAtPoint(new Point(button1.Location.X, button1.Location.Y + 74)) != null)
            {
                Control c1 = panel1.GetChildAtPoint(new Point(button1.Location.X, button1.Location.Y + 74));
                if (c1.GetType().ToString() == "System.Windows.Forms.Button")//判断面前是否是箱子
                {
                    Control c2 = panel1.GetChildAtPoint(new Point(button1.Location.X, button1.Location.Y + 148));
                    if (c2 != null && c2.GetType().ToString() != "System.Windows.Forms.Button")//禁止推多个箱子
                    {
                        c1.Location = new Point(button1.Location.X, button1.Location.Y + 148);
                    }
                    else//防止角色穿进箱子
                    {
                        return;
                    }
                }
                button1.Location = new Point(button1.Location.X, button1.Location.Y + 74);
            }
            else if (e.KeyCode == Keys.Left && panel1.GetChildAtPoint(new Point(button1.Location.X - 74, button1.Location.Y)) != null)
            {
                Control c1 = panel1.GetChildAtPoint(new Point(button1.Location.X - 74, button1.Location.Y));
                if (c1.GetType().ToString() == "System.Windows.Forms.Button")//判断面前是否是箱子
                {
                    Control c2 = panel1.GetChildAtPoint(new Point(button1.Location.X - 148, button1.Location.Y));
                    if (c2 != null && c2.GetType().ToString() != "System.Windows.Forms.Button")//禁止推多个箱子
                    {
                        c1.Location = new Point(button1.Location.X - 148, button1.Location.Y);
                    }
                    else//防止角色穿进箱子
                    {
                        return;
                    }
                }
                button1.Location = new Point(button1.Location.X - 74, button1.Location.Y);
            }
            else if (e.KeyCode == Keys.Right && panel1.GetChildAtPoint(new Point(button1.Location.X + 74, button1.Location.Y)) != null)
            {
                Control c1 = panel1.GetChildAtPoint(new Point(button1.Location.X + 74, button1.Location.Y));
                if (c1.GetType().ToString() == "System.Windows.Forms.Button")//判断面前是否是箱子
                {
                    Control c2 = panel1.GetChildAtPoint(new Point(button1.Location.X + 148, button1.Location.Y));
                    if (c2 != null && c2.GetType().ToString() != "System.Windows.Forms.Button")//禁止推多个箱子
                    {
                        c1.Location = new Point(button1.Location.X + 148, button1.Location.Y);
                    }
                    else//防止角色穿进箱子
                    {
                        return;
                    }
                }
                button1.Location = new Point(button1.Location.X + 74, button1.Location.Y);
            }
            if (button2.Location == pictureBox3.Location && button3.Location == pictureBox5.Location && button4.Location == pictureBox4.Location && button5.Location == pictureBox10.Location)
            {
                MessageBox.Show("恭喜通关！您就是最强大脑！");
            }
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            return false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
