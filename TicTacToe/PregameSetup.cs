using System;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class PregameSetup : Form
    {
        public PregameSetup(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.mode = Game.MODE.PvE;
            this.side = Game.SIDE.CROSSES;
            this.diff = Game.DIFFICULTY.EASY;
            size = 3;
        }

        private Form1 parent;
        private bool DRAGGING = false;
        private Point startPos = new Point(0, 0);
        private Game.MODE mode;
        private Game.SIDE side;
        private Game.DIFFICULTY diff;
        private int size;

        private void label_MouseEnter(object sender, EventArgs e)
        {
            (sender as Label).ForeColor = Color.FromArgb(237, 183, 33);
        }

        private void label_MouseLeave(object sender, EventArgs e)
        {
            (sender as Label).ForeColor = SystemColors.ButtonFace;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            parent.Show();
            Close();
        }

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            DRAGGING = true;
            startPos = e.Location;
        }

        private void panel_MouseUp(object sender, MouseEventArgs e)
        {
            DRAGGING = false;
        }

        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (DRAGGING)
            {
                Location = new Point(Location.X + (e.X - startPos.X), Location.Y + (e.Y - startPos.Y));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game f = new Game(this.parent, this.mode, this.size, Game.SIDE.CROSSES, this.diff);
            f.Show();
            Close();
        }

        private void regime_PvE_MouseClick(object sender, MouseEventArgs e)
        {
            this.mode = Game.MODE.PvE;
            delimeter_2.Visible = true;
            panel_difficulty.Visible = true;
            size_4x4.Visible = false;
            size_5x5.Visible = false;
            size_3x3.Checked = true;
            Size = new Size(Size.Width, 440);
            button1.Location = new Point(button1.Location.X, 390);
        } 

        private void regime_PvP_MouseClick(object sender, MouseEventArgs e)
        {
            this.mode = Game.MODE.PvP;
            delimeter_2.Visible = false;
            panel_difficulty.Visible = false;
            size_4x4.Visible = true;
            size_5x5.Visible = true;
            Size = new Size(Size.Width, 310);
            button1.Location = new Point(button1.Location.X, 260);
        }

        private void size_3x3_MouseClick(object sender, MouseEventArgs e) => this.size = 3;

        private void size_4x4_MouseClick(object sender, MouseEventArgs e) => this.size = 4;
      
        private void size_5x5_MouseClick(object sender, MouseEventArgs e) => this.size = 5;

        private void diffuculty_easy_MouseClick(object sender, MouseEventArgs e) => this.diff = Game.DIFFICULTY.EASY;

        private void difficulty_medium_MouseClick(object sender, MouseEventArgs e) => this.diff = Game.DIFFICULTY.MEDIUM;

        private void difficulty_hard_MouseClick(object sender, MouseEventArgs e) => this.diff = Game.DIFFICULTY.HARD;
    }
}
