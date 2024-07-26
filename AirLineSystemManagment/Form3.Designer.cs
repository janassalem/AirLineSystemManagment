namespace AirLineSystemManagment
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            System.Windows.Forms.Label cUSTOMER_IDLabel;
            System.Windows.Forms.Label nATIONALITYLabel;
            this.masterDataSet9 = new AirLineSystemManagment.masterDataSet9();
            this.nATIONALITYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nATIONALITYTableAdapter = new AirLineSystemManagment.masterDataSet9TableAdapters.NATIONALITYTableAdapter();
            this.tableAdapterManager = new AirLineSystemManagment.masterDataSet9TableAdapters.TableAdapterManager();
            this.nATIONALITYBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.nATIONALITYBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cUSTOMER_IDTextBox = new System.Windows.Forms.TextBox();
            this.nATIONALITYTextBox = new System.Windows.Forms.TextBox();
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cUSTOMERTableAdapter = new AirLineSystemManagment.masterDataSet9TableAdapters.CUSTOMERTableAdapter();
            this.cUSTOMERDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cUSTOMER_IDLabel = new System.Windows.Forms.Label();
            nATIONALITYLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nATIONALITYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nATIONALITYBindingNavigator)).BeginInit();
            this.nATIONALITYBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // masterDataSet9
            // 
            this.masterDataSet9.DataSetName = "masterDataSet9";
            this.masterDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nATIONALITYBindingSource
            // 
            this.nATIONALITYBindingSource.DataMember = "NATIONALITY";
            this.nATIONALITYBindingSource.DataSource = this.masterDataSet9;
            // 
            // nATIONALITYTableAdapter
            // 
            this.nATIONALITYTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ADMINTableAdapter = null;
            this.tableAdapterManager.AIRCRAFTTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOOKEDTableAdapter = null;
            this.tableAdapterManager.BOOKSTableAdapter = null;
            this.tableAdapterManager.BOOKTableAdapter = null;
            this.tableAdapterManager.CANCELTableAdapter = null;
            this.tableAdapterManager.CHANGETableAdapter = null;
            this.tableAdapterManager.CUSTOMERTableAdapter = this.cUSTOMERTableAdapter;
            this.tableAdapterManager.FLIGHTTableAdapter = null;
            this.tableAdapterManager.HAS_ATableAdapter = null;
            this.tableAdapterManager.NATIONALITYTableAdapter = this.nATIONALITYTableAdapter;
            this.tableAdapterManager.TICKETTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AirLineSystemManagment.masterDataSet9TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nATIONALITYBindingNavigator
            // 
            this.nATIONALITYBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.nATIONALITYBindingNavigator.BindingSource = this.nATIONALITYBindingSource;
            this.nATIONALITYBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.nATIONALITYBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.nATIONALITYBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.nATIONALITYBindingNavigatorSaveItem});
            this.nATIONALITYBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.nATIONALITYBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.nATIONALITYBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.nATIONALITYBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.nATIONALITYBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.nATIONALITYBindingNavigator.Name = "nATIONALITYBindingNavigator";
            this.nATIONALITYBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.nATIONALITYBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.nATIONALITYBindingNavigator.TabIndex = 0;
            this.nATIONALITYBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // nATIONALITYBindingNavigatorSaveItem
            // 
            this.nATIONALITYBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nATIONALITYBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("nATIONALITYBindingNavigatorSaveItem.Image")));
            this.nATIONALITYBindingNavigatorSaveItem.Name = "nATIONALITYBindingNavigatorSaveItem";
            this.nATIONALITYBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.nATIONALITYBindingNavigatorSaveItem.Text = "Save Data";
            this.nATIONALITYBindingNavigatorSaveItem.Click += new System.EventHandler(this.nATIONALITYBindingNavigatorSaveItem_Click);
            // 
            // cUSTOMER_IDLabel
            // 
            cUSTOMER_IDLabel.AutoSize = true;
            cUSTOMER_IDLabel.Location = new System.Drawing.Point(14, 46);
            cUSTOMER_IDLabel.Name = "cUSTOMER_IDLabel";
            cUSTOMER_IDLabel.Size = new System.Drawing.Size(85, 13);
            cUSTOMER_IDLabel.TabIndex = 1;
            cUSTOMER_IDLabel.Text = "CUSTOMER ID:";
            // 
            // cUSTOMER_IDTextBox
            // 
            this.cUSTOMER_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nATIONALITYBindingSource, "CUSTOMER_ID", true));
            this.cUSTOMER_IDTextBox.Location = new System.Drawing.Point(105, 43);
            this.cUSTOMER_IDTextBox.Name = "cUSTOMER_IDTextBox";
            this.cUSTOMER_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.cUSTOMER_IDTextBox.TabIndex = 2;
            // 
            // nATIONALITYLabel
            // 
            nATIONALITYLabel.AutoSize = true;
            nATIONALITYLabel.Location = new System.Drawing.Point(14, 72);
            nATIONALITYLabel.Name = "nATIONALITYLabel";
            nATIONALITYLabel.Size = new System.Drawing.Size(81, 13);
            nATIONALITYLabel.TabIndex = 3;
            nATIONALITYLabel.Text = "NATIONALITY:";
            // 
            // nATIONALITYTextBox
            // 
            this.nATIONALITYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nATIONALITYBindingSource, "NATIONALITY", true));
            this.nATIONALITYTextBox.Location = new System.Drawing.Point(105, 69);
            this.nATIONALITYTextBox.Name = "nATIONALITYTextBox";
            this.nATIONALITYTextBox.Size = new System.Drawing.Size(100, 20);
            this.nATIONALITYTextBox.TabIndex = 4;
            // 
            // cUSTOMERBindingSource
            // 
            this.cUSTOMERBindingSource.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource.DataSource = this.masterDataSet9;
            // 
            // cUSTOMERTableAdapter
            // 
            this.cUSTOMERTableAdapter.ClearBeforeFill = true;
            // 
            // cUSTOMERDataGridView
            // 
            this.cUSTOMERDataGridView.AutoGenerateColumns = false;
            this.cUSTOMERDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cUSTOMERDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.cUSTOMERDataGridView.DataSource = this.cUSTOMERBindingSource;
            this.cUSTOMERDataGridView.Location = new System.Drawing.Point(17, 114);
            this.cUSTOMERDataGridView.Name = "cUSTOMERDataGridView";
            this.cUSTOMERDataGridView.Size = new System.Drawing.Size(771, 270);
            this.cUSTOMERDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CUSTOMERID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CUSTOMERID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ADMINID";
            this.dataGridViewTextBoxColumn2.HeaderText = "ADMINID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NAME";
            this.dataGridViewTextBoxColumn3.HeaderText = "NAME";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DATEOFBIRTH";
            this.dataGridViewTextBoxColumn4.HeaderText = "DATEOFBIRTH";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "USERNAME";
            this.dataGridViewTextBoxColumn5.HeaderText = "USERNAME";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PASSWORD";
            this.dataGridViewTextBoxColumn6.HeaderText = "PASSWORD";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "EMAIL";
            this.dataGridViewTextBoxColumn7.HeaderText = "EMAIL";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CITY";
            this.dataGridViewTextBoxColumn8.HeaderText = "CITY";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "COUNTRY";
            this.dataGridViewTextBoxColumn9.HeaderText = "COUNTRY";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "STREET";
            this.dataGridViewTextBoxColumn10.HeaderText = "STREET";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "AGE";
            this.dataGridViewTextBoxColumn11.HeaderText = "AGE";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cUSTOMERDataGridView);
            this.Controls.Add(cUSTOMER_IDLabel);
            this.Controls.Add(this.cUSTOMER_IDTextBox);
            this.Controls.Add(nATIONALITYLabel);
            this.Controls.Add(this.nATIONALITYTextBox);
            this.Controls.Add(this.nATIONALITYBindingNavigator);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nATIONALITYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nATIONALITYBindingNavigator)).EndInit();
            this.nATIONALITYBindingNavigator.ResumeLayout(false);
            this.nATIONALITYBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private masterDataSet9 masterDataSet9;
        private System.Windows.Forms.BindingSource nATIONALITYBindingSource;
        private masterDataSet9TableAdapters.NATIONALITYTableAdapter nATIONALITYTableAdapter;
        private masterDataSet9TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator nATIONALITYBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton nATIONALITYBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox cUSTOMER_IDTextBox;
        private System.Windows.Forms.TextBox nATIONALITYTextBox;
        private masterDataSet9TableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource;
        private System.Windows.Forms.DataGridView cUSTOMERDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    }
}