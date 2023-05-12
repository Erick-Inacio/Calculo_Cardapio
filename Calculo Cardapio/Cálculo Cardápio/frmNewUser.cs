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
    public partial class frmNewUser : Form
    {
        public frmNewUser()
        {
            InitializeComponent();
           // Pexcel.fCarregarPlanilha();
        }

        private void btnNewSheet_Click(object sender, EventArgs e)
        {
            Pexcel.fNewSheet(txtNomeSheet.Text);
            
        }

        private void frmNewUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Pexcel.FecharPlanilha();
        }
    }
}
