using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Incripciones.controlDeInscripción;

namespace Incripciones
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonInscripciones_Click(object sender, EventArgs e)
        {
            FormInscripcion formInscripcion = new FormInscripcion();
            formInscripcion.ShowDialog();
        }

        private void buttonReporte_Click(object sender, EventArgs e)
        {
            FormReporte formReporte = new FormReporte();
            formReporte.ShowDialog();
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
