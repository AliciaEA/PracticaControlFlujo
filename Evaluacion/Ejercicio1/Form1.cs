using Ejercicio1.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        RegistroUsuario registro = new RegistroUsuario();
        int index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        //Funcion Limpiar
        public void limpiarTodo()
        {
            tbPasswordRe.Clear();
            tbNameRe.Clear();
            tbNameRe.Focus();

            tbNameVer.Clear();
            tbNameVer.Focus();
            tbPasswordVer.Clear();

        }

        //Funcion Verificacion de entrada
        public bool verificarEntrada(string entrada)
        {
            if (string.IsNullOrEmpty(entrada))
            {
                MessageBox.Show("El campo no puede estar vacio", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                limpiarTodo();
                return false;
            }
            else
            {
                return true;
            }

        }

        //Registro de Usuario
        //Funciones 
        public void AgregarUsuario()
        {
            Usuario usuario = new Usuario(); //Usuario que se agregara al registro

            //Creamos variables que almacenaran temporalmente los datos ingresados
            string nickname = tbNameRe.Text.Trim();
            string password = tbPasswordRe.Text.Trim();

            //Funcion para validar entrada de datos
            if (!verificarEntrada(nickname) || !verificarEntrada(password))
            {
                return;
            }

            //Asignamos los datos al usuario y lo agregamos al registro
            usuario.Nickname = nickname;
            usuario.Password = password;

            if (index >= 25)//Verificamos si el registro esta lleno
            {
                MessageBox.Show("Registro de Usuarios Lleno", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            registro.AgregarUsuario(usuario, index);
            index++;//Incrementamos el indice para el siguiente usuario
            limpiarTodo();

            MessageBox.Show("Usuario Registrado Exitosamente", "Confirmacion",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            AgregarUsuario();
        }

        //Verificacion de Usuario
        public void VerificarUsuario()
        {

            Usuario usuario = new Usuario(); //Usuario que se verificara

            //Creamos variables que almacenaran temporalmente los datos ingresados
            string nickname = tbNameVer.Text.Trim();
            string password = tbPasswordVer.Text.Trim();

            //Funcion para validar entrada de datos
            if (!verificarEntrada(nickname) || !verificarEntrada(password))
            {
                return;
            }

            //Asignamos los datos al usuario y lo agregamos al registro
            usuario.Nickname = nickname;
            usuario.Password = password;

            //Verificamos si el usuario esta registrado
            if (registro.VerificarUsuario(usuario))
            {
                limpiarTodo();
                //Si el usuario esta registrado mostramos un mensaje de confirmacion
                MessageBox.Show("Usuario Verificado", "Confirmacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                limpiarTodo();
                //Si el usuario no esta registrado mostramos un mensaje de error
                MessageBox.Show("Usuario No Verificado", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            VerificarUsuario();
        }
    }
}
