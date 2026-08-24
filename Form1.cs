using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace miPrimeaAplicacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Función para calcular la media aritmética
        private double media(double[] serie)
        {
            return serie.Average();
        }

        // Función para calcular la desviación típica
        private double desviacionTipica(double[] serie, double media)
        {
            return Math.Sqrt(serie.Average(n => Math.Pow(n - media, 2)));
        }

        // Función para calcular la media armónica
        private double armonica(double[] serie)
        {
            return serie.Length / serie.Sum(x => 1 / x);
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            limpiar();

            if (string.IsNullOrWhiteSpace(txtSerie.Text)) return;

            // Convierte el texto separado por comas a un arreglo de números
            double[] miSerie = txtSerie.Text.Split(',')
                                           .Select(n => double.Parse(n.Trim()))
                                           .ToArray();

            double m = media(miSerie);

            ltsValores.Items.Add("La media es: " + m);
            ltsValores.Items.Add("La desviacion tipica: " + desviacionTipica(miSerie, m));
            ltsValores.Items.Add("La media armonica: " + armonica(miSerie));
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            ltsValores.Items.Clear();
        }
    }
}

