using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessClient
{
    public partial class FormChooseMode : Form
    {
        public FormChooseMode()
        {
            InitializeComponent();
        }


        private void ChessMode_Click(object sender, EventArgs e)
        {
            FormLauncher frmLauncher = new FormLauncher();
            frmLauncher.Show();
        }

        private void Chess960Mode_Click(object sender, EventArgs e)
        {
            FormLauncher frmLauncher = new FormLauncher();
            frmLauncher.Show();
        }
    }
}
