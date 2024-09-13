using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.models
{
    internal class RegistroDeNotas
    {
        int[] notas = new int[1000]; //Arreglo de 1000 elementos
        public void IngresarNotas(int nota, int posicion)
        {
            notas[posicion] = nota; //Agregar la nota en la posicion indicada
        }
        public int[] ObtenerElemento()
        {
            return notas; //Retornar el arreglo de notas
        }

    }
}
