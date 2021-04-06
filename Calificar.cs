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
using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Calificar : Form
    {
        public Calificar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextReader leer;
            leer = new StreamReader("lista.txt");
            string matricula = BuscarMatricula.Text;

            TextWriter escribir;
            escribir = new StreamWriter("lista1.txt");

            bool aparecio = false;
            string[] One = new string[50];
            string linea = leer.ReadLine();
            while(linea != null)
            {
                if (linea.Contains(matricula))
                {
                    One = linea.Split('|');
                    linea = leer.ReadLine();
                    aparecio = true;
                }
                escribir.WriteLine(linea);
                linea = leer.ReadLine();
            }
            if (aparecio)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                button1.Enabled = true;

                textBox1.Text = One[1];
                textBox2.Text = One[2];
                textBox3.Text = One[3];
                textBox4.Text = One[4];
                textBox5.Text = One[5];

            }

            leer.Close();
            escribir.Close();

            TextWriter SobreEscribir;
            SobreEscribir = new StreamWriter("lista.txt");

            TextReader leer2;
            leer2 = new StreamReader("lista1.txt");

            string linea2 = leer2.ReadLine();
            while ( linea2 != null)
            {
                SobreEscribir.WriteLine(linea2);
                linea2 = leer2.ReadLine();
            }

            leer2.Close();
            SobreEscribir.Close();
        }

        private void Calificar_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string estudiante = $"{BuscarMatricula.Text}|{textBox1.Text}|{textBox2.Text}|{textBox3.Text}|{textBox4.Text}|{textBox5.Text}|";


            StreamWriter pegar = File.AppendText("lista.txt");

            pegar.WriteLine(estudiante);

            pegar.Close();
            this.Dispose();
        }
    }
}
