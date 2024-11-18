using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPConstructor_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        //Trackbarlardan (red,green,blue olarak verilen) alınan degerler butona basıldıktan sonra acılan Form3'ün arka plan rengini belirlesin...

        private void BtnForm3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(TrbRed.Value,TrbGreen.Value,TrbBlue.Value);
            f3.ShowDialog();
        }
    }
}
