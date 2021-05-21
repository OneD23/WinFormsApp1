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
    public partial class MateriaProfesor : Form
    {
        private string[] datos = new string[10];
        public MateriaProfesor(string[] datosi)
        {
            datos = datosi;
            InitializeComponent();
        }

        private void Tareas_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new TareaProfesor(datos));
        }

        private void AbrirFormHija(object hija)
        {
            if (this.contenido.Controls.Count > 0)
            {
                contenido.Controls.RemoveAt(0);
            }
            Form fh = hija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;

            this.contenido.Controls.Add(fh);
            this.contenido.Tag = fh;

            fh.Show();
        }

        private void Examenes_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Examenes(datos));

        }

        private void Calificaciones_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new CalificarTarea(datos));
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Program.inicio.Visible = true;
            this.Dispose();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Program.inicio.Visible = true;
            this.Dispose();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            Moderno profe = new Moderno(datos[3]);
            profe.Show();
        }

        private void MateriaProfesor_Load(object sender, EventArgs e)
        {
            AbrirFormHija(new CalificarTarea(datos));

        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {
            Moderno pro = new Moderno(datos[2]);
            pro.Show();
            this.Dispose();
        }
    }
}
