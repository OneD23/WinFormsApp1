
namespace WinFormsApp1
{
    partial class Examenes
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
            this.label2 = new System.Windows.Forms.Label();
            this.CreaExamen = new System.Windows.Forms.Button();
            this.EDExamen = new System.Windows.Forms.Button();
            this.Lcantidad = new System.Windows.Forms.Label();
            this.Cantidad = new System.Windows.Forms.TextBox();
            this.NombreExamen = new System.Windows.Forms.TextBox();
            this.RaL = new System.Windows.Forms.Label();
            this.RbL = new System.Windows.Forms.Label();
            this.RcL = new System.Windows.Forms.Label();
            this.RdL = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.TextBox();
            this.B = new System.Windows.Forms.TextBox();
            this.C = new System.Windows.Forms.TextBox();
            this.D = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.LrC = new System.Windows.Forms.Label();
            this.Correcta = new System.Windows.Forms.TextBox();
            this.Lexamen = new System.Windows.Forms.Label();
            this.Sigte = new System.Windows.Forms.Button();
            this.NombrePregunta = new System.Windows.Forms.TextBox();
            this.Lasignatura = new System.Windows.Forms.Label();
            this.Numero = new System.Windows.Forms.Label();
            this.Lpregunta = new System.Windows.Forms.Label();
            this.Materias = new System.Windows.Forms.TextBox();
            this.NuevoExamen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 0;
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.SkyBlue;
            this.label2.Location = new System.Drawing.Point(301, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Examenes";
            // 
            // CreaExamen
            // 
            this.CreaExamen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreaExamen.ForeColor = System.Drawing.Color.Black;
            this.CreaExamen.Location = new System.Drawing.Point(322, 69);
            this.CreaExamen.Name = "CreaExamen";
            this.CreaExamen.Size = new System.Drawing.Size(134, 35);
            this.CreaExamen.TabIndex = 4;
            this.CreaExamen.Text = "Crear Examen";
            this.CreaExamen.UseVisualStyleBackColor = true;
            this.CreaExamen.Click += new System.EventHandler(this.CreaExamen_Click);
            // 
            // EDExamen
            // 
            this.EDExamen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EDExamen.ForeColor = System.Drawing.Color.Black;
            this.EDExamen.Location = new System.Drawing.Point(322, 110);
            this.EDExamen.Name = "EDExamen";
            this.EDExamen.Size = new System.Drawing.Size(134, 35);
            this.EDExamen.TabIndex = 4;
            this.EDExamen.Text = "Editar Examen";
            this.EDExamen.UseVisualStyleBackColor = true;
            this.EDExamen.Visible = false;
            // 
            // Lcantidad
            // 
            this.Lcantidad.AutoSize = true;
            this.Lcantidad.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lcantidad.ForeColor = System.Drawing.Color.Black;
            this.Lcantidad.Location = new System.Drawing.Point(247, 153);
            this.Lcantidad.Name = "Lcantidad";
            this.Lcantidad.Size = new System.Drawing.Size(173, 21);
            this.Lcantidad.TabIndex = 5;
            this.Lcantidad.Text = "Cantidad de pregunta:";
            this.Lcantidad.Visible = false;
            // 
            // Cantidad
            // 
            this.Cantidad.Location = new System.Drawing.Point(426, 151);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(66, 23);
            this.Cantidad.TabIndex = 6;
            this.Cantidad.Visible = false;
            // 
            // NombreExamen
            // 
            this.NombreExamen.Location = new System.Drawing.Point(218, 81);
            this.NombreExamen.Name = "NombreExamen";
            this.NombreExamen.Size = new System.Drawing.Size(146, 23);
            this.NombreExamen.TabIndex = 6;
            this.NombreExamen.Visible = false;
            // 
            // RaL
            // 
            this.RaL.AutoSize = true;
            this.RaL.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RaL.ForeColor = System.Drawing.Color.Black;
            this.RaL.Location = new System.Drawing.Point(42, 255);
            this.RaL.Name = "RaL";
            this.RaL.Size = new System.Drawing.Size(104, 21);
            this.RaL.TabIndex = 5;
            this.RaL.Text = "Respuesta A:";
            this.RaL.Visible = false;
            // 
            // RbL
            // 
            this.RbL.AutoSize = true;
            this.RbL.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RbL.ForeColor = System.Drawing.Color.Black;
            this.RbL.Location = new System.Drawing.Point(42, 289);
            this.RbL.Name = "RbL";
            this.RbL.Size = new System.Drawing.Size(103, 21);
            this.RbL.TabIndex = 5;
            this.RbL.Text = "Respuesta B:";
            this.RbL.Visible = false;
            // 
            // RcL
            // 
            this.RcL.AutoSize = true;
            this.RcL.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RcL.ForeColor = System.Drawing.Color.Black;
            this.RcL.Location = new System.Drawing.Point(458, 253);
            this.RcL.Name = "RcL";
            this.RcL.Size = new System.Drawing.Size(103, 21);
            this.RcL.TabIndex = 5;
            this.RcL.Text = "Respuesta C:";
            this.RcL.Visible = false;
            // 
            // RdL
            // 
            this.RdL.AutoSize = true;
            this.RdL.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RdL.ForeColor = System.Drawing.Color.Black;
            this.RdL.Location = new System.Drawing.Point(458, 287);
            this.RdL.Name = "RdL";
            this.RdL.Size = new System.Drawing.Size(104, 21);
            this.RdL.TabIndex = 5;
            this.RdL.Text = "Respuesta D:";
            this.RdL.Visible = false;
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(152, 249);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(146, 23);
            this.A.TabIndex = 6;
            this.A.Visible = false;
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(152, 287);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(146, 23);
            this.B.TabIndex = 6;
            this.B.Visible = false;
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(568, 253);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(146, 23);
            this.C.TabIndex = 6;
            this.C.Visible = false;
            // 
            // D
            // 
            this.D.Location = new System.Drawing.Point(568, 289);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(146, 23);
            this.D.TabIndex = 6;
            this.D.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 370);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(767, 150);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(26, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 21);
            this.label11.TabIndex = 5;
            this.label11.Text = "Pregunta 1:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(26, 161);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 21);
            this.label12.TabIndex = 5;
            this.label12.Text = "Respuesta A:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(26, 195);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 21);
            this.label13.TabIndex = 5;
            this.label13.Text = "Respuesta B:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(26, 228);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 21);
            this.label14.TabIndex = 5;
            this.label14.Text = "Respuesta C:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(26, 262);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 21);
            this.label15.TabIndex = 5;
            this.label15.Text = "Respuesta D:";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(202, 92);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(66, 23);
            this.textBox8.TabIndex = 6;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(122, 126);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(189, 23);
            this.textBox9.TabIndex = 6;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(136, 155);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(175, 23);
            this.textBox10.TabIndex = 6;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(136, 193);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(175, 23);
            this.textBox11.TabIndex = 6;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(136, 228);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(175, 23);
            this.textBox12.TabIndex = 6;
            // 
            // LrC
            // 
            this.LrC.AutoSize = true;
            this.LrC.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LrC.ForeColor = System.Drawing.Color.Black;
            this.LrC.Location = new System.Drawing.Point(110, 341);
            this.LrC.Name = "LrC";
            this.LrC.Size = new System.Drawing.Size(230, 21);
            this.LrC.TabIndex = 5;
            this.LrC.Text = "Letra de la respuesta correcta:";
            this.LrC.Visible = false;
            // 
            // Correcta
            // 
            this.Correcta.Location = new System.Drawing.Point(346, 341);
            this.Correcta.Name = "Correcta";
            this.Correcta.Size = new System.Drawing.Size(146, 23);
            this.Correcta.TabIndex = 6;
            this.Correcta.Visible = false;
            // 
            // Lexamen
            // 
            this.Lexamen.AutoSize = true;
            this.Lexamen.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lexamen.ForeColor = System.Drawing.Color.Black;
            this.Lexamen.Location = new System.Drawing.Point(42, 83);
            this.Lexamen.Name = "Lexamen";
            this.Lexamen.Size = new System.Drawing.Size(170, 21);
            this.Lexamen.TabIndex = 5;
            this.Lexamen.Text = "Nombre del EXAMEN:";
            this.Lexamen.Visible = false;
            // 
            // Sigte
            // 
            this.Sigte.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Sigte.ForeColor = System.Drawing.Color.Black;
            this.Sigte.Location = new System.Drawing.Point(541, 329);
            this.Sigte.Name = "Sigte";
            this.Sigte.Size = new System.Drawing.Size(173, 35);
            this.Sigte.TabIndex = 4;
            this.Sigte.Text = "Siguiente pregunta";
            this.Sigte.UseVisualStyleBackColor = true;
            this.Sigte.Visible = false;
            this.Sigte.Click += new System.EventHandler(this.Sigte_Click);
            // 
            // NombrePregunta
            // 
            this.NombrePregunta.Location = new System.Drawing.Point(346, 189);
            this.NombrePregunta.Multiline = true;
            this.NombrePregunta.Name = "NombrePregunta";
            this.NombrePregunta.Size = new System.Drawing.Size(368, 34);
            this.NombrePregunta.TabIndex = 6;
            this.NombrePregunta.Visible = false;
            // 
            // Lasignatura
            // 
            this.Lasignatura.AutoSize = true;
            this.Lasignatura.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lasignatura.ForeColor = System.Drawing.Color.Black;
            this.Lasignatura.Location = new System.Drawing.Point(42, 117);
            this.Lasignatura.Name = "Lasignatura";
            this.Lasignatura.Size = new System.Drawing.Size(92, 21);
            this.Lasignatura.TabIndex = 5;
            this.Lasignatura.Text = "Asignatura:";
            this.Lasignatura.Visible = false;
            // 
            // Numero
            // 
            this.Numero.AutoSize = true;
            this.Numero.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Numero.ForeColor = System.Drawing.Color.Black;
            this.Numero.Location = new System.Drawing.Point(322, 191);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(16, 21);
            this.Numero.TabIndex = 5;
            this.Numero.Text = "1";
            this.Numero.Visible = false;
            // 
            // Lpregunta
            // 
            this.Lpregunta.AutoSize = true;
            this.Lpregunta.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lpregunta.ForeColor = System.Drawing.Color.Black;
            this.Lpregunta.Location = new System.Drawing.Point(247, 191);
            this.Lpregunta.Name = "Lpregunta";
            this.Lpregunta.Size = new System.Drawing.Size(100, 21);
            this.Lpregunta.TabIndex = 5;
            this.Lpregunta.Text = "Pregunta     :";
            this.Lpregunta.Visible = false;
            // 
            // Materias
            // 
            this.Materias.Location = new System.Drawing.Point(141, 114);
            this.Materias.Name = "Materias";
            this.Materias.Size = new System.Drawing.Size(223, 23);
            this.Materias.TabIndex = 8;
            this.Materias.Visible = false;
            // 
            // NuevoExamen
            // 
            this.NuevoExamen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NuevoExamen.ForeColor = System.Drawing.Color.Black;
            this.NuevoExamen.Location = new System.Drawing.Point(541, 329);
            this.NuevoExamen.Name = "NuevoExamen";
            this.NuevoExamen.Size = new System.Drawing.Size(173, 35);
            this.NuevoExamen.TabIndex = 9;
            this.NuevoExamen.Text = "Nuevo Examen";
            this.NuevoExamen.UseVisualStyleBackColor = true;
            this.NuevoExamen.Visible = false;
            this.NuevoExamen.Click += new System.EventHandler(this.NuevoExamen_Click);
            // 
            // Examenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 520);
            this.Controls.Add(this.NuevoExamen);
            this.Controls.Add(this.Materias);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Correcta);
            this.Controls.Add(this.D);
            this.Controls.Add(this.C);
            this.Controls.Add(this.B);
            this.Controls.Add(this.A);
            this.Controls.Add(this.NombrePregunta);
            this.Controls.Add(this.NombreExamen);
            this.Controls.Add(this.Cantidad);
            this.Controls.Add(this.LrC);
            this.Controls.Add(this.RdL);
            this.Controls.Add(this.RcL);
            this.Controls.Add(this.RbL);
            this.Controls.Add(this.RaL);
            this.Controls.Add(this.Numero);
            this.Controls.Add(this.Lpregunta);
            this.Controls.Add(this.Lasignatura);
            this.Controls.Add(this.Lexamen);
            this.Controls.Add(this.Lcantidad);
            this.Controls.Add(this.Sigte);
            this.Controls.Add(this.EDExamen);
            this.Controls.Add(this.CreaExamen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Examenes";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Borrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CreaExamen;
        private System.Windows.Forms.Button EDExamen;
        private System.Windows.Forms.Label Lcantidad;
        private System.Windows.Forms.TextBox Cantidad;
        private System.Windows.Forms.TextBox NombreExamen;
        private System.Windows.Forms.Label RaL;
        private System.Windows.Forms.Label RbL;
        private System.Windows.Forms.Label RcL;
        private System.Windows.Forms.Label RdL;
        private System.Windows.Forms.TextBox A;
        private System.Windows.Forms.TextBox B;
        private System.Windows.Forms.TextBox C;
        private System.Windows.Forms.TextBox D;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label LrC;
        private System.Windows.Forms.TextBox Correcta;
        private System.Windows.Forms.Label Lexamen;
        private System.Windows.Forms.Button Sigte;
        private System.Windows.Forms.TextBox NombrePregunta;
        private System.Windows.Forms.Label Lasignatura;
        private System.Windows.Forms.Label Numero;
        private System.Windows.Forms.Label Lpregunta;
        private System.Windows.Forms.TextBox Materias;
        private System.Windows.Forms.Button NuevoExamen;
    }
}