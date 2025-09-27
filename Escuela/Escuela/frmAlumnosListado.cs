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
    public partial class frmAlumnosListado : Form
    {
        public frmAlumnosListado()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgbAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
