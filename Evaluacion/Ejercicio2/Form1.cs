using Ejercicio2.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        RegistroDeNotas registro = new RegistroDeNotas();
        int index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public void AgregarElemento()
        {
            try
            {
                if (Convert.ToInt32(tbNota.Text) >= 0 && Convert.ToInt32(tbNota.Text) <= 100)
                {
                    //Agregar la nota al arreglo
                    int nota = Convert.ToInt32(tbNota.Text);
                    registro.IngresarNotas(nota, index);
                    index++;
                    tbNota.Clear();
                    tbNota.Focus();
                    MostrarNotas();
                }
                else
                {//Verificar que la nota este en el rango de 0 a 100
                    MessageBox.Show("Alerta: La nota debe estra entre el rango de 0 a 100", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbNota.Clear();
                    tbNota.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Cuidado", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void MostrarNotas()
        {
            lbMostrar.Items.Clear();//Limpiar la lista
            for (int i = 0; i < index; i++)//Agregar las notas al listbox,
                                           //uno por uno hasta llegar al indice(total agregados)
            {
                lbMostrar.Items.Add(registro.ObtenerElemento()[i]);
            }
            //Calcular el promedio
            int sum = registro.ObtenerElemento().Sum();
            double promedio = sum / index;
            lblPromedio.Text = "Promedio: " + promedio.ToString();//Mostrar el promedio
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarElemento();
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            //Mostrar el top 3 mejores notas
            lbTop.Items.Clear();
            int[] notas = registro.ObtenerElemento();
            Array.Sort(notas); //Ordenar el arreglo
            Array.Reverse(notas);//El arreglo se ordena de menor a mayor, 
                                 //por lo que se invierte para mostrar las mejores notas
            for (int i = 0; i < 3; i++)
            {
                lbTop.Items.Add(notas[i]);
            }

        }
    }
}
