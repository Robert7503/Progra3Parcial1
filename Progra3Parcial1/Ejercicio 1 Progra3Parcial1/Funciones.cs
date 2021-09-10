using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1_Progra3Parcial1
{
    public partial class Funciones : Form
    {
        public Funciones()
        {
            InitializeComponent();

        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }


        private void LimpiarControles()//PROCEDIMIENTO
        {
            Numero1TextBox.Clear();
            Numero2TextBox2.Text = "";
            ResultadoLabel.Text = string.Empty;
            //limpiar Texto de label
            //.clear();
            // = String.Emty;
            // = "";
        }

        
        private int Sumar(int valor1, int valor2)//PROCEDIMIENTO
        {

            return valor1 + valor2;
        }
        private void SumaButton_Click(object sender, EventArgs e)
        {
            //DAR VALORES PROCEDIMIENTO Sumar.
            ResultadoLabel.Text =  Sumar(Convert.ToInt32(Numero1TextBox.Text),Convert.ToInt32(Numero2TextBox2.Text)).ToString();


        }

        private int Resta( int valor1, int valor2)
        {
            int resta = valor1 - valor2;
            return resta;
        }

        private void RestaButton_Click(object sender, EventArgs e)
        {
            ResultadoLabel.Text = Resta(Convert.ToInt32(Numero1TextBox.Text), Convert.ToInt32(Numero2TextBox2.Text)).ToString();

        }

        private int multiplicar(int valor1,int valor2)
        {
            int multiplicar = valor1 * valor2;
            return multiplicar;
        }
        private void MultiplicarButton_Click(object sender, EventArgs e)
        {
            ResultadoLabel.Text = multiplicar(Convert.ToInt32(Numero1TextBox.Text), Convert.ToInt32(Numero2TextBox2.Text)).ToString();
        }


        private int dividir(int valor1, int valor2)
        {
            int dividir = valor1 / valor2;
            return dividir;
        }
        private void DividirButton_Click(object sender, EventArgs e)
        {
            ResultadoLabel.Text = dividir(Convert.ToInt32(Numero1TextBox.Text), Convert.ToInt32(Numero2TextBox2.Text)).ToString();
        }
    }
}
