using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ahihi
{
    public partial class Form1 : Form
    {
        WMPLib.WindowsMediaPlayer music = new WMPLib.WindowsMediaPlayer();

        Random rand = new Random();
        int x, y, a, b;
        public Form1()
        {
            music.URL = "CMBELN_01.mp3";
            music.controls.play();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            if (music.status == "Paused" || music.status == "Stoped") music.controls.play();
            x = rand.Next(0, 360);
            y = rand.Next(0, 360);
            button2.Location = new Point(x, y);
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            label1.Visible = true;
            label1.Text = "Nào, gì đấy :((";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (music.status == "Paused" || music.status == "Stoped") music.controls.play();
            a = Cursor.Position.X + 3;
            b = Cursor.Position.Y + 3;
            if (button2.Location.X == a || button2.Location.Y == b)
            {
                x = rand.Next(0, 360);
                y = rand.Next(0, 360);
                button2.Location = new Point(x, y);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (music.status == "Paused" || music.status == "Stoped") music.controls.play();
            x = rand.Next(0, 360);
            y = rand.Next(0, 360);
            button2.Location = new Point(x, y);
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            label1.Visible = true;
            label1.Text = "Nào, gì đấy :((";
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            if (music.status == "Paused" || music.status == "Stoped") music.controls.play();
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
            label1.Visible = true;
            label1.Text = "Đấy, nút đó đấy :))";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (music.status == "Paused" || music.status == "Stoped") music.controls.play();
            MessageBox.Show("Gọi cho anh luôn nhé: 0334704530 =))", "Anh cũng thế!!!");
        }
    }
}
