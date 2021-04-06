
namespace WinFormsApp1
{
    partial class inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.registrar = new System.Windows.Forms.Button();
            this.calificar = new System.Windows.Forms.Button();
            this.listar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.asistencia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SkyBlue;
            this.label1.Location = new System.Drawing.Point(37, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Control de estudiantes";
            // 
            // registrar
            // 
            this.registrar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.registrar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.registrar.ForeColor = System.Drawing.Color.SkyBlue;
            this.registrar.Location = new System.Drawing.Point(12, 123);
            this.registrar.Name = "registrar";
            this.registrar.Size = new System.Drawing.Size(109, 38);
            this.registrar.TabIndex = 1;
            this.registrar.Text = "Registrar";
            this.registrar.UseVisualStyleBackColor = false;
            this.registrar.Click += new System.EventHandler(this.registrar_Click);
            // 
            // calificar
            // 
            this.calificar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.calificar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calificar.ForeColor = System.Drawing.Color.SkyBlue;
            this.calificar.Location = new System.Drawing.Point(242, 123);
            this.calificar.Name = "calificar";
            this.calificar.Size = new System.Drawing.Size(109, 38);
            this.calificar.TabIndex = 1;
            this.calificar.Text = "Calificar";
            this.calificar.UseVisualStyleBackColor = false;
            this.calificar.Click += new System.EventHandler(this.calificar_Click);
            // 
            // listar
            // 
            this.listar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.listar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listar.ForeColor = System.Drawing.Color.SkyBlue;
            this.listar.Location = new System.Drawing.Point(357, 123);
            this.listar.Name = "listar";
            this.listar.Size = new System.Drawing.Size(109, 38);
            this.listar.TabIndex = 1;
            this.listar.Text = "Listar";
            this.listar.UseVisualStyleBackColor = false;
            this.listar.Click += new System.EventHandler(this.listar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // asistencia
            // 
            this.asistencia.BackColor = System.Drawing.SystemColors.ControlDark;
            this.asistencia.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.asistencia.ForeColor = System.Drawing.Color.SkyBlue;
            this.asistencia.Location = new System.Drawing.Point(127, 123);
            this.asistencia.Name = "asistencia";
            this.asistencia.Size = new System.Drawing.Size(109, 38);
            this.asistencia.TabIndex = 1;
            this.asistencia.Text = "Borrar";
            this.asistencia.UseVisualStyleBackColor = false;
            this.asistencia.Click += new System.EventHandler(this.asistencia_Click);
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 251);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listar);
            this.Controls.Add(this.calificar);
            this.Controls.Add(this.asistencia);
            this.Controls.Add(this.registrar);
            this.Controls.Add(this.label1);
            this.Name = "inicio";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button registrar;
        private System.Windows.Forms.Button calificar;
        private System.Windows.Forms.Button listar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button asistencia;
    }
}

