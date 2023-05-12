using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace Cálculo_Cardápio
{
    abstract class Pexcel
    {
        //vars excel
        public static string Sheet1 = "Sheet1", Login = "Login";


        public static Excel.Application App = new Excel.Application();
        public static Workbook Pasta;
        public static Worksheet Plan;
        public static string Path = @"C:\Users\erick\Desktop\Faculdade\aprendendo_Csharp\Projeto Autoral\Cálculo Cardápio\Cardápio.xlsx";

        public static void fCarregarPlanilha()
        {
            try
            {
                Pasta = App.Workbooks.Open(Path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha: " + ex.Message);
            }
        }
        public static void FOpenSheet(string sheet = null)
        {

            try
            {
                Plan = Pasta.Worksheets[sheet];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha " + ex.Message); 
            }
        }
        
        public static void FecharPlanilha()
        {
            if (Pasta != null)
            {
                Pasta.Save();
                Pasta.Close(true);
            }

            App.Quit();

            Plan = null;
            Pasta = null;
            App = null;
        }

        public static void fNewSheet(string ws)
        {
            Excel.Worksheet newWorksheet = null;
            newWorksheet = Pasta.Worksheets.Add(ws);
        }

        //public static void SalvarPlanilha()
        //{
        //    try
        //    {
        //        //Plan.Cells[2, 1].Value = Convert.ToDecimal("0" + txtAltura.Text);
        //        Pasta.Save();

        //        if (Pasta.Saved == true)
        //        {
        //            MessageBox.Show("salvo com sucesso");
        //        }

        //        //txtStatus.Text = "Planilha Salva";
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Falha: " + ex.Message);
        //    }

        //    //txtStatus.Text = "Pronto";

        //}

    }
    
}
