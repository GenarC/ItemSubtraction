namespace Item_Subtracter
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnImportExcel = new System.Windows.Forms.Button();
            this.dgItems = new System.Windows.Forms.DataGridView();
            this.dgSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgMPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRsMPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgArticleNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPackQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgUnitMeasure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgArticleDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgManufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgMHCodeLevel1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnImportExcel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgItems, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1415, 731);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.Location = new System.Drawing.Point(8, 8);
            this.btnImportExcel.Margin = new System.Windows.Forms.Padding(8);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.Size = new System.Drawing.Size(151, 84);
            this.btnImportExcel.TabIndex = 0;
            this.btnImportExcel.Text = "ImportExcel";
            this.btnImportExcel.UseVisualStyleBackColor = true;
            this.btnImportExcel.Click += new System.EventHandler(this.btnImportExcel_Click);
            // 
            // dgItems
            // 
            this.dgItems.AllowUserToAddRows = false;
            this.dgItems.AllowUserToDeleteRows = false;
            this.dgItems.AllowUserToOrderColumns = true;
            this.dgItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgSelect,
            this.dgNo,
            this.dgMPN,
            this.dgRsMPN,
            this.dgArticleNo,
            this.dgPackQuantity,
            this.dgUnitMeasure,
            this.dgArticleDesc,
            this.dgManufacturer,
            this.dgPrice,
            this.dgMHCodeLevel1});
            this.dgItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgItems.Location = new System.Drawing.Point(16, 116);
            this.dgItems.Margin = new System.Windows.Forms.Padding(16);
            this.dgItems.Name = "dgItems";
            this.dgItems.RowTemplate.Height = 24;
            this.dgItems.Size = new System.Drawing.Size(1383, 599);
            this.dgItems.TabIndex = 1;
            // 
            // dgSelect
            // 
            this.dgSelect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgSelect.HeaderText = "X";
            this.dgSelect.Name = "dgSelect";
            this.dgSelect.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgSelect.Visible = false;
            this.dgSelect.Width = 46;
            // 
            // dgNo
            // 
            this.dgNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgNo.HeaderText = "No";
            this.dgNo.Name = "dgNo";
            this.dgNo.Width = 55;
            // 
            // dgMPN
            // 
            this.dgMPN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgMPN.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgMPN.HeaderText = "MPN";
            this.dgMPN.Name = "dgMPN";
            this.dgMPN.ReadOnly = true;
            this.dgMPN.Width = 67;
            // 
            // dgRsMPN
            // 
            this.dgRsMPN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgRsMPN.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgRsMPN.HeaderText = "RS MPN";
            this.dgRsMPN.Name = "dgRsMPN";
            this.dgRsMPN.ReadOnly = true;
            this.dgRsMPN.Width = 90;
            // 
            // dgArticleNo
            // 
            this.dgArticleNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgArticleNo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgArticleNo.HeaderText = "Article No";
            this.dgArticleNo.Name = "dgArticleNo";
            this.dgArticleNo.ReadOnly = true;
            this.dgArticleNo.Width = 98;
            // 
            // dgPackQuantity
            // 
            this.dgPackQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgPackQuantity.HeaderText = "Pack Quantity (SSM)";
            this.dgPackQuantity.Name = "dgPackQuantity";
            this.dgPackQuantity.ReadOnly = true;
            this.dgPackQuantity.Width = 154;
            // 
            // dgUnitMeasure
            // 
            this.dgUnitMeasure.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgUnitMeasure.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgUnitMeasure.HeaderText = "Unit Measure (UoM)";
            this.dgUnitMeasure.Name = "dgUnitMeasure";
            this.dgUnitMeasure.ReadOnly = true;
            this.dgUnitMeasure.Width = 5;
            // 
            // dgArticleDesc
            // 
            this.dgArticleDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgArticleDesc.HeaderText = "Article Desc";
            this.dgArticleDesc.Name = "dgArticleDesc";
            this.dgArticleDesc.ReadOnly = true;
            // 
            // dgManufacturer
            // 
            this.dgManufacturer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgManufacturer.HeaderText = "Manufacturer";
            this.dgManufacturer.Name = "dgManufacturer";
            this.dgManufacturer.ReadOnly = true;
            this.dgManufacturer.Width = 121;
            // 
            // dgPrice
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgPrice.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgPrice.HeaderText = "Price";
            this.dgPrice.Name = "dgPrice";
            this.dgPrice.ReadOnly = true;
            // 
            // dgMHCodeLevel1
            // 
            this.dgMHCodeLevel1.HeaderText = "MH Code Level 1";
            this.dgMHCodeLevel1.Name = "dgMHCodeLevel1";
            this.dgMHCodeLevel1.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 731);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnImportExcel;
        private System.Windows.Forms.DataGridView dgItems;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgMPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRsMPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgArticleNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPackQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgUnitMeasure;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgArticleDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgManufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgMHCodeLevel1;
    }
}

