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
    public partial class Asignacion : Form
    {
        string facultadMateria;
        public Asignacion()
        {
            InitializeComponent();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            Class1 conexion = new Class1();

            conexion.abrir();

            SqlCommand comando = new SqlCommand("insert into AsignaturaProfesor(Matricula, Seccion, Nombre) values(@matricula, @seccion, @asignatura)", conexion.Obtener());
            comando.Parameters.AddWithValue("@matricula", Matricula.Text);
            comando.Parameters.AddWithValue("@seccion",Seccion.Text);
            comando.Parameters.AddWithValue("@asignatura",Asignatura.Text);
            comando.ExecuteNonQuery();

            conexion.cerrar();
            Matricula.Text = "";
            Seccion.Text = "";
            Asignatura.Text = "";
        
        }

        private void Asignatura_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Asignacion_Load(object sender, EventArgs e)
        {
            Asignatura.Enabled = false;
            Seccion.Enabled = false;
            button1.Enabled = false;
            Matricula.Enabled = false;

            Class1 conexion = new Class1();
            conexion.abrir();

            

            SqlCommand comando = new SqlCommand("SELECT * FROM Materia", conexion.Obtener());
            SqlDataReader rd = comando.ExecuteReader();

            while (rd.Read())
            {
                dataGridView1.Rows.Add(rd["Materia"].ToString(), rd["Seccion"].ToString(), rd["Creditos"].ToString(), rd["Facultad"].ToString());

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Matricula_TextChanged(object sender, EventArgs e)
        {
            if (Matricula.TextLength == 9)
            {
                string[] datos = new string[10];

                Class1 conexion = new Class1();
                conexion.abrir();

                bool existe = false;

                SqlCommand comando = new SqlCommand("SELECT * FROM Profesor WHERE Matricula = @matricula", conexion.Obtener());
                comando.Parameters.AddWithValue("@matricula", Matricula.Text);

                SqlDataReader rd = comando.ExecuteReader();

                while (rd.Read())
                {

                    datos[0] = rd["Nombre"].ToString();
                    datos[1] = rd["Apellido"].ToString();
                    datos[7] = rd["Facultad"].ToString();
                    existe = true;

                }

                if (!existe)
                {
                    MessageBox.Show("Esta matricula no esta registrada");
                }
                else
                {   
                    string nom = datos[0] + " " + datos[1];

                    if (datos[7] == facultadMateria)
                    {
                        button1.Enabled = true;
                        Guardar.Enabled = true;
                        Nombre.Text = nom;

                    }
                    else
                    {
                        MessageBox.Show("La facultad a la que petenece la materia no es la misma a la que pertenece el profesor");
                    }
                    
                }

                conexion.cerrar();
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Program.inicio.Visible = true;
            this.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Class1 conexion = new Class1();
            conexion.abrir();

            SqlCommand comando = new SqlCommand("SELECT * FROM AsignaturaProfesor WHERE Nombre = @nombre AND Seccion = @seccion", conexion.Obtener());
            comando.Parameters.AddWithValue("@nombre", dataGridView1.CurrentRow.Cells[0].Value.ToString());
            comando.Parameters.AddWithValue("@seccion", dataGridView1.CurrentRow.Cells[1].Value.ToString());
            
            SqlDataReader rd = comando.ExecuteReader();
            bool existe =  false;
            while (rd.Read())
            {
                existe = true;
            }

            if (existe)
            {
                MessageBox.Show("La materia " + dataGridView1.CurrentRow.Cells[0].Value.ToString() + " con la seccion " + dataGridView1.CurrentRow.Cells[1].Value.ToString() + " ya fue asignada a otro profesor");
            }
            else
            {
                Asignatura.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Seccion.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                facultadMateria = dataGridView1.CurrentRow.Cells[3].Value.ToString();

                Asignatura.Enabled = false;
                Seccion.Enabled = false;
                Matricula.Enabled = true;
            }

        }
    }
}
