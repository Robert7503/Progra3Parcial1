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
    public partial class FuncionesDeTexto : Form
    {
        public FuncionesDeTexto()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            string cadena = txtCadena.Text;

            //Obtener la longitud de la cadena ingresada
            txtLongitud.Text = Convert.ToString(cadena.Length);// .ToString();

            //Obtener el primer elemento o caracter
            txtPrimeraLetra.Text = cadena.Substring(0, 1);

            //Obtener el último elemento o caracter
            txtUltimaLetra.Text = cadena.Substring(cadena.Length - 1, 1);

            //Rango de x a y
            txtRangoLetras.Text = cadena.Substring(5, 15);

            //Convertir a mayúsculas
            txtTodasMayusculas.Text = cadena.ToUpper();

            //Convertir a Minúscula
            txtTodasMinusculas.Text = cadena.ToLower();

            //Reemplazar
            txtRemplazoLetras.Text = cadena.Replace("a", "b");

            //Primer Letra en Mayúscula
            txtPrimeraMayuscula.Text = cadena.Substring(0, 1).ToUpper() + cadena.Substring(1, cadena.Length - 1).ToLower();
        }
    }
}
