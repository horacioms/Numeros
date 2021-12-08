
namespace Numeros
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.TxtLinea = new System.Windows.Forms.TextBox();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.TxtSalida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "Evaluar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtLinea
            // 
            this.TxtLinea.Location = new System.Drawing.Point(124, 17);
            this.TxtLinea.Name = "TxtLinea";
            this.TxtLinea.Size = new System.Drawing.Size(260, 23);
            this.TxtLinea.TabIndex = 1;
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(124, 46);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(130, 23);
            this.TxtValor.TabIndex = 2;
            // 
            // TxtSalida
            // 
            this.TxtSalida.Enabled = false;
            this.TxtSalida.Location = new System.Drawing.Point(124, 164);
            this.TxtSalida.Name = "TxtSalida";
            this.TxtSalida.Size = new System.Drawing.Size(260, 23);
            this.TxtSalida.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Números a evaluar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total de números:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "RESPUESTA:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 290);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSalida);
            this.Controls.Add(this.TxtValor);
            this.Controls.Add(this.TxtLinea);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtLinea;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.TextBox TxtSalida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

