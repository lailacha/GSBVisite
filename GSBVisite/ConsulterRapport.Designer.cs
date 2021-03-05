namespace GSBVisite
{
    partial class ConsulterRapport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.visiteur_cbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.motif_cbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.num_Rapport_cbx = new System.Windows.Forms.ComboBox();
            this.rapport_dg = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.rapport_dg)).BeginInit();
            this.SuspendLayout();
            // 
            // visiteur_cbx
            // 
            this.visiteur_cbx.FormattingEnabled = true;
            this.visiteur_cbx.Location = new System.Drawing.Point(359, 91);
            this.visiteur_cbx.Name = "visiteur_cbx";
            this.visiteur_cbx.Size = new System.Drawing.Size(143, 33);
            this.visiteur_cbx.TabIndex = 2;
            this.visiteur_cbx.SelectedIndexChanged += new System.EventHandler(this.visiteur_cbx_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(61, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom du visiteur";
            // 
            // motif_cbx
            // 
            this.motif_cbx.Location = new System.Drawing.Point(334, 270);
            this.motif_cbx.Name = "motif_cbx";
            this.motif_cbx.Size = new System.Drawing.Size(408, 31);
            this.motif_cbx.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(12, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 45);
            this.label2.TabIndex = 5;
            this.label2.Text = "Motif de la visite:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(12, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(466, 45);
            this.label3.TabIndex = 6;
            this.label3.Text = "Numéro du rapport de visite";
            // 
            // num_Rapport_cbx
            // 
            this.num_Rapport_cbx.FormattingEnabled = true;
            this.num_Rapport_cbx.Location = new System.Drawing.Point(514, 178);
            this.num_Rapport_cbx.Name = "num_Rapport_cbx";
            this.num_Rapport_cbx.Size = new System.Drawing.Size(143, 33);
            this.num_Rapport_cbx.TabIndex = 7;
            // 
            // rapport_dg
            // 
            this.rapport_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rapport_dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.rapport_dg.Location = new System.Drawing.Point(1007, 166);
            this.rapport_dg.Name = "rapport_dg";
            this.rapport_dg.RowHeadersWidth = 82;
            this.rapport_dg.RowTemplate.Height = 33;
            this.rapport_dg.Size = new System.Drawing.Size(817, 407);
            this.rapport_dg.TabIndex = 8;
            // 
            // Column1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.Width = 500;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // ConsulterRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1890, 672);
            this.Controls.Add(this.rapport_dg);
            this.Controls.Add(this.num_Rapport_cbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.motif_cbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.visiteur_cbx);
            this.Name = "ConsulterRapport";
            this.Text = "ConsulterRapport";
            this.Load += new System.EventHandler(this.ConsulterRapport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rapport_dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox visiteur_cbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox motif_cbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox num_Rapport_cbx;
        private System.Windows.Forms.DataGridView rapport_dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}