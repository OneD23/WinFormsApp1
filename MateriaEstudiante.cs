using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class MateriaEstudiante : Form
    {
        private string[] datos = new string[10];
        public MateriaEstudiante(string[] datosi)
        {
            datos = datosi;
          
            InitializeComponent();
        }

        private void MateriaEstudiante_Load(object sender, EventArgs e)
        {

            ID.Text = datos[2];
            AbrirFormHija(new Calificaciones(datos));
        }

        private void AbrirFormHija(object hija)
        {
            if (this.ptro.Controls.Count > 0)
            {
                ptro.Controls.RemoveAt(0);
            }
            Form fh = hija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;

            this.ptro.Controls.Add(fh);
            this.ptro.Tag = fh;

            fh.Show();
        }

    

        private void Cerrar_Click(object sender, EventArgs e)
        {

            Program.inicio.Visible = true;
            this.Dispose();
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            //Restaurar.Visible = true;
            Maximizar.Visible = false;
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            // Restaurar.Visible = false;
            Maximizar.Visible = true;
        }

        private void Tareas_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new TareaEstudiante(datos));
        }

        private void Calificaciones_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Calificaciones(datos));
        }

        private void Examenes_Click_1(object sender, EventArgs e)
        {
            AbrirFormHija(new ExamenEstudiante(datos));
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            Program.inicio.Visible = true;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Program.inicio.Visible = true;
            this.Dispose();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form2 estudiante = new Form2(datos);
            estudiante.Show();
            this.Dispose();
        }
    }
}
