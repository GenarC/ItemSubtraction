#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace Item_Subtracter
{
    partial class Office2010Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Office2010Form1));
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.PanelSlide = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.sfButton1 = new Syncfusion.WinForms.Controls.SfButton();
            this.sfButton2 = new Syncfusion.WinForms.Controls.SfButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelSlide)).BeginInit();
            this.PanelSlide.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.gradientPanel1.Controls.Add(this.sfButton1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(69, 612);
            this.gradientPanel1.TabIndex = 0;
            // 
            // PanelSlide
            // 
            this.PanelSlide.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.PanelSlide.Controls.Add(this.sfButton2);
            this.PanelSlide.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelSlide.Location = new System.Drawing.Point(69, 0);
            this.PanelSlide.Name = "PanelSlide";
            this.PanelSlide.Size = new System.Drawing.Size(285, 612);
            this.PanelSlide.TabIndex = 1;
            // 
            // sfButton1
            // 
            this.sfButton1.AccessibleName = "Button";
            this.sfButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sfButton1.Image = ((System.Drawing.Image)(resources.GetObject("sfButton1.Image")));
            this.sfButton1.ImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sfButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.sfButton1.Location = new System.Drawing.Point(10, 10);
            this.sfButton1.Name = "sfButton1";
            this.sfButton1.Size = new System.Drawing.Size(46, 32);
            this.sfButton1.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.sfButton1.TabIndex = 0;
            this.sfButton1.Click += new System.EventHandler(this.sfButton1_Click);
            // 
            // sfButton2
            // 
            this.sfButton2.AccessibleName = "Button";
            this.sfButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sfButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sfButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.sfButton2.Location = new System.Drawing.Point(30, 24);
            this.sfButton2.Name = "sfButton2";
            this.sfButton2.Size = new System.Drawing.Size(157, 61);
            this.sfButton2.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sfButton2.TabIndex = 0;
            this.sfButton2.Text = "sfButton2";
            this.sfButton2.ThemeName = "";
            this.sfButton2.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Office2010Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 612);
            this.Controls.Add(this.PanelSlide);
            this.Controls.Add(this.gradientPanel1);
            this.Name = "Office2010Form1";
            this.Text = "Office2010Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelSlide)).EndInit();
            this.PanelSlide.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Syncfusion.WinForms.Controls.SfButton sfButton1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel PanelSlide;
        private Syncfusion.WinForms.Controls.SfButton sfButton2;
        private System.Windows.Forms.Timer timer1;
    }
}