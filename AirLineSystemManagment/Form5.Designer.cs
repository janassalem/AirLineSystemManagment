namespace AirLineSystemManagment
{
    partial class Form5
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
            System.Windows.Forms.Label aDMINIDLabel;
            System.Windows.Forms.Label nAMELabel;
            System.Windows.Forms.Label uSERNAMELabel;
            System.Windows.Forms.Label pASSWORDLabel;
            System.Windows.Forms.Label dATEOFBIRTHLabel;
            System.Windows.Forms.Label aGELabel;
            this.masterDataSet9 = new AirLineSystemManagment.masterDataSet9();
            this.masterDataSet9BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKTableAdapter = new AirLineSystemManagment.masterDataSet9TableAdapters.BOOKTableAdapter();
            this.bOOKSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKSTableAdapter = new AirLineSystemManagment.masterDataSet9TableAdapters.BOOKSTableAdapter();
            this.fLIGHTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fLIGHTTableAdapter = new AirLineSystemManagment.masterDataSet9TableAdapters.FLIGHTTableAdapter();
            this.masterDataSet10 = new AirLineSystemManagment.masterDataSet10();
            this.masterDataSet10BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fLIGHTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fLIGHTTableAdapter1 = new AirLineSystemManagment.masterDataSet10TableAdapters.FLIGHTTableAdapter();
            this.ticketTableAdapter1 = new AirLineSystemManagment.masterDataSetTableAdapters.TICKETTableAdapter();
            this.aDMINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aDMINTableAdapter = new AirLineSystemManagment.masterDataSet10TableAdapters.ADMINTableAdapter();
            this.tableAdapterManager = new AirLineSystemManagment.masterDataSet10TableAdapters.TableAdapterManager();
            this.aDMINIDTextBox = new System.Windows.Forms.TextBox();
            this.nAMETextBox = new System.Windows.Forms.TextBox();
            this.uSERNAMETextBox = new System.Windows.Forms.TextBox();
            this.pASSWORDTextBox = new System.Windows.Forms.TextBox();
            this.dATEOFBIRTHTextBox = new System.Windows.Forms.TextBox();
            this.aGETextBox = new System.Windows.Forms.TextBox();
            aDMINIDLabel = new System.Windows.Forms.Label();
            nAMELabel = new System.Windows.Forms.Label();
            uSERNAMELabel = new System.Windows.Forms.Label();
            pASSWORDLabel = new System.Windows.Forms.Label();
            dATEOFBIRTHLabel = new System.Windows.Forms.Label();
            aGELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet9BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLIGHTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet10BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLIGHTBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDMINBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // masterDataSet9
            // 
            this.masterDataSet9.DataSetName = "masterDataSet9";
            this.masterDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // masterDataSet9BindingSource
            // 
            this.masterDataSet9BindingSource.DataSource = this.masterDataSet9;
            this.masterDataSet9BindingSource.Position = 0;
            // 
            // bOOKBindingSource
            // 
            this.bOOKBindingSource.DataMember = "BOOK";
            this.bOOKBindingSource.DataSource = this.masterDataSet9BindingSource;
            // 
            // bOOKTableAdapter
            // 
            this.bOOKTableAdapter.ClearBeforeFill = true;
            // 
            // bOOKSBindingSource
            // 
            this.bOOKSBindingSource.DataMember = "BOOKS";
            this.bOOKSBindingSource.DataSource = this.masterDataSet9BindingSource;
            // 
            // bOOKSTableAdapter
            // 
            this.bOOKSTableAdapter.ClearBeforeFill = true;
            // 
            // fLIGHTBindingSource
            // 
            this.fLIGHTBindingSource.DataMember = "FLIGHT";
            this.fLIGHTBindingSource.DataSource = this.masterDataSet9;
            // 
            // fLIGHTTableAdapter
            // 
            this.fLIGHTTableAdapter.ClearBeforeFill = true;
            // 
            // masterDataSet10
            // 
            this.masterDataSet10.DataSetName = "masterDataSet10";
            this.masterDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // masterDataSet10BindingSource
            // 
            this.masterDataSet10BindingSource.DataSource = this.masterDataSet10;
            this.masterDataSet10BindingSource.Position = 0;
            this.masterDataSet10BindingSource.CurrentChanged += new System.EventHandler(this.masterDataSet10BindingSource_CurrentChanged);
            // 
            // fLIGHTBindingSource1
            // 
            this.fLIGHTBindingSource1.DataMember = "FLIGHT";
            this.fLIGHTBindingSource1.DataSource = this.masterDataSet10BindingSource;
            // 
            // fLIGHTTableAdapter1
            // 
            this.fLIGHTTableAdapter1.ClearBeforeFill = true;
            // 
            // ticketTableAdapter1
            // 
            this.ticketTableAdapter1.ClearBeforeFill = true;
            // 
            // aDMINBindingSource
            // 
            this.aDMINBindingSource.DataMember = "ADMIN";
            this.aDMINBindingSource.DataSource = this.masterDataSet10;
            // 
            // aDMINTableAdapter
            // 
            this.aDMINTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ADMINTableAdapter = this.aDMINTableAdapter;
            this.tableAdapterManager.AIRCRAFTTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOOKEDTableAdapter = null;
            this.tableAdapterManager.BOOKSTableAdapter = null;
            this.tableAdapterManager.BOOKTableAdapter = null;
            this.tableAdapterManager.CANCELTableAdapter = null;
            this.tableAdapterManager.CHANGETableAdapter = null;
            this.tableAdapterManager.CUSTOMERTableAdapter = null;
            this.tableAdapterManager.FLIGHTTableAdapter = this.fLIGHTTableAdapter1;
            this.tableAdapterManager.HAS_ATableAdapter = null;
            this.tableAdapterManager.NATIONALITYTableAdapter = null;
            this.tableAdapterManager.TICKETTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AirLineSystemManagment.masterDataSet10TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // aDMINIDLabel
            // 
            aDMINIDLabel.AutoSize = true;
            aDMINIDLabel.Location = new System.Drawing.Point(11, 14);
            aDMINIDLabel.Name = "aDMINIDLabel";
            aDMINIDLabel.Size = new System.Drawing.Size(56, 13);
            aDMINIDLabel.TabIndex = 0;
            aDMINIDLabel.Text = "ADMINID:";
            // 
            // aDMINIDTextBox
            // 
            this.aDMINIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aDMINBindingSource, "ADMINID", true));
            this.aDMINIDTextBox.Location = new System.Drawing.Point(103, 11);
            this.aDMINIDTextBox.Name = "aDMINIDTextBox";
            this.aDMINIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.aDMINIDTextBox.TabIndex = 1;
            // 
            // nAMELabel
            // 
            nAMELabel.AutoSize = true;
            nAMELabel.Location = new System.Drawing.Point(11, 40);
            nAMELabel.Name = "nAMELabel";
            nAMELabel.Size = new System.Drawing.Size(41, 13);
            nAMELabel.TabIndex = 2;
            nAMELabel.Text = "NAME:";
            // 
            // nAMETextBox
            // 
            this.nAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aDMINBindingSource, "NAME", true));
            this.nAMETextBox.Location = new System.Drawing.Point(103, 37);
            this.nAMETextBox.Name = "nAMETextBox";
            this.nAMETextBox.Size = new System.Drawing.Size(100, 20);
            this.nAMETextBox.TabIndex = 3;
            // 
            // uSERNAMELabel
            // 
            uSERNAMELabel.AutoSize = true;
            uSERNAMELabel.Location = new System.Drawing.Point(11, 66);
            uSERNAMELabel.Name = "uSERNAMELabel";
            uSERNAMELabel.Size = new System.Drawing.Size(71, 13);
            uSERNAMELabel.TabIndex = 4;
            uSERNAMELabel.Text = "USERNAME:";
            // 
            // uSERNAMETextBox
            // 
            this.uSERNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aDMINBindingSource, "USERNAME", true));
            this.uSERNAMETextBox.Location = new System.Drawing.Point(103, 63);
            this.uSERNAMETextBox.Name = "uSERNAMETextBox";
            this.uSERNAMETextBox.Size = new System.Drawing.Size(100, 20);
            this.uSERNAMETextBox.TabIndex = 5;
            // 
            // pASSWORDLabel
            // 
            pASSWORDLabel.AutoSize = true;
            pASSWORDLabel.Location = new System.Drawing.Point(11, 92);
            pASSWORDLabel.Name = "pASSWORDLabel";
            pASSWORDLabel.Size = new System.Drawing.Size(73, 13);
            pASSWORDLabel.TabIndex = 6;
            pASSWORDLabel.Text = "PASSWORD:";
            // 
            // pASSWORDTextBox
            // 
            this.pASSWORDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aDMINBindingSource, "PASSWORD", true));
            this.pASSWORDTextBox.Location = new System.Drawing.Point(103, 89);
            this.pASSWORDTextBox.Name = "pASSWORDTextBox";
            this.pASSWORDTextBox.Size = new System.Drawing.Size(100, 20);
            this.pASSWORDTextBox.TabIndex = 7;
            // 
            // dATEOFBIRTHLabel
            // 
            dATEOFBIRTHLabel.AutoSize = true;
            dATEOFBIRTHLabel.Location = new System.Drawing.Point(11, 118);
            dATEOFBIRTHLabel.Name = "dATEOFBIRTHLabel";
            dATEOFBIRTHLabel.Size = new System.Drawing.Size(86, 13);
            dATEOFBIRTHLabel.TabIndex = 8;
            dATEOFBIRTHLabel.Text = "DATEOFBIRTH:";
            // 
            // dATEOFBIRTHTextBox
            // 
            this.dATEOFBIRTHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aDMINBindingSource, "DATEOFBIRTH", true));
            this.dATEOFBIRTHTextBox.Location = new System.Drawing.Point(103, 115);
            this.dATEOFBIRTHTextBox.Name = "dATEOFBIRTHTextBox";
            this.dATEOFBIRTHTextBox.Size = new System.Drawing.Size(100, 20);
            this.dATEOFBIRTHTextBox.TabIndex = 9;
            // 
            // aGELabel
            // 
            aGELabel.AutoSize = true;
            aGELabel.Location = new System.Drawing.Point(11, 144);
            aGELabel.Name = "aGELabel";
            aGELabel.Size = new System.Drawing.Size(32, 13);
            aGELabel.TabIndex = 10;
            aGELabel.Text = "AGE:";
            // 
            // aGETextBox
            // 
            this.aGETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aDMINBindingSource, "AGE", true));
            this.aGETextBox.Location = new System.Drawing.Point(103, 141);
            this.aGETextBox.Name = "aGETextBox";
            this.aGETextBox.Size = new System.Drawing.Size(100, 20);
            this.aGETextBox.TabIndex = 11;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(aDMINIDLabel);
            this.Controls.Add(this.aDMINIDTextBox);
            this.Controls.Add(nAMELabel);
            this.Controls.Add(this.nAMETextBox);
            this.Controls.Add(uSERNAMELabel);
            this.Controls.Add(this.uSERNAMETextBox);
            this.Controls.Add(pASSWORDLabel);
            this.Controls.Add(this.pASSWORDTextBox);
            this.Controls.Add(dATEOFBIRTHLabel);
            this.Controls.Add(this.dATEOFBIRTHTextBox);
            this.Controls.Add(aGELabel);
            this.Controls.Add(this.aGETextBox);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet9BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLIGHTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet10BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLIGHTBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDMINBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource masterDataSet9BindingSource;
        private masterDataSet9 masterDataSet9;
        private System.Windows.Forms.BindingSource bOOKBindingSource;
        private masterDataSet9TableAdapters.BOOKTableAdapter bOOKTableAdapter;
        private System.Windows.Forms.BindingSource bOOKSBindingSource;
        private masterDataSet9TableAdapters.BOOKSTableAdapter bOOKSTableAdapter;
        private System.Windows.Forms.BindingSource fLIGHTBindingSource;
        private masterDataSet9TableAdapters.FLIGHTTableAdapter fLIGHTTableAdapter;
        private System.Windows.Forms.BindingSource masterDataSet10BindingSource;
        private masterDataSet10 masterDataSet10;
        private System.Windows.Forms.BindingSource fLIGHTBindingSource1;
        private masterDataSet10TableAdapters.FLIGHTTableAdapter fLIGHTTableAdapter1;
        private masterDataSetTableAdapters.TICKETTableAdapter ticketTableAdapter1;
        private System.Windows.Forms.BindingSource aDMINBindingSource;
        private masterDataSet10TableAdapters.ADMINTableAdapter aDMINTableAdapter;
        private masterDataSet10TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox aDMINIDTextBox;
        private System.Windows.Forms.TextBox nAMETextBox;
        private System.Windows.Forms.TextBox uSERNAMETextBox;
        private System.Windows.Forms.TextBox pASSWORDTextBox;
        private System.Windows.Forms.TextBox dATEOFBIRTHTextBox;
        private System.Windows.Forms.TextBox aGETextBox;
    }
}