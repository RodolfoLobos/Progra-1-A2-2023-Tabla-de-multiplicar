
namespace Tabla_de_multiplicar
{
    partial class Form1
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
            this.btnProcesar = new System.Windows.Forms.Button();
            this.lblTablaDeMultiplicar = new System.Windows.Forms.Label();
            this.txtTablaDeMultiplicar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnProcesar
            // 
            this.btnProcesar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesar.Location = new System.Drawing.Point(269, 170);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(137, 34);
            this.btnProcesar.TabIndex = 0;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // lblTablaDeMultiplicar
            // 
            this.lblTablaDeMultiplicar.AutoSize = true;
            this.lblTablaDeMultiplicar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablaDeMultiplicar.Location = new System.Drawing.Point(12, 57);
            this.lblTablaDeMultiplicar.Name = "lblTablaDeMultiplicar";
            this.lblTablaDeMultiplicar.Size = new System.Drawing.Size(226, 27);
            this.lblTablaDeMultiplicar.TabIndex = 1;
            this.lblTablaDeMultiplicar.Text = "Tabla de Multiplicar:";
            // 
            // txtTablaDeMultiplicar
            // 
            this.txtTablaDeMultiplicar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTablaDeMultiplicar.Location = new System.Drawing.Point(244, 54);
            this.txtTablaDeMultiplicar.Name = "txtTablaDeMultiplicar";
            this.txtTablaDeMultiplicar.Size = new System.Drawing.Size(185, 35);
            this.txtTablaDeMultiplicar.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 450);
            this.Controls.Add(this.txtTablaDeMultiplicar);
            this.Controls.Add(this.lblTablaDeMultiplicar);
            this.Controls.Add(this.btnProcesar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Label lblTablaDeMultiplicar;
        private System.Windows.Forms.TextBox txtTablaDeMultiplicar;
    }
}

