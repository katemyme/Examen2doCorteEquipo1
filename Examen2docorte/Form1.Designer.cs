namespace Examen2docorte
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbNormal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCritico = new System.Windows.Forms.TextBox();
            this.lbNormal = new System.Windows.Forms.ListBox();
            this.lbCritico = new System.Windows.Forms.ListBox();
            this.btnEliminarPacienteNormal = new System.Windows.Forms.Button();
            this.btnEliminarPacienteCritico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pacientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pacientes Emergencias";
            // 
            // tbNormal
            // 
            this.tbNormal.Location = new System.Drawing.Point(30, 45);
            this.tbNormal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNormal.Name = "tbNormal";
            this.tbNormal.Size = new System.Drawing.Size(76, 20);
            this.tbNormal.TabIndex = 2;
            this.tbNormal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNormal_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Caso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Caso";
            // 
            // tbCritico
            // 
            this.tbCritico.Location = new System.Drawing.Point(166, 44);
            this.tbCritico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCritico.Name = "tbCritico";
            this.tbCritico.Size = new System.Drawing.Size(76, 20);
            this.tbCritico.TabIndex = 5;
            this.tbCritico.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCritico_KeyDown);
            // 
            // lbNormal
            // 
            this.lbNormal.FormattingEnabled = true;
            this.lbNormal.Location = new System.Drawing.Point(30, 109);
            this.lbNormal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbNormal.Name = "lbNormal";
            this.lbNormal.Size = new System.Drawing.Size(91, 238);
            this.lbNormal.TabIndex = 6;
            // 
            // lbCritico
            // 
            this.lbCritico.FormattingEnabled = true;
            this.lbCritico.Location = new System.Drawing.Point(166, 109);
            this.lbCritico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbCritico.Name = "lbCritico";
            this.lbCritico.Size = new System.Drawing.Size(91, 238);
            this.lbCritico.TabIndex = 7;
            // 
            // btnEliminarPacienteNormal
            // 
            this.btnEliminarPacienteNormal.Location = new System.Drawing.Point(10, 69);
            this.btnEliminarPacienteNormal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarPacienteNormal.Name = "btnEliminarPacienteNormal";
            this.btnEliminarPacienteNormal.Size = new System.Drawing.Size(119, 36);
            this.btnEliminarPacienteNormal.TabIndex = 8;
            this.btnEliminarPacienteNormal.Text = "Eliminar Paciente Comun";
            this.btnEliminarPacienteNormal.UseVisualStyleBackColor = true;
            this.btnEliminarPacienteNormal.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEliminarPacienteCritico
            // 
            this.btnEliminarPacienteCritico.Location = new System.Drawing.Point(153, 69);
            this.btnEliminarPacienteCritico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarPacienteCritico.Name = "btnEliminarPacienteCritico";
            this.btnEliminarPacienteCritico.Size = new System.Drawing.Size(115, 36);
            this.btnEliminarPacienteCritico.TabIndex = 9;
            this.btnEliminarPacienteCritico.Text = "Eliminar Paciente Emergencia";
            this.btnEliminarPacienteCritico.UseVisualStyleBackColor = true;
            this.btnEliminarPacienteCritico.Click += new System.EventHandler(this.btnEliminarPacienteCritico_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 366);
            this.Controls.Add(this.btnEliminarPacienteCritico);
            this.Controls.Add(this.btnEliminarPacienteNormal);
            this.Controls.Add(this.lbCritico);
            this.Controls.Add(this.lbNormal);
            this.Controls.Add(this.tbCritico);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNormal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNormal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCritico;
        private System.Windows.Forms.ListBox lbNormal;
        private System.Windows.Forms.ListBox lbCritico;
        private System.Windows.Forms.Button btnEliminarPacienteNormal;
        private System.Windows.Forms.Button btnEliminarPacienteCritico;
    }
}

