using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int Registrados;
        private Int64 cantidad_Per;
        Contacto[] arreglo;
        public Form1()
        {
            InitializeComponent();
            Registrados = 0;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            if ((Registrados < cantidad_Per))
            {
                var contactonuevo = new Contacto();
                contactonuevo._nombre = TXTnombre.Text;
                contactonuevo.correo_ = TXTcorreo.Text;
                contactonuevo._telefono = TXTtelefono.Text;
                contactonuevo._fechaNacimineto = DTfecha.Value;
                arreglo[Registrados] = contactonuevo;
                Registrados = Registrados + 1;
                string newline = contactonuevo._nombre + ", " + contactonuevo._telefono.ToString() + ", " + contactonuevo.Edad_.ToString() + ", " + contactonuevo.correo_.ToString() + Environment.NewLine;
                Datos.Text = Datos.Text + newline;
            }
            else
                MessageBox.Show("Toy LLenito, Para");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LBLtelefono_Click(object sender, EventArgs e)
        {

        }

        private void LBLnombre_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            cantidad_Per = Convert.ToInt64(NUDcantidad.Value);
            arreglo = new Contacto[cantidad_Per];
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    internal class ReDim
    {
    }
}

