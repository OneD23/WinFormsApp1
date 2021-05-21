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
    public partial class CalificarTarea : Form
    {
        string[] datos = new string[10];
        public CalificarTarea(string[] datosi)
        {
            datos = datosi;
            InitializeComponent();
        }

        private void CalificarTarea_Load(object sender, EventArgs e)
        {
            Recargar();
        }

        private void Tareas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NombreTarea.Text =  Tareas.CurrentRow.Cells[4].Value.ToString(); 
            Descripcion.Text = Tareas.CurrentRow.Cells[5].Value.ToString();
            Respuesta.Text = Tareas.CurrentRow.Cells[7].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 conexion = new Class1();
            conexion.abrir();

            SqlCommand comando = new SqlCommand("UPDATE TareasAlumnos SET Puntuacion = @puntuacion WHERE Asignatura = @asignatura AND Seccion = @seccion AND Nombre = @nombre  AND Descripcion = @descripcion AND Respuesta = @respuesta", conexion.Obtener());
            
            comando.Parameters.AddWithValue("@asignatura", datos[0]);
            comando.Parameters.AddWithValue("@puntuacion", nota.Text);
            comando.Parameters.AddWithValue("@seccion", datos[1]);
            comando.Parameters.AddWithValue("@nombre", NombreTarea.Text);
            comando.Parameters.AddWithValue("@respuesta", Respuesta.Text);
            comando.Parameters.AddWithValue("@descripcion", Descripcion.Text);


            comando.ExecuteNonQuery();

            conexion.cerrar();

            Recargar();
        }

        private void Recargar()
        {
            Class1 conexion = new Class1();

            SqlCommand comando = new SqlCommand("SELECT * FROM TareasAlumnos WHERE Asignatura = @asignatura and Seccion = @seccion", conexion.Obtener());
            comando.Parameters.AddWithValue("@asignatura", datos[0]);
            comando.Parameters.AddWithValue("@seccion", datos[1]);
            SqlDataAdapter data = new SqlDataAdapter();

            data.SelectCommand = comando;

            DataTable tabla = new DataTable();
            data.Fill(tabla);
            Tareas.DataSource = tabla;
        }
    }
}
