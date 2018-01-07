using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_2_Darbas_su_Failu
{
    public partial class SkaiciavimaiForma : Form
    {
        public SkaiciavimaiForma(List<Darbuotojas> Darbuotojai)
        {
            InitializeComponent();
            textBox1.Text = Vidurkis(Darbuotojai).ToString();
        }

        public double Vidurkis(List<Darbuotojas> Darbuotojai)
        {
            var suma = 0;
            {

            }

            return 0;
        }
    }
}
