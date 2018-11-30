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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btnAddTown_Click(object sender, EventArgs e)
        {
            Artist artist = new Artist("","","","");
            fArtist ft = new fArtist(artist);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                tbArtistInfo.Text += string.Format("{0}, {1}, {2}. Жанр: {3}. Ціна концерту: {4} грн. Концертів: {5} Заробіток за тур {6} грн\r\n Стать: {7}",    artist.Name, artist.Country, artist.Region, artist.SalaryForConcert, artist.NumberOfConcerts, artist.GetTourSalary(), artist.Sex ? "оловік" : "Жінка");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Припинити роботу застосунку?", "Припинити роботу", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }
    }
    }
