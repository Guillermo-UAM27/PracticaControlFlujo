using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion
{
    public partial class Form1 : Form
    {
        Personas[] per = new Personas[20];
        int index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre, apellido;
            DateTime nacimiento;
            int edad;
            if(string.IsNullOrEmpty(tbApellido.Text) || string.IsNullOrEmpty(tbNombre.Text))
            {

            }
            else
            {
                nombre= tbNombre.Text;
                apellido= tbApellido.Text;
                nacimiento = dtFecha.Value;
                edad= caledad(nacimiento);


                per[index]= new Personas(nombre, apellido, edad);
                
                index++;

                agregar();
                
            }
        }
        void agregar()
        {
            lbPersonas.Items.Clear();
            for (int i = 0; i < index; i++)
            {
                lbPersonas.Items.Add(per[i].nombre + " " + per[i].apellido + " " + per[i].edad);
                
            }
        }

        public int caledad(DateTime fecha)
        {
            DateTime hoy = DateTime.Today;
            return hoy.Year - fecha.Year;
        }
    }
}
