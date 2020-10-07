namespace Pry_WorkshopSena
{
    partial class FrmCodigoEquipos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCodigoEquipos));
            this.PnlBarraNavegacion = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.DtgCodigoEquipos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.mover = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.PnlBarraNavegacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgCodigoEquipos)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlBarraNavegacion
            // 
            this.PnlBarraNavegacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(57)))));
            this.PnlBarraNavegacion.Controls.Add(this.label5);
            this.PnlBarraNavegacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlBarraNavegacion.Location = new System.Drawing.Point(0, 0);
            this.PnlBarraNavegacion.Name = "PnlBarraNavegacion";
            this.PnlBarraNavegacion.Size = new System.Drawing.Size(493, 44);
            this.PnlBarraNavegacion.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(9, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "Codigó de equipos\r\n";
            // 
            // DtgCodigoEquipos
            // 
            this.DtgCodigoEquipos.AllowUserToAddRows = false;
            this.DtgCodigoEquipos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DtgCodigoEquipos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DtgCodigoEquipos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgCodigoEquipos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DtgCodigoEquipos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DtgCodigoEquipos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DtgCodigoEquipos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgCodigoEquipos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DtgCodigoEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgCodigoEquipos.DoubleBuffered = true;
            this.DtgCodigoEquipos.EnableHeadersVisualStyles = false;
            this.DtgCodigoEquipos.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(57)))));
            this.DtgCodigoEquipos.HeaderForeColor = System.Drawing.SystemColors.Control;
            this.DtgCodigoEquipos.Location = new System.Drawing.Point(24, 109);
            this.DtgCodigoEquipos.Name = "DtgCodigoEquipos";
            this.DtgCodigoEquipos.ReadOnly = true;
            this.DtgCodigoEquipos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DtgCodigoEquipos.Size = new System.Drawing.Size(440, 329);
            this.DtgCodigoEquipos.TabIndex = 1;
            // 
            // mover
            // 
            this.mover.Fixed = true;
            this.mover.Horizontal = true;
            this.mover.TargetControl = this.PnlBarraNavegacion;
            this.mover.Vertical = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(19, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 21);
            this.label1.TabIndex = 94;
            this.label1.Text = "Nombre del equipo";
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.BackColor = System.Drawing.Color.Gainsboro;
            this.Txt_Nombre.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Nombre.Location = new System.Drawing.Point(21, 74);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.Txt_Nombre.Size = new System.Drawing.Size(443, 29);
            this.Txt_Nombre.TabIndex = 95;
            this.Txt_Nombre.TextChanged += new System.EventHandler(this.Txt_Nombre_TextChanged);
            this.Txt_Nombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_Nombre_KeyUp);
            // 
            // FrmCodigoEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(493, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.DtgCodigoEquipos);
            this.Controls.Add(this.PnlBarraNavegacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCodigoEquipos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PnlBarraNavegacion.ResumeLayout(false);
            this.PnlBarraNavegacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgCodigoEquipos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlBarraNavegacion;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DtgCodigoEquipos;
        private Bunifu.Framework.UI.BunifuDragControl mover;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Nombre;
    }
}