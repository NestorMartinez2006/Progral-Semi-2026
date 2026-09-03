using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace SistemaEstadistico
{
    public partial class FormEstadistica : Form
    {
        public FormEstadistica()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDatos.Text))
            {
                MessageBox.Show("Por favor, ingrese algunos datos para calcular.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string[] entradas = txtDatos.Text.Split(new[] { ',', ';', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                List<double> datos = new List<double>();

                foreach (string item in entradas)
                {
                    string itemNormalizado = item.Replace(',', '.');

                    if (double.TryParse(itemNormalizado, NumberStyles.Any, CultureInfo.InvariantCulture, out double valor))
                    {
                        datos.Add(valor);
                    }
                    else
                    {
                        MessageBox.Show($"El valor '{item}' no es un número válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (datos.Count == 0)
                {
                    MessageBox.Show("No se encontraron números válidos en la entrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                datos = datos.OrderBy(n => n).ToList();
                int count = datos.Count;

                double media = datos.Average();

                double mediana = (count % 2 == 0)
                    ? (datos[(count / 2) - 1] + datos[count / 2]) / 2.0
                    : datos[count / 2];

                var frecuenciasGroup = datos.GroupBy(x => x)
                    .Select(g => new { Valor = g.Key, Frecuencia = g.Count() })
                    .OrderByDescending(x => x.Frecuencia)
                    .ToList();

                int maxFrecuencia = frecuenciasGroup.First().Frecuencia;
                var modas = frecuenciasGroup.Where(x => x.Frecuencia == maxFrecuencia && maxFrecuencia > 1)
                                            .Select(x => x.Valor)
                                            .ToList();

                string modaStr = modas.Any()
                    ? string.Join(", ", modas.Select(m => m.ToString("0.##", CultureInfo.InvariantCulture)))
                    : "No hay moda (frecuencia = 1)";

                double varianza = count > 1
                    ? datos.Sum(x => Math.Pow(x - media, 2)) / (count - 1)
                    : 0;

                double desviacionEstandar = Math.Sqrt(varianza);
                double rango = datos.Max() - datos.Min();

                txtResultados.Clear();
                txtResultados.AppendText("--- RESULTADOS ---\n\n");
                txtResultados.AppendText($"Total datos (n): {count}\n");
                txtResultados.AppendText($"Media: {media:F2}\n");
                txtResultados.AppendText($"Mediana: {mediana:F2}\n");
                txtResultados.AppendText($"Moda: {modaStr}\n");
                txtResultados.AppendText($"Varianza: {varianza:F2}\n");
                txtResultados.AppendText($"Desv. Estándar: {desviacionEstandar:F2}\n");
                txtResultados.AppendText($"Rango: {rango:F2}\n");

                DataTable tablaFrec = new DataTable();
                tablaFrec.Columns.Add("Dato (x)", typeof(double));
                tablaFrec.Columns.Add("Frec. Absoluta (f)", typeof(int));
                tablaFrec.Columns.Add("Frec. Relativa (r)", typeof(string));

                foreach (var item in frecuenciasGroup.OrderBy(x => x.Valor))
                {
                    double rel = (double)item.Frecuencia / count;
                    tablaFrec.Rows.Add(item.Valor, item.Frecuencia, $"{rel:P2}");
                }

                dgvFrecuencias.DataSource = null;
                dgvFrecuencias.DataSource = tablaFrec;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error de ejecución", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDatos.Clear();
            txtResultados.Clear();
            dgvFrecuencias.DataSource = null;
            txtDatos.Focus();
        }
    }
}