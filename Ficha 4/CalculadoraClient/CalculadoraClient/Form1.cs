/*	
	<author>Rafael Reis</author>
	<email>a17025@alunos.ipca.pt</email>
    <desc>Ficha 4 exercicio da calculadora - cliente.</desc>
*/
using System;
using System.Windows.Forms;

namespace CalculadoraClient
{
    public partial class Form1 : Form
    {
        Calculadora.Calculadora wsCalculadora;
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Calcula Adição com serviço externo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void adicaoButton_Click(object sender, EventArgs e)
        {
            if(wsCalculadora == null)
            {
                wsCalculadora = new Calculadora.Calculadora();
            }

            int x = int.Parse(xValue.Text);
            int y = int.Parse(yValue.Text);

            resultTextBox.Text = wsCalculadora.Adicao(x, y).ToString();
        }

        /// <summary>
        /// Calcula Subtração com serviço externo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void subtracaoButton_Click(object sender, EventArgs e)
        {
            if (wsCalculadora == null)
            {
                wsCalculadora = new Calculadora.Calculadora();
            }

            int x = int.Parse(xValue.Text);
            int y = int.Parse(yValue.Text);

            resultTextBox.Text = wsCalculadora.Subtracao(x, y).ToString();
        }

        /// <summary>
        /// Calcula Multiplicação com serviço externo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void multButton_Click(object sender, EventArgs e)
        {
            if (wsCalculadora == null)
            {
                wsCalculadora = new Calculadora.Calculadora();
            }

            int x = int.Parse(xValue.Text);
            int y = int.Parse(yValue.Text);

            resultTextBox.Text = wsCalculadora.Multiplicacao(x, y).ToString();
        }

        /// <summary>
        /// Calcula Divisão com serviço externo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void divButton_Click(object sender, EventArgs e)
        {
            if (wsCalculadora == null)
            {
                wsCalculadora = new Calculadora.Calculadora();
            }

            int x = int.Parse(xValue.Text);
            int y = int.Parse(yValue.Text);

            resultTextBox.Text = wsCalculadora.Divisao(x, y).ToString();
        }

        /// <summary>
        /// Calcula Factorial com serviço externo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void factButton_Click(object sender, EventArgs e)
        {
            if (wsCalculadora == null)
            {
                wsCalculadora = new Calculadora.Calculadora();
            }

            int x = int.Parse(xValue.Text);

            resultTextBox.Text = wsCalculadora.Factorial(x).ToString();
        }

        /// <summary>
        /// Calcula Potencia com serviço externo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void powButton_Click(object sender, EventArgs e)
        {
            if (wsCalculadora == null)
            {
                wsCalculadora = new Calculadora.Calculadora();
            }

            double x = double.Parse(xValue.Text);
            double y = double.Parse(yValue.Text);

            resultTextBox.Text = wsCalculadora.Potencia(x,y).ToString();
        }

        /// <summary>
        /// Calcula Valor Absoluto com serviço externo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void absButton_Click(object sender, EventArgs e)
        {
            if (wsCalculadora == null)
            {
                wsCalculadora = new Calculadora.Calculadora();
            }

            int x = int.Parse(xValue.Text);

            resultTextBox.Text = wsCalculadora.ValorAbsoluto(x).ToString();
        }
    }
}
