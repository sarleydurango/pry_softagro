namespace Pry_WorkshopSena
{
    partial class FrmBienvenido
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBienvenido));
            this.Aparecer = new System.Windows.Forms.Timer(this.components);
            this.Animacion = new System.Windows.Forms.Timer(this.components);
            this.bunifuGradientPanel6 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.BarraCargante = new Bunifu.Framework.UI.BunifuProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Aparecer
            // 
            this.Aparecer.Tick += new System.EventHandler(this.Aparecer_Tick);
            // 
            // Animacion
            // 
            this.Animacion.Tick += new System.EventHandler(this.Animacion_Tick);
            // 
            // bunifuGradientPanel6
            // 
            this.bunifuGradientPanel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel6.BackgroundImage")));
            this.bunifuGradientPanel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel6.Controls.Add(this.label2);
            this.bunifuGradientPanel6.Controls.Add(this.BarraCargante);
            this.bunifuGradientPanel6.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel6.Controls.Add(this.label3);
            this.bunifuGradientPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel6.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(13)))), ((int)(((byte)(40)))));
            this.bunifuGradientPanel6.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuGradientPanel6.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(4)))), ((int)(((byte)(25)))));
            this.bunifuGradientPanel6.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(4)))), ((int)(((byte)(25)))));
            this.bunifuGradientPanel6.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel6.Name = "bunifuGradientPanel6";
            this.bunifuGradientPanel6.Quality = 10;
            this.bunifuGradientPanel6.Size = new System.Drawing.Size(607, 355);
            this.bunifuGradientPanel6.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(200, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 21);
            this.label2.TabIndex = 101;
            this.label2.Text = "Copyright © 2020 ASY Soft\r\n";
            // 
            // BarraCargante
            // 
            this.BarraCargante.BackColor = System.Drawing.Color.Silver;
            this.BarraCargante.BorderRadius = 5;
            this.BarraCargante.Location = new System.Drawing.Point(84, 291);
            this.BarraCargante.MaximumValue = 100;
            this.BarraCargante.Name = "BarraCargante";
            this.BarraCargante.ProgressColor = System.Drawing.Color.Teal;
            this.BarraCargante.Size = new System.Drawing.Size(443, 10);
            this.BarraCargante.TabIndex = 100;
            this.BarraCargante.Value = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Pry_WorkshopSena.Properties.Resources.logo_w;
            this.pictureBox1.Location = new System.Drawing.Point(156, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 98;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(178, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 86);
            this.label3.TabIndex = 97;
            this.label3.Text = "Workshop Soft\r\n\r\n";
            // 
            // FrmBienvenido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 355);
            this.Controls.Add(this.bunifuGradientPanel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBienvenido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBienvenido";
            this.Load += new System.EventHandler(this.FrmBienvenido_Load);
            this.bunifuGradientPanel6.ResumeLayout(false);
            this.bunifuGradientPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel6;
        private Bunifu.Framework.UI.BunifuProgressBar BarraCargante;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer Aparecer;
        private System.Windows.Forms.Timer Animacion;
        private System.Windows.Forms.Label label2;
    }
}