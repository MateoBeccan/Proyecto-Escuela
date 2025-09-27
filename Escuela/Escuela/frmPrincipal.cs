using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escuela
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gestiónDeAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumnos Alumnos = new frmAlumnos();
            Alumnos.Show();

        }

        private void gestiónDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNotas Notas = new frmNotas();
            Notas.Show();
        }

        private void asignaturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAsignatura Asignatura = new frmAsignatura();
            Asignatura.Show();
        }

        private void ciudadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCiudades ciudades = new frmCiudades();
            ciudades.Show();
        }

        private void tiposDeExámenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTiposdeExamen tiposdeExamen = new frmTiposdeExamen();
            tiposdeExamen.Show();
        }

        private void listadoDeAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumnosListado alumnosListado  = new frmAlumnosListado();
            alumnosListado.Show();
        }

        private void listadoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void notasDeAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNotasAlumno notasAlumno = new frmNotasAlumno();
            notasAlumno.Show();
        }
    }
}
