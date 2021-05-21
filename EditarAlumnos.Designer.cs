
namespace WinFormsApp1
{
    partial class EditarAlumnos
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
            this.Matricula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Otros = new System.Windows.Forms.CheckBox();
            this.Femenino = new System.Windows.Forms.CheckBox();
            this.Masculino = new System.Windows.Forms.CheckBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Apellido = new System.Windows.Forms.TextBox();
            this.Carrera = new System.Windows.Forms.TextBox();
            this.Direccion = new System.Windows.Forms.TextBox();
            this.Telefono = new System.Windows.Forms.TextBox();
            this.Nacionalidad = new System.Windows.Forms.TextBox();
            this.EstadoCivil = new System.Windows.Forms.TextBox();
            this.Guardar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.FotoPerfil = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.Contraseña = new System.Windows.Forms.TextBox();
            this.Terminar = new System.Windows.Forms.Button();
            this.Correo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FotoPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(33, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricula:";
            
            // 
            // Matricula
            // 
            this.Matricula.Location = new System.Drawing.Point(154, 97);
            this.Matricula.MaxLength = 9;
            this.Matricula.Name = "Matricula";
            this.Matricula.Size = new System.Drawing.Size(120, 23);
            this.Matricula.TabIndex = 1;
            this.Matricula.TextChanged += new System.EventHandler(this.Matricula_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(33, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(33, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(33, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Carrera:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(33, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Fecha de nacimieto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(33, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Direccion:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(33, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "telefono:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(33, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nacionalida:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(33, 423);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "Estado civil:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(33, 459);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 22);
            this.label10.TabIndex = 0;
            this.label10.Text = "Sexo:";
            // 
            // Otros
            // 
            this.Otros.AutoSize = true;
            this.Otros.Enabled = false;
            this.Otros.Location = new System.Drawing.Point(276, 459);
            this.Otros.Name = "Otros";
            this.Otros.Size = new System.Drawing.Size(55, 19);
            this.Otros.TabIndex = 2;
            this.Otros.Text = "Otros";
            this.Otros.UseVisualStyleBackColor = true;
            // 
            // Femenino
            // 
            this.Femenino.AutoSize = true;
            this.Femenino.Enabled = false;
            this.Femenino.Location = new System.Drawing.Point(191, 459);
            this.Femenino.Name = "Femenino";
            this.Femenino.Size = new System.Drawing.Size(79, 19);
            this.Femenino.TabIndex = 2;
            this.Femenino.Text = "Femenino";
            this.Femenino.UseVisualStyleBackColor = true;
            // 
            // Masculino
            // 
            this.Masculino.AutoSize = true;
            this.Masculino.Enabled = false;
            this.Masculino.Location = new System.Drawing.Point(106, 459);
            this.Masculino.Name = "Masculino";
            this.Masculino.Size = new System.Drawing.Size(81, 19);
            this.Masculino.TabIndex = 2;
            this.Masculino.Text = "Masculino";
            this.Masculino.UseVisualStyleBackColor = true;
            // 
            // Nombre
            // 
            this.Nombre.Enabled = false;
            this.Nombre.Location = new System.Drawing.Point(123, 132);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(197, 23);
            this.Nombre.TabIndex = 3;
            // 
            // Apellido
            // 
            this.Apellido.Enabled = false;
            this.Apellido.Location = new System.Drawing.Point(142, 165);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(178, 23);
            this.Apellido.TabIndex = 3;
            // 
            // Carrera
            // 
            this.Carrera.Enabled = false;
            this.Carrera.Location = new System.Drawing.Point(140, 248);
            this.Carrera.Name = "Carrera";
            this.Carrera.Size = new System.Drawing.Size(180, 23);
            this.Carrera.TabIndex = 3;
            // 
            // Direccion
            // 
            this.Direccion.Enabled = false;
            this.Direccion.Location = new System.Drawing.Point(154, 318);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(166, 23);
            this.Direccion.TabIndex = 3;
            // 
            // Telefono
            // 
            this.Telefono.Enabled = false;
            this.Telefono.Location = new System.Drawing.Point(140, 353);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(180, 23);
            this.Telefono.TabIndex = 3;
            // 
            // Nacionalidad
            // 
            this.Nacionalidad.Enabled = false;
            this.Nacionalidad.Location = new System.Drawing.Point(169, 387);
            this.Nacionalidad.Name = "Nacionalidad";
            this.Nacionalidad.Size = new System.Drawing.Size(151, 23);
            this.Nacionalidad.TabIndex = 3;
            // 
            // EstadoCivil
            // 
            this.EstadoCivil.Enabled = false;
            this.EstadoCivil.Location = new System.Drawing.Point(169, 422);
            this.EstadoCivil.Name = "EstadoCivil";
            this.EstadoCivil.Size = new System.Drawing.Size(151, 23);
            this.EstadoCivil.TabIndex = 3;
            // 
            // Guardar
            // 
            this.Guardar.BackColor = System.Drawing.Color.DimGray;
            this.Guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guardar.FlatAppearance.BorderSize = 0;
            this.Guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Guardar.Font = new System.Drawing.Font("Poor Richard", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardar.Location = new System.Drawing.Point(478, 408);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(117, 38);
            this.Guardar.TabIndex = 8;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = false;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(199, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(209, 22);
            this.label11.TabIndex = 0;
            this.label11.Text = "Registro de Alumno";
            // 
            // FotoPerfil
            // 
            this.FotoPerfil.Location = new System.Drawing.Point(467, 97);
            this.FotoPerfil.Name = "FotoPerfil";
            this.FotoPerfil.Size = new System.Drawing.Size(143, 130);
            this.FotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FotoPerfil.TabIndex = 9;
            this.FotoPerfil.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Poor Richard", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(467, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "Foto";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(249, 282);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(71, 23);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(31, 205);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 22);
            this.label12.TabIndex = 0;
            this.label12.Text = "Contraseña:";
            // 
            // Contraseña
            // 
            this.Contraseña.Enabled = false;
            this.Contraseña.Location = new System.Drawing.Point(169, 204);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(151, 23);
            this.Contraseña.TabIndex = 3;
            // 
            // Terminar
            // 
            this.Terminar.BackColor = System.Drawing.Color.DimGray;
            this.Terminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Terminar.FlatAppearance.BorderSize = 0;
            this.Terminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.Terminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Terminar.Font = new System.Drawing.Font("Poor Richard", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Terminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Terminar.Location = new System.Drawing.Point(467, 408);
            this.Terminar.Name = "Terminar";
            this.Terminar.Size = new System.Drawing.Size(132, 38);
            this.Terminar.TabIndex = 8;
            this.Terminar.Text = "Terminar";
            this.Terminar.UseVisualStyleBackColor = false;
            this.Terminar.Visible = false;
            this.Terminar.Click += new System.EventHandler(this.Terminar_Click);
            // 
            // Correo
            // 
            this.Correo.Enabled = false;
            this.Correo.Location = new System.Drawing.Point(439, 354);
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(195, 23);
            this.Correo.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(429, 329);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(216, 22);
            this.label13.TabIndex = 0;
            this.label13.Text = "Correo electronico:";
            // 
            // EditarAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 494);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FotoPerfil);
            this.Controls.Add(this.Terminar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.EstadoCivil);
            this.Controls.Add(this.Correo);
            this.Controls.Add(this.Nacionalidad);
            this.Controls.Add(this.Telefono);
            this.Controls.Add(this.Direccion);
            this.Controls.Add(this.Carrera);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Masculino);
            this.Controls.Add(this.Femenino);
            this.Controls.Add(this.Otros);
            this.Controls.Add(this.Matricula);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarAlumnos";
            this.Text = "EditarAlumnos";
            ((System.ComponentModel.ISupportInitialize)(this.FotoPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Matricula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox Otros;
        private System.Windows.Forms.CheckBox Femenino;
        private System.Windows.Forms.CheckBox Masculino;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox Apellido;
        private System.Windows.Forms.TextBox Carrera;
        private System.Windows.Forms.TextBox Direccion;
        private System.Windows.Forms.TextBox Telefono;
        private System.Windows.Forms.TextBox Nacionalidad;
        private System.Windows.Forms.TextBox EstadoCivil;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox FotoPerfil;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Contraseña;
        private System.Windows.Forms.Button Terminar;
        private System.Windows.Forms.TextBox Correo;
        private System.Windows.Forms.Label label13;
    }
}