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
    public partial class frmEER : Form
    {
        string[] grauAtv = new string [4] { "Sedentário","Pouco Ativo","Ativo","Muito Ativo"};
        double[,] grauMultAtv = new double[4, 4] {{1.00,1.00,1.00,1.00},
                                                  {1.13,1.16,1.11,1.12},
                                                  {1.26,1.31,1.25,1.27},
                                                  {1.42,1.56,1.48,1.45}};

        public frmEER()
        {
            InitializeComponent();
        }

        private void frmEER_Load(object sender, EventArgs e)
        {
            cbxGrauAtv.Items.AddRange(grauAtv);
            cbxSexo.Items.Add("Masculino");
            cbxSexo.Items.Add("Feminino");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            fCalcularEer();
        }

        private void cbxGrauAtv_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtEer_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPuxar_Click(object sender, EventArgs e)
        {
            txtIdade.Text = Pexcel.Plan.Cells[2,4].value.ToString();
            cbxSexo.Text = Pexcel.Plan.Cells[2, 6].Value.ToString();
            cbxGrauAtv.Text = Pexcel.Plan.Cells[2, 5].Value.ToString();

            fCalcularEer();
        }

        private void fCalcularEer()
        {
            int indiceLin = 0;

            for (int i = 0; i < 4; i++)
            {
                if (string.Equals(grauAtv[i], cbxGrauAtv.Text))
                {
                    indiceLin = i;
                    //MessageBox.Show("grau :" + grauMultAtv[indiceLin,1]);
                    break;
                }

            }

            if (double.TryParse(txtIdade.Text, out VG.Idade))
            {
                if (VG.Idade >= 3 && VG.Idade <= 8)
                {
                    if (string.Equals(cbxSexo.Text, "Masculino"))
                    {
                        //testar
                        VG.Eer = (88.5 - 61.9 * VG.Idade +
                            grauMultAtv[indiceLin, 0] * ((26.7 * VG.PesoAlmejado +
                            903 * VG.Altura)) + 20);
                    }
                    else
                    {
                        //testar
                        VG.Eer = (135.3 - 30.8 * VG.Idade +
                            grauMultAtv[indiceLin, 1] * (10 * VG.PesoAlmejado +
                            934 * VG.Altura) + 20);
                    }
                }
                else if (VG.Idade >= 9 && VG.Idade <= 18)
                {
                    if (string.Equals(cbxSexo.Text, "Masculino"))
                    {
                        //testar
                        VG.Eer = (88.5 - 61.9 * VG.Idade +
                            grauMultAtv[indiceLin, 0] * ((26.7 * VG.PesoAlmejado +
                            903 * VG.Altura)) + 25);
                    }
                    else
                    {
                        //testar
                        VG.Eer = (135.3 - 30.8 * VG.Idade +
                            grauMultAtv[indiceLin, 1] * (10 * VG.PesoAlmejado +
                            934 * VG.Altura) + 25);
                    }
                }
                else if (VG.Idade >= 19)
                {
                    if (string.Equals(cbxSexo.Text, "Masculino"))
                    {
                        //testar
                        VG.Eer = (662 - 9.53 * VG.Idade + grauMultAtv[indiceLin, 2] *
                            (15.91 * VG.PesoAlmejado + 539.6 * VG.Altura));
                    }
                    else
                    {
                        //testar
                        VG.Eer = (354 - 6.91 + VG.Idade + grauMultAtv[indiceLin, 3] *
                            (9.36 * VG.PesoAlmejado + 726 * VG.Altura));
                    }
                }

                txtEer.Text = VG.Eer.ToString("N0");
                VG.Eer *= 0.75;
                txtEerReduzido.Text = VG.Eer.ToString("N0");
            }
        }
    }
}
