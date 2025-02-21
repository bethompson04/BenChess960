using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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
            FormLauncher frmLauncher = new FormLauncher(false);
            frmLauncher.Show();
        }

        private void Chess960Mode_Click(object sender, EventArgs e)
        {
            FormLauncher frmLauncher = new FormLauncher(true);
            frmLauncher.Show();
        }
    }
}
