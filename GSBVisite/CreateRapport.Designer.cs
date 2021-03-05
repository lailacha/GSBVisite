namespace GSBVisite
{
    partial class CreateRapport
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.visiteur_tbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.praticien_cbx = new System.Windows.Forms.ComboBox();
            this.date_saisie_tbx = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.motif_cbx = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.coef_conf_tbx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bilan_Hesit_txbx = new System.Windows.Forms.RichTextBox();
            this.btnEnvoyerRapport = new System.Windows.Forms.Button();
            this.bilan_Concu_tbx = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.impact_tbx = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.medicamentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gsbDataSet = new GSBVisite.gsbDataSet();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.medicamentTableAdapter = new GSBVisite.gsbDataSetTableAdapters.medicamentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsbDataSet)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(451, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(731, 117);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rapport de visite";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 13.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(28, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 45);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numero visiteur";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // visiteur_tbx
            // 
            this.visiteur_tbx.Location = new System.Drawing.Point(324, 256);
            this.visiteur_tbx.Name = "visiteur_tbx";
            this.visiteur_tbx.Size = new System.Drawing.Size(191, 31);
            this.visiteur_tbx.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 13.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(37, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 45);
            this.label2.TabIndex = 6;
            this.label2.Text = "Praticien";
            // 
            // praticien_cbx
            // 
            this.praticien_cbx.FormattingEnabled = true;
            this.praticien_cbx.Location = new System.Drawing.Point(278, 367);
            this.praticien_cbx.Name = "praticien_cbx";
            this.praticien_cbx.Size = new System.Drawing.Size(248, 33);
            this.praticien_cbx.TabIndex = 7;
            // 
            // date_saisie_tbx
            // 
            this.date_saisie_tbx.Location = new System.Drawing.Point(324, 472);
            this.date_saisie_tbx.Name = "date_saisie_tbx";
            this.date_saisie_tbx.Size = new System.Drawing.Size(200, 31);
            this.date_saisie_tbx.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 13.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(12, 460);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 45);
            this.label4.TabIndex = 9;
            this.label4.Text = "Date de la saisie";
            // 
            // motif_cbx
            // 
            this.motif_cbx.FormattingEnabled = true;
            this.motif_cbx.Location = new System.Drawing.Point(288, 565);
            this.motif_cbx.Name = "motif_cbx";
            this.motif_cbx.Size = new System.Drawing.Size(248, 33);
            this.motif_cbx.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 13.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(-4, 553);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(269, 45);
            this.label5.TabIndex = 11;
            this.label5.Text = "Motif de la visite";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 13.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(12, 670);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(391, 45);
            this.label6.TabIndex = 12;
            this.label6.Text = "Coefficient de confiance";
            // 
            // coef_conf_tbx
            // 
            this.coef_conf_tbx.Location = new System.Drawing.Point(445, 684);
            this.coef_conf_tbx.Name = "coef_conf_tbx";
            this.coef_conf_tbx.Size = new System.Drawing.Size(191, 31);
            this.coef_conf_tbx.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 13.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(28, 779);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(268, 45);
            this.label7.TabIndex = 14;
            this.label7.Text = "Bilan Hésitation:";
            // 
            // bilan_Hesit_txbx
            // 
            this.bilan_Hesit_txbx.Location = new System.Drawing.Point(324, 774);
            this.bilan_Hesit_txbx.Name = "bilan_Hesit_txbx";
            this.bilan_Hesit_txbx.Size = new System.Drawing.Size(421, 158);
            this.bilan_Hesit_txbx.TabIndex = 15;
            this.bilan_Hesit_txbx.Text = "";
            // 
            // btnEnvoyerRapport
            // 
            this.btnEnvoyerRapport.Font = new System.Drawing.Font("Impact", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnvoyerRapport.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEnvoyerRapport.Location = new System.Drawing.Point(1158, 605);
            this.btnEnvoyerRapport.Name = "btnEnvoyerRapport";
            this.btnEnvoyerRapport.Size = new System.Drawing.Size(184, 56);
            this.btnEnvoyerRapport.TabIndex = 16;
            this.btnEnvoyerRapport.Text = "Envoyer";
            this.btnEnvoyerRapport.UseVisualStyleBackColor = true;
            this.btnEnvoyerRapport.Click += new System.EventHandler(this.btnEnvoyerRapport_Click);
            // 
            // bilan_Concu_tbx
            // 
            this.bilan_Concu_tbx.Location = new System.Drawing.Point(1051, 294);
            this.bilan_Concu_tbx.Name = "bilan_Concu_tbx";
            this.bilan_Concu_tbx.Size = new System.Drawing.Size(421, 158);
            this.bilan_Concu_tbx.TabIndex = 18;
            this.bilan_Concu_tbx.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Impact", 13.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(684, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(602, 45);
            this.label8.TabIndex = 17;
            this.label8.Text = "Bilan d\'observation de la concurrence:";
            // 
            // impact_tbx
            // 
            this.impact_tbx.Location = new System.Drawing.Point(1131, 523);
            this.impact_tbx.Name = "impact_tbx";
            this.impact_tbx.Size = new System.Drawing.Size(191, 31);
            this.impact_tbx.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Impact", 13.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(781, 509);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(304, 45);
            this.label9.TabIndex = 19;
            this.label9.Text = "Impact de la visite:";
            // 
            // medicamentBindingSource
            // 
            this.medicamentBindingSource.DataMember = "medicament";
            this.medicamentBindingSource.DataSource = this.gsbDataSet;
            // 
            // gsbDataSet
            // 
            this.gsbDataSet.DataSetName = "gsbDataSet";
            this.gsbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1618, 50);
            this.fillByToolStrip.TabIndex = 22;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(75, 44);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // medicamentTableAdapter
            // 
            this.medicamentTableAdapter.ClearBeforeFill = true;
            // 
            // CreateRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1618, 1107);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.impact_tbx);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bilan_Concu_tbx);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnEnvoyerRapport);
            this.Controls.Add(this.bilan_Hesit_txbx);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.coef_conf_tbx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.motif_cbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.date_saisie_tbx);
            this.Controls.Add(this.praticien_cbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.visiteur_tbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "CreateRapport";
            this.Text = "CreateRapport";
            this.Load += new System.EventHandler(this.CreateRapport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medicamentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsbDataSet)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox visiteur_tbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox praticien_cbx;
        private System.Windows.Forms.DateTimePicker date_saisie_tbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox motif_cbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox coef_conf_tbx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox bilan_Hesit_txbx;
        private System.Windows.Forms.Button btnEnvoyerRapport;
        private System.Windows.Forms.RichTextBox bilan_Concu_tbx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox impact_tbx;
        private System.Windows.Forms.Label label9;
        private gsbDataSet gsbDataSet;
        private System.Windows.Forms.BindingSource medicamentBindingSource;
        private gsbDataSetTableAdapters.medicamentTableAdapter medicamentTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
    }
}