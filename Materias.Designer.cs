
namespace WinFormsApp1
{
    partial class Materias
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Seccion = new System.Windows.Forms.TextBox();
            this.Facultad = new System.Windows.Forms.TextBox();
            this.Creditos = new System.Windows.Forms.TextBox();
            this.Guardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(195, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Añadiendo Asignaturas al sistema";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Seccion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Facultad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Creditos:";
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(128, 107);
            this.Nombre.MaxLength = 150;
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(182, 23);
            this.Nombre.TabIndex = 1;
            // 
            // Seccion
            // 
            this.Seccion.Location = new System.Drawing.Point(128, 158);
            this.Seccion.MaxLength = 150;
            this.Seccion.Name = "Seccion";
            this.Seccion.Size = new System.Drawing.Size(182, 23);
            this.Seccion.TabIndex = 1;
            // 
            // Facultad
            // 
            this.Facultad.Location = new System.Drawing.Point(128, 210);
            this.Facultad.MaxLength = 150;
            this.Facultad.Name = "Facultad";
            this.Facultad.Size = new System.Drawing.Size(182, 23);
            this.Facultad.TabIndex = 1;
            // 
            // Creditos
            // 
            this.Creditos.Location = new System.Drawing.Point(128, 265);
            this.Creditos.MaxLength = 5;
            this.Creditos.Name = "Creditos";
            this.Creditos.Size = new System.Drawing.Size(182, 23);
            this.Creditos.TabIndex = 1;
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(392, 312);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(87, 31);
            this.Guardar.TabIndex = 2;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Materias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Creditos);
            this.Controls.Add(this.Facultad);
            this.Controls.Add(this.Seccion);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Materias";
            this.Text = "Materias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox Seccion;
        private System.Windows.Forms.TextBox Facultad;
        private System.Windows.Forms.TextBox Creditos;
        private System.Windows.Forms.Button Guardar;
    }
}