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
    public partial class AgregarMaterias : Form
    {
        string[] datos = new string[10];
        public AgregarMaterias(string[] datosi)
        {
            datos = datosi;
            InitializeComponent();
        }

        private void AgregarMaterias_Load(object sender, EventArgs e)
        {
            Class1 conexion = new Class1();
            conexion.abrir();

            SqlCommand comando = new SqlCommand("SELECT AsignaturaProfesor.Nombre, AsignaturaProfesor.Seccion, Profesor.Nombre, Profesor.Apellido FROM AsignaturaProfesor, Profesor WHERE  AsignaturaProfesor.Matricula = Profesor.Matricula ", conexion.Obtener());
            SqlDataAdapter data = new SqlDataAdapter();

            data.SelectCommand = comando;

            DataTable tabla = new DataTable();
            data.Fill(tabla);
            Materias.DataSource = tabla;

            conexion.cerrar();

        }

        private void Materias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Asignatura.Text = Materias.CurrentRow.Cells[0].Value.ToString();
            Profesor.Text = Materias.CurrentRow.Cells[2].Value.ToString();
            Seccion.Text = Materias.CurrentRow.Cells[1].Value.ToString();

            Asignatura.Enabled = false;
            Profesor.Enabled = false;
            Seccion.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 conexion = new Class1();

            conexion.abrir();

            SqlCommand comando = new SqlCommand("insert into AsignaturaAlumno(Matricula, Seccion, Nombre) values(@matricula, @seccion, @asignatura)", conexion.Obtener());
            comando.Parameters.AddWithValue("@matricula", datos[2]);
            comando.Parameters.AddWithValue("@seccion", Seccion.Text);
            comando.Parameters.AddWithValue("@asignatura", Asignatura.Text);
            comando.ExecuteNonQuery();

            conexion.cerrar();
            Profesor.Text = "";
            Seccion.Text = "";
            Asignatura.Text = "";
        }
    }
}
