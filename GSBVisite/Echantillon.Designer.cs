namespace GSBVisite
{
    partial class Echantillon
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
            this.med_cbx = new System.Windows.Forms.ComboBox();
            this.medicamentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gsbDataSet = new GSBVisite.gsbDataSet();
            this.medicamentTableAdapter = new GSBVisite.gsbDataSetTableAdapters.medicamentTableAdapter();
            this.medicamentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gsbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicamentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.gsbDataSet1 = new GSBVisite.gsbDataSet1();
            this.medicamentTableAdapter1 = new GSBVisite.gsbDataSet1TableAdapters.medicamentTableAdapter();
            this.echantillon_dataG = new System.Windows.Forms.DataGridView();
            this.med_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ech_add_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.echantillon_dataG)).BeginInit();
            this.SuspendLayout();
            // 
            // med_cbx
            // 
            this.med_cbx.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.medicamentBindingSource, "MED_NOMCOMMERCIAL", true));
            this.med_cbx.FormattingEnabled = true;
            this.med_cbx.Location = new System.Drawing.Point(167, 110);
            this.med_cbx.Name = "med_cbx";
            this.med_cbx.Size = new System.Drawing.Size(318, 33);
            this.med_cbx.TabIndex = 0;
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
            // medicamentTableAdapter
            // 
            this.medicamentTableAdapter.ClearBeforeFill = true;
            // 
            // medicamentBindingSource1
            // 
            this.medicamentBindingSource1.DataMember = "medicament";
            this.medicamentBindingSource1.DataSource = this.gsbDataSet;
            // 
            // gsbDataSetBindingSource
            // 
            this.gsbDataSetBindingSource.DataSource = this.gsbDataSet;
            this.gsbDataSetBindingSource.Position = 0;
            // 
            // medicamentBindingSource2
            // 
            this.medicamentBindingSource2.DataMember = "medicament";
            this.medicamentBindingSource2.DataSource = this.gsbDataSet1;
            // 
            // gsbDataSet1
            // 
            this.gsbDataSet1.DataSetName = "gsbDataSet1";
            this.gsbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicamentTableAdapter1
            // 
            this.medicamentTableAdapter1.ClearBeforeFill = true;
            // 
            // echantillon_dataG
            // 
            this.echantillon_dataG.AllowUserToAddRows = false;
            this.echantillon_dataG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.echantillon_dataG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.med_col,
            this.supprimer});
            this.echantillon_dataG.Location = new System.Drawing.Point(108, 224);
            this.echantillon_dataG.Name = "echantillon_dataG";
            this.echantillon_dataG.RowHeadersWidth = 82;
            this.echantillon_dataG.RowTemplate.Height = 33;
            this.echantillon_dataG.Size = new System.Drawing.Size(831, 435);
            this.echantillon_dataG.TabIndex = 1;
            this.echantillon_dataG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.echantillon_dataG_CellContentClick);
            // 
            // med_col
            // 
            this.med_col.HeaderText = "Medicament";
            this.med_col.MinimumWidth = 10;
            this.med_col.Name = "med_col";
            this.med_col.Width = 200;
            // 
            // supprimer
            // 
            this.supprimer.HeaderText = "Supprimer";
            this.supprimer.MinimumWidth = 10;
            this.supprimer.Name = "supprimer";
            this.supprimer.Text = "Supprimer";
            this.supprimer.ToolTipText = "Supprimer";
            this.supprimer.UseColumnTextForButtonValue = true;
            this.supprimer.Width = 200;
            // 
            // ech_add_btn
            // 
            this.ech_add_btn.Location = new System.Drawing.Point(506, 101);
            this.ech_add_btn.Name = "ech_add_btn";
            this.ech_add_btn.Size = new System.Drawing.Size(180, 48);
            this.ech_add_btn.TabIndex = 2;
            this.ech_add_btn.Text = "ajouter";
            this.ech_add_btn.UseVisualStyleBackColor = true;
            this.ech_add_btn.Click += new System.EventHandler(this.ech_add_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(437, 759);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "Enregistrer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Echantillon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1064, 952);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ech_add_btn);
            this.Controls.Add(this.echantillon_dataG);
            this.Controls.Add(this.med_cbx);
            this.Name = "Echantillon";
            this.Text = "Echantillon";
            this.Load += new System.EventHandler(this.Echantillon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medicamentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.echantillon_dataG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox med_cbx;
        private gsbDataSet gsbDataSet;
        private System.Windows.Forms.BindingSource medicamentBindingSource;
        private gsbDataSetTableAdapters.medicamentTableAdapter medicamentTableAdapter;
        private System.Windows.Forms.BindingSource medicamentBindingSource1;
        private System.Windows.Forms.BindingSource gsbDataSetBindingSource;
        private gsbDataSet1 gsbDataSet1;
        private System.Windows.Forms.BindingSource medicamentBindingSource2;
        private gsbDataSet1TableAdapters.medicamentTableAdapter medicamentTableAdapter1;
        private System.Windows.Forms.DataGridView echantillon_dataG;
        private System.Windows.Forms.Button ech_add_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn med_col;
        private System.Windows.Forms.DataGridViewButtonColumn supprimer;
        private System.Windows.Forms.Button button1;
    }
}