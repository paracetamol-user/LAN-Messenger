﻿namespace UI
{
    partial class ucFileShow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucFileShow));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDownLoad = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDownLoad)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxDownLoad
            // 
            this.pictureBoxDownLoad.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxDownLoad.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDownLoad.Image")));
            this.pictureBoxDownLoad.Location = new System.Drawing.Point(231, 2);
            this.pictureBoxDownLoad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxDownLoad.Name = "pictureBoxDownLoad";
            this.pictureBoxDownLoad.Size = new System.Drawing.Size(20, 28);
            this.pictureBoxDownLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDownLoad.TabIndex = 1;
            this.pictureBoxDownLoad.TabStop = false;
            this.pictureBoxDownLoad.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(34, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4, 6, 15, 0);
            this.panel1.Size = new System.Drawing.Size(197, 28);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // ucFileShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxDownLoad);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ucFileShow";
            this.Padding = new System.Windows.Forms.Padding(8, 2, 15, 1);
            this.Size = new System.Drawing.Size(266, 31);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDownLoad)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxDownLoad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}