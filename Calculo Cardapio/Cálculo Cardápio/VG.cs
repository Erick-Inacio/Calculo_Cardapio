using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Cálculo_Cardápio
{
    internal class VG
    {
        public static double Imc = 0, Eer = 0, PesoAlmejado = 0, Altura= 0;
        public static double Idade = 0, Cho = 0, Ptn = 0, Lip = 0, Desjejum = 0,
            Colacao = 0, Almoco = 0, Lanche = 0, Janta = 0, Ceia = 0;

        public static string[] gpAlimentares = new string[8] {"Cereais e tubérculos", "Legumes e verduras",
            "Frutas", "Carnes e Ovos", "Leite e derivados", "Leguminosas", "Óleos e gorduras", "Açúcares e doces"};
        public static string[] kcalGpAlim = new string[8] { "150", "15", "70", "190", "120", "55", "73", "110" };
    }
}
