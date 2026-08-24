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

        private double media(double[] serie)
        {
            return serie.Average();
        }

        private double desviacionTipica(double[] serie, double media)
        {
            return Math.Sqrt(serie.Average(n => Math.Pow(n - media, 2)));
        }

        private double armonica(double[] serie)
        {
            return serie.Length / serie.Sum(x => 1 / x);
        }

       
        private double varianza(double[] serie, double media)
        {
            double sumaCuadrados = 0;
            for (int i = 0; i < serie.Length; i++)
            {
                sumaCuadrados += Math.Pow(serie[i], 2);
            }
            double varianza = (sumaCuadrados / serie.Length) - Math.Pow(media, 2);
            return varianza;
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            limpiar();

            if (string.IsNullOrWhiteSpace(txtSerie.Text)) return;

            double[] miSerie = txtSerie.Text.Split(',')
                                           .Select(n => double.Parse(n.Trim()))
                                           .ToArray();

            double m = media(miSerie);

            ltsValores.Items.Add("La media es: " + m);
            ltsValores.Items.Add("La desviacion tipica: " + desviacionTipica(miSerie, m));
            ltsValores.Items.Add("La media armonica: " + armonica(miSerie));
            ltsValores.Items.Add("La desviacion estandar es: " + varianza(miSerie, m));
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
