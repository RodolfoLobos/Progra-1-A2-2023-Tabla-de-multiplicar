using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabla_de_multiplicar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            int ntabla = int.Parse(txtTablaDeMultiplicar.Text);
            String msg = "TABLA DE MULTIPLICAR DEL " + ntabla + "\n";
            for(int i=1; i <=10; i++)
            {
                msg += ntabla + "x" + i + "=" + (ntabla * i) + "\n";
            }
            MessageBox.Show(msg);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
