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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
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
            this.dgCustomerQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgStockQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgColBreak1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPrice1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgColBreak2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPrice2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgMHCodeLevel1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnImportExcel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMatchingProductCount = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.bw_TakeMPNList = new System.ComponentModel.BackgroundWorker();
            this.bw_ItemAnalyzer = new System.ComponentModel.BackgroundWorker();
            this.pb_ProgressCircle = new AltoControls.ProcessingControl();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgItems, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
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
            this.dgColBreak1,
            this.dgPrice1,
            this.dgColBreak2,
            this.dgPrice2,
            this.dgMHCodeLevel1});
            this.dgItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgItems.Location = new System.Drawing.Point(16, 116);
            this.dgItems.Margin = new System.Windows.Forms.Padding(16);
            this.dgItems.Name = "dgItems";
            this.dgItems.ReadOnly = true;
            this.dgItems.RowTemplate.Height = 24;
            this.dgItems.Size = new System.Drawing.Size(1179, 359);
            this.dgItems.TabIndex = 1;
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
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgMPN.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgMPN.HeaderText = "MPN";
            this.dgMPN.Name = "dgMPN";
            this.dgMPN.ReadOnly = true;
            this.dgMPN.Width = 67;
            // 
            // dgRsMPN
            // 
            this.dgRsMPN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgRsMPN.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgRsMPN.HeaderText = "RS MPN";
            this.dgRsMPN.Name = "dgRsMPN";
            this.dgRsMPN.ReadOnly = true;
            this.dgRsMPN.Width = 90;
            // 
            // dgArticleNo
            // 
            this.dgArticleNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgArticleNo.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgArticleNo.HeaderText = "Article No";
            this.dgArticleNo.Name = "dgArticleNo";
            this.dgArticleNo.ReadOnly = true;
            this.dgArticleNo.Width = 98;
            // 
            // dgPackQuantity
            // 
            this.dgPackQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgPackQuantity.HeaderText = "SSM";
            this.dgPackQuantity.Name = "dgPackQuantity";
            this.dgPackQuantity.ReadOnly = true;
            this.dgPackQuantity.Width = 66;
            // 
            // dgUnitMeasure
            // 
            this.dgUnitMeasure.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgUnitMeasure.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgUnitMeasure.HeaderText = "UoM";
            this.dgUnitMeasure.Name = "dgUnitMeasure";
            this.dgUnitMeasure.ReadOnly = true;
            this.dgUnitMeasure.Width = 66;
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
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgCustomerQuantity.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgCustomerQuantity.HeaderText = "Qty";
            this.dgCustomerQuantity.Name = "dgCustomerQuantity";
            this.dgCustomerQuantity.ReadOnly = true;
            this.dgCustomerQuantity.Width = 59;
            // 
            // dgStockQuantity
            // 
            this.dgStockQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgStockQuantity.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgStockQuantity.HeaderText = "Stock Qty";
            this.dgStockQuantity.Name = "dgStockQuantity";
            this.dgStockQuantity.ReadOnly = true;
            this.dgStockQuantity.Width = 98;
            // 
            // dgColBreak1
            // 
            this.dgColBreak1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgColBreak1.HeaderText = "I Break";
            this.dgColBreak1.MinimumWidth = 60;
            this.dgColBreak1.Name = "dgColBreak1";
            this.dgColBreak1.ReadOnly = true;
            this.dgColBreak1.Width = 81;
            // 
            // dgPrice1
            // 
            this.dgPrice1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgPrice1.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgPrice1.HeaderText = "I Price";
            this.dgPrice1.MinimumWidth = 60;
            this.dgPrice1.Name = "dgPrice1";
            this.dgPrice1.ReadOnly = true;
            this.dgPrice1.Width = 76;
            // 
            // dgColBreak2
            // 
            this.dgColBreak2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgColBreak2.HeaderText = "II Break";
            this.dgColBreak2.MinimumWidth = 60;
            this.dgColBreak2.Name = "dgColBreak2";
            this.dgColBreak2.ReadOnly = true;
            this.dgColBreak2.Width = 84;
            // 
            // dgPrice2
            // 
            this.dgPrice2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgPrice2.HeaderText = "II Price";
            this.dgPrice2.MinimumWidth = 60;
            this.dgPrice2.Name = "dgPrice2";
            this.dgPrice2.ReadOnly = true;
            this.dgPrice2.Width = 79;
            // 
            // dgMHCodeLevel1
            // 
            this.dgMHCodeLevel1.HeaderText = "MH Code Level 1";
            this.dgMHCodeLevel1.Name = "dgMHCodeLevel1";
            this.dgMHCodeLevel1.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pb_ProgressCircle);
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
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1150, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 86);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(484, 22);
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
            this.label1.Location = new System.Drawing.Point(250, 37);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMatchingProductCount);
            this.panel1.Controls.Add(this.lblCount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 494);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1205, 44);
            this.panel1.TabIndex = 3;
            // 
            // lblMatchingProductCount
            // 
            this.lblMatchingProductCount.AutoSize = true;
            this.lblMatchingProductCount.Location = new System.Drawing.Point(158, 12);
            this.lblMatchingProductCount.Name = "lblMatchingProductCount";
            this.lblMatchingProductCount.Size = new System.Drawing.Size(16, 17);
            this.lblMatchingProductCount.TabIndex = 1;
            this.lblMatchingProductCount.Text = "0";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(11, 12);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(138, 17);
            this.lblCount.TabIndex = 0;
            this.lblCount.Text = "Eşleşen Ürün Sayısı:";
            // 
            // bw_TakeMPNList
            // 
            this.bw_TakeMPNList.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_TakeMPNList_DoWork);
            this.bw_TakeMPNList.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_TakeMPNList_RunWorkerCompleted);
            // 
            // bw_ItemAnalyzer
            // 
            this.bw_ItemAnalyzer.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_ItemAnalyzer_DoWork);
            // 
            // pb_ProgressCircle
            // 
            this.pb_ProgressCircle.BackColor = System.Drawing.Color.Transparent;
            this.pb_ProgressCircle.IndexColor = System.Drawing.Color.Gray;
            this.pb_ProgressCircle.Interval = 100;
            this.pb_ProgressCircle.Location = new System.Drawing.Point(176, 14);
            this.pb_ProgressCircle.Name = "pb_ProgressCircle";
            this.pb_ProgressCircle.NCircle = 8;
            this.pb_ProgressCircle.Others = System.Drawing.Color.LightGray;
            this.pb_ProgressCircle.Radius = 7;
            this.pb_ProgressCircle.Size = new System.Drawing.Size(68, 66);
            this.pb_ProgressCircle.Spin = true;
            this.pb_ProgressCircle.TabIndex = 3;
            this.pb_ProgressCircle.Visible = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnImportExcel;
        private System.Windows.Forms.DataGridView dgItems;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblMatchingProductCount;
        private System.ComponentModel.BackgroundWorker bw_TakeMPNList;
        private AltoControls.ProcessingControl pb_ProgressCircle;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dgColBreak1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPrice1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgColBreak2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPrice2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgMHCodeLevel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker bw_ItemAnalyzer;
    }
}

