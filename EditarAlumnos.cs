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
    public partial class EditarAlumnos : Form
    {
        public EditarAlumnos()
        {
            InitializeComponent();
        }

        private void Matricula_TextChanged(object sender, EventArgs e)
        {
            if (Matricula.TextLength == 9)
            {
                Class1 conex = new Class1();
                conex.abrir();
                SqlCommand comando = new SqlCommand("SELECT * FROM Alumnos WHERE Matricula = @matricula", conex.Obtener());
                comando.Parameters.AddWithValue("@matricula", Matricula.Text);

                MessageBox.Show(Matricula.Text);


                SqlDataReader rd = comando.ExecuteReader();

                while (rd.Read()) {
                    MessageBox.Show("Ya esta matricula esta registrada, si desea puede editarla");
                    Terminar.Visible = true;

                    Nombre.Text = rd["Nombre"].ToString();
                    Apellido.Text = rd["Apellido"].ToString();
                    Direccion.Text = rd["Direccion"].ToString();
                    Carrera.Text = rd["carrera"].ToString();
                    Contraseña.Text = rd["Password"].ToString();
                    Telefono.Text = rd["Telefono"].ToString();
                    Matricula.Text = rd["Matricula"].ToString();
                    Nacionalidad.Text = rd["Nacionalidad"].ToString(); ;
                    EstadoCivil.Text = rd["EstadoCivil"].ToString();
                    Correo.Text = rd["Correo"].ToString();
                    if (rd["Sexo"].ToString() == "Masculino")
                    {
                        Masculino.Checked = true;
                    }
                    if (rd["Sexo"].ToString() == "Femenino")
                    {
                        Femenino.Checked = true;
                    }
                    else
                    {
                        Otros.Checked = true;
                    }
                    try
                    {
                        byte[] img = (byte[])rd["Foto"];
                         System.IO.MemoryStream ms = new System.IO.MemoryStream(img);
                        FotoPerfil.Image = Image.FromStream(ms);
                    }
                    catch
                    {
                        FotoPerfil.Image = null;
                    }

                   
                    
                }

                conex.cerrar();

                Nombre.Enabled = true;
                Apellido.Enabled = true;
                Carrera.Enabled = true;
                Direccion.Enabled = true;
                Telefono.Enabled = true;
                Nacionalidad.Enabled = true;
                EstadoCivil.Enabled = true;
                Otros.Enabled = true;
                Femenino.Enabled = true;
                Masculino.Enabled = true;
                Contraseña.Enabled = true;
                Correo.Enabled = true;

                dateTimePicker1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fo = new OpenFileDialog();
            DialogResult imagen = fo.ShowDialog();

            if (imagen == DialogResult.OK)
            {
                FotoPerfil.Image = Image.FromFile(fo.FileName);
            }
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            string sexo = "Otro";
            if (Masculino.Checked)
            {
                sexo = "Masculino";
            }
            else if(Femenino.Checked){
                sexo = "Femenino";
            }

            string espacio1 = "";
            string espacio2 = "";
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            if (FotoPerfil.Image != null)
            {
                FotoPerfil.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                 espacio1 = ",Foto";
                 espacio2 = ",@foto";
            }

            Class1 conexion = new Class1();
            conexion.abrir();

            SqlCommand comando = new SqlCommand("INSERT INTO Alumnos(Nombre, Apellido, Direccion, Fecha_nacimiento, carrera, Password, Telefono, Seccion, Matricula, Nacionalidad, EstadoCivil, Sexo, Correo "+ espacio1 +" ) VALUES( @Nombre, @Apellido, @Direccion, @Fecha_nacimiento, @carrera, @Password, @Telefono, @Seccion, @Matricula, @Nacionalidad, @EstadoCivil, @Sexo, @correo"+ espacio2 +") ", conexion.Obtener());


            comando.Parameters.AddWithValue("@Nombre", Nombre.Text);
            comando.Parameters.AddWithValue("@Apellido",Apellido.Text);
            comando.Parameters.AddWithValue("@Direccion",Direccion.Text);
            comando.Parameters.AddWithValue("@Fecha_nacimiento", dateTimePicker1.Value);
            comando.Parameters.AddWithValue("@carrera",Carrera.Text);
            comando.Parameters.AddWithValue("@Password",Contraseña.Text);
            comando.Parameters.AddWithValue("@Telefono",Telefono.Text);
            comando.Parameters.AddWithValue("@Seccion","");
            comando.Parameters.AddWithValue("@Matricula",Matricula.Text);
            comando.Parameters.AddWithValue("@Nacionalidad", Nacionalidad.Text);
            comando.Parameters.AddWithValue("@EstadoCivil", EstadoCivil.Text);
            comando.Parameters.AddWithValue("@Sexo", sexo);
            comando.Parameters.AddWithValue("@correo", Correo.Text);

            if (FotoPerfil.Image != null)
            { comando.Parameters.AddWithValue("@foto", ms.GetBuffer()); }

            comando.ExecuteNonQuery();

            MessageBox.Show("Usuario Guardado!");
            string[] men = new string[5];
            Mensaje msg = new Mensaje();

            if (Correo.Text != null)
            {
                men[0] = Correo.Text;
                men[1] = "Aprobacion de solicitud en ASODEBIN";
                men[2] = "Luego de un cordial saludo nos facina informarle que ha sido aproba\n en nuestra universidad como alumno, muchas felicidades.  \n Acontinuacion le facilitamos sus CREDENCIAS \n User: " + Matricula.Text + " \n Password:" + Contraseña.Text;
                msg.Enviar(men);
            }

            Nombre.Text = "";
            Apellido.Text = "";
            Direccion.Text = "";
            
            Carrera.Text = "";
            Contraseña.Text = "";
            Telefono.Text = "";

            Matricula.Text = "";
            Nacionalidad.Text = "";
            EstadoCivil.Text = "";
            Correo.Text = "";


            Masculino.Checked = false;
            Femenino.Checked = false;
            Otros.Checked = false;

            FotoPerfil.Image = null;

            conexion.cerrar();

           
        }

        private void Terminar_Click(object sender, EventArgs e)
        {
            string sexo = "Otro";
            if (Masculino.Checked)
            {
                sexo = "Masculino";
            }
            else if (Femenino.Checked)
            {
                sexo = "Femenino";
            }
            string v = "";
            if (FotoPerfil.Image != null)
            {
                v = ", Foto = @Foto ";
            }

             Class1 conexion = new Class1();
            conexion.abrir();

            SqlCommand comando = new SqlCommand("UPDATE  Alumnos SET  Nombre = @Nombre, Apellido = @Apellido , Direccion = @Direccion, Fecha_nacimiento = @Fecha_nacimiento, carrera = @carrera, Password = @Password, Telefono = @Telefono, Matricula = @Matricula, Nacionalidad = @Nacionalidad, EstadoCivil = @EstadoCivil, Sexo = @Sexo, Correo = @correo "+v+" WHERE Matricula = @Matricula ", conexion.Obtener());

            comando.Parameters.AddWithValue("@Nombre", Nombre.Text);
            comando.Parameters.AddWithValue("@Apellido", Apellido.Text);
            comando.Parameters.AddWithValue("@Direccion", Direccion.Text);
            comando.Parameters.AddWithValue("@Fecha_nacimiento", dateTimePicker1.Value);
            comando.Parameters.AddWithValue("@carrera", Carrera.Text);
            comando.Parameters.AddWithValue("@Password", Contraseña.Text);
            comando.Parameters.AddWithValue("@Telefono", Telefono.Text);
            comando.Parameters.AddWithValue("@Seccion", "");
            comando.Parameters.AddWithValue("@Matricula", Matricula.Text);
            comando.Parameters.AddWithValue("@Nacionalidad", Nacionalidad.Text);
            comando.Parameters.AddWithValue("@EstadoCivil", EstadoCivil.Text);
            comando.Parameters.AddWithValue("@Sexo", sexo);
            comando.Parameters.AddWithValue("@correo", Correo.Text);

            if (FotoPerfil.Image != null) 
            { 
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                FotoPerfil.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                comando.Parameters.AddWithValue("@foto", ms.GetBuffer());
            }
            
            

            comando.ExecuteNonQuery();

            MessageBox.Show("Usuario Guardado!");

            Nombre.Text = "";
            Apellido.Text = "";
            Direccion.Text = "";

            Carrera.Text = "";
            Contraseña.Text = "";
            Telefono.Text = "";
            Correo.Text = "";

            Matricula.Text = "";
            Nacionalidad.Text = "";
            EstadoCivil.Text = "";
            Masculino.Checked = false;
            Femenino.Checked = false;
            Otros.Checked = false;

            FotoPerfil.Image = null;



            conexion.cerrar();
        }

       

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }  
    }
}
