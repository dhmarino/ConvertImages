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
            this.BtnTiffToJpg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnConvertJpgToIco
            // 
            this.BtnConvertJpgToIco.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnConvertJpgToIco.Location = new System.Drawing.Point(284, 85);
            this.BtnConvertJpgToIco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnConvertJpgToIco.Name = "BtnConvertJpgToIco";
            this.BtnConvertJpgToIco.Size = new System.Drawing.Size(202, 96);
            this.BtnConvertJpgToIco.TabIndex = 0;
            this.BtnConvertJpgToIco.Text = "JPG to ICO";
            this.BtnConvertJpgToIco.UseVisualStyleBackColor = true;
            this.BtnConvertJpgToIco.Click += new System.EventHandler(this.BtnConvertJpgToIco_Click);
            // 
            // BtnConvertPngToIco
            // 
            this.BtnConvertPngToIco.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnConvertPngToIco.Location = new System.Drawing.Point(284, 200);
            this.BtnConvertPngToIco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnConvertPngToIco.Name = "BtnConvertPngToIco";
            this.BtnConvertPngToIco.Size = new System.Drawing.Size(202, 96);
            this.BtnConvertPngToIco.TabIndex = 1;
            this.BtnConvertPngToIco.Text = "PNG to ICO";
            this.BtnConvertPngToIco.UseVisualStyleBackColor = true;
            this.BtnConvertPngToIco.Click += new System.EventHandler(this.BtnConvertPngToIco_Click);
            // 
            // BtnSvgToJpg
            // 
            this.BtnSvgToJpg.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnSvgToJpg.Location = new System.Drawing.Point(284, 319);
            this.BtnSvgToJpg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSvgToJpg.Name = "BtnSvgToJpg";
            this.BtnSvgToJpg.Size = new System.Drawing.Size(202, 96);
            this.BtnSvgToJpg.TabIndex = 2;
            this.BtnSvgToJpg.Text = "SVG to JPG";
            this.BtnSvgToJpg.UseVisualStyleBackColor = true;
            this.BtnSvgToJpg.Click += new System.EventHandler(this.BtnSvgToJpg_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(616, 569);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(85, 25);
            this.lblVersion.TabIndex = 3;
            this.lblVersion.Text = "Version";
            // 
            // BtnTiffToJpg
            // 
            this.BtnTiffToJpg.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnTiffToJpg.Location = new System.Drawing.Point(284, 444);
            this.BtnTiffToJpg.Margin = new System.Windows.Forms.Padding(4);
            this.BtnTiffToJpg.Name = "BtnTiffToJpg";
            this.BtnTiffToJpg.Size = new System.Drawing.Size(202, 96);
            this.BtnTiffToJpg.TabIndex = 4;
            this.BtnTiffToJpg.Text = "MultiTIFF to JPG";
            this.BtnTiffToJpg.UseVisualStyleBackColor = true;
            this.BtnTiffToJpg.Click += new System.EventHandler(this.BtnTiffToJpg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 617);
            this.Controls.Add(this.BtnTiffToJpg);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.BtnSvgToJpg);
            this.Controls.Add(this.BtnConvertPngToIco);
            this.Controls.Add(this.BtnConvertJpgToIco);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button BtnTiffToJpg;
    }
}

