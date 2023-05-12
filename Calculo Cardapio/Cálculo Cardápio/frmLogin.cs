using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cálculo_Cardápio
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            Pexcel.FOpenSheet(Pexcel.Login);
        }
        private void btnPuxar_Click(object sender, EventArgs e)
        {

        }

        private void lblSenha_Click(object sender, EventArgs e)
        {

        }

        private void gpbLogin_Enter(object sender, EventArgs e)
        {

        }

        private void ValidaLogin()
        {
            int i = 2;
            do
            {
                if (String.Compare(txtUsername.Text, Pexcel.Plan.Cells[i, 1].value.ToString()) == 0)
                {
                    MessageBox.Show("É Igual");
                    break;
                }
                else
                {
                    i++;
                }
            }
            while (string.IsNullOrEmpty(Pexcel.Plan.Cells[i, 1].value.ToString()) == false);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ValidaLogin();
        }
    }
}
