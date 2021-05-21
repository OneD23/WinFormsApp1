
namespace WinFormsApp1
{
    partial class TareaProfesor
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
            this.DescripcionTarea = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Guardo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NombreTarea = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DescripcionTarea
            // 
            this.DescripcionTarea.Location = new System.Drawing.Point(167, 221);
            this.DescripcionTarea.Multiline = true;
            this.DescripcionTarea.Name = "DescripcionTarea";
            this.DescripcionTarea.Size = new System.Drawing.Size(295, 176);
            this.DescripcionTarea.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descripcion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(232, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Creacion tareas";
            // 
            // Guardo
            // 
            this.Guardo.Location = new System.Drawing.Point(313, 449);
            this.Guardo.Name = "Guardo";
            this.Guardo.Size = new System.Drawing.Size(149, 68);
            this.Guardo.TabIndex = 10;
            this.Guardo.Text = "Guardar";
            this.Guardo.UseVisualStyleBackColor = true;
            this.Guardo.Click += new System.EventHandler(this.Guardo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre";
            // 
            // NombreTarea
            // 
            this.NombreTarea.Location = new System.Drawing.Point(167, 161);
            this.NombreTarea.Name = "NombreTarea";
            this.NombreTarea.Size = new System.Drawing.Size(295, 23);
            this.NombreTarea.TabIndex = 12;
            // 
            // TareaProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 557);
            this.Controls.Add(this.NombreTarea);
            this.Controls.Add(this.DescripcionTarea);
            this.Controls.Add(this.Guardo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TareaProfesor";
            this.Text = "Calificar";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox DescripcionTarea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Guardo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NombreTarea;
    }
}