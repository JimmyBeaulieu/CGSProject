using CGS_DLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGS_Windows
{
    public partial class SellForm : Form
    {
        Gallery gallery = new Gallery();
        
        public SellForm(Gallery gallery)
        {
            InitializeComponent();
            this.gallery = gallery;
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(@"C:\Users\gytim\source\repos\CGS\CGS_Windows\CGS_Windows\artPiece.txt"))
            {
                while (sr.Peek() >= 0)
                {
                    string str = sr.ReadLine();
                    string[] strArray = str.Split(' ');

                    if (strArray[0] == artPieceText.Text && Convert.ToInt32(strArray[5]) <= Convert.ToInt32(estimateText.Text))
                    {
                        gallery.changeStatusToSold(strArray[0]);
                        gallery.addArtPiece(strArray[0], strArray[1], strArray[2], strArray[3], Convert.ToInt32(strArray[4]), Convert.ToDouble(strArray[5]), "S");
                    }
                }
            }
            gallery.saveArtPieceInfo();

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string allArtPieceInfo = gallery.getAllArtpiecesInfo();
            richTextBox1.AppendText(allArtPieceInfo);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
