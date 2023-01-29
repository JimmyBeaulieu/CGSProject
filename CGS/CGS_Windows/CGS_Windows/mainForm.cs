using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CGS_DLL;

namespace CGS_Windows
{
    public partial class mainForm : Form
    {
        Gallery gallery = new Gallery();

        public mainForm()
        {
            InitializeComponent();
        }

        private void btn_AddCur_Click(object sender, EventArgs e)
        {
            string message = gallery.addCurator(curatorIDBox.Text, curatorFirstNameBox.Text, curatorLastNameBox.Text);
            MessageBox.Show(message);
            curatorIDBox.Clear();
            curatorFirstNameBox.Clear();
            curatorLastNameBox.Clear();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_ViewCur_Click(object sender, EventArgs e)
        {
            string allCuratorsInfo = gallery.getAllCuratorsInfo();
            richTextBox.AppendText(allCuratorsInfo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = gallery.addArtist(artistIDBox.Text, artistFirstNameBox.Text, 
                artistLastNameBox.Text);
            MessageBox.Show(message);
            artistIDBox.Clear();
            artistFirstNameBox.Clear();
            artistLastNameBox.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string allArtistsInfo = gallery.getAllArtistsInfo();
            richTextBox.AppendText(allArtistsInfo);
        }

        private void btn_AddArtPiece_Click(object sender, EventArgs e)
        {
            string message = gallery.addArtPiece(IDTextBox.Text, CuratorIDTextBox.Text, ArtistIDTextBox.Text, 
                TitleTextBox.Text, Convert.ToInt32(YearTextBox.Text), Convert.ToDouble(ValueTextBox.Text), "D");
            MessageBox.Show(message);
            IDTextBox.Clear();
            CuratorIDTextBox.Clear();
            ArtistIDTextBox.Clear();
            TitleTextBox.Clear();
            YearTextBox.Clear();
            ValueTextBox.Clear();
        }

        private void btn_ListPieces_Click(object sender, EventArgs e)
        {
            string allArtpiecesInfo = gallery.getAllArtpiecesInfo();
            richTextBox.AppendText(allArtpiecesInfo);
        }

        private void btn_SellArtPiece_Click(object sender, EventArgs e)
        {
            SellForm sellform = new SellForm(gallery);
            sellform.ShowDialog();

        }
        private void btn_SaveCur_Click(object sender, EventArgs e)
        {
            string info = "First name: " + curatorFirstNameBox.Text + "\nLast name: " + curatorLastNameBox.Text + "\nID: " + curatorIDBox.Text;
            MessageBox.Show(info);
            gallery.saveCuratorInfo();
        }

        private void saveArtistButton_Click(object sender, EventArgs e)
        {
            string info = "First name: " + artistFirstNameBox.Text + "\nLast name: " + artistLastNameBox.Text + "\nID: " + artistIDBox.Text;
            MessageBox.Show(info);
            gallery.saveArtistInfo();
        }

        private void artPieceSaveBox_Click(object sender, EventArgs e)
        {
            string info = "ID: " + IDTextBox.Text + "Title: " + TitleTextBox.Text + "Year: " + YearTextBox.Text + "Value: " + ValueTextBox.Text +
                            "Artist ID: " + ArtistIDTextBox.Text + "Curator ID: " + CuratorIDTextBox.Text;
            MessageBox.Show(info);
            gallery.saveArtPieceInfo();
        }
    }
}
