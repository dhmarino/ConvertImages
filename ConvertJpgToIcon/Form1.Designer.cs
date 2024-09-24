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
            this.BtnConvertJpgToIco = new System.Windows.Forms.Button();
            this.BtnConvertPngToIco = new System.Windows.Forms.Button();
            this.BtnSvgToJpg = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnConvertJpgToIco
            // 
            this.BtnConvertJpgToIco.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnConvertJpgToIco.Location = new System.Drawing.Point(142, 44);
            this.BtnConvertJpgToIco.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnConvertJpgToIco.Name = "BtnConvertJpgToIco";
            this.BtnConvertJpgToIco.Size = new System.Drawing.Size(101, 50);
            this.BtnConvertJpgToIco.TabIndex = 0;
            this.BtnConvertJpgToIco.Text = "JPG to ICO";
            this.BtnConvertJpgToIco.UseVisualStyleBackColor = true;
            this.BtnConvertJpgToIco.Click += new System.EventHandler(this.BtnConvertJpgToIco_Click);
            // 
            // BtnConvertPngToIco
            // 
            this.BtnConvertPngToIco.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnConvertPngToIco.Location = new System.Drawing.Point(142, 129);
            this.BtnConvertPngToIco.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnConvertPngToIco.Name = "BtnConvertPngToIco";
            this.BtnConvertPngToIco.Size = new System.Drawing.Size(101, 50);
            this.BtnConvertPngToIco.TabIndex = 1;
            this.BtnConvertPngToIco.Text = "PNG to ICO";
            this.BtnConvertPngToIco.UseVisualStyleBackColor = true;
            this.BtnConvertPngToIco.Click += new System.EventHandler(this.BtnConvertPngToIco_Click);
            // 
            // BtnSvgToJpg
            // 
            this.BtnSvgToJpg.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnSvgToJpg.Location = new System.Drawing.Point(142, 218);
            this.BtnSvgToJpg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnSvgToJpg.Name = "BtnSvgToJpg";
            this.BtnSvgToJpg.Size = new System.Drawing.Size(101, 50);
            this.BtnSvgToJpg.TabIndex = 2;
            this.BtnSvgToJpg.Text = "SVG to JPG";
            this.BtnSvgToJpg.UseVisualStyleBackColor = true;
            this.BtnSvgToJpg.Click += new System.EventHandler(this.BtnSvgToJpg_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(308, 296);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(42, 13);
            this.lblVersion.TabIndex = 3;
            this.lblVersion.Text = "Version";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 321);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.BtnSvgToJpg);
            this.Controls.Add(this.BtnConvertPngToIco);
            this.Controls.Add(this.BtnConvertJpgToIco);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Conversor Imagenes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnConvertJpgToIco;
        private System.Windows.Forms.Button BtnConvertPngToIco;
        private System.Windows.Forms.Button BtnSvgToJpg;
        private System.Windows.Forms.Label lblVersion;
    }
}

