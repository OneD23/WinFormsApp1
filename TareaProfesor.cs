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
    public partial class TareaProfesor : Form
    {
        private string[] datos = new string[10];
        public TareaProfesor(string[] datosi)
        {
            datos = datosi;
            InitializeComponent();
        }

        private void Guardo_Click(object sender, EventArgs e)
        {
            Class1 conn = new Class1();

            conn.abrir();

           
            SqlCommand cmd = new SqlCommand( "INSERT INTO TareaProfesor(Matricula, Asignatura, Seccion, Nombre, Descripcion) VALUES(@matricula, @asignatura, @seccion, @nombre, @descripcion)" , conn.Obtener());

            cmd.Parameters.AddWithValue("@matricula", datos[2]);
            cmd.Parameters.AddWithValue("@asignatura", datos[0]);
            cmd.Parameters.AddWithValue("@seccion", datos[1]);
            cmd.Parameters.AddWithValue("@nombre", NombreTarea.Text);
            cmd.Parameters.AddWithValue("@descripcion", DescripcionTarea.Text);
            cmd.ExecuteNonQuery();

            conn.cerrar();

            NombreTarea.Text = "";
            DescripcionTarea.Text = "";
            MessageBox.Show("Tarea guardada correctamente!!");


        }
    }
}
