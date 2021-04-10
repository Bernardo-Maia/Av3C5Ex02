using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Av3C5Ex02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            int quantidade = int.Parse(txtQuantidade.Text);
            double valor = double.Parse(txtValor.Text), dolar = 5.68, convercao = 0;

            convercao = quantidade * valor * dolar;
            lblFim.Text = "Converção para R$: " + convercao;

        }
    }
}
