using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Tic_Tac_Toe
{
    public partial class frmGameSetup : Form
    {
        public frmGameSetup()
        {
            InitializeComponent();
        }

        public enum enDifficulty { Easy = 1, Medium = 2, Hard = 3 }
        public struct stGameSettings
        {
            public string Player1Name;
            public string Player2Name;
            public int Rounds;
            public enDifficulty Difficulty;
            public bool IsVsPC;
        };

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbPlayr1.Text) || (!chkVSPC.Checked && string.IsNullOrWhiteSpace(txbPlayr2.Text)))
            {
                MessageBox.Show("Please enter player names!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (chkVSPC.Checked && !rbEasy.Checked && !rbMed.Checked && !ebHard.Checked)
            {
                MessageBox.Show("Please select a difficulty level before starting!", "Difficulty Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SoundPlayer StartGame = new SoundPlayer(Properties.Resources.StartGame);
            StartGame.Play();

            stGameSettings GameInfo = new stGameSettings()
            {
                Player1Name = txbPlayr1.Text,
                Player2Name = txbPlayr2.Text,
                Rounds = (int)numericUpDown1.Value,
                IsVsPC = chkVSPC.Checked,
                Difficulty = GetSelectedDifficulty()
            };


            frmGame frmGame = new frmGame(GameInfo);
            frmGame.Show();
            this.Hide();
        }

        private enDifficulty GetSelectedDifficulty()
        {
            foreach (RadioButton rb in pnlDiff.Controls.OfType<RadioButton>())
            {
                if (rb.Checked)
                {
                    return (enDifficulty)Convert.ToInt32(rb.Tag);
                }
            }
            return enDifficulty.Easy; // Default
        }

        void CheckAct()
        {
            bool isVsPC = chkVSPC.Checked;

            txbPlayr2.Enabled = !isVsPC;
            txbPlayr2.Text = isVsPC ? "PC" : "";

            pnlDiff.Enabled = isVsPC;
            pnlDiff.BackColor = isVsPC ? Color.Transparent : Color.Silver;

            rbEasy.Enabled = isVsPC;
            rbMed.Enabled = isVsPC;
            ebHard.Enabled = isVsPC;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckAct();
            
        }

        private void frmGameSetup_Load(object sender, EventArgs e)
        {
            CheckAct();
        }

        private void frmGameSetup_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtFirstPlayer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // منع صوت الـ "بينج" المزعج اللي بيطلع مع الإنتر
                e.SuppressKeyPress = true;

                // الانتقال للاعب الثاني
                txbPlayr2.Focus();
            }
        }

        private void txtSecondPlayer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                numericUpDown1.Focus();
            }
        }

        private void numericUpDown1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                // استدعاء الميثود الخاصة ببدء اللعبة (اللي مربوطة بـ btnStart)
                button1.PerformClick();
            }
        }
    }
}
