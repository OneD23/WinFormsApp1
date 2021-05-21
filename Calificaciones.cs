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
    public partial class Calificaciones : Form
    {
        string[] datos = new string[10];
        public Calificaciones(string[] datosi)
        {
            datos = datosi;
            InitializeComponent();
        }

        private void ExamenEstudiante_Load(object sender, EventArgs e)
        {
            Class1 conexion = new Class1();

            conexion.abrir();
            SqlCommand comando = new SqlCommand("SELECT * FROM TareasAlumnos WHERE Matricula = @matricula and Asignatura = @asignatura",conexion.Obtener());
            comando.Parameters.AddWithValue("@matricula", datos[2]);
            comando.Parameters.AddWithValue("@asignatura", datos[0]);

            SqlDataReader rd = comando.ExecuteReader();

            while (rd.Read())
            {
                Tareas.Rows.Add(rd["Asignatura"].ToString(), rd["Nombre"].ToString(), rd["Puntuacion"].ToString());
            }


            rd.Close();
            comando = new SqlCommand("SELECT DISTINCT * FROM ExamenAlumnos WHERE Matricula = @matricula and Asignatura = @asignatura", conexion.Obtener());
            comando.Parameters.AddWithValue("@matricula", datos[2]);
            comando.Parameters.AddWithValue("@asignatura", datos[0]);

            rd = comando.ExecuteReader();

            while (rd.Read())
            {
                Examenes.Rows.Add(rd["Nombre"].ToString(), rd["Asignatura"].ToString(), rd["Nota"].ToString());
            }
            conexion.cerrar();

        }
    }
}
