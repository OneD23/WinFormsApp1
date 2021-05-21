
namespace WinFormsApp1
{
    partial class Calificar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Apellido = new System.Windows.Forms.TextBox();
            this.Matricula = new System.Windows.Forms.TextBox();
            this.Carrera = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Seccion = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Materias = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(316, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "CALIFICAR ALUMNOS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 348);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(984, 173);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(14, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Carrera:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(14, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Apellido:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Matricula:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(132, 142);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(198, 23);
            this.Nombre.TabIndex = 1;
            this.Nombre.TextChanged += new System.EventHandler(this.Nombre_TextChanged);
            // 
            // Apellido
            // 
            this.Apellido.Location = new System.Drawing.Point(132, 187);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(198, 23);
            this.Apellido.TabIndex = 1;
            this.Apellido.TextChanged += new System.EventHandler(this.Nombre_TextChanged);
            // 
            // Matricula
            // 
            this.Matricula.Location = new System.Drawing.Point(132, 229);
            this.Matricula.Name = "Matricula";
            this.Matricula.Size = new System.Drawing.Size(198, 23);
            this.Matricula.TabIndex = 1;
            this.Matricula.TextChanged += new System.EventHandler(this.Nombre_TextChanged);
            // 
            // Carrera
            // 
            this.Carrera.Location = new System.Drawing.Point(132, 276);
            this.Carrera.Name = "Carrera";
            this.Carrera.Size = new System.Drawing.Size(198, 23);
            this.Carrera.TabIndex = 1;
            this.Carrera.TextChanged += new System.EventHandler(this.Nombre_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(438, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Seccion:";
            this.label7.Click += new System.EventHandler(this.label4_Click);
            // 
            // Seccion
            // 
            this.Seccion.FormattingEnabled = true;
            this.Seccion.Location = new System.Drawing.Point(429, 287);
            this.Seccion.Name = "Seccion";
            this.Seccion.Size = new System.Drawing.Size(121, 23);
            this.Seccion.TabIndex = 3;
            this.Seccion.SelectedIndexChanged += new System.EventHandler(this.Seccion_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(417, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Asignatura:";
            this.label6.Click += new System.EventHandler(this.label4_Click);
            // 
            // Materias
            // 
            this.Materias.FormattingEnabled = true;
            this.Materias.Location = new System.Drawing.Point(429, 229);
            this.Materias.Name = "Materias";
            this.Materias.Size = new System.Drawing.Size(121, 23);
            this.Materias.TabIndex = 3;
            this.Materias.SelectedIndexChanged += new System.EventHandler(this.Materias_SelectedIndexChanged);
            // 
            // Calificar
            // 
            this.ClientSize = new System.Drawing.Size(984, 521);
            this.Controls.Add(this.Seccion);
            this.Controls.Add(this.Materias);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Carrera);
            this.Controls.Add(this.Matricula);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Calificar";
            this.Load += new System.EventHandler(this.Calificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox Apellido;
        private System.Windows.Forms.TextBox Matricula;
        private System.Windows.Forms.TextBox Carrera;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Seccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Materias;
    }
}