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
            //Primero que nada mandamos a ingresar las variables 
            string nombre, apellido;
            DateTime nacimiento;
            int edad;
       
            // Verifica si los campos de Apellido o Nombre están vacíos 
            if (string.IsNullOrEmpty(tbApellido.Text) || string.IsNullOrEmpty(tbNombre.Text))
            {
                // Aquí puedes mostrar un mensaje de advertencia si los campos están vacíos
                MessageBox.Show("Por favor, ingrese tanto el nombre como el apellido.");
            }
            else
            {
                //capturamos los valores y los mandamos a los texbox 
                nombre= tbNombre.Text;
                apellido= tbApellido.Text;
                nacimiento = dtFecha.Value;
                edad= caledad(nacimiento);

                // Almacena la posicion actual del aarreglo y mandamos a incrementar con el index y llamamos al metodo agregar para actualizar la lista
                per[index]= new Personas(nombre, apellido, edad);
                
                index++;
                
                agregar();
                
            }
        }//aqui agg a las personas al lis box
        void agregar()
        {//Limpiamos el lisbox
            lbPersonas.Items.Clear();
            //llamamos al arreglo y agregamos a cada persona a la lista
            for (int i = 0; i < index; i++)
            {
                //Estructuta para que se imprima en el lisbox
                lbPersonas.Items.Add("Nombre: " + per[i].nombre + " " + per[i].apellido + ",  " + per[i].edad + " Años");
                
            }
        }
        //Calculamos como calcular  la edad.
        public int caledad(DateTime fecha)
        {
            DateTime hoy = DateTime.Today;
            return hoy.Year - fecha.Year;
        }
    }
}
