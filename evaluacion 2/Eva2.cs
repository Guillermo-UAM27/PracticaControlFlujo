using Evaluacion2.Notas;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion2
{
    public partial class Form1 : Form
    {
        private RegistroDeNotas registro = new RegistroDeNotas();
        private int index = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarElemento();
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            MostrarTopTres();
        }
        private void AgregarElemento()
        {
            try
            {
                // Convierte la entrada a numeros enteros.
                if (int.TryParse(tbNota.Text, out int nota) && nota >= 0 && nota <= 100)
                {
                    // Mandamos a limpiar los texbox y agregar las notas
                    registro.IngresarNotas(nota, index);
                    index++;
                    tbNota.Clear();
                    tbNota.Focus();
                    MostrarNotas();
                }
                else
                {
                    MessageBox.Show("La nota debe estar entre 0 y 100.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Manndamos a Mostrar Notas
        private void MostrarNotas()
        {
            lbMostrar.Items.Clear();
            int[] notas = registro.ObtenerElemento();
           for (int i = 0; i < notas.Length; i++)

            {
                lbMostrar.Items.Add(notas[i]);
            }

            //Calculamos el promedio y mandamos a mostrar al Lisbox
            double promedio = notas.Average();
            lblPromedio.Text = "Promedio: " + promedio.ToString();
        }
        //Aqui la funcion busca hacer que el top tres se imprima en un lb aparte, en donde el array funciona para ordenar las notas agregar.
        private void MostrarTopTres()
        {
            lbTop.Items.Clear();
            int[] notas = registro.ObtenerElemento();
            Array.Sort(notas);
            Array.Reverse(notas);
            for (int i = 0; i < Math.Min(3, notas.Length); i++)
            {
                lbTop.Items.Add(notas[i]);
            }
        }

            private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
