
namespace WinFormsApp1
{
    partial class TareaEstudiante
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.NombreTarea = new System.Windows.Forms.Label();
            this.Guardo = new System.Windows.Forms.Button();
            this.DescripcionTarea = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Respuesta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 407);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(886, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(292, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tareas";
            // 
            // NombreTarea
            // 
            this.NombreTarea.AutoSize = true;
            this.NombreTarea.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NombreTarea.Location = new System.Drawing.Point(12, 121);
            this.NombreTarea.Name = "NombreTarea";
            this.NombreTarea.Size = new System.Drawing.Size(86, 32);
            this.NombreTarea.TabIndex = 1;
            this.NombreTarea.Text = "Tareas";
            // 
            // Guardo
            // 
            this.Guardo.Location = new System.Drawing.Point(657, 378);
            this.Guardo.Name = "Guardo";
            this.Guardo.Size = new System.Drawing.Size(75, 23);
            this.Guardo.TabIndex = 3;
            this.Guardo.Text = "Guardar";
            this.Guardo.UseVisualStyleBackColor = true;
            this.Guardo.Click += new System.EventHandler(this.Guardo_Click);
            // 
            // DescripcionTarea
            // 
            this.DescripcionTarea.Location = new System.Drawing.Point(22, 157);
            this.DescripcionTarea.Multiline = true;
            this.DescripcionTarea.Name = "DescripcionTarea";
            this.DescripcionTarea.Size = new System.Drawing.Size(295, 111);
            this.DescripcionTarea.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(599, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Desarrollo";
            // 
            // Respuesta
            // 
            this.Respuesta.Location = new System.Drawing.Point(450, 156);
            this.Respuesta.Multiline = true;
            this.Respuesta.Name = "Respuesta";
            this.Respuesta.Size = new System.Drawing.Size(425, 215);
            this.Respuesta.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(24, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tareas";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(505, 257);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(295, 215);
            this.textBox3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tareas:";
            // 
            // TareaEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 546);
            this.Controls.Add(this.Respuesta);
            this.Controls.Add(this.DescripcionTarea);
            this.Controls.Add(this.Guardo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NombreTarea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TareaEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TareaEstudiante";
            this.Load += new System.EventHandler(this.TareaEstudiante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NombreTarea;
        private System.Windows.Forms.Button Guardo;
        private System.Windows.Forms.TextBox Respuesta;
        private System.Windows.Forms.TextBox DescripcionTarea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
    }
}