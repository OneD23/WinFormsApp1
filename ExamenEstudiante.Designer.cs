
namespace WinFormsApp1
{
    partial class ExamenEstudiante
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
            this.NombreExamen = new System.Windows.Forms.Label();
            this.Examenes = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pregunta = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.RadioButton();
            this.B = new System.Windows.Forms.RadioButton();
            this.C = new System.Windows.Forms.RadioButton();
            this.D = new System.Windows.Forms.RadioButton();
            this.Enviar = new System.Windows.Forms.Button();
            this.Siguiente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Examenes)).BeginInit();
            this.SuspendLayout();
            // 
            // NombreExamen
            // 
            this.NombreExamen.AutoSize = true;
            this.NombreExamen.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NombreExamen.Location = new System.Drawing.Point(248, 9);
            this.NombreExamen.Name = "NombreExamen";
            this.NombreExamen.Size = new System.Drawing.Size(110, 29);
            this.NombreExamen.TabIndex = 0;
            this.NombreExamen.Text = "Examen";
            // 
            // Examenes
            // 
            this.Examenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Examenes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre});
            this.Examenes.Location = new System.Drawing.Point(210, 96);
            this.Examenes.Name = "Examenes";
            this.Examenes.RowTemplate.Height = 25;
            this.Examenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Examenes.Size = new System.Drawing.Size(317, 150);
            this.Examenes.TabIndex = 1;
            this.Examenes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Examenes_CellContentClick);
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nombre.HeaderText = "Examen";
            this.nombre.Name = "nombre";
            this.nombre.Width = 74;
            // 
            // Pregunta
            // 
            this.Pregunta.AutoSize = true;
            this.Pregunta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Pregunta.Location = new System.Drawing.Point(74, 96);
            this.Pregunta.Name = "Pregunta";
            this.Pregunta.Size = new System.Drawing.Size(80, 21);
            this.Pregunta.TabIndex = 2;
            this.Pregunta.Text = "Pregunta";
            this.Pregunta.Visible = false;
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Location = new System.Drawing.Point(74, 135);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(94, 19);
            this.A.TabIndex = 3;
            this.A.TabStop = true;
            this.A.Text = "radioButton1";
            this.A.UseVisualStyleBackColor = true;
            this.A.Visible = false;
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.Location = new System.Drawing.Point(74, 227);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(94, 19);
            this.B.TabIndex = 3;
            this.B.TabStop = true;
            this.B.Text = "radioButton1";
            this.B.UseVisualStyleBackColor = true;
            this.B.Visible = false;
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Location = new System.Drawing.Point(462, 135);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(94, 19);
            this.C.TabIndex = 3;
            this.C.TabStop = true;
            this.C.Text = "radioButton1";
            this.C.UseVisualStyleBackColor = true;
            this.C.Visible = false;
            // 
            // D
            // 
            this.D.AutoSize = true;
            this.D.Location = new System.Drawing.Point(462, 227);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(94, 19);
            this.D.TabIndex = 3;
            this.D.TabStop = true;
            this.D.Text = "radioButton1";
            this.D.UseVisualStyleBackColor = true;
            this.D.Visible = false;
            // 
            // Enviar
            // 
            this.Enviar.Location = new System.Drawing.Point(343, 285);
            this.Enviar.Name = "Enviar";
            this.Enviar.Size = new System.Drawing.Size(75, 23);
            this.Enviar.TabIndex = 4;
            this.Enviar.Text = "Enviar";
            this.Enviar.UseVisualStyleBackColor = true;
            this.Enviar.Visible = false;
            this.Enviar.Click += new System.EventHandler(this.Enviar_Click);
            // 
            // Siguiente
            // 
            this.Siguiente.Location = new System.Drawing.Point(210, 285);
            this.Siguiente.Name = "Siguiente";
            this.Siguiente.Size = new System.Drawing.Size(75, 23);
            this.Siguiente.TabIndex = 4;
            this.Siguiente.Text = "Siguiente";
            this.Siguiente.UseVisualStyleBackColor = true;
            this.Siguiente.Visible = false;
            this.Siguiente.Click += new System.EventHandler(this.Siguiente_Click);
            // 
            // ExamenEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Siguiente);
            this.Controls.Add(this.Enviar);
            this.Controls.Add(this.D);
            this.Controls.Add(this.B);
            this.Controls.Add(this.C);
            this.Controls.Add(this.A);
            this.Controls.Add(this.Pregunta);
            this.Controls.Add(this.Examenes);
            this.Controls.Add(this.NombreExamen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExamenEstudiante";
            this.Text = "ExamenEstudiante";
            this.Load += new System.EventHandler(this.ExamenEstudiante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Examenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NombreExamen;
        private System.Windows.Forms.DataGridView Examenes;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.Label Pregunta;
        private System.Windows.Forms.RadioButton A;
        private System.Windows.Forms.RadioButton B;
        private System.Windows.Forms.RadioButton C;
        private System.Windows.Forms.RadioButton D;
        private System.Windows.Forms.Button Enviar;
        private System.Windows.Forms.Button Siguiente;
    }
}