using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArtistLibrary;

namespace WindowsFormsApp1
{
    public partial class fArtist : Form
    {
        public Artist TheArtist;
        public fArtist(Artist t)
        {
            TheArtist = t;
            InitializeComponent();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            TheArtist.Name = tbName.Text.Trim();
            TheArtist.Country = tbCountry.Text.Trim();
            TheArtist.Region = tbRegion.Text.Trim();
            TheArtist.Genre = tbGenre.Text.Trim();
            TheArtist.SalaryForConcert = int.Parse(tbSalaryForConcert.Text.Trim());
            TheArtist.NumberOfConcerts = int.Parse(tbNumberOfConcerts.Text.Trim());
            if (rbMan.Checked)
            {
                TheArtist.Sex = true;
            }
            else if (rbWoman.Checked) {
                TheArtist.Sex = false;
            }

            DialogResult = DialogResult.OK;
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void fArtist_Load(object sender, EventArgs e)
        {
            tbName.Text = TheArtist.Name;
            tbCountry.Text = TheArtist.Country;
            tbRegion.Text = TheArtist.Region;
            tbGenre.Text = TheArtist.Genre;
            tbSalaryForConcert.Text = TheArtist.SalaryForConcert.ToString();
            tbNumberOfConcerts.Text = TheArtist.NumberOfConcerts.ToString();
            if (TheArtist.Sex = true)
            {
                rbMan.Checked = true;
            }
            else if (TheArtist.Sex = false)
            {
                rbWoman.Checked = true;
            }

        }
    }
    }
