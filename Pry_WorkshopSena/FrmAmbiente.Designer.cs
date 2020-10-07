namespace Pry_WorkshopSena
{
    partial class FrmAmbiente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAmbiente));
            this.Btn_AsignarAmbiente = new System.Windows.Forms.Button();
            this.Txt_Asignar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_AsignarAmbiente
            // 
            this.Btn_AsignarAmbiente.BackColor = System.Drawing.Color.Transparent;
            this.Btn_AsignarAmbiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_AsignarAmbiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AsignarAmbiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AsignarAmbiente.ForeColor = System.Drawing.Color.DimGray;
            this.Btn_AsignarAmbiente.Location = new System.Drawing.Point(104, 111);
            this.Btn_AsignarAmbiente.Name = "Btn_AsignarAmbiente";
            this.Btn_AsignarAmbiente.Size = new System.Drawing.Size(179, 35);
            this.Btn_AsignarAmbiente.TabIndex = 94;
            this.Btn_AsignarAmbiente.Text = "Asignar";
            this.Btn_AsignarAmbiente.UseVisualStyleBackColor = false;
            this.Btn_AsignarAmbiente.Click += new System.EventHandler(this.Btn_AsignarAmbiente_Click);
            // 
            // Txt_Asignar
            // 
            this.Txt_Asignar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Txt_Asignar.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Asignar.Location = new System.Drawing.Point(17, 53);
            this.Txt_Asignar.Multiline = true;
            this.Txt_Asignar.Name = "Txt_Asignar";
            this.Txt_Asignar.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.Txt_Asignar.Size = new System.Drawing.Size(365, 38);
            this.Txt_Asignar.TabIndex = 93;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 26);
            this.label1.TabIndex = 92;
            this.label1.Text = "Asignar un nuevo ambiente de aprendizaje";
            // 
            // FrmAmbiente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(394, 180);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Asignar);
            this.Controls.Add(this.Btn_AsignarAmbiente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAmbiente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignar ambiente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Asignar;
        private System.Windows.Forms.Button Btn_AsignarAmbiente;
    }
}