
namespace WindowsFormsApp1
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.nombreIniciado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.correoIniciado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(295, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // nombreIniciado
            // 
            this.nombreIniciado.AutoSize = true;
            this.nombreIniciado.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreIniciado.ForeColor = System.Drawing.SystemColors.Control;
            this.nombreIniciado.Location = new System.Drawing.Point(295, 153);
            this.nombreIniciado.Name = "nombreIniciado";
            this.nombreIniciado.Size = new System.Drawing.Size(91, 25);
            this.nombreIniciado.TabIndex = 1;
            this.nombreIniciado.Text = "DEFAULT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(295, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Correo";
            // 
            // correoIniciado
            // 
            this.correoIniciado.AutoSize = true;
            this.correoIniciado.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correoIniciado.ForeColor = System.Drawing.SystemColors.Control;
            this.correoIniciado.Location = new System.Drawing.Point(295, 267);
            this.correoIniciado.Name = "correoIniciado";
            this.correoIniciado.Size = new System.Drawing.Size(91, 25);
            this.correoIniciado.TabIndex = 3;
            this.correoIniciado.Text = "DEFAULT";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.correoIniciado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nombreIniciado);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nombreIniciado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label correoIniciado;
    }
}