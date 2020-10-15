using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class Form1 : Form
    {
        double numero = -1;
        

        public Form1()
        {
            
            InitializeComponent();
        }

        public void btnAgregar_Click(object sender, EventArgs e)
        {

            pantalla.Text = numero.ToString();
            numero++;
            pantalla.Clear();
            pantalla.Text = pantalla.Text + numero;
            if (numero == 25)
            {
                MessageBox.Show("Llegaste los 25");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            numero--;
            pantalla.Clear();
            pantalla.Text = pantalla.Text + numero;
            if (numero == 0)
            {
                MessageBox.Show("No hay mas numeros");
            }
        }
    }
}
