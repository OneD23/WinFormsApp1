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
/* 
datos[0] = Materia
datos[1] = seccion
datos[2] = Matricula
datos[3] = Nombre
datos[4] = Apellido
 */

{
    public partial class TareaEstudiante : Form
    {
        private string[] datos = new string[10];
        public TareaEstudiante(string[] datosi)
        {
            datos = datosi;
           
            InitializeComponent();
        }

        private void TareaEstudiante_Load(object sender, EventArgs e)
        {
            
            Class1 conexion = new Class1();
            conexion.abrir();

            SqlCommand comando = new SqlCommand("SELECT Nombre, Descripcion, FechaLimite FROM TareaProfesor WHERE Asignatura = @asignatura and Seccion = @seccion", conexion.Obtener());
            comando.Parameters.AddWithValue("@asignatura", datos[0]);
            comando.Parameters.AddWithValue("@seccion", datos[1]);

            SqlDataAdapter data = new SqlDataAdapter();

            data.SelectCommand = comando;

            DataTable tabla = new DataTable();
            data.Fill(tabla);
            dataGridView1.DataSource = tabla;

            DescripcionTarea.Enabled = false;

            conexion.cerrar();
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string nombre = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string descripcion = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            NombreTarea.Text = nombre;
            DescripcionTarea.Text = descripcion;

            Class1 conexion = new Class1();

            conexion.abrir();

            SqlCommand comando = new SqlCommand("SELECT * FROM TareasAlumnos WHERE Matricula = @matricula AND Asignatura = @asignatura and Nombre = @nombre and Descripcion = @descripcion", conexion.Obtener());
            comando.Parameters.AddWithValue("@matricula", datos[2]);
            comando.Parameters.AddWithValue("@asignatura", datos[0]);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@descripcion", descripcion);

            SqlDataReader rd = comando.ExecuteReader();

            while (rd.Read())
            {
                if (rd["Respuesta"].ToString().Length > 1)
                {
                    Respuesta.Enabled = false;
                    Respuesta.Text = rd["Respuesta"].ToString();
                    MessageBox.Show("Ya esta tarea esta hecha y guardada, no puede modificarla");
                }
                else
                {
                    Respuesta.Enabled = true;     
                }
            }

            conexion.cerrar();
            DateTime now = DateTime.Now;
            string date = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

       

        private void Guardo_Click(object sender, EventArgs e)
        {
            Class1 conn = new Class1();

            conn.abrir();

            string query = @"INSERT INTO TareasAlumnos (Matricula, Asignatura, Seccion, Nombre, Descripcion, Respuesta)
                             VALUES (@matricula, @asignatura, @seccion, @nombre, @descripcion, @respuesta)";

            SqlCommand cmd = new SqlCommand(query, conn.Obtener());

            cmd.Parameters.AddWithValue("@matricula", datos[2]);
            cmd.Parameters.AddWithValue("@Asignatura", datos[0]);
            cmd.Parameters.AddWithValue("@seccion", datos[1]);
            cmd.Parameters.AddWithValue("@nombre", NombreTarea.Text);
            cmd.Parameters.AddWithValue("@descripcion", DescripcionTarea.Text);
            cmd.Parameters.AddWithValue("@respuesta", Respuesta.Text);

            cmd.ExecuteNonQuery();

            Respuesta.Enabled = false;


            conn.cerrar();
        }
    }
}
