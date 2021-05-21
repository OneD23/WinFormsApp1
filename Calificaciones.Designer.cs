
namespace WinFormsApp1
{
    partial class Calificaciones
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
            this.Examenes = new System.Windows.Forms.DataGridView();
            this.Tareas = new System.Windows.Forms.DataGridView();
            this.asignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.examen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Examenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tareas)).BeginInit();
            this.SuspendLayout();
            // 
            // Examenes
            // 
            this.Examenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Examenes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.examen,
            this.dataGridViewTextBoxColumn1,
            this.Calificacion});
            this.Examenes.Location = new System.Drawing.Point(12, 288);
            this.Examenes.Name = "Examenes";
            this.Examenes.RowTemplate.Height = 25;
            this.Examenes.Size = new System.Drawing.Size(776, 150);
            this.Examenes.TabIndex = 0;
            // 
            // Tareas
            // 
            this.Tareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tareas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.asignatura,
            this.tarea,
            this.nota});
            this.Tareas.Location = new System.Drawing.Point(12, 64);
            this.Tareas.Name = "Tareas";
            this.Tareas.RowTemplate.Height = 25;
            this.Tareas.Size = new System.Drawing.Size(776, 150);
            this.Tareas.TabIndex = 0;
            // 
            // asignatura
            // 
            this.asignatura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.asignatura.HeaderText = "Asignatura";
            this.asignatura.Name = "asignatura";
            this.asignatura.Width = 89;
            // 
            // tarea
            // 
            this.tarea.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tarea.HeaderText = "Tarea";
            this.tarea.Name = "tarea";
            this.tarea.Width = 59;
            // 
            // nota
            // 
            this.nota.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nota.HeaderText = "Calificacion";
            this.nota.Name = "nota";
            this.nota.Width = 94;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(341, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Examenes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(356, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tareas";
            // 
            // examen
            // 
            this.examen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.examen.HeaderText = "Examen";
            this.examen.Name = "examen";
            this.examen.Width = 74;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "Asignatura";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 89;
            // 
            // Calificacion
            // 
            this.Calificacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Calificacion.HeaderText = "Calificacion";
            this.Calificacion.Name = "Calificacion";
            this.Calificacion.Width = 94;
            // 
            // Calificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tareas);
            this.Controls.Add(this.Examenes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Calificaciones";
            this.Text = "ExamenEstudiante";
            this.Load += new System.EventHandler(this.ExamenEstudiante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Examenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tareas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Examenes;
        private System.Windows.Forms.DataGridView Tareas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn asignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota;
        private System.Windows.Forms.DataGridViewTextBoxColumn examen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calificacion;
    }
}