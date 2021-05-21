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
    public partial class Form2 : Form
    {
        private string id;
        private string[] arregloMateria = new string[10];
        private string[] arregloSeccion = new string[10];

        private string[] datos = new string[10];

        public Form2(string[] datosi)
        {
            id = datosi[2];
            datos = datosi;
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



        private void Form2_Load_1(object sender, EventArgs e)
        {
            string m = "";
            Class1 conex = new Class1();
            conex.abrir();
            SqlCommand comando = new SqlCommand("SELECT * FROM Alumnos WHERE Matricula = @matricula", conex.Obtener());
            comando.Parameters.AddWithValue("@matricula", id);

            SqlDataReader rd = comando.ExecuteReader();
            
            while (rd.Read())
            {
                try
                {
                    byte[] img = (byte[])rd["Foto"];
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(img);
                    FotoPerfil.Image = Image.FromStream(ms);
                }
                catch
                {
                    FotoPerfil.Image = null;
                }

                m = rd["Matricula"].ToString();
                datos[2] = rd["Matricula"].ToString(); 
                datos[3] = rd["Nombre"].ToString(); 
                datos[4] = rd["apellido"].ToString(); 
                datos[5] = rd["Matricula"].ToString(); 
                
            }
            NombreCompleto.Text = datos[3] + " " + datos[4];
            Matricula.Text = m;
           
            AbrirFormHija(new MenuPrincipal(datos, My()));

         

            conex.cerrar();
        }


        Form My()
        {

            return this;
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            AbrirFormHija(new AgregarMaterias(datos));
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new MenuPrincipal(datos, this));
            pictureBox6.Visible = false;
        }
    }
}
