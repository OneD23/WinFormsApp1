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
    public partial class Examenes : Form
    {
        string[] datos = new string[10];
        private string Id;
        public Examenes(string[] datosi)
        {
            datos = datosi;
            InitializeComponent();
        }

        private void Borrar_Load(object sender, EventArgs e)
        {
            Class1 con = new Class1();

            con.abrir();

            SqlCommand comand = new SqlCommand("SELECT * FROM Examen WHERE Profesor = @profe", con.Obtener());
            comand.Parameters.AddWithValue("@profe", datos[3]);
           

            SqlDataReader rd = comand.ExecuteReader();

            if (rd.Read())
            {
                EDExamen.Enabled = true;
            }
            else
            {
                EDExamen.Enabled = false;
            }
            con.cerrar(); 
        }

        private void CreaExamen_Click(object sender, EventArgs e)
        {
            EDExamen.Visible = false;
            CreaExamen.Visible = false;

            Sigte.Visible = true;
            Lasignatura.Visible = true;
            Lexamen.Visible = true;
            Lpregunta.Visible = true;
            Lcantidad.Visible = true;
            RaL.Visible = true;
            RbL.Visible = true;
            RcL.Visible = true;
            RdL.Visible = true;
            LrC.Visible = true;

            NombreExamen.Visible = true;
            Cantidad.Visible = true;
            NombrePregunta.Visible = true;
            A.Visible = true;
            B.Visible = true;
            C.Visible = true;
            D.Visible = true;
            Correcta.Visible = true;


            dataGridView1.Visible = true;
            Materias.Visible = true;
            Sigte.Visible = true;
            Numero.Visible = true;

            
                Materias.Text = datos[0];
            
        }

        private void Sigte_Click(object sender, EventArgs e)
        {
            int numeroPregunta = Int32.Parse(Numero.Text);
            Class1 conexion = new Class1();

            conexion.abrir(); 

            SqlCommand comando = new SqlCommand("insert into Examen (Nombre , Asignatura, Pregunta, A,B,C,D, Correcta, Numero, Profesor) values(@NOMBRE ,@Asignatura, @Pregunta, @A, @B, @C, @D, @Correcta, @Numero, @Profesor) ", conexion.Obtener());
            comando.Parameters.AddWithValue("@NOMBRE", NombreExamen.Text);
            comando.Parameters.AddWithValue("@Asignatura", Materias.Text);
            comando.Parameters.AddWithValue("@Pregunta", NombrePregunta.Text);
            comando.Parameters.AddWithValue("@A", A.Text);
            comando.Parameters.AddWithValue("@B", B.Text);
            comando.Parameters.AddWithValue("@C", C.Text);
            comando.Parameters.AddWithValue("@D", D.Text);
            comando.Parameters.AddWithValue("@Correcta", Correcta.Text);
            comando.Parameters.AddWithValue("@Numero", numeroPregunta);
            comando.Parameters.AddWithValue("@Profesor", datos[3] );

            comando.ExecuteNonQuery();

            numeroPregunta++;
            Numero.Text = numeroPregunta.ToString();

            NombreExamen.Enabled = false;
            Materias.Enabled = false;
            Cantidad.Enabled = false;

            //data 

            comando = new SqlCommand("SELECT Numero, NOMBRE , Asignatura, Pregunta , A,B,C,D, Correcta  FROM Examen WHERE Asignatura = @materia AND Profesor = @profe AND Nombre = @nombre", conexion.Obtener());
            comando.Parameters.AddWithValue("@materia", Materias.Text);
            comando.Parameters.AddWithValue("@profe", datos[3]);
            comando.Parameters.AddWithValue("@nombre", NombreExamen.Text);



            SqlDataAdapter data = new SqlDataAdapter();

            data.SelectCommand = comando;

            DataTable tabla = new DataTable();
            data.Fill(tabla);
            dataGridView1.DataSource = tabla;

            //
            if (Sigte.Text == "terminar")
            {
                Sigte.Visible = false;
                NuevoExamen.Visible = true;
            }


            if (numeroPregunta >= Int32.Parse(Cantidad.Text))
            {
                Sigte.Text = "terminar";

            }

            conexion.cerrar();

            NombrePregunta.Text = "";
            A.Text = "";
            B.Text = "";
            C.Text = "";
            D.Text = "";
            Correcta.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Materias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NuevoExamen_Click(object sender, EventArgs e)
        {
            Sigte.Visible = false;

            NombreExamen.Enabled = true;
            Materias.Enabled = true;
            Cantidad.Enabled = true;
        }
    }
}
