using System;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool DRAGGING = false;
        private Point startPos = new Point(0, 0);

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            (sender as Label).ForeColor = Color.FromArgb(237, 183, 33);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            (sender as Label).ForeColor = SystemColors.ButtonFace;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            PregameSetup f = new PregameSetup(this);
            f.Show();
            Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            DRAGGING = true;
            startPos = e.Location;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            DRAGGING = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (DRAGGING)
            {
                Location = new Point(Location.X + (e.X - startPos.X), Location.Y + (e.Y - startPos.Y));
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
