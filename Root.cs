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
    public partial class Root : Form
    {
        public Root()
        {
            InitializeComponent();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            
            Program.inicio.Visible = true;
                this.Dispose();
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Restaurar.Visible = true;
            Maximizar.Visible = false;
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            Maximizar.Visible = true;
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
        public String Ids()
        {
            return Id.Text;
        }
        public void SetIds(string nuevo)
        {
             Id.Text = nuevo;
        }
        private void contenido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new EditarAlumnos());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new EditarProfesor());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Asignacion());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Materias());
        }
    }
}
