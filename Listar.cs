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
    public partial class Listar : Form
    {
        public Listar()
        {
            InitializeComponent();
        }

        private void Listar_Load(object sender, EventArgs e)
        {
            
            
                TextReader leer;
                leer = new StreamReader("lista.txt");
          

            string linea = leer.ReadLine();

            while (linea != null)
            {

                string[] One = linea.Split('|');

                if (One.Length > 1)
                {
                    int n = dataGridView1.Rows.Add();

                    dataGridView1.Rows[n].Cells[0].Value = One[0];
                    dataGridView1.Rows[n].Cells[1].Value = One[1];
                    dataGridView1.Rows[n].Cells[2].Value = One[2];
                    dataGridView1.Rows[n].Cells[3].Value = One[3];
                    dataGridView1.Rows[n].Cells[4].Value = One[4];
                    dataGridView1.Rows[n].Cells[5].Value = One[5];
                    
                }

                linea = leer.ReadLine();

            }
           
            leer.Close();

        }
    }
}
