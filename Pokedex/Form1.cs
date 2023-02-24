using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCharmander_Click(object sender, EventArgs e)
        {
            pictureBoxPokedex.Image = Properties.Resources.gif_charmander;
        }

        private void btnSquirtle_Click(object sender, EventArgs e)
        {
            pictureBoxPokedex.Image = Properties.Resources.gif_squirtle;
        }

        private void btnBulbasaur_Click(object sender, EventArgs e)
        {
            pictureBoxPokedex.Image = Properties.Resources.gif_bulbasaur;
        }

        private void btnCaterpie_Click(object sender, EventArgs e)
        {
            pictureBoxPokedex.Image = Properties.Resources.gif_caterpie;
        }

        private void btnWeedle_Click(object sender, EventArgs e)
        {
            pictureBoxPokedex.Image = Properties.Resources.gif_weedle;
        }

        private void btnPidgey_Click(object sender, EventArgs e)
        {
            pictureBoxPokedex.Image = Properties.Resources.gif_pidgey;
        }

        private void btnRattata_Click(object sender, EventArgs e)
        {
            pictureBoxPokedex.Image = Properties.Resources.gif_rattata;
        }

        private void btnEkans_Click(object sender, EventArgs e)
        {
            pictureBoxPokedex.Image = Properties.Resources.gif_ekans;
        }

        private void btnSandshrew_Click(object sender, EventArgs e)
        {
            pictureBoxPokedex.Image = Properties.Resources.gif_sandshrew;
        }

        private void btnJigglypuff_Click(object sender, EventArgs e)
        {
            pictureBoxPokedex.Image = Properties.Resources.gif_jigglypuff;
        }
    }
}
