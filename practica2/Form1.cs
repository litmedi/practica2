using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btguardar_Click(object sender, EventArgs e)
        {
            string Nombre = texNombre.Text;
            string Apellido = texApellido.Text;
            string Edad = texEdad.Text;
            string Estatura = texEstatura.Text;
            string Telefono = texTelefono.Text;


            string genero = "";
            if (rbhombre.Checked)
            {
                genero = "Hombre";
            }
            else if (rbmujer.Checked)
            {
                genero = "Mujer";
            }

            string datos = $"Nombres: {Nombre}\r\nApellido:{Apellido}\r\nTelefono"
        }
    }
}
