using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void registrar_Click(object sender, EventArgs e)
        {
            Form Registrar = new Registrar();
            Registrar.Show();
        }

        private void asistencia_Click(object sender, EventArgs e)
        {
            Form Asistencia = new Borrar();
            Asistencia.Show();
        }

        private void calificar_Click(object sender, EventArgs e)
        {
            Form Calificar = new Calificar();
            Calificar.Show();
        }

        private void listar_Click(object sender, EventArgs e)
        {
            Form Listar = new Listar();
            Listar.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
