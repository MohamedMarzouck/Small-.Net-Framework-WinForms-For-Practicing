using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApps.Properties;
using static WindowsFormsApps.TicTacToe;

namespace WindowsFormsApps
{
    public partial class TicTacToe : Form
    {
        public TicTacToe()
        {
            InitializeComponent();
        }


        public enum enPlayer { Player1, Player2 };
        public enum enWinner { Inprogress, Draw, Player1, Player2 };
        public struct stGameStatus
        {
            public enPlayer CurrentPlayer;
            public enWinner Winner;
            public short MoveCount;
            public bool GameOver;

            stGameStatus(enPlayer DefaultPlayer = enPlayer.Player1)
            {
                CurrentPlayer = DefaultPlayer;
                Winner = enWinner.Inprogress;
                MoveCount = 0;
                GameOver = false;
            }
        }
        stGameStatus GameStatus;
        short WinPlayer1 = 0;
        short WinPlayer2 = 0;
        private void GetResult()
        {
            label6.Text = Convert.ToString(WinPlayer1);
            label8.Text = Convert.ToString(WinPlayer2);
        }

        private bool CheckValues(PictureBox Box1, PictureBox Box2, PictureBox Box3)
        {
            if (Box1.Tag.ToString() != "?" && Box1.Tag == Box2.Tag && Box1.Tag == Box3.Tag)
            {
                EndGame(Box1, Box2, Box3);
                return true;
            }

            return false;
        }
        private bool CheckWinner()
        {
            if (CheckValues(pictureBox1, pictureBox2, pictureBox3)) return true;
            else if (CheckValues(pictureBox4, pictureBox5, pictureBox6)) return true;
            else if (CheckValues(pictureBox7, pictureBox8, pictureBox9)) return true;
            else if (CheckValues(pictureBox1, pictureBox4, pictureBox7)) return true;
            else if (CheckValues(pictureBox2, pictureBox5, pictureBox8)) return true;
            else if (CheckValues(pictureBox3, pictureBox6, pictureBox9)) return true;
            else if (CheckValues(pictureBox1, pictureBox5, pictureBox9)) return true;
            else if (CheckValues(pictureBox3, pictureBox5, pictureBox7)) return true;

            return false;
        }

        private void StartGame(PictureBox Box)
        {
            if (GameStatus.GameOver)
            {
                MessageBox.Show("Game is already over! Click Restart to play again.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Box.Tag.ToString() == "?")
            {
                GameStatus.MoveCount++;

                switch(GameStatus.CurrentPlayer)
                {
                case enPlayer.Player1:
                    Box.Image = Resources.O;
                    Box.Tag = "O";
                    if (CheckWinner())
                    {
                        WinPlayer1++;
                        GetResult();
                        GameStatus.Winner = enWinner.Player1;
                        label4.Text = "Player 1";
                        gbTicTacToe.Enabled = false;
                        return;
                    }
                    GameStatus.CurrentPlayer = enPlayer.Player2;
                    label2.Text = "Player 2";
                    break;

                case enPlayer.Player2:
                    Box.Image = Resources.X;
                    Box.Tag = "X";
                    if (CheckWinner())
                    {
                        WinPlayer2++;
                        GetResult();
                        GameStatus.Winner = enWinner.Player2;
                        label4.Text = "Player 2";
                        gbTicTacToe.Enabled = false;
                        return;
                    }
                        GameStatus.CurrentPlayer = enPlayer.Player1;
                    label2.Text = "Player 1";
                    break;
                }

                if (GameStatus.MoveCount == 9)
                {
                    GameStatus.Winner = enWinner.Draw;
                    label4.Text = "Draw";
                    label2.Text = "Game Over";
                    GameStatus.GameOver = true;
                    gbTicTacToe.Enabled = false;
                    MessageBox.Show("Game ended in a draw!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Wrong Choice!", "Wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EndGame(PictureBox Box1, PictureBox Box2, PictureBox Box3)
        {
            Box1.BackColor = Box2.BackColor = Box3.BackColor = Color.DarkRed;
            GameStatus.GameOver = true;
            label2.Text = "Game Over";
        }

        private void ResetpictureBox(PictureBox Box)
        {
            Box.BackColor = Color.Transparent;
            Box.Image = Resources.question_mark_96;
            Box.Tag = "?";

        }
        private void Reset()
        {
            gbTicTacToe.Enabled = true;

            ResetpictureBox(pictureBox1);
            ResetpictureBox(pictureBox2);
            ResetpictureBox(pictureBox3);
            ResetpictureBox(pictureBox4);
            ResetpictureBox(pictureBox5);
            ResetpictureBox(pictureBox6);
            ResetpictureBox(pictureBox7);
            ResetpictureBox(pictureBox8);
            ResetpictureBox(pictureBox9);

            label2.Text = "Player 1";
            label4.Text = "In Progress";
            GameStatus = new stGameStatus();
        }


        private void PictureBox_Click(object sender, EventArgs e)
        {
            StartGame((PictureBox)sender);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void gbTicTacToe_Load(object sender, EventArgs e)
        {
            Reset();
        }

    }
}
