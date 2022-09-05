using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Division
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cldivision ss = new cldivision();

            ss.N1 = double.Parse(textBox1.Text);
            ss.N2 = double.Parse(textBox2.Text);

            textBox3.Text = ss.DVSN().ToString();

            // aqui se crea el objeto ODVSN
            cldivision ODVSN;

            // aqui manda los parametros(valores) al construct
            ODVSN = new cldivision(double.Parse(textBox1.Text), 
            double.Parse(textBox2.Text)); textBox3.Text = ODVSN.DVSN().
            ToString();
        }
    }
}
