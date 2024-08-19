namespace ConvertJpgToIcon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonConvert = new System.Windows.Forms.Button();
            this.buttonConvert2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonConvert
            // 
            this.buttonConvert.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonConvert.Location = new System.Drawing.Point(283, 84);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(202, 97);
            this.buttonConvert.TabIndex = 0;
            this.buttonConvert.Text = "JPG to ICO";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // buttonConvert2
            // 
            this.buttonConvert2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonConvert2.Location = new System.Drawing.Point(283, 248);
            this.buttonConvert2.Name = "buttonConvert2";
            this.buttonConvert2.Size = new System.Drawing.Size(202, 97);
            this.buttonConvert2.TabIndex = 1;
            this.buttonConvert2.Text = "PNG to ICO";
            this.buttonConvert2.UseVisualStyleBackColor = true;
            this.buttonConvert2.Click += new System.EventHandler(this.buttonConvert2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonConvert2);
            this.Controls.Add(this.buttonConvert);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Conversor Imagenes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Button buttonConvert2;
    }
}

