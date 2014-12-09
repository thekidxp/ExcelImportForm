namespace TestingExcelImport
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
            this.btnImportData = new System.Windows.Forms.Button();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnHRAnalysis = new System.Windows.Forms.Button();
            this.btnLogAnal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnImportData
            // 
            this.btnImportData.Location = new System.Drawing.Point(98, 227);
            this.btnImportData.Name = "btnImportData";
            this.btnImportData.Size = new System.Drawing.Size(75, 23);
            this.btnImportData.TabIndex = 0;
            this.btnImportData.Text = "Import Data";
            this.btnImportData.UseVisualStyleBackColor = true;
            this.btnImportData.Click += new System.EventHandler(this.btnImportData_Click);
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(9, 172);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(138, 13);
            this.lblFilePath.TabIndex = 1;
            this.lblFilePath.Text = "Please enter path of text file";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(12, 188);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(219, 20);
            this.txtFilePath.TabIndex = 2;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(237, 185);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnHRAnalysis
            // 
            this.btnHRAnalysis.Location = new System.Drawing.Point(12, 12);
            this.btnHRAnalysis.Name = "btnHRAnalysis";
            this.btnHRAnalysis.Size = new System.Drawing.Size(75, 23);
            this.btnHRAnalysis.TabIndex = 4;
            this.btnHRAnalysis.Text = "HR Analysis";
            this.btnHRAnalysis.UseVisualStyleBackColor = true;
            this.btnHRAnalysis.Click += new System.EventHandler(this.btnHRAnalysis_Click);
            // 
            // btnLogAnal
            // 
            this.btnLogAnal.Location = new System.Drawing.Point(98, 11);
            this.btnLogAnal.Name = "btnLogAnal";
            this.btnLogAnal.Size = new System.Drawing.Size(103, 23);
            this.btnLogAnal.TabIndex = 5;
            this.btnLogAnal.Text = "Logging Analysis";
            this.btnLogAnal.UseVisualStyleBackColor = true;
            this.btnLogAnal.Click += new System.EventHandler(this.btnLogAnal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 262);
            this.Controls.Add(this.btnLogAnal);
            this.Controls.Add(this.btnHRAnalysis);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.btnImportData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImportData;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnHRAnalysis;
        private System.Windows.Forms.Button btnLogAnal;
    }
}

