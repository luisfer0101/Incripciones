using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using Incripciones.controlDeInscripción;
using Formatting = Newtonsoft.Json.Formatting;

namespace Incripciones
{
    public partial class FormInscripcion : Form
    {
        private List<Alumno> alumnos = new List<Alumno>();
        private List<Taller> talleres = new List<Taller>();
        private List<Inscripcion> inscripciones = new List<Inscripcion>();

        private string archivoAlumnos = "alumnos.json";
        private string archivoTalleres = "talleres.json";
        private string archivoInscripciones = "inscripciones.json";
        public FormInscripcion()
        {
            InitializeComponent();
            this.Load += FormInscripcion_Load;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (comboBoxAlumno.SelectedItem == null || comboBoxTaller.SelectedItem == null)
            {
                MessageBox.Show("Seleccioná un alumno y un taller.");
                return;
            }

            string nombreAlumno = comboBoxAlumno.SelectedItem.ToString();
            string nombreTaller = comboBoxTaller.SelectedItem.ToString();

            string dpi = alumnos.First(a => a.Nombre == nombreAlumno).Dpi;
            string codigo = talleres.First(t => t.Nombre == nombreTaller).Codigo;

            Inscripcion ins = new Inscripcion
            {
                DpiAlumno = dpi,
                CodigoTaller = codigo,
                FechaInscripcion = DateTime.Now
            };

            if (File.Exists(archivoInscripciones))
                inscripciones = JsonConvert.DeserializeObject<List<Inscripcion>>(File.ReadAllText(archivoInscripciones)) ?? new List<Inscripcion>();

            inscripciones.Add(ins);
            File.WriteAllText(archivoInscripciones, JsonConvert.SerializeObject(inscripciones, Formatting.Indented));

            MessageBox.Show("Inscripción guardada.");
        }

        //metodos


        private void FormInscripcion_Load(object sender, EventArgs e)
        {
            alumnos = JsonConvert.DeserializeObject<List<Alumno>>(File.ReadAllText(archivoAlumnos)) ?? new List<Alumno>();
            talleres = JsonConvert.DeserializeObject<List<Taller>>(File.ReadAllText(archivoTalleres)) ?? new List<Taller>();

            comboBoxAlumno.Items.AddRange(alumnos.Select(a => a.Nombre).ToArray());
            comboBoxTaller.Items.AddRange(talleres.Select(t => t.Nombre).ToArray());
        }

    }
}

