namespace WhatForensics
{
    partial class AcquisitionViaManzanaView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcquisitionViaManzanaView));
            this.btnAcquire = new System.Windows.Forms.Button();
            this.pbAcquisition = new System.Windows.Forms.ProgressBar();
            this.txtDeviceHeader = new System.Windows.Forms.TextBox();
            this.txtDeviceDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAcquire
            // 
            this.btnAcquire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAcquire.Location = new System.Drawing.Point(387, 10);
            this.btnAcquire.Name = "btnAcquire";
            this.btnAcquire.Size = new System.Drawing.Size(75, 23);
            this.btnAcquire.TabIndex = 1;
            this.btnAcquire.Text = "Acquire";
            this.btnAcquire.UseVisualStyleBackColor = true;
            this.btnAcquire.Click += new System.EventHandler(this.btnAcquire_Click);
            // 
            // pbAcquisition
            // 
            this.pbAcquisition.Location = new System.Drawing.Point(12, 10);
            this.pbAcquisition.Name = "pbAcquisition";
            this.pbAcquisition.Size = new System.Drawing.Size(369, 23);
            this.pbAcquisition.TabIndex = 2;
            // 
            // txtDeviceHeader
            // 
            this.txtDeviceHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDeviceHeader.BackColor = System.Drawing.SystemColors.Control;
            this.txtDeviceHeader.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDeviceHeader.Location = new System.Drawing.Point(12, 39);
            this.txtDeviceHeader.Multiline = true;
            this.txtDeviceHeader.Name = "txtDeviceHeader";
            this.txtDeviceHeader.ReadOnly = true;
            this.txtDeviceHeader.Size = new System.Drawing.Size(116, 177);
            this.txtDeviceHeader.TabIndex = 3;
            this.txtDeviceHeader.Text = resources.GetString("txtDeviceHeader.Text");
            // 
            // txtDeviceDescription
            // 
            this.txtDeviceDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDeviceDescription.BackColor = System.Drawing.SystemColors.Control;
            this.txtDeviceDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDeviceDescription.Location = new System.Drawing.Point(134, 39);
            this.txtDeviceDescription.Multiline = true;
            this.txtDeviceDescription.Name = "txtDeviceDescription";
            this.txtDeviceDescription.ReadOnly = true;
            this.txtDeviceDescription.Size = new System.Drawing.Size(328, 177);
            this.txtDeviceDescription.TabIndex = 4;
            this.txtDeviceDescription.Text = "N/A";
            // 
            // AcquisitionViaManzanaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 228);
            this.Controls.Add(this.txtDeviceDescription);
            this.Controls.Add(this.txtDeviceHeader);
            this.Controls.Add(this.pbAcquisition);
            this.Controls.Add(this.btnAcquire);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AcquisitionViaManzanaView";
            this.Text = "AcquisitionViaManzanaView";
            this.Load += new System.EventHandler(this.AcquisitionViaManzanaView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAcquire;
        private System.Windows.Forms.ProgressBar pbAcquisition;
        private System.Windows.Forms.TextBox txtDeviceHeader;
        private System.Windows.Forms.TextBox txtDeviceDescription;
    }
}