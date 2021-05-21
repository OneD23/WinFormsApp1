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
    public partial class ExamenEstudiante : Form
    {
        string[] datos = new string[10];
        string[] preguntas = new string[100];
        string[] As = new string[100];
        string[] Bs = new string[100];
        string[] Cs = new string[100];
        string[] Ds = new string[100];
        string[] Correcta = new string[100];

        int cuenta = 0;
        float nota = 0;
        float totalPreguntas = 0;
        string nombreDelExamen;


        public ExamenEstudiante(string[]  datosi)
        {
            datos = datosi;
            InitializeComponent();
        }

        private void ExamenEstudiante_Load(object sender, EventArgs e)
        {
            Loade();
        }

        private void Loade()
        {
            Class1 conexion = new Class1();
            conexion.abrir();

            SqlCommand comando = new SqlCommand("SELECT DISTINCT Nombre FROM Examen WHERE Asignatura = @asignatura", conexion.Obtener());
            comando.Parameters.AddWithValue("@asignatura", datos[0]);

            SqlDataReader rd = comando.ExecuteReader();

            while (rd.Read())
            {
                Examenes.Rows.Add(rd["Nombre"]);
            }


            conexion.cerrar();
        }

        private void Examenes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Class1 conexion = new Class1();
            conexion.abrir();

            SqlCommand comando = new SqlCommand("SELECT * FROM ExamenAlumnos WHERE Asignatura = @asignatura and Nombre = @examen", conexion.Obtener());
            comando.Parameters.AddWithValue("@asignatura", datos[0]);
            comando.Parameters.AddWithValue("@examen", Examenes.CurrentRow.Cells[0].Value.ToString());

            SqlDataReader rd = comando.ExecuteReader();
            bool existe = true;
            while (rd.Read())
            {
                existe = false;
            }

            if (existe)
            {
                if (MessageBox.Show("Solo tienes una oportunidad para llenar el examen, desea continuar", "Examen", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cuenta = 0;
                    nota = 0;
                    Examenes.Visible = false;
                    NombreExamen.Visible = true;
                    Pregunta.Visible = true;
                    A.Visible = true;
                    B.Visible = true;
                    C.Visible = true;
                    D.Visible = true;

                    Enviar.Visible = true;
                    Siguiente.Visible = true;

                    comando = new SqlCommand("SELECT * FROM Examen WHERE Asignatura = @asignatura AND Nombre =@examen ", conexion.Obtener());
                    comando.Parameters.AddWithValue("@asignatura", datos[0]);
                    comando.Parameters.AddWithValue("@examen", Examenes.CurrentRow.Cells[0].Value.ToString());
                    rd.Close();
                    rd = comando.ExecuteReader();
                    int contador = 0;
                    while (rd.Read())
                    {
                        
                        preguntas[contador] = rd["Pregunta"].ToString();
                        nombreDelExamen = rd["Nombre"].ToString();
                        As[contador] = rd["A"].ToString();
                        Bs[contador] = rd["B"].ToString();
                        Cs[contador] = rd["C"].ToString();
                        Ds[contador] = rd["D"].ToString();
                        Correcta[contador] = rd["Correcta"].ToString();
                        contador++;
                    }
                    totalPreguntas = contador - 1;
                    conexion.cerrar();

                    MuestraExamen();
                }
            }
            else
            {
                MessageBox.Show("Ya has llenado este examen, pasa por la ventana \n de calificaciones  aver como te fue");
            }
        }

        

        private void Siguiente_Click(object sender, EventArgs e)
        {
           
                float puntos =   100 / totalPreguntas;
                if (A.Checked && (Correcta[cuenta] == "A" || Correcta[cuenta] == "a"))
                {
                    nota += puntos;
                    MessageBox.Show("si: " + puntos + " y " + totalPreguntas);
                }
                if (B.Checked && Correcta[cuenta] == "B" || Correcta[cuenta] == "b")
                {
                    nota += puntos;
                MessageBox.Show("si: " + puntos + " y " + totalPreguntas);
            }
                if (C.Checked && Correcta[cuenta] == "C" || Correcta[cuenta] == "c")
                {
                    nota += puntos;
                MessageBox.Show("si: " + puntos + " y " + totalPreguntas);
            }
                if (D.Checked && Correcta[cuenta] == "D" || Correcta[cuenta] == "D")
                {
                    nota += puntos;
                MessageBox.Show("si: " + puntos + " y " + totalPreguntas);
            }

                A.Checked = false;
                B.Checked = false;
                C.Checked = false;
                D.Checked = false;

                MuestraExamen();
            
             if(cuenta == totalPreguntas )
            {
                Siguiente.Visible = false;
            }
        }

        private void Enviar_Click(object sender, EventArgs e)
        {

            Examenes.Visible = true;
            NombreExamen.Visible = false;
            Pregunta.Visible = false;
            A.Visible = false;
            B.Visible = false;
            C.Visible = false;
            D.Visible = false;

            Enviar.Visible = false;
            Siguiente.Visible = false;

            float puntos = 100 / totalPreguntas;
            if (A.Checked && Correcta[cuenta] == "A" || Correcta[cuenta] == "a")
            {
                nota += puntos;
                MessageBox.Show("si: " + puntos + " y " + totalPreguntas);
            }
            else if (B.Checked && Correcta[cuenta] == "B" || Correcta[cuenta] == "b")
            {
                nota += puntos;
                MessageBox.Show("si: " + puntos + " y " + totalPreguntas);
            }
            else if (C.Checked && Correcta[cuenta] == "C" || Correcta[cuenta] == "c")
            {
                nota += puntos;
                MessageBox.Show("si: " + puntos + " y " + totalPreguntas);
            }
            else if (D.Checked && Correcta[cuenta] == "D" || Correcta[cuenta] == "D")
            {
                nota += puntos;
                MessageBox.Show("si: " + puntos + " y " + totalPreguntas);
            }

            A.Checked = false;
            B.Checked = false;
            C.Checked = false;
            D.Checked = false;

            Class1 conexion = new Class1();
            conexion.abrir();

            SqlCommand comando = new SqlCommand("INSERT INTO ExamenAlumnos(Matricula, Asignatura, Nombre, Nota, Seccion) VALUES(@matricula, @asignatura, @examen, @nota, @seccion)", conexion.Obtener());
            
            comando.Parameters.AddWithValue("@matricula", datos[2]);
            comando.Parameters.AddWithValue("@asignatura", datos[0]);
            comando.Parameters.AddWithValue("@examen", NombreExamen.Text);
            comando.Parameters.AddWithValue("@nota", nota);
            comando.Parameters.AddWithValue("@seccion", datos[1]);
            
            comando.ExecuteNonQuery();
            conexion.cerrar();

            
        }

        private void MuestraExamen()
        {
            NombreExamen.Text = nombreDelExamen;
            Pregunta.Text = preguntas[cuenta];
            A.Text = "A)- " + As[cuenta];
            B.Text = "B)- " + Bs[cuenta];
            C.Text = "C)- " + Cs[cuenta];
            D.Text = "D)- " + Ds[cuenta];
            cuenta++;
        }
    }
}
