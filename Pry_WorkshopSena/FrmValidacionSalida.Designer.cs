namespace Pry_WorkshopSena
{
    partial class FrmValidacionSalida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmValidacionSalida));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_SalirApp = new System.Windows.Forms.Button();
            this.Btn_NoApp = new System.Windows.Forms.Button();
            this.label92 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_SalirApp
            // 
            this.Btn_SalirApp.BackColor = System.Drawing.Color.Transparent;
            this.Btn_SalirApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_SalirApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SalirApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SalirApp.ForeColor = System.Drawing.Color.DimGray;
            this.Btn_SalirApp.Location = new System.Drawing.Point(123, 70);
            this.Btn_SalirApp.Name = "Btn_SalirApp";
            this.Btn_SalirApp.Size = new System.Drawing.Size(71, 28);
            this.Btn_SalirApp.TabIndex = 0;
            this.Btn_SalirApp.Text = "Si";
            this.Btn_SalirApp.UseVisualStyleBackColor = false;
            this.Btn_SalirApp.Click += new System.EventHandler(this.Btn_SalirApp_Click);
            // 
            // Btn_NoApp
            // 
            this.Btn_NoApp.BackColor = System.Drawing.Color.Transparent;
            this.Btn_NoApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_NoApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_NoApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_NoApp.ForeColor = System.Drawing.Color.DimGray;
            this.Btn_NoApp.Location = new System.Drawing.Point(200, 70);
            this.Btn_NoApp.Name = "Btn_NoApp";
            this.Btn_NoApp.Size = new System.Drawing.Size(71, 28);
            this.Btn_NoApp.TabIndex = 1;
            this.Btn_NoApp.Text = "No";
            this.Btn_NoApp.UseVisualStyleBackColor = false;
            this.Btn_NoApp.Click += new System.EventHandler(this.Btn_NoApp_Click);
            // 
            // label92
            // 
            this.label92.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label92.AutoSize = true;
            this.label92.BackColor = System.Drawing.SystemColors.Control;
            this.label92.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label92.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label92.Location = new System.Drawing.Point(102, 23);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(211, 21);
            this.label92.TabIndex = 68;
            this.label92.Text = "¿Esta seguro que desea salir?";
            // 
            // FrmValidacionSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 139);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label92);
            this.Controls.Add(this.Btn_NoApp);
            this.Controls.Add(this.Btn_SalirApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmValidacionSalida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmacion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button Btn_SalirApp;
        public System.Windows.Forms.Button Btn_NoApp;
        private System.Windows.Forms.Label label92;
    }
}