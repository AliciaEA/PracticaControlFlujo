using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.models
{
    internal class RegistroUsuario
    {
        //Arreglo de Usuarios que se registraran
        Usuario[] Usuarios = new Usuario[25];

        //Metodo para agregar un usuario al registro
        public void AgregarUsuario(Usuario usuario, int posicion)
        {
            Usuarios[posicion] = usuario;
        }

        //Metodo para verificar si el usuario ya esta registrado
        public Boolean VerificarUsuario(Usuario usuario)
        {
            for (int i = 0; i < Usuarios.Length; i++)
            {
                if (Usuarios[i] != null)
                {
                    if (Usuarios[i].Nickname == usuario.Nickname && //Si la clave y nickname coinciden, retorna verdadero
                        Usuarios[i].Password == usuario.Password)
                    {
                        return true;//Indica usuario registrado
                    }
                }
            }
            return false;
        }
    }
}
