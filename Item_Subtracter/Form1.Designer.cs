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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgItems = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnImportExcel = new System.Windows.Forms.Button();
            this.dgSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgMPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRsMPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgArticleNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPackQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgUnitMeasure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgArticleDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgManufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCustomerQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgStockQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgMHCodeLevel1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgItems, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1211, 541);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgItems
            // 
            this.dgItems.AllowUserToAddRows = false;
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
            this.dgCustomerQuantity,
            this.dgStockQuantity,
            this.dgPrice,
            this.dgMHCodeLevel1});
            this.dgItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgItems.Location = new System.Drawing.Point(16, 116);
            this.dgItems.Margin = new System.Windows.Forms.Padding(16);
            this.dgItems.Name = "dgItems";
            this.dgItems.ReadOnly = true;
            this.dgItems.RowTemplate.Height = 24;
            this.dgItems.Size = new System.Drawing.Size(1179, 409);
            this.dgItems.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnImportExcel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1205, 94);
            this.panel2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(427, 25);
            this.button1.Margin = new System.Windows.Forms.Padding(8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Yükle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(176, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "MPN Listesi Hazır Değil";
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.ForeColor = System.Drawing.Color.Black;
            this.btnImportExcel.Location = new System.Drawing.Point(14, 5);
            this.btnImportExcel.Margin = new System.Windows.Forms.Padding(8);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.Size = new System.Drawing.Size(151, 84);
            this.btnImportExcel.TabIndex = 0;
            this.btnImportExcel.Text = "Excel Ekle";
            this.btnImportExcel.UseVisualStyleBackColor = true;
            this.btnImportExcel.Click += new System.EventHandler(this.btnImportExcel_Click);
            // 
            // dgSelect
            // 
            this.dgSelect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgSelect.HeaderText = "X";
            this.dgSelect.Name = "dgSelect";
            this.dgSelect.ReadOnly = true;
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
            this.dgNo.ReadOnly = true;
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
            // dgCustomerQuantity
            // 
            this.dgCustomerQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgCustomerQuantity.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgCustomerQuantity.HeaderText = "Qty";
            this.dgCustomerQuantity.Name = "dgCustomerQuantity";
            this.dgCustomerQuantity.ReadOnly = true;
            this.dgCustomerQuantity.Width = 59;
            // 
            // dgStockQuantity
            // 
            this.dgStockQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgStockQuantity.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgStockQuantity.HeaderText = "Stock Qty";
            this.dgStockQuantity.Name = "dgStockQuantity";
            this.dgStockQuantity.ReadOnly = true;
            this.dgStockQuantity.Width = 5;
            // 
            // dgPrice
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgPrice.DefaultCellStyle = dataGridViewCellStyle7;
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
            this.ClientSize = new System.Drawing.Size(1211, 541);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(1229, 588);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnImportExcel;
        private System.Windows.Forms.DataGridView dgItems;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgMPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRsMPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgArticleNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPackQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgUnitMeasure;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgArticleDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgManufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCustomerQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgStockQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgMHCodeLevel1;
    }
}

