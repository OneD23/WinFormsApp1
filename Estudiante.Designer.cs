
namespace WinFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.Maximizar = new System.Windows.Forms.PictureBox();
            this.Cerrar = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.PanelLateral = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.Agregar = new System.Windows.Forms.Button();
            this.Matricula = new System.Windows.Forms.Label();
            this.NombreCompleto = new System.Windows.Forms.Label();
            this.FotoPerfil = new System.Windows.Forms.PictureBox();
            this.Id = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contenido = new System.Windows.Forms.Panel();
            this.PanelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            this.PanelLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.PanelSuperior.Controls.Add(this.Maximizar);
            this.PanelSuperior.Controls.Add(this.Cerrar);
            this.PanelSuperior.Controls.Add(this.Minimizar);
            this.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(1200, 30);
            this.PanelSuperior.TabIndex = 0;
            // 
            // Maximizar
            // 
            this.Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Maximizar.Image = global::WinFormsApp1.Properties.Resources.maxi;
            this.Maximizar.Location = new System.Drawing.Point(1140, 5);
            this.Maximizar.Name = "Maximizar";
            this.Maximizar.Size = new System.Drawing.Size(25, 25);
            this.Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Maximizar.TabIndex = 9;
            this.Maximizar.TabStop = false;
            this.Maximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cerrar.Image = global::WinFormsApp1.Properties.Resources.cerrar;
            this.Cerrar.Location = new System.Drawing.Point(1171, 6);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(25, 25);
            this.Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cerrar.TabIndex = 8;
            this.Cerrar.TabStop = false;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimizar.Image = global::WinFormsApp1.Properties.Resources.minimazar;
            this.Minimizar.Location = new System.Drawing.Point(1109, 6);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(25, 25);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimizar.TabIndex = 7;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // PanelLateral
            // 
            this.PanelLateral.BackColor = System.Drawing.Color.DimGray;
            this.PanelLateral.Controls.Add(this.pictureBox6);
            this.PanelLateral.Controls.Add(this.Agregar);
            this.PanelLateral.Controls.Add(this.Matricula);
            this.PanelLateral.Controls.Add(this.NombreCompleto);
            this.PanelLateral.Controls.Add(this.FotoPerfil);
            this.PanelLateral.Controls.Add(this.Id);
            this.PanelLateral.Controls.Add(this.pictureBox1);
            this.PanelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLateral.Location = new System.Drawing.Point(0, 30);
            this.PanelLateral.Name = "PanelLateral";
            this.PanelLateral.Size = new System.Drawing.Size(313, 546);
            this.PanelLateral.TabIndex = 1;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(12, 489);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(36, 30);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 27;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Visible = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // Agregar
            // 
            this.Agregar.BackColor = System.Drawing.Color.DimGray;
            this.Agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Agregar.FlatAppearance.BorderSize = 0;
            this.Agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Agregar.Font = new System.Drawing.Font("Poor Richard", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Agregar.Location = new System.Drawing.Point(47, 468);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(238, 78);
            this.Agregar.TabIndex = 8;
            this.Agregar.Text = "Agregar o eliminar clases";
            this.Agregar.UseVisualStyleBackColor = false;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Matricula
            // 
            this.Matricula.AutoSize = true;
            this.Matricula.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Matricula.Location = new System.Drawing.Point(102, 408);
            this.Matricula.Name = "Matricula";
            this.Matricula.Size = new System.Drawing.Size(76, 25);
            this.Matricula.TabIndex = 6;
            this.Matricula.Text = "label23";
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.AutoSize = true;
            this.NombreCompleto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NombreCompleto.Location = new System.Drawing.Point(67, 379);
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.Size = new System.Drawing.Size(76, 25);
            this.NombreCompleto.TabIndex = 5;
            this.NombreCompleto.Text = "label23";
            // 
            // FotoPerfil
            // 
            this.FotoPerfil.Location = new System.Drawing.Point(67, 191);
            this.FotoPerfil.Name = "FotoPerfil";
            this.FotoPerfil.Size = new System.Drawing.Size(182, 174);
            this.FotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FotoPerfil.TabIndex = 4;
            this.FotoPerfil.TabStop = false;
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Id.Location = new System.Drawing.Point(103, 379);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(79, 25);
            this.Id.TabIndex = 3;
            this.Id.Text = "wander";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // contenido
            // 
            this.contenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenido.Location = new System.Drawing.Point(313, 30);
            this.contenido.Name = "contenido";
            this.contenido.Size = new System.Drawing.Size(887, 546);
            this.contenido.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 576);
            this.Controls.Add(this.contenido);
            this.Controls.Add(this.PanelLateral);
            this.Controls.Add(this.PanelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estudiante";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            this.PanelSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            this.PanelLateral.ResumeLayout(false);
            this.PanelLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.Panel PanelLateral;

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel contenido;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.PictureBox FotoPerfil;
        private System.Windows.Forms.PictureBox Maximizar;
        private System.Windows.Forms.PictureBox Cerrar;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.Label Matricula;
        private System.Windows.Forms.Label NombreCompleto;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}