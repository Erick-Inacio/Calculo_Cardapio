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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            //Pexcel.fCarregarPlanilha();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void iMCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIMC IMC = new frmIMC();
            IMC.MdiParent = this;
            IMC.WindowState = FormWindowState.Maximized;
            IMC.Show();
        }

        private void eERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEER EER = new frmEER();
            EER.MdiParent = this;
            EER.WindowState = FormWindowState.Maximized;
            EER.Show();
        }

        private void balanceamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBalanceamento BALANCEAMENTO = new frmBalanceamento();
            BALANCEAMENTO.MdiParent = this;
            BALANCEAMENTO.WindowState = FormWindowState.Maximized;
            BALANCEAMENTO.Show();
        }

        private void kcalPorRefeiçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKcalRefeicao KCALREFEICAO = new frmKcalRefeicao();
            KCALREFEICAO.MdiParent = this;
            KCALREFEICAO.WindowState = FormWindowState.Maximized;
            KCALREFEICAO.Show();
        }

        //private void testeExcelToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    frmTesteExcel TESTEEXCEL = new frmTesteExcel(); 
        //    TESTEEXCEL.MdiParent = this;
        //    TESTEEXCEL.WindowState = FormWindowState.Maximized;
        //    TESTEEXCEL.Show();
        //}

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Pexcel.FecharPlanilha();
        }
    }
}
