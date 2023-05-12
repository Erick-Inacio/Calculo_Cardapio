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
    public partial class frmTesteExcel : Form
    {
        //Excel.Application app = new Excel.Application();
        //Workbook pasta;
        //Worksheet plan;
        //string path = @"C:\Users\erick\Desktop\Faculdade\aprendendo_Csharp\Projeto Autoral\Cálculo Cardápio\Cardápio.xlsx";

        public frmTesteExcel()
        {
            InitializeComponent();
            //Pexcel.fCarregarPlanilha();
        }

        private void frmTesteExcel_Load(object sender, EventArgs e)
        {

        }

        private void btnAttPlanilha_Click(object sender, EventArgs e)
        {
            //Pexcel.fCarregarPlanilha();

            txtAltura.Text = Pexcel.Plan.Cells[2, 1].Value.ToString();
            txtPeso.Text = Pexcel.Plan.Cells[2, 2].Value.ToString();
        }

        //private void fCarregarPlanilha()
        //{
        //    txtStatus.Text = "Abrindo planilha de teste";

        //    //try
        //    //{
        //    Pexcel.Pasta = Pexcel.App.Workbooks.Open(Pexcel.Path);
        //    //    plan = pasta.Worksheets["Sheet1"];

        //        txtStatus.Text = "Carregando Dados";

        //    //    txtAltura.Text = plan.Cells[2, 1].Value.ToString();
        //    //    txtPeso.Text = plan.Cells[2,2].Value.ToString();
        //    //}
        //    //catch (Exception ex) 
        //    //{
        //    //    MessageBox.Show("Falha: " + ex.Message);
        //    //}

        //    txtStatus.Text = "Pronto";
        //}

        private void frmTesteExcel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Pexcel.FecharPlanilha();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Pexcel.Plan.Cells[2,1].Value = Convert.ToDecimal(txtAltura.Text);
            Pexcel.Pasta.Save();
            
        }
    }
}
