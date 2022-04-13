using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Game : Form
    {
        public Game(Form1 parent, MODE mode, int size, SIDE side, DIFFICULTY diff)
        {
            InitializeComponent();
            this.parent = parent;
            this.mode = mode;
            this.size = size;
            this.diff = diff;
            this.currentFieldState = new int[size, size];
            this.player = new Player { side = side, makingTurn = side == SIDE.CROSSES, score = 0};
            this.opponent = new Player { side = side == SIDE.CROSSES ? SIDE.ZEROES : SIDE.CROSSES, makingTurn = side == SIDE.ZEROES, score = 0 };
            this.signs = new string[2] { "X", "O" };
        }

        private Form1 parent;
        private MODE mode;
        private DIFFICULTY diff;
        private int size;
        private bool DRAGGING = false;
        private Point startPos = new Point(0, 0);
        private int[,] currentFieldState;
        private Player player, opponent;
        private string[] signs;
        private List<Button> buttons;

        public enum MODE
        {
            PvP,
            PvE
        }

        public enum SIDE
        {
            CROSSES = 1,
            ZEROES = 2
        }

        public enum DIFFICULTY
        {
            EASY,
            MEDIUM,
            HARD
        }

        private void label_MouseEnter(object sender, EventArgs e)
        {
            (sender as Label).ForeColor = Color.FromArgb(237, 183, 33);
        }

        private void label_MouseLeave(object sender, EventArgs e)
        {
            (sender as Label).ForeColor = SystemColors.ButtonFace;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.parent.Show();
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

        private void Game_Load(object sender, EventArgs e)
        {
            int MARGIN;
            switch (this.size)
            {
                case 3:
                    MARGIN = 5;
                    break;
                case 4:
                    MARGIN = 4;
                    break;
                case 5:
                    MARGIN = 3;
                    break;
                default:
                    MARGIN = 0;
                    break;
            }
            int BLOCKSIZE = (320 - MARGIN * (this.size - 1) * 2) / this.size;

            this.buttons = new List<Button>();
            for (int row = 0; row < this.size; row++)
            {
                int x = 5;
                int y = 5 + BLOCKSIZE * row + MARGIN * row * 2;
                for (int col = 0; col < this.size; col++)
                {
                    var but = createButton(BLOCKSIZE);
                    but.Location = new Point(x, y);
                    but.Name = $"item_{row}_{col}";
                    buttons.Add(but);
                    x += BLOCKSIZE + MARGIN * 2;
                }
            }
        }

        private Button createButton(int size)
        {
            Button b = new Button();
            b.FlatStyle = FlatStyle.Flat;
            b.BackColor = Color.FromArgb(237, 183, 33);
            b.Cursor = Cursors.Hand;
            b.Click += playerMove;
            b.Size = new Size(size, size);
            b.FlatAppearance.BorderSize = 0;
            b.Font = new Font("Fira Code", size == 100 ? 48 : size == 74 ? 36 : 28);
            b.Parent = gamefield;
            return b;
        }

        private void playerMove(object sender, EventArgs e)
        {
            bool makeMove = true;
            var cell = sender as Button;
            int[] indices = getIndices(cell.Name);
            if (mode == MODE.PvE && !player.makingTurn || currentFieldState[indices[0], indices[1]] != 0)
                makeMove = false;
            if (makeMove)
            {
                int match = player.makingTurn ? (int)player.side : (int)opponent.side;
                cell.Text = player.makingTurn ? this.signs[match - 1] : this.signs[match - 1];
                currentFieldState[indices[0], indices[1]] = match;
                player.makingTurn = !player.makingTurn;
                opponent.makingTurn = !opponent.makingTurn;
                bool result = checkForWin(currentFieldState, match);
                if (result)
                {
                    nextround.Visible = true;
                    if (match == 1)
                    {
                        player.score++;
                        player1_score.Text = "Игрок1: " + player.score.ToString();
                        MessageBox.Show("Победил Игрок1!", "Победа!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        if (player.score == 3)
                        {
                            MessageBox.Show("Игрок1 выиграл по очкам!", "Конец", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                            parent.Show();
                        }
                    }
                    else
                    {
                        opponent.score++;
                        player2_score.Text = "Игрок2: " + opponent.score.ToString();
                        MessageBox.Show("Победил Игрок2!", "Победа!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        if (opponent.score == 3)
                        {
                            MessageBox.Show("Игрок2 выиграл по очкам!", "Конец", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                            parent.Show();
                        }
                    }
                }
                else
                {
                    if (emptyIndices(currentFieldState).Count == 0)
                    {
                        nextround.Visible = true;
                        MessageBox.Show("Ничья!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        if (mode == MODE.PvE)
                        {
                            botMove();
                        }
                }
            }
        }

        private void botMove()
        {
            Move move = minimax(currentFieldState, 2, 1);
            var b = gamefield.Controls.Find($"item_{move.indices[0]}_{move.indices[1]}", false)[0] as Button;
            int match = (int)opponent.side;
            b.Text = this.signs[match - 1];
            currentFieldState[move.indices[0], move.indices[1]] = match;
            if (emptyIndices(currentFieldState).Count == 0)
            {
                nextround.Visible = true;
                MessageBox.Show("Ничья!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool result = checkForWin(currentFieldState, match);
                if (result)
                {
                    opponent.score++;
                    player2_score.Text = "Игрок2: " + opponent.score.ToString();
                    MessageBox.Show("Победил Игрок2!", "Победа!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (opponent.score == 3)
                    {
                        MessageBox.Show("Игрок2 выиграл по очкам!", "Конец", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                        parent.Show();
                    }
                }
                player.makingTurn = !player.makingTurn;
                opponent.makingTurn = !opponent.makingTurn;
            }
        }

        private List<int[]> emptyIndices(int[,] board)
        {
            var lst = new List<int[]>();
            for (int row = 0; row < this.size; row++)
            {
                for (int col = 0; col < this.size; col++)
                {
                    if (board[row, col] == 0)
                        lst.Add(new int[] { row, col });
                }
            }
            return lst;
        }

        struct Move
        {
            public int[] indices;
            public int score;
        }

        private Move minimax(int[,] board, int match, int depth)
        {
            var available = emptyIndices(board);

            if (checkForWin(board, 1))
                return new Move { indices = new int[] { -1, -1 }, score = -100 };
            else if (checkForWin(board, 2))
                return new Move { indices = new int[] { -1, -1 }, score = 100 };
            else if (available.Count == 0)
                return new Move { indices = new int[] { -1, -1 }, score = 0 }; ;

            List<Move> moves = new List<Move>();
            for (int i = 0; i < available.Count; i++)
            {
                Move move = new Move { indices = available[i] };
                board[move.indices[0], move.indices[1]] = match;

                if (match == 1)
                {
                    var result = minimax(board, 2, depth + 1);
                    move.score = result.score;
                }
                else
                {
                    var result = minimax(board, 1, depth + 1);
                    move.score = result.score;
                }

                board[move.indices[0], move.indices[1]] = 0;
                moves.Add(move);
            }

            int bestMove = 0;
            if (match == 2)
            {
                int bestScore = -10000;
                for (int i = 0; i < moves.Count; i++)
                    if(moves[i].score > bestScore)
                    {
                        bestScore = moves[i].score;
                        bestMove = i;
                    }
            }
            else
            {
                int bestScore = 10000;
                for (int i = 0; i < moves.Count; i++)
                    if (moves[i].score < bestScore)
                    {
                        bestScore = moves[i].score;
                        bestMove = i;
                    }
            }
            if (depth == 1 && moves.Count > 1)
            {
                List<int> directions = new List<int>() { -1, 1 };
                if (bestMove == 0)
                    directions.RemoveAt(0);
                if (bestMove == moves.Count - 1)
                    directions.RemoveAt(1);
                Random rand = new Random();
                int roll = rand.Next(0, 10);
                Action makeRoll = () =>
                {
                    System.Threading.Thread.Sleep(20);
                    int dir = rand.Next(0, directions.Count);
                    bestMove += directions[dir];
                };
                switch (diff)
                {
                    case DIFFICULTY.EASY:
                        if (roll > 3)
                            makeRoll();
                        break;
                    case DIFFICULTY.MEDIUM:
                        if (roll > 6)
                            makeRoll();
                        break;
                    default:
                        if (roll > 8)
                            makeRoll();
                        break;
                }
            }
            return moves[bestMove];
        }

        private int[] getIndices(string name)
        {
            int first = name.IndexOf("_") + 1,
                second = name.LastIndexOf("_") + 1;
            return new int[] { int.Parse(name[first].ToString()), int.Parse(name[second].ToString()) };
        }

        private bool checkForWin(int[,] board, int match)
        {
            int scoreToWin = size > 4 ? 4 : 3;
            bool won = false;

            // check for rows
            int score = 0;
            for (int row = 0; row < this.size && !won; row++)
            {
                score = 0;
                for (int col = 0; col < this.size && !won; col++)
                {
                    if (board[row, col] == match)
                        score++;
                    else
                        score = 0;
                    if (score == scoreToWin)
                        won = true;
                }
            }
            if (won)
                return true;

            // check for cols
            score = 0;
            for (int col = 0; col < this.size && !won; col++)
            {
                score = 0;
                for (int row = 0; row < this.size && !won; row++)
                {
                    if (board[row, col] == match)
                        score++;
                    else
                        score = 0;
                    if (score == scoreToWin)
                        won = true;
                }
            }
            if (won)
                return true;

            // check main diagonal
            score = 0;
            for (int ind = 0; ind < this.size && !won; ind++)
            {
                
                if (board[ind, ind] == match)
                    score++;
                else
                    score = 0;
                if (score == scoreToWin)
                    won = true;
            }
            if (won)
                return true;

            // check secondary diagonal
            score = 0;
            for (int ind = 0; ind < this.size && !won; ind++)
            {
                if (board[ind, this.size - 1 - ind] == match)
                    score++;
                else
                    score = 0;
                if (score == scoreToWin)
                    won = true;
            }
            if (won)
                return true;

            if (size > 3)
            {
                // check other diagonales

                // main ones
                score = 0;
                for (int ind = 0; ind < this.size - 1 && !won; ind++)
                {
                    if (board[ind, ind + 1] == match)
                        score++;
                    else
                        score = 0;
                    if (score == scoreToWin)
                        won = true;
                }
                if (won)
                    return true;

                score = 0;
                for (int ind = 0; ind < this.size - 1 && !won; ind++)
                {
                    if (board[ind + 1, ind] == match)
                        score++;
                    else
                        score = 0;
                    if (score == scoreToWin)
                        won = true;
                }
                if (won)
                    return true;

                // secondary ones
                score = 0;
                for (int ind = 0; ind < this.size - 1 && !won; ind++)
                {
                    if (board[ind, this.size - 2 - ind] == match)
                        score++;
                    else
                        score = 0;
                    if (score == scoreToWin)
                        won = true;
                }
                if (won)
                    return true;

                score = 0;
                for (int ind = 0; ind < this.size - 1 && !won; ind++)
                {
                    if (board[ind + 1, this.size - 1 - ind] == match)
                        score++;
                    else
                        score = 0;
                    if (score == scoreToWin)
                        won = true;
                }
                if (won)
                    return true;
            }
            return false;
        }

        private void nextround_Click(object sender, EventArgs e)
        {
            foreach (var but in this.buttons)
                but.Text = "";
            this.currentFieldState = new int[size, size];
            player.makingTurn = true;
            opponent.makingTurn = false;
            nextround.Visible = false;
        }

        struct Player
        {
            public SIDE side;
            public bool makingTurn;
            public int score;
        }
    }
}
