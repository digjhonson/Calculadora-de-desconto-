using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoradedesconto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Obtém os valores dos TextBoxes
            double valorCompra = double.Parse(txtValorCompra.Text);
            double desconto = double.Parse(txtDesconto.Text);

            // Calcula o desconto
            double valorDesconto = valorCompra * (desconto / 100);

            // Calcula o valor final da compra
            double valorFinal = valorCompra - valorDesconto;

            // Exibe o resultado no Label
            lblResultado.Text = "Resultado da compra com desconto R$ " + valorFinal.ToString("0.00");
        
       }
    }
}
