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
    public partial class frmIMC : Form
    {
        double peso;
        string classificacao, grauObes, magreza, normal, sobrepeso, obes, obesGrave;

        public frmIMC()
        {
            InitializeComponent();
            Pexcel.FOpenSheet(Pexcel.Sheet1);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
            if ((VG.Altura < 2.8 && VG.Altura > 0.55) && (peso < 600) &&
                (double.TryParse(txtPesoAlmejado.Text, out VG.PesoAlmejado)))
            {
                VG.Imc = (peso / Math.Pow(VG.Altura, 2));
                txtImc.Text = VG.Imc.ToString("N1");

                if (VG.Imc <= 18.5)
                {
                    classificacao = "Magreza";
                    grauObes = "0";
                }
                else if (VG.Imc <= 24.9)
                {
                    classificacao = "Normal";
                    grauObes = "0";
                }
                else if (VG.Imc <= 29.9)
                {
                    classificacao = "Sobrepeso";
                    grauObes = "I";
                }
                else if (VG.Imc <= 39.9)
                {
                    classificacao = "Obesidade";
                    grauObes = "II";
                }
                else
                {
                    classificacao = "Obesidade Grave";
                    grauObes = "III";
                }

                txtClassificacao.Text = classificacao;
                txtGrauObesidade.Text = grauObes;

            }
            else
            {
                txtImc.Clear();
                txtGrauObesidade.Clear();
                txtClassificacao.Clear();

                MessageBox.Show("Valores inválidos");
            }
        }

        private void btnPuxar_Click(object sender, EventArgs e)
        {
            txtAltura.Text = Pexcel.Plan.Cells[2,1].Value.ToString();
            txtPeso.Text = Pexcel.Plan.Cells[2, 2].Value.ToString();
            txtPesoAlmejado.Text = Pexcel.Plan.Cells[2, 3].Value.ToString();

            fValidaValores();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPeso.Clear();
            txtAltura.Clear();
            txtImc.Clear();
            txtClassificacao.Clear();
            txtGrauObesidade.Clear();
            txtMagreza.Clear();
            txtNormal.Clear();
            txtSobrepeso.Clear();
            txtObesidade.Clear();
            txtObesGrave.Clear();
        }

        private void txtPeso_Validated(object sender, EventArgs e)
        {
            fValidaValores();
        }

        private void txtAltura_Validated(object sender, EventArgs e)
        {
            fValidaValores();
        }

        private void frmIMC_Load(object sender, EventArgs e)
        {
             
        }

        private void fValidaValores()
        {
            if (Double.TryParse(txtAltura.Text, out VG.Altura) && (VG.Altura > 2.8
                || VG.Altura < 0.55))
            {
                txtImc.Clear();
                txtClassificacao.Clear();
                txtGrauObesidade.Clear();
                txtMagreza.Clear();
                txtNormal.Clear();
                txtSobrepeso.Clear();
                txtObesidade.Clear();
                txtObesGrave.Clear();

                MessageBox.Show("Digite um valor entre 0,55m - 2,8m");


            }
            else
            {
                //Calculo txtMagreza
                magreza = (Math.Pow(VG.Altura, 2) * 18.5).ToString("N1");
                txtMagreza.Text = ("< " + magreza);

                //Calculo txtNormal
                normal = (Math.Pow(VG.Altura, 2) * 24.9).ToString("N1");
                txtNormal.Text = (magreza + " - " + normal);

                //Calculo txtSobrepeso
                sobrepeso = (Math.Pow(VG.Altura, 2) * 29.9).ToString("N1");
                txtSobrepeso.Text = (normal + " - " + sobrepeso);

                //Calculo txtObesidade
                obes = (Math.Pow(VG.Altura, 2) * 39.9).ToString("N1");
                txtObesidade.Text = (sobrepeso + " - " + obes);

                //Calculo txtObesGrave
                obesGrave = (Math.Pow(VG.Altura, 2) * 40).ToString("N1");
                txtObesGrave.Text = ("> " + obesGrave);

            }
            if (txtAltura.Text == "")
            {
                txtMagreza.Clear();
                txtNormal.Clear();
                txtSobrepeso.Clear();
                txtObesidade.Clear();
                txtObesGrave.Clear();
            }

            if (Double.TryParse(txtPeso.Text, out peso) && peso > 600)
            {
                txtImc.Clear();
                txtClassificacao.Clear();
                txtGrauObesidade.Clear();
                txtMagreza.Clear();
                txtNormal.Clear();
                txtSobrepeso.Clear();
                txtObesidade.Clear();
                txtObesGrave.Clear();
                MessageBox.Show("Peso máximo excedido, digite um peso de até 600kg");
            }
        }
    }
}
