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
    public partial class Listar : Form
    {
        public Listar()
        {
            InitializeComponent();
        }

        private void Listar_Load(object sender, EventArgs e)
        {

                    string cadena1 = "Server=localhost\\SQLEXPRESS01;Database=Registro;Trusted_Connection=True;";
                    SqlConnection conexion = new SqlConnection();

                    conexion.ConnectionString = cadena1;
                    conexion.Open();

                    SqlCommand comando = new SqlCommand("SELECT * FROM Alumnos WHERE profesor", conexion);
                    SqlDataAdapter data = new SqlDataAdapter();

                    data.SelectCommand = comando;

                    DataTable tabla = new DataTable();
                    data.Fill(tabla);
                    dataGridView1.DataSource = tabla;

            conexion.Close();

        }
    }
}
