namespace Ejercicio2
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
            this.tbNota = new System.Windows.Forms.TextBox();
            this.gbNotas = new System.Windows.Forms.GroupBox();
            this.lbTop = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lbMostrar = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnTop = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gbNotas.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la nota:";
            // 
            // tbNota
            // 
            this.tbNota.Location = new System.Drawing.Point(200, 61);
            this.tbNota.Name = "tbNota";
            this.tbNota.Size = new System.Drawing.Size(350, 31);
            this.tbNota.TabIndex = 1;
            // 
            // gbNotas
            // 
            this.gbNotas.Controls.Add(this.label2);
            this.gbNotas.Controls.Add(this.lbTop);
            this.gbNotas.Controls.Add(this.btnAgregar);
            this.gbNotas.Controls.Add(this.btnTop);
            this.gbNotas.Controls.Add(this.label3);
            this.gbNotas.Controls.Add(this.lblPromedio);
            this.gbNotas.Controls.Add(this.lbMostrar);
            this.gbNotas.Controls.Add(this.label1);
            this.gbNotas.Controls.Add(this.tbNota);
            this.gbNotas.Location = new System.Drawing.Point(12, 15);
            this.gbNotas.Name = "gbNotas";
            this.gbNotas.Size = new System.Drawing.Size(675, 472);
            this.gbNotas.TabIndex = 3;
            this.gbNotas.TabStop = false;
            this.gbNotas.Text = "Notas";
            // 
            // lbTop
            // 
            this.lbTop.FormattingEnabled = true;
            this.lbTop.ItemHeight = 20;
            this.lbTop.Location = new System.Drawing.Point(447, 306);
            this.lbTop.Name = "lbTop";
            this.lbTop.Size = new System.Drawing.Size(145, 144);
            this.lbTop.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 5;
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(463, 170);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(0, 20);
            this.lblPromedio.TabIndex = 4;
            // 
            // lbMostrar
            // 
            this.lbMostrar.FormattingEnabled = true;
            this.lbMostrar.ItemHeight = 20;
            this.lbMostrar.Location = new System.Drawing.Point(27, 146);
            this.lbMostrar.Name = "lbMostrar";
            this.lbMostrar.Size = new System.Drawing.Size(405, 304);
            this.lbMostrar.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAgregar.ImageKey = "(ninguno)";
            this.btnAgregar.Location = new System.Drawing.Point(556, 47);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(96, 55);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnTop
            // 
            this.btnTop.Image = global::Ejercicio2.Properties.Resources.top3;
            this.btnTop.Location = new System.Drawing.Point(447, 234);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(61, 47);
            this.btnTop.TabIndex = 6;
            this.btnTop.UseVisualStyleBackColor = true;
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(523, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "Top3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(764, 522);
            this.Controls.Add(this.gbNotas);
            this.Font = new System.Drawing.Font("MingLiU-ExtB", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Registro de Notas";
            this.gbNotas.ResumeLayout(false);
            this.gbNotas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNota;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox gbNotas;
        private System.Windows.Forms.ListBox lbMostrar;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbTop;
        private System.Windows.Forms.Button btnTop;
        private System.Windows.Forms.Label label2;
    }
}

