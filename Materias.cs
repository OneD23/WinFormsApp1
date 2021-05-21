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
    public partial class Materias : Form
    {
        public Materias()
        {
            InitializeComponent();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            Class1 conexion = new Class1();
            conexion.abrir();

            SqlCommand comando = new SqlCommand("INSERT INTO Materia(Materia, Seccion, Facultad, Creditos) VALUES(@materia, @seccion, @facultad, @creditos)", conexion.Obtener());
            comando.Parameters.AddWithValue("@materia", Nombre.Text);
            comando.Parameters.AddWithValue("@seccion", Seccion.Text);
            comando.Parameters.AddWithValue("@facultad", Facultad.Text);
            comando.Parameters.AddWithValue("@creditos", Creditos.Text);

            comando.ExecuteNonQuery();
            conexion.cerrar();
        }
    }
}
