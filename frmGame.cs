using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using Tic_Tac_Toe.Properties;
using System.Media;

namespace Tic_Tac_Toe
{
    public partial class frmGame : Form
    {
        frmGameSetup.stGameSettings _GameInfo;
        public frmGame(frmGameSetup.stGameSettings GameInfo)
        {
            InitializeComponent();
            _GameInfo = GameInfo;
        }
        enum enBoxState { X = 0, O = 1, Empty = 2 };

        enBoxState[,] Boxes = new enBoxState[3, 3];

        struct stPlayer
        {
            public string Name;
            public enBoxState Symbol;
            public int Wins;
        }

        struct stRoundinfo
        {
            public int RoundNumber;
            public stPlayer Winner;
        }

        stPlayer Player1, Player2, CurrentPlayer;

        stRoundinfo CurrentRound;

        SoundPlayer clickSound = new SoundPlayer(Properties.Resources.ClickSound);
        SoundPlayer RoundResult = new SoundPlayer(Properties.Resources.RoundResult);
        SoundPlayer FinalWinner = new SoundPlayer(Properties.Resources.FinalWinner);

        void GetRandomMove(out int row, out int col)
        {
            row = -1; col = -1;
            Random rand = new Random();
            while (true)
            {
                int r = rand.Next(0, 3);
                int c = rand.Next(0, 3);
                if (Boxes[r, c] == enBoxState.Empty)
                {
                    row = r; col = c;
                    break;
                }
            }
        }

        bool CheckVirtualWinner(enBoxState symbol)
        {
            for (int i = 0; i < 3; i++)
            {
                if (Boxes[i, 0] == symbol && Boxes[i, 1] == symbol && Boxes[i, 2] == symbol) return true;
                if (Boxes[0, i] == symbol && Boxes[1, i] == symbol && Boxes[2, i] == symbol) return true;
            }
            if (Boxes[0, 0] == symbol && Boxes[1, 1] == symbol && Boxes[2, 2] == symbol) return true;
            if (Boxes[0, 2] == symbol && Boxes[1, 1] == symbol && Boxes[2, 0] == symbol) return true;
            return false;
        }

        bool TryWinOrBlock(enBoxState symbol, out int row, out int col)
        {
            row = -1; col = -1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (Boxes[i, j] == enBoxState.Empty)
                    {
                        Boxes[i, j] = symbol;
                        if (CheckVirtualWinner(symbol))
                        {
                            row = i; col = j;
                            Boxes[i, j] = enBoxState.Empty;
                            return true;
                        }
                        Boxes[i, j] = enBoxState.Empty;
                    }
                }
            }
            return false;
        }

        void PC_Play()
        {
            if (GetGameResult() != enGameResuls.Continue) return;

            int row = -1, col = -1;
            Random rand = new Random();

            if (_GameInfo.Difficulty == frmGameSetup.enDifficulty.Easy)
                GetRandomMove(out row, out col);
            else if (_GameInfo.Difficulty == frmGameSetup.enDifficulty.Medium)
            {
                if (!TryWinOrBlock(Player2.Symbol, out row, out col))
                    GetRandomMove(out row, out col);
            }
            else if (_GameInfo.Difficulty == frmGameSetup.enDifficulty.Hard)
            {
                if (!TryWinOrBlock(Player2.Symbol, out row, out col)) // الهجوم
                    if (!TryWinOrBlock(Player1.Symbol, out row, out col)) // الدفاع
                        if (Boxes[1, 1] == enBoxState.Empty) { row = 1; col = 1; } // المركز
                        else GetRandomMove(out row, out col);
            }

            if (row != -1 && col != -1)
            {
                foreach (PictureBox pb in pnlPictures.Controls)
                {
                    if (pb.Tag.ToString() == $"{row},{col}")
                    {
                        // محاكاة النقر
                        ExecuteMove(pb, row, col);
                        break;
                    }
                }
            }
        }
        bool IsPlayer1Turn(stPlayer CurrentPlayer)
        {
            return (CurrentPlayer.Name == Player1.Name);

        }

        void SwitchPlayer()
        {
            CurrentPlayer = IsPlayer1Turn(CurrentPlayer) ? Player2 : Player1;
            lbTurn.Text = CurrentPlayer.Name;

            if (_GameInfo.IsVsPC && CurrentPlayer.Name == Player2.Name)
            {
                PC_Play();
            }
        }

        void EmptyBoxes()
        {
            for (int i = 0; i < Boxes.GetLength(0); i++)
            {
                for (int j = 0; j < Boxes.GetLength(1); j++)
                {
                    Boxes[i, j] = enBoxState.Empty;
                }

            }
        }

        stPlayer GetNextPlayer(stPlayer CurrentPlayer)
        {
            if (CurrentPlayer.Name == Player1.Name) return Player2;
            else return Player1;
        }

        void IncreaseWinner(stPlayer CurrentPlayer)
        {
            if (CurrentPlayer.Name == Player1.Name)
            {
                Player1.Wins++;
                lbPlayer1Wins.Text = Player1.Wins.ToString();
            }
            else
            {
                Player2.Wins++;
                lbPlayer2Wins.Text = Player2.Wins.ToString();
            }      
        }

        void IntialState()
        {
            EmptyBoxes();
            DeletePictures();
            pnlPictures.Enabled = true;
            Player1.Wins = 0;
            Player2.Wins = 0;
            lbPlayer1Wins.Text = Player1.Wins.ToString();
            lbPlayer2Wins.Text = Player2.Wins.ToString();

            Player1.Symbol = enBoxState.X; Player2.Symbol = enBoxState.O;
            Player1.Name = _GameInfo.Player1Name; Player2.Name = _GameInfo.Player2Name;

            CurrentPlayer = Player1;
            lbTurn.Text = CurrentPlayer.Name;
            lbWinner.Text = "In Progress.";
            CurrentRound.RoundNumber = 1;
            lbRond.Text = CurrentRound.RoundNumber.ToString();
            btnNextRound.Enabled = false;
        }

        void Reset()
        {

            EmptyBoxes();
            DeletePictures();
            pnlPictures.Enabled = true;
            lbWinner.Text = "In Progress.";
            CurrentPlayer = GetNextPlayer(CurrentPlayer);
            lbTurn.Text = CurrentPlayer.Name;
            lbRond.Text = CurrentRound.RoundNumber.ToString();
            lbPlayer1Wins.Text = Player1.Wins.ToString();
            lbPlayer2Wins.Text = Player2.Wins.ToString();
            btnNextRound.Enabled = false;
            // تعديل: إذا بدأ الدور للكمبيوتر في الجولة الجديدة
            if (_GameInfo.IsVsPC && CurrentPlayer.Name == Player2.Name) PC_Play();

        }

        void UpDatePicture(PictureBox clickedPB)
        {
            if (CurrentPlayer.Symbol == enBoxState.O)
                clickedPB.Image = Resources.O;
            if (CurrentPlayer.Symbol == enBoxState.X)
                clickedPB.Image = Resources.X;
            clickSound.Play();
        }

        void ColorWinningBox(int row, int col)
        {
            foreach (PictureBox pb in pnlPictures.Controls)
            {
                if (pb.Tag.ToString() == $"{row},{col}")
                {
                    pb.BackColor = Color.LightBlue;
                }
            }
        }

        bool IsWinner()
        {
            for (int i = 0; i < Boxes.GetLength(0); i++)
            {
                if (Boxes[i, 0] == CurrentPlayer.Symbol
                    && Boxes[i, 1] == CurrentPlayer.Symbol &&
                    Boxes[i, 2] == CurrentPlayer.Symbol)
                {
                    ColorWinningBox(i, 0); ColorWinningBox(i, 1); ColorWinningBox(i, 2);
                    return true;
                }
            }
            for (int i = 0; i < Boxes.GetLength(1); i++)
            {
                if (Boxes[0, i] == CurrentPlayer.Symbol &&
                    Boxes[1, i] == CurrentPlayer.Symbol &&
                    Boxes[2, i] == CurrentPlayer.Symbol)
                {
                    ColorWinningBox(0, i); ColorWinningBox(1, i); ColorWinningBox(2, i);
                    return true;
                }
            }


            if (Boxes[0, 0] == CurrentPlayer.Symbol
                && Boxes[1, 1] == CurrentPlayer.Symbol
                && Boxes[2, 2] == CurrentPlayer.Symbol)
            {
                ColorWinningBox(0, 0); ColorWinningBox(1, 1); ColorWinningBox(2, 2);
                return true;
            }

            if (Boxes[0, 2] == CurrentPlayer.Symbol
            && Boxes[1, 1] == CurrentPlayer.Symbol
            && Boxes[2, 0] == CurrentPlayer.Symbol)
            {
                ColorWinningBox(0, 2);ColorWinningBox(1, 1);ColorWinningBox(2, 0);
                return true;
            }

            return false;
        }

        void DeletePictures()
        {
            foreach(PictureBox box in pnlPictures.Controls)
            {
                box.Image = null;
                box.BackColor = Color.Transparent;
            }
        }

        bool IsDraw()
        {
            for (int i = 0; i < Boxes.GetLength(0); i++) {
                for (int j = 0; j < Boxes.GetLength(1); j++)
                {
                    if (Boxes[i, j] == enBoxState.Empty)
                        return false;
                } 
            }
            return true;
        }
        
        bool IsLastRound()
        {
            return (CurrentRound.RoundNumber >= _GameInfo.Rounds);

        }

        bool DrawPlayersWins()
        {
            return (Player1.Wins == Player2.Wins);
        }

        stPlayer GetFinalWinner()
        {
            if (Player1.Wins > Player2.Wins)
                return Player1;
            else 
                return Player2;
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            EmptyBoxes();
            IntialState();
        }

        private void btnNextRound_Click(object sender, EventArgs e)
        {
            Reset();
        }

        string[] Getparts(PictureBox clickedPB)
        {
            string tagValue = clickedPB.Tag.ToString();
            return tagValue.Split(',');
        }

        bool UpdateBoxesArr(int row, int col)
        {                    
            if (Boxes[row, col] != enBoxState.Empty)
            {
                if (!(_GameInfo.IsVsPC && CurrentPlayer.Name == Player2.Name))
                    MessageBox.Show("You Cannot Play in This Box!", "Erorr!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            Boxes[row, col] = CurrentPlayer.Symbol;
            return true;
        }

        enum enGameResuls { Win, Draw, Continue };

        enGameResuls GetGameResult()
        {
            if (IsWinner()) return enGameResuls.Win;
            if (IsDraw()) return enGameResuls.Draw;
            return enGameResuls.Continue;
        }

        void UpdateUI(enGameResuls resuls)
        {
            if (resuls == enGameResuls.Win)
            {
                lbWinner.Text = CurrentPlayer.Name;
                pnlPictures.Enabled = false;
                btnNextRound.Enabled = true;
                RoundResult.Play();
                MessageBox.Show("The Winner In Round " + CurrentRound.RoundNumber.ToString() + " Is " + CurrentPlayer.Name, "Congrats", MessageBoxButtons.OK);
                IncreaseWinner(CurrentPlayer);

            }

            if (resuls == enGameResuls.Draw)
            {
                lbWinner.Text = "No Winner";
                MessageBox.Show("No Winner In Round " + CurrentRound.RoundNumber.ToString(), "Draw", MessageBoxButtons.OK);
                pnlPictures.Enabled = false;
                btnNextRound.Enabled = true;

            }
        }

        bool HandleEndGame()
        {
            if (IsLastRound())
            {
                if (!DrawPlayersWins()) FinalWinner.Play();

                string FinalMessageText = (DrawPlayersWins()) ? "No Winner in Game!" : "The Winner In Game Is " + GetFinalWinner().Name;

                if (MessageBox.Show(FinalMessageText + "\n\nDo You Want to Play Again?", "Game Result",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    frmGameSetup GameSetup = new frmGameSetup();
                    GameSetup.Show();
                    this.Hide();
                    return true;
                }
                else
                {
                    End frmEnd = new End();
                    frmEnd.Show();
                    this.Hide();
                    return true;
                }
            }
            return false;

        }

        void ExecuteMove(PictureBox clickedPB, int row, int col)
        {
            if (!UpdateBoxesArr(row, col)) return;
            UpDatePicture(clickedPB);

            enGameResuls result = GetGameResult();
            UpdateUI(result);

            if (result == enGameResuls.Win || result == enGameResuls.Draw)
            {
                if (result == enGameResuls.Win) CurrentRound.Winner = CurrentPlayer;

                if (!HandleEndGame())
                {
                    CurrentRound.RoundNumber++;
                }
                return;
            }
            SwitchPlayer();
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            if (_GameInfo.IsVsPC && CurrentPlayer.Name == Player2.Name) return;

            PictureBox clickedPB = (PictureBox)sender;
            string[] parts = Getparts(clickedPB);

            int row = int.Parse(parts[0]);
            int col = int.Parse(parts[1]);

           ExecuteMove(clickedPB, row, col);

        }

        private void frmGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }

}
