namespace Ejercicio1
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
            this.tbNameVer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPasswordVer = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNameRe = new System.Windows.Forms.TextBox();
            this.tbPasswordRe = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nickname:";
            // 
            // tbNameVer
            // 
            this.tbNameVer.Location = new System.Drawing.Point(153, 115);
            this.tbNameVer.Name = "tbNameVer";
            this.tbNameVer.Size = new System.Drawing.Size(298, 31);
            this.tbNameVer.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // tbPasswordVer
            // 
            this.tbPasswordVer.Location = new System.Drawing.Point(153, 166);
            this.tbPasswordVer.Name = "tbPasswordVer";
            this.tbPasswordVer.Size = new System.Drawing.Size(298, 31);
            this.tbPasswordVer.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbNameRe);
            this.groupBox1.Controls.Add(this.tbPasswordRe);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(519, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 355);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Usuario";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Image = global::Ejercicio1.Properties.Resources.agregUsuario;
            this.btnRegistrar.Location = new System.Drawing.Point(142, 236);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(176, 65);
            this.btnRegistrar.TabIndex = 14;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MingLiU-ExtB", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 28);
            this.label4.TabIndex = 13;
            this.label4.Text = "Registrate";
            // 
            // tbNameRe
            // 
            this.tbNameRe.Location = new System.Drawing.Point(116, 112);
            this.tbNameRe.Name = "tbNameRe";
            this.tbNameRe.Size = new System.Drawing.Size(330, 31);
            this.tbNameRe.TabIndex = 10;
            // 
            // tbPasswordRe
            // 
            this.tbPasswordRe.Location = new System.Drawing.Point(116, 161);
            this.tbPasswordRe.Name = "tbPasswordRe";
            this.tbPasswordRe.Size = new System.Drawing.Size(330, 31);
            this.tbPasswordRe.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nickname:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Password:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnVerificar);
            this.groupBox2.Controls.Add(this.tbPasswordVer);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbNameVer);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(469, 367);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Verificacion de Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MingLiU-ExtB", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(167, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 28);
            this.label3.TabIndex = 15;
            this.label3.Text = "Verificacion";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Image = global::Ejercicio1.Properties.Resources.verificado;
            this.btnVerificar.Location = new System.Drawing.Point(153, 237);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(176, 65);
            this.btnVerificar.TabIndex = 15;
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1025, 391);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("MingLiU-ExtB", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Verificacion Usuario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNameVer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPasswordVer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNameRe;
        private System.Windows.Forms.TextBox tbPasswordRe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label label3;
    }
}

