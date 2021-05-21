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
    
    public partial class Moderno : Form
    {
        private string id;
        private string[] arregloMateria = new string[10];
        private string[] arregloSeccion = new string[10];

        private string[] datos = new string[10];

        public Moderno(string ids)
        {
            id = ids;
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
      

       

        public String Ids()
        {
            
            return ID.Text;
        }
        public void SetIds(string nuevo)
        {
            ID.Text = nuevo;
        }


        private void Moderno_Load(object sender, EventArgs e)
        {
            string m = "";
            Class1 conex = new Class1();
            conex.abrir();
            SqlCommand comando = new SqlCommand("SELECT * FROM Profesor WHERE Matricula = @matricula", conex.Obtener());
            comando.Parameters.AddWithValue("@matricula", id);

            
            SqlDataReader rd = comando.ExecuteReader();

            while (rd.Read())
            {
                try {
                    byte[] img = (byte[])rd["Foto"];
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(img);
                    FotoPerfil.Image = Image.FromStream(ms);
                }
                catch
                {
                    FotoPerfil.Image = null;
                }

                
                m = rd["Matricula"].ToString();
                
                datos[2] = m; 
                datos[3] = rd["Nombre"].ToString(); 
                datos[4] = rd["apellido"].ToString(); 
                datos[5] = rd["Matricula"].ToString(); 

            }
            rd.Close();
           
            comando = new SqlCommand("SELECT Nombre, Seccion FROM AsignaturaProfesor WHERE Matricula =" + m, conex.Obtener());
            int contador = 1;

            NombreCompleto.Text = datos[3] +" "+ datos[4];
            label23.Text = datos[2];

            NombreCompleto.Visible = true;
            label23.Visible = true;


            rd = comando.ExecuteReader();
            while (rd.Read())
            {
                switch (contador)
                {
                    case 1:
                        label1.Text = rd["Nombre"].ToString();
                        arregloMateria[0] = rd["Nombre"].ToString();
                        label1.Visible = true;

                        label13.Text = rd["Seccion"].ToString();
                        arregloSeccion[0] = rd["Seccion"].ToString();
                        label13.Visible = true;


                        pictureBox2.Visible = true;

                        break;

                    case 2:
                        label2.Text = rd["Nombre"].ToString();
                        arregloMateria[1] = rd["Nombre"].ToString();

                        label14.Text = rd["Seccion"].ToString();
                        arregloSeccion[1] = rd["Seccion"].ToString();
                        label14.Visible = true;

                        label2.Visible = true;
                        pictureBox3.Visible = true;

                        break;

                    case 3:
                        label3.Text = rd["Nombre"].ToString();
                        arregloMateria[2] = rd["Nombre"].ToString();

                        label15.Text = rd["Seccion"].ToString();
                        arregloSeccion[2] = rd["Seccion"].ToString();
                        label15.Visible = true;

                        label3.Visible = true;
                        pictureBox4.Visible = true;

                        break;

                    case 4:
                        label4.Text = rd["Nombre"].ToString();
                        arregloMateria[3] = rd["Nombre"].ToString();

                        label16.Text = rd["Seccion"].ToString();
                        arregloSeccion[3] = rd["Seccion"].ToString();
                        label16.Visible = true;

                        label4.Visible = true;
                        pictureBox5.Visible = true;

                        break;

                    case 5:
                        label5.Text = rd["Nombre"].ToString();
                        arregloMateria[4] = rd["Nombre"].ToString();

                        label20.Text = rd["Seccion"].ToString();
                        arregloSeccion[4] = rd["Seccion"].ToString();
                        label20.Visible = true;

                        label5.Visible = true;
                        pictureBox6.Visible = true;

                        break;

                    case 6:
                        label6.Text = rd["Nombre"].ToString();
                        arregloMateria[5] = rd["Nombre"].ToString();

                        label19.Text = rd["Seccion"].ToString();
                        arregloSeccion[5] = rd["Seccion"].ToString();
                        label19.Visible = true;

                        label6.Visible = true;
                        pictureBox7.Visible = true;

                        break;

                    case 7:
                        label7.Text = rd["Nombre"].ToString();
                        arregloMateria[6] = rd["Nombre"].ToString();

                        label18.Text = rd["Seccion"].ToString();
                        arregloSeccion[6] = rd["Seccion"].ToString();
                        label18.Visible = true;

                        label7.Visible = true;
                        pictureBox8.Visible = true;

                        break;

                    case 8:
                        label8.Text = rd["Nombre"].ToString();
                        arregloMateria[7] = rd["Nombre"].ToString();

                        label17.Text = rd["Seccion"].ToString();
                        arregloSeccion[7] = rd["Seccion"].ToString();
                        label17.Visible = true;

                        label8.Visible = true;
                        pictureBox9.Visible = true;

                        break;

                    case 9:
                        label9.Text = rd["Nombre"].ToString();
                        arregloMateria[8] = rd["Nombre"].ToString();

                        label21.Text = rd["Seccion"].ToString();
                        arregloSeccion[8] = rd["Seccion"].ToString();
                        label21.Visible = true;

                        label9.Visible = true;
                        pictureBox10.Visible = true;

                        break;

                    case 10:
                        label10.Text = rd["Nombre"].ToString();
                        arregloMateria[9] = rd["Nombre"].ToString();

                        label22.Text = rd["Seccion"].ToString();
                        arregloSeccion[9] = rd["Seccion"].ToString();
                        label22.Visible = true;

                        pictureBox11.Visible = true;

                        label10.Visible = true;
                        break;

                }

                contador++;
            }

            conex.cerrar();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            datos[0] = arregloMateria[0];
            datos[1] = arregloSeccion[0];

            MateriaProfesor materia = new MateriaProfesor(datos);
            this.Dispose();
            materia.Show();

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            datos[0] = arregloMateria[1];
            datos[1] = arregloSeccion[1];

            MateriaProfesor materia = new MateriaProfesor(datos);
            this.Dispose();
            materia.Show();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            datos[0] = arregloMateria[2];
            datos[1] = arregloSeccion[2];

            MateriaProfesor materia = new MateriaProfesor(datos);
            this.Dispose();
            materia.Show();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            datos[0] = arregloMateria[3];
            datos[1] = arregloSeccion[3];

            MateriaProfesor materia = new MateriaProfesor(datos);
            this.Dispose();
            materia.Show();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            datos[0] = arregloMateria[4];
            datos[1] = arregloSeccion[4];

            MateriaProfesor materia = new MateriaProfesor(datos);
            this.Dispose();
            materia.Show();

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            datos[0] = arregloMateria[5];
            datos[1] = arregloSeccion[5];

            MateriaProfesor materia = new MateriaProfesor(datos);
            this.Dispose();
            materia.Show();

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            datos[0] = arregloMateria[6];
            datos[1] = arregloSeccion[6];

            MateriaProfesor materia = new MateriaProfesor(datos);
            this.Dispose();
            materia.Show();

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            datos[0] = arregloMateria[7];
            datos[1] = arregloSeccion[7];

            MateriaProfesor materia = new MateriaProfesor(datos);
            this.Dispose();
            materia.Show();

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            datos[0] = arregloMateria[8];
            datos[1] = arregloSeccion[8];

            MateriaProfesor materia = new MateriaProfesor(datos);
            this.Dispose();
            materia.Show();

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            datos[0] = arregloMateria[9];
            datos[1] = arregloSeccion[9];

            MateriaProfesor materia = new MateriaProfesor(datos);
            this.Dispose();
            materia.Show();

        }
        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Program.inicio.Visible = true;
            this.Dispose();
        }
    }
}
