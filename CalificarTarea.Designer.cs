
namespace WinFormsApp1
{
    partial class CalificarTarea
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
            this.Tareas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.NombreTarea = new System.Windows.Forms.Label();
            this.Descripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Respuesta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nota = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Tareas)).BeginInit();
            this.SuspendLayout();
            // 
            // Tareas
            // 
            this.Tareas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Tareas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tareas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Tareas.Location = new System.Drawing.Point(0, 282);
            this.Tareas.Name = "Tareas";
            this.Tareas.RowTemplate.Height = 25;
            this.Tareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tareas.Size = new System.Drawing.Size(800, 168);
            this.Tareas.TabIndex = 0;
            this.Tareas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tareas_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(223, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Correcion de Tareas";
            // 
            // NombreTarea
            // 
            this.NombreTarea.AutoSize = true;
            this.NombreTarea.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NombreTarea.Location = new System.Drawing.Point(12, 79);
            this.NombreTarea.Name = "NombreTarea";
            this.NombreTarea.Size = new System.Drawing.Size(198, 28);
            this.NombreTarea.TabIndex = 1;
            this.NombreTarea.Text = "Nombre de la tarea";
            // 
            // Descripcion
            // 
            this.Descripcion.Enabled = false;
            this.Descripcion.Location = new System.Drawing.Point(13, 131);
            this.Descripcion.Multiline = true;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(197, 114);
            this.Descripcion.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(378, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Respuesta";
            // 
            // Respuesta
            // 
            this.Respuesta.Enabled = false;
            this.Respuesta.Location = new System.Drawing.Point(355, 131);
            this.Respuesta.Multiline = true;
            this.Respuesta.Name = "Respuesta";
            this.Respuesta.Size = new System.Drawing.Size(282, 114);
            this.Respuesta.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(668, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Calificacion";
            // 
            // nota
            // 
            this.nota.Location = new System.Drawing.Point(655, 152);
            this.nota.Name = "nota";
            this.nota.Size = new System.Drawing.Size(100, 23);
            this.nota.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(668, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CalificarTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nota);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Respuesta);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NombreTarea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tareas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CalificarTarea";
            this.Text = "CalificarTarea";
            this.Load += new System.EventHandler(this.CalificarTarea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tareas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Tareas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NombreTarea;
        private System.Windows.Forms.TextBox Descripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Respuesta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nota;
        private System.Windows.Forms.Button button1;
    }
}