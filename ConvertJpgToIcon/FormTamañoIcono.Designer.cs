namespace ConvertJpgToIcon
{
    partial class FormTamañoIcono
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTamañoIcono));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ButtonCancelar = new System.Windows.Forms.Button();
            this.ButtonConfirmar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(183, 146);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(434, 38);
            this.textBox1.TabIndex = 0;
            // 
            // ButtonCancelar
            // 
            this.ButtonCancelar.BackColor = System.Drawing.Color.IndianRed;
            this.ButtonCancelar.Location = new System.Drawing.Point(213, 215);
            this.ButtonCancelar.Name = "ButtonCancelar";
            this.ButtonCancelar.Size = new System.Drawing.Size(143, 45);
            this.ButtonCancelar.TabIndex = 1;
            this.ButtonCancelar.Text = "Cancelar";
            this.ButtonCancelar.UseVisualStyleBackColor = false;
            this.ButtonCancelar.Click += new System.EventHandler(this.ButtonCancelar_Click);
            // 
            // ButtonConfirmar
            // 
            this.ButtonConfirmar.BackColor = System.Drawing.Color.ForestGreen;
            this.ButtonConfirmar.Location = new System.Drawing.Point(415, 215);
            this.ButtonConfirmar.Name = "ButtonConfirmar";
            this.ButtonConfirmar.Size = new System.Drawing.Size(168, 45);
            this.ButtonConfirmar.TabIndex = 2;
            this.ButtonConfirmar.Text = "Confirmar";
            this.ButtonConfirmar.UseVisualStyleBackColor = false;
            this.ButtonConfirmar.Click += new System.EventHandler(this.ButtonConfirmar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese el tamaño de Icono (Ejemplo: 32x32)";
            // 
            // FormTamañoIcono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 372);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonConfirmar);
            this.Controls.Add(this.ButtonCancelar);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTamañoIcono";
            this.Text = "Tamaño del Icono";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ButtonCancelar;
        private System.Windows.Forms.Button ButtonConfirmar;
        private System.Windows.Forms.Label label1;
    }
}