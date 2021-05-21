using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace WinFormsApp1
{
    class Class1
    {
        string cadena = "Server=localhost\\SQLEXPRESS01;Database=Registro;Trusted_Connection=True;";
        public SqlConnection conectar = new SqlConnection();

        public Class1()
        {
            conectar.ConnectionString = cadena;
        }

        public void abrir()
        {
            try
            {
                conectar.Open();
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        public SqlConnection Obtener()
        {
            return conectar;
        }

        public void cerrar()
        {
            conectar.Dispose();
        }


    }
}
