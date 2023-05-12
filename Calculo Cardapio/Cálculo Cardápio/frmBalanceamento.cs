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
    public partial class frmBalanceamento : Form
    {
        public frmBalanceamento()
        {
            InitializeComponent();
        }

        private void frmBalanceamento_Load(object sender, EventArgs e)
        {

        }

        //corrigir os macronutrientes
        private void txtPtn_Validated(object sender, EventArgs e)
        {
            if (!(double.TryParse(txtPtn.Text, out VG.Ptn) && VG.Ptn >= 10 &&
                VG.Ptn <= 15 && !string.IsNullOrEmpty(txtPtn.Text) == true))
            {
                MessageBox.Show("Digite um número válido para PTN entre 10 e 15");
            }
            txtVet.Text = (VG.Cho + VG.Ptn + VG.Lip).ToString();
        }

        private void txtLip_Validated(object sender, EventArgs e)
        {
            if (!(double.TryParse(txtLip.Text, out VG.Lip) && VG.Lip >= 15 &&
                VG.Lip <= 30 && !string.IsNullOrEmpty(txtLip.Text) == true))
            {
                MessageBox.Show("Digite um número válido para LIP entre 15 e 30");
            }
            txtVet.Text = (VG.Cho + VG.Ptn + VG.Lip).ToString();
        }

        private void txtCho_Validated(object sender, EventArgs e)
        {
            if(!(double.TryParse(txtCho.Text, out VG.Cho) && VG.Cho>= 55 &&
                VG.Cho<= 75 && !(string.IsNullOrEmpty(txtCho.Text) == true)))
            {
                MessageBox.Show("Digite um número válido para CHO entre 55 e 75");
            }
            txtVet.Text =(VG.Cho + VG.Ptn + VG.Lip).ToString();
        }

        private void txtColacao_Validated(object sender, EventArgs e)
        {
            double.TryParse(txtColacao.Text, out VG.Colacao);

            txtTotal.Text = (VG.Desjejum + VG.Colacao + VG.Almoco + VG.Lanche +
                VG.Janta + VG.Ceia).ToString();
        }

        private void txtAlmoco_Validated(object sender, EventArgs e)
        {
            double.TryParse(txtAlmoco.Text, out VG.Almoco);

            txtTotal.Text = (VG.Desjejum + VG.Colacao + VG.Almoco + VG.Lanche +
                VG.Janta + VG.Ceia).ToString();
        }

        private void txtLanche_Validated(object sender, EventArgs e)
        {
            double.TryParse(txtLanche.Text, out VG.Lanche);

            txtTotal.Text = (VG.Desjejum + VG.Colacao + VG.Almoco + VG.Lanche +
                VG.Janta + VG.Ceia).ToString();
        }

        private void txtJanta_Validated(object sender, EventArgs e)
        {
            double.TryParse(txtJanta.Text, out VG.Janta);

            txtTotal.Text = (VG.Desjejum + VG.Colacao + VG.Almoco + VG.Lanche +
                VG.Janta + VG.Ceia).ToString();
        }

        private void txtCeia_Validated(object sender, EventArgs e)
        {
            double.TryParse(txtCeia.Text, out VG.Ceia);

            txtTotal.Text = (VG.Desjejum + VG.Colacao + VG.Almoco + VG.Lanche +
                VG.Janta + VG.Ceia).ToString();
        }

        private void txtDesjejum_Validated(object sender, EventArgs e)
        {
            double.TryParse(txtDesjejum.Text, out VG.Desjejum);

            txtTotal.Text = (VG.Desjejum + VG.Colacao + VG.Almoco + VG.Lanche +
                VG.Janta + VG.Ceia).ToString();
        }
    }
}
