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
    public partial class frmKcalRefeicao : Form
    {
        public frmKcalRefeicao()
        {
            InitializeComponent();
        }

        private void frmKcalRefeicao_Load(object sender, EventArgs e)
        {
            txtDesjejum.Text = (VG.Eer * (VG.Desjejum / 100)).ToString("N1");

            txtColacao.Text = (VG.Eer * (VG.Colacao / 100)).ToString("N0");

            txtAlmoco.Text = (VG.Eer * (VG.Almoco / 100)).ToString("N0");

            txtLanche.Text = (VG.Eer * (VG.Lanche / 100)).ToString("N0");

            txtJanta.Text = (VG.Eer * (VG.Janta / 100)).ToString("N0");

            txtCeia.Text = (VG.Eer * (VG.Ceia / 100)).ToString("N0");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

        }
    }
}
