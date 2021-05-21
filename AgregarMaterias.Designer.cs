
namespace WinFormsApp1
{
    partial class AgregarMaterias
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
            this.Materias = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Asignatura = new System.Windows.Forms.TextBox();
            this.Profesor = new System.Windows.Forms.TextBox();
            this.Seccion = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Materias)).BeginInit();
            this.SuspendLayout();
            // 
            // Materias
            // 
            this.Materias.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Materias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Materias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Materias.Dock = System.Windows.Forms.DockStyle.Top;
            this.Materias.Location = new System.Drawing.Point(0, 0);
            this.Materias.Name = "Materias";
            this.Materias.RowTemplate.Height = 25;
            this.Materias.Size = new System.Drawing.Size(800, 210);
            this.Materias.TabIndex = 0;
            this.Materias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Materias_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Asignatura:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Profesor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Seccion:";
            // 
            // Asignatura
            // 
            this.Asignatura.Location = new System.Drawing.Point(136, 258);
            this.Asignatura.Name = "Asignatura";
            this.Asignatura.Size = new System.Drawing.Size(224, 23);
            this.Asignatura.TabIndex = 2;
            // 
            // Profesor
            // 
            this.Profesor.Location = new System.Drawing.Point(110, 313);
            this.Profesor.Name = "Profesor";
            this.Profesor.Size = new System.Drawing.Size(250, 23);
            this.Profesor.TabIndex = 2;
            // 
            // Seccion
            // 
            this.Seccion.Location = new System.Drawing.Point(101, 370);
            this.Seccion.Name = "Seccion";
            this.Seccion.Size = new System.Drawing.Size(259, 23);
            this.Seccion.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(678, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Inscribir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AgregarMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Seccion);
            this.Controls.Add(this.Profesor);
            this.Controls.Add(this.Asignatura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Materias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarMaterias";
            this.Text = "Profesor:";
            this.Load += new System.EventHandler(this.AgregarMaterias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Materias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Materias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Asignatura;
        private System.Windows.Forms.TextBox Profesor;
        private System.Windows.Forms.TextBox Seccion;
        private System.Windows.Forms.Button button1;
    }
}