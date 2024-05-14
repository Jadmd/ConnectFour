using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect_Four
{
    public partial class Form3 : Form
    {
        Rectangle[] boardColumns;
        int[,] board;
        int turn;
        int Counter = 0;
        public Form3()
        {
            InitializeComponent();
            this.boardColumns = new Rectangle[7];
            this.board = new int[6, 7];
            this.turn = 1;
        }

        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Blue, 24, 24, 340, 300);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (i == 0)
                    {
                        this.boardColumns[j] = new Rectangle(32 + 48 * j, 24, 32, 300);
                    }

                    e.Graphics.FillEllipse(Brushes.White, 32 + 48 * j, 32 + 48 * i, 32, 32);
                }
            }
        }

        private void Form3_MouseClick(object sender, MouseEventArgs e)
        {
            int ColumnIndext = this.ColumnNumber(e.Location);
            if (ColumnIndext != -1)
            {
                int rowIndext = EmptyRow(ColumnIndext);
                if (rowIndext != -1)
                {
                    this.board[rowIndext, ColumnIndext] = this.turn;
                    if (this.turn == 1)
                    {
                        Graphics g = this.CreateGraphics();
                        g.FillEllipse(Brushes.Red, 32 + 48 * ColumnIndext, 32 + 48 * rowIndext, 32, 32);
                        Counter++;
                    }
                    else if (this.turn == 2)
                    {
                        Graphics g = this.CreateGraphics();
                        g.FillEllipse(Brushes.Yellow, 32 + 48 * ColumnIndext, 32 + 48 * rowIndext, 32, 32);
                        Counter++;
                    }
                    int Winner = this.WinnerPlayer(this.turn);
                    if (Winner != -1)
                    {
                        string player;
                        if (Winner == 1 && Counter != 42)
                        {
                            int a = Convert.ToInt32(P_red.Text);
                            a++;
                            P_red.Text = a.ToString();
                            player = Player_red.Text;
                        }
                        else
                        {
                            int a = Convert.ToInt32(P_yellow.Text);
                            a++;
                            P_yellow.Text = a.ToString();
                            player = Player_yellow.Text;
                        }
                        MessageBox.Show(player + " has won!");
                        ResetGame();
                        turn = 2;
                    }
                    if (Counter == 42)
                    {
                        int a = Convert.ToInt32(Draw_Lap.Text);
                        a++;
                        Draw_Lap.Text = a.ToString();
                        MessageBox.Show(Draw.Text);
                        ResetGame();
                    }
                    if (this.turn == 1)
                    {
                        this.turn = 2;
                    }
                    else
                    {
                        this.turn = 1;
                    }
                }
            }
        }
        private int WinnerPlayer(int playerToCheck)
        {
            // vertical win  check (|)
            for (int row = 0; row < this.board.GetLength(0) - 3; row++)
            {
                for (int col = 0; col < this.board.GetLength(1); col++)
                {
                    if (this.AllNumbersEqual(playerToCheck,
                        this.board[row, col],
                        this.board[row + 1, col],
                        this.board[row + 2, col],
                        this.board[row + 3, col]))
                    {
                        return playerToCheck;
                    }
                }
            }
            // horizontal win check (-)
            for (int row = 0; row < this.board.GetLength(0); row++)
            {
                for (int col = 0; col < this.board.GetLength(1) - 3; col++)
                {
                    if (this.AllNumbersEqual(playerToCheck,
                        this.board[row, col],
                        this.board[row, col + 1],
                        this.board[row, col + 2],
                        this.board[row, col + 3]))
                    {
                        return playerToCheck;
                    }
                }
            }
            // top-left diagonal win check (\)
            for (int row = 0; row < this.board.GetLength(0) - 3; row++)
            {
                for (int col = 0; col < this.board.GetLength(1) - 3; col++)
                {
                    if (this.AllNumbersEqual(playerToCheck,
                        this.board[row, col],
                        this.board[row + 1, col + 1],
                        this.board[row + 2, col + 2],
                        this.board[row + 3, col + 3]))
                    {
                        return playerToCheck;
                    }
                }
            }
            // top-left diagonal win check (/)
            for (int row = 0; row < this.board.GetLength(0) - 3; row++)
            {
                for (int col = 3; col < this.board.GetLength(1); col++)
                {
                    if (this.AllNumbersEqual(playerToCheck,
                        this.board[row, col],
                        this.board[row + 1, col - 1],
                        this.board[row + 2, col - 2],
                        this.board[row + 3, col - 3]))
                    {
                        return playerToCheck;
                    }
                }
            }
            return -1;
        }
        private bool AllNumbersEqual(int toCheck, params int[] number)
        {
            foreach (int num in number)
            {
                if (num != toCheck)
                {
                    return false;
                }
            }
            return true;
        }
        private int ColumnNumber(Point mouse)
        {
            for (int i = 0; i < this.boardColumns.Length; i++)
            {
                if ((mouse.X >= this.boardColumns[i].X) && (mouse.Y >= this.boardColumns[i].Y))
                {
                    if ((mouse.X <= this.boardColumns[i].X + this.boardColumns[i].Width) &&
                        (mouse.Y <= this.boardColumns[i].Y + this.boardColumns[i].Height))
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
        private int EmptyRow(int col)
        {
            for (int i = 5; i >= 0; i--)
            {
                if (this.board[i, col] == 0)
                {
                    return i;
                }
            }
            return -1;
        }
        private void ResetGame()
        {

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    this.board[i, j] = 0;
                }
            }
            this.Invalidate();
            Counter = 0;
            turn = 1;
        }

        private void new_game_Click(object sender, EventArgs e)
        {
            ResetGame();
            P_red.Text = "0";
            P_yellow.Text = "0";
            Draw_Lap.Text = "0";
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
