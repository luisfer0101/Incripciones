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
using Newtonsoft.Json;
using System.IO;

namespace Incripciones
{
    public partial class FormReporte : Form
    {
        private List<Alumno> alumnos;
        private List<Taller> talleres;
        private List<Inscripcion> inscripciones;
        List<dataReporte> reporte = new List<dataReporte>();
        List<dataReporte> listaReporte = new List<dataReporte>();
        public FormReporte()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            alumnos = JsonConvert.DeserializeObject<List<Alumno>>(File.ReadAllText("alumnos.json")) ?? new List<Alumno>();
            talleres = JsonConvert.DeserializeObject<List<Taller>>(File.ReadAllText("talleres.json")) ?? new List<Taller>();
            inscripciones = JsonConvert.DeserializeObject<List<Inscripcion>>(File.ReadAllText("inscripciones.json")) ?? new List<Inscripcion>();
            listaReporte = new List<dataReporte>();

            
            foreach (Inscripcion ins in inscripciones)
            {
                Alumno alumnoEncontrado = null;
                Taller tallerEncontrado = null;

                
                foreach (Alumno a in alumnos)
                {
                    if (a.Dpi == ins.DpiAlumno)
                    {
                        alumnoEncontrado = a;
                        break;
                    }
                }

                
                foreach (Taller t in talleres)
                {
                    if (t.Codigo == ins.CodigoTaller)
                    {
                        tallerEncontrado = t;
                        break;
                    }
                }

               
                if (alumnoEncontrado != null && tallerEncontrado != null)
                {
                    dataReporte reporte = new dataReporte
                    {
                        NombreAlumno = alumnoEncontrado.Nombre,
                        TallerInscrito = tallerEncontrado.Codigo,
                        Fecha = ins.FechaInscripcion
                    };

                    listaReporte.Add(reporte);
                }
            }

           
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaReporte;
        }



        private void button3_Click(object sender, EventArgs e)
        {
            //btn ordenar
            listaReporte.Sort((x, y) => x.TallerInscrito.CompareTo(y.TallerInscrito));

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaReporte;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total de estudiantes inscritos: " + listaReporte.Count);
        }
    }
}
