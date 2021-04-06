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

namespace WinFormsApp1
{
    public partial class Borrar : Form
    {
        public Borrar()
        {
            InitializeComponent();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            TextReader leer;
            leer = new StreamReader("lista.txt");
            string matricula = Matricula.Text;

            TextWriter escribir;
            escribir = new StreamWriter("lista1.txt");

            bool aparecio = false;
            string[] One = new string[50];
            string linea = leer.ReadLine();
            while (linea != null)
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
                nombre.Text = One[1];
                button1.Enabled = true;

            }

            leer.Close();
            escribir.Close();

            TextWriter SobreEscribir;
            SobreEscribir = new StreamWriter("lista.txt");

            TextReader leer2;
            leer2 = new StreamReader("lista1.txt");

            string linea2 = leer2.ReadLine();
            while (linea2 != null)
            {
                SobreEscribir.WriteLine(linea2);
                linea2 = leer2.ReadLine();
                if(linea2 == null)
                {
                    break;
                }
            }

            leer2.Close();
            SobreEscribir.Close();

            

        }

        private void Borrar_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
