namespace Evaluacion2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.x = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNota = new System.Windows.Forms.TextBox();
            this.lbMostrar = new System.Windows.Forms.ListBox();
            this.lbTop = new System.Windows.Forms.ListBox();
            this.btnTop = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(183, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Programa de estudiantes notas: ";
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.x.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.x.Location = new System.Drawing.Point(161, 94);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(64, 20);
            this.x.TabIndex = 1;
            this.x.Text = "Notas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("PT Bold Broken", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(70, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Todas las notas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("PT Bold Broken", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(544, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "Top Tres:";
            // 
            // tbNota
            // 
            this.tbNota.Location = new System.Drawing.Point(233, 91);
            this.tbNota.Name = "tbNota";
            this.tbNota.Size = new System.Drawing.Size(311, 22);
            this.tbNota.TabIndex = 4;
            // 
            // lbMostrar
            // 
            this.lbMostrar.FormattingEnabled = true;
            this.lbMostrar.ItemHeight = 16;
            this.lbMostrar.Location = new System.Drawing.Point(50, 240);
            this.lbMostrar.Name = "lbMostrar";
            this.lbMostrar.Size = new System.Drawing.Size(243, 196);
            this.lbMostrar.TabIndex = 5;
            // 
            // lbTop
            // 
            this.lbTop.FormattingEnabled = true;
            this.lbTop.ItemHeight = 16;
            this.lbTop.Location = new System.Drawing.Point(490, 240);
            this.lbTop.Name = "lbTop";
            this.lbTop.Size = new System.Drawing.Size(267, 196);
            this.lbTop.TabIndex = 6;
            // 
            // btnTop
            // 
            this.btnTop.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTop.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTop.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTop.Location = new System.Drawing.Point(343, 311);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(93, 56);
            this.btnTop.TabIndex = 7;
            this.btnTop.Text = "Top";
            this.btnTop.UseVisualStyleBackColor = false;
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregar.Location = new System.Drawing.Point(550, 86);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(99, 32);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(322, 253);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(0, 16);
            this.lblPromedio.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnTop);
            this.Controls.Add(this.lbTop);
            this.Controls.Add(this.lbMostrar);
            this.Controls.Add(this.tbNota);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.x);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label x;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNota;
        private System.Windows.Forms.ListBox lbMostrar;
        private System.Windows.Forms.ListBox lbTop;
        private System.Windows.Forms.Button btnTop;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblPromedio;
    }
}

