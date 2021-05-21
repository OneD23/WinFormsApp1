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
    public partial class inicio : Form
    {
        string[] datos = new string[10];

        public inicio()
        {
            InitializeComponent();
        }
        
        

        private void Login_Click(object sender, EventArgs e)
        {
            Class1 n = new Class1();

            if (usuario.Text != "" || contraseña.Text != "") 
            {

                n.abrir();
                SqlCommand cmd = new SqlCommand("SELECT Nombre, Password FROM Profesor WHERE Matricula = @user AND Password = @pass", n.Obtener());

                cmd.Parameters.AddWithValue("@user", usuario.Text);
                cmd.Parameters.AddWithValue("@pass", contraseña.Text);
                
                SqlDataReader rd = cmd.ExecuteReader();

                
                if (rd.Read())
                {
                    Moderno vent = new Moderno(usuario.Text);
                    vent.SetIds(rd["Nombre"].ToString());
                    this.Visible = false;
                    vent.Show();

                }
                else
                {
                    rd.Close();
                    cmd = new SqlCommand("SELECT Nombre, Password FROM Alumnos WHERE Matricula = @user AND Password = @pass", n.Obtener());
                    cmd.Parameters.AddWithValue("@user", usuario.Text);
                    cmd.Parameters.AddWithValue("@pass", contraseña.Text);
                    rd = cmd.ExecuteReader();
                    if (rd.Read())
                    {
                        string[] dato = new string[10];
                        datos[2] = usuario.Text;
                       Form2 user = new Form2(datos);
                        this.Visible = false;
                        user.Show();
                    }
                    else
                    {
                        rd.Close();
                        if (usuario.Text == "root" && contraseña.Text == "Admin")
                        {
                            Root root = new Root();
                            this.Visible = false;
                            root.Show();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o Contraseña incorrectos");
                        }
                    }
                   
                }
                rd.Close();
                n.cerrar();

            }
            else
            {
                MessageBox.Show("Error: No pueden haber campos vacios");
            }

        }
    }
}
