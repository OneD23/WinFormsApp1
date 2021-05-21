using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;



namespace WinFormsApp1
{
    public partial class Calificar : Form
    {
        public string id;
        string[] datos = new string[10];
        public Calificar(string[] ids)
        {
            datos = ids;
            InitializeComponent();
        }

        private void Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Calificar_Load(object sender, EventArgs e)
        {
            Nombre.Enabled = false;
            Apellido.Enabled = false;
            Matricula.Enabled = false;
            Carrera.Enabled = false;
            Seccion.Enabled = false;

            Class1 Conex = new Class1();
            Conex.abrir();



            SqlCommand comand = new SqlCommand("SELECT  * FROM AsignaturaProfesor WHERE Matricula = @matricula ", Conex.Obtener());
            comand.Parameters.AddWithValue("@matricula", datos[2]);
      


            SqlDataReader dr = comand.ExecuteReader();
            while (dr.Read())
            {
                Materias.Items.Add(dr["Nombre"].ToString());
               
            }


            Conex.cerrar();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Materias_SelectedIndexChanged(object sender, EventArgs e)
        {
            Seccion.Items.Clear();
            Class1 Conex = new Class1();
            Conex.abrir();
            if (Materias.SelectedItem != null)
            {
                Seccion.Enabled = true;
                SqlCommand comando = new SqlCommand("SELECT * FROM Alumnos WHERE carrera = @materia", Conex.Obtener());
                comando.Parameters.AddWithValue("@materia", Materias.SelectedItem.ToString());
                SqlDataAdapter data = new SqlDataAdapter();

                data.SelectCommand = comando;

                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dataGridView1.DataSource = tabla;

                

                SqlCommand comand = new SqlCommand("SELECT  Seccion FROM AsignaturaProfesor WHERE Matricula = @matricula AND Nombre = @nombre", Conex.Obtener());
                comand.Parameters.AddWithValue("@matricula", datos[2]);
                comand.Parameters.AddWithValue("@nombre", Materias.SelectedItem.ToString());

                SqlDataReader dr = comand.ExecuteReader();
                while (dr.Read())
                {
                   
                    Seccion.Items.Add(dr["Seccion"].ToString());
                }

            }
        }

        private void Seccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
           

            Class1 Conex = new Class1();
            Conex.abrir();
            if (Materias.SelectedItem != null && Seccion.SelectedItem != null)
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM Alumnos WHERE carrera = @materia AND Seccion =@seccion", Conex.Obtener());
                comando.Parameters.AddWithValue("@materia", Materias.SelectedItem.ToString());
                comando.Parameters.AddWithValue("@seccion", Seccion.SelectedItem.ToString());
                SqlDataAdapter data = new SqlDataAdapter();

                data.SelectCommand = comando;

                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dataGridView1.DataSource = tabla;

                Conex.cerrar();
            }
        }
            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Nombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Apellido.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Matricula.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            Carrera.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
           
        }
    }
}
