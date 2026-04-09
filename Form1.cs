using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            frmGameSetup frmGameSetup = new frmGameSetup();
            frmGameSetup.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SoundPlayer GameSound = new SoundPlayer(Properties.Resources.GameSound);
            GameSound.PlayLooping();
        }
    }
}
