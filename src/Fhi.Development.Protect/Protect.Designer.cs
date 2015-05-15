namespace Fhi.Felles.KeyProtection
{
    partial class Protect
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtExecutionLog = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblCurrentCredentials = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProtect = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIVFilePathSource = new System.Windows.Forms.TextBox();
            this.txtWriteIVPath = new System.Windows.Forms.TextBox();
            this.txtKeyFilePathSource = new System.Windows.Forms.TextBox();
            this.txtWriteKeypath = new System.Windows.Forms.TextBox();
            this.txtKeyBase64Source = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIVBase64Source = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblIV = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblStringCurrentCredentials = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnProtectString = new System.Windows.Forms.Button();
            this.txtProtectedStringPath = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUnprotectedString = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtProtectedKeyFilePathSource = new System.Windows.Forms.TextBox();
            this.txtProtectedIVFilePathSource = new System.Windows.Forms.TextBox();
            this.btnLoadProtected = new System.Windows.Forms.Button();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtExecutionLog);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1085, 479);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Execution Log";
            // 
            // txtExecutionLog
            // 
            this.txtExecutionLog.BackColor = System.Drawing.Color.White;
            this.txtExecutionLog.ForeColor = System.Drawing.Color.Black;
            this.txtExecutionLog.Location = new System.Drawing.Point(-4, 0);
            this.txtExecutionLog.Multiline = true;
            this.txtExecutionLog.Name = "txtExecutionLog";
            this.txtExecutionLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtExecutionLog.Size = new System.Drawing.Size(1093, 483);
            this.txtExecutionLog.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.btnLoadProtected);
            this.tabPage1.Controls.Add(this.txtProtectedIVFilePathSource);
            this.tabPage1.Controls.Add(this.txtProtectedKeyFilePathSource);
            this.tabPage1.Controls.Add(this.lblCurrentCredentials);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnProtect);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtIVFilePathSource);
            this.tabPage1.Controls.Add(this.txtWriteIVPath);
            this.tabPage1.Controls.Add(this.txtKeyFilePathSource);
            this.tabPage1.Controls.Add(this.txtWriteKeypath);
            this.tabPage1.Controls.Add(this.txtKeyBase64Source);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtIVBase64Source);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnLoad);
            this.tabPage1.Controls.Add(this.btnGenerate);
            this.tabPage1.Controls.Add(this.lblIV);
            this.tabPage1.Controls.Add(this.lblKey);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1085, 479);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Protect Key";
            // 
            // lblCurrentCredentials
            // 
            this.lblCurrentCredentials.AutoSize = true;
            this.lblCurrentCredentials.Location = new System.Drawing.Point(157, 366);
            this.lblCurrentCredentials.Name = "lblCurrentCredentials";
            this.lblCurrentCredentials.Size = new System.Drawing.Size(0, 13);
            this.lblCurrentCredentials.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Using current credentials:";
            // 
            // btnProtect
            // 
            this.btnProtect.Location = new System.Drawing.Point(15, 400);
            this.btnProtect.Name = "btnProtect";
            this.btnProtect.Size = new System.Drawing.Size(1024, 34);
            this.btnProtect.TabIndex = 4;
            this.btnProtect.Text = "Protect";
            this.btnProtect.UseVisualStyleBackColor = true;
            this.btnProtect.Click += new System.EventHandler(this.btnProtectRijndael_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(580, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "IV (unprotected)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(580, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Path to write protected IV";
            // 
            // txtIVFilePathSource
            // 
            this.txtIVFilePathSource.Location = new System.Drawing.Point(583, 33);
            this.txtIVFilePathSource.Name = "txtIVFilePathSource";
            this.txtIVFilePathSource.Size = new System.Drawing.Size(456, 20);
            this.txtIVFilePathSource.TabIndex = 7;
            this.txtIVFilePathSource.TabStop = false;
            this.txtIVFilePathSource.Text = "C:\\development\\Fhi.Dar\\Main\\Fhi.Dar.DataAccess\\Resources\\IV.dat";
            // 
            // txtWriteIVPath
            // 
            this.txtWriteIVPath.Location = new System.Drawing.Point(583, 315);
            this.txtWriteIVPath.Name = "txtWriteIVPath";
            this.txtWriteIVPath.Size = new System.Drawing.Size(456, 20);
            this.txtWriteIVPath.TabIndex = 7;
            this.txtWriteIVPath.TabStop = false;
            this.txtWriteIVPath.Text = "C:\\development\\Fhi.Dar\\Main\\Fhi.Dar.Utils\\ProtectedKey\\RijndaelIV.dat";
            // 
            // txtKeyFilePathSource
            // 
            this.txtKeyFilePathSource.Location = new System.Drawing.Point(15, 33);
            this.txtKeyFilePathSource.Name = "txtKeyFilePathSource";
            this.txtKeyFilePathSource.Size = new System.Drawing.Size(456, 20);
            this.txtKeyFilePathSource.TabIndex = 7;
            this.txtKeyFilePathSource.TabStop = false;
            this.txtKeyFilePathSource.Text = "C:\\development\\Fhi.Dar\\Main\\Fhi.Dar.DataAccess\\Resources\\Key.dat";
            // 
            // txtWriteKeypath
            // 
            this.txtWriteKeypath.Location = new System.Drawing.Point(15, 315);
            this.txtWriteKeypath.Name = "txtWriteKeypath";
            this.txtWriteKeypath.Size = new System.Drawing.Size(456, 20);
            this.txtWriteKeypath.TabIndex = 7;
            this.txtWriteKeypath.TabStop = false;
            this.txtWriteKeypath.Text = "C:\\development\\Fhi.Dar\\Main\\Fhi.Dar.Utils\\ProtectedKey\\RijndaelKey.dat";
            // 
            // txtKeyBase64Source
            // 
            this.txtKeyBase64Source.Location = new System.Drawing.Point(15, 140);
            this.txtKeyBase64Source.Multiline = true;
            this.txtKeyBase64Source.Name = "txtKeyBase64Source";
            this.txtKeyBase64Source.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtKeyBase64Source.Size = new System.Drawing.Size(456, 131);
            this.txtKeyBase64Source.TabIndex = 0;
            this.txtKeyBase64Source.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Key (unprotected)";
            // 
            // txtIVBase64Source
            // 
            this.txtIVBase64Source.Location = new System.Drawing.Point(583, 140);
            this.txtIVBase64Source.Multiline = true;
            this.txtIVBase64Source.Name = "txtIVBase64Source";
            this.txtIVBase64Source.Size = new System.Drawing.Size(456, 131);
            this.txtIVBase64Source.TabIndex = 0;
            this.txtIVBase64Source.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Path to write protected key";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(488, 33);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.TabStop = false;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoadRijndael_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(488, 196);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.TabStop = false;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerateRijndael_Click);
            // 
            // lblIV
            // 
            this.lblIV.AutoSize = true;
            this.lblIV.Location = new System.Drawing.Point(580, 124);
            this.lblIV.Name = "lblIV";
            this.lblIV.Size = new System.Drawing.Size(152, 13);
            this.lblIV.TabIndex = 1;
            this.lblIV.Text = "IV (paste as base64 or load IV)";
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(12, 124);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(167, 13);
            this.lblKey.TabIndex = 1;
            this.lblKey.Text = "Key (paste as base64 or load key)";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1093, 505);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Transparent;
            this.tabPage3.Controls.Add(this.lblStringCurrentCredentials);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.btnProtectString);
            this.tabPage3.Controls.Add(this.txtProtectedStringPath);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.txtUnprotectedString);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1085, 479);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Protect String";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblStringCurrentCredentials
            // 
            this.lblStringCurrentCredentials.AutoSize = true;
            this.lblStringCurrentCredentials.Location = new System.Drawing.Point(162, 254);
            this.lblStringCurrentCredentials.Name = "lblStringCurrentCredentials";
            this.lblStringCurrentCredentials.Size = new System.Drawing.Size(0, 13);
            this.lblStringCurrentCredentials.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Using current Credentials: ";
            // 
            // btnProtectString
            // 
            this.btnProtectString.Location = new System.Drawing.Point(24, 313);
            this.btnProtectString.Name = "btnProtectString";
            this.btnProtectString.Size = new System.Drawing.Size(456, 23);
            this.btnProtectString.TabIndex = 4;
            this.btnProtectString.Text = "Protect";
            this.btnProtectString.UseVisualStyleBackColor = true;
            this.btnProtectString.Click += new System.EventHandler(this.btnProtectString_Click);
            // 
            // txtProtectedStringPath
            // 
            this.txtProtectedStringPath.Location = new System.Drawing.Point(24, 199);
            this.txtProtectedStringPath.Name = "txtProtectedStringPath";
            this.txtProtectedStringPath.Size = new System.Drawing.Size(456, 20);
            this.txtProtectedStringPath.TabIndex = 3;
            this.txtProtectedStringPath.Text = "C:\\temp\\teststringprotect.dat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Path to write protected UTF8 string";
            // 
            // txtUnprotectedString
            // 
            this.txtUnprotectedString.Location = new System.Drawing.Point(24, 30);
            this.txtUnprotectedString.Multiline = true;
            this.txtUnprotectedString.Name = "txtUnprotectedString";
            this.txtUnprotectedString.Size = new System.Drawing.Size(456, 131);
            this.txtUnprotectedString.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "String to protect";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Key (protected)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(580, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "IV (protected)";
            // 
            // txtProtectedKeyFilePathSource
            // 
            this.txtProtectedKeyFilePathSource.Location = new System.Drawing.Point(18, 84);
            this.txtProtectedKeyFilePathSource.Name = "txtProtectedKeyFilePathSource";
            this.txtProtectedKeyFilePathSource.Size = new System.Drawing.Size(453, 20);
            this.txtProtectedKeyFilePathSource.TabIndex = 11;
            // 
            // txtProtectedIVFilePathSource
            // 
            this.txtProtectedIVFilePathSource.Location = new System.Drawing.Point(583, 83);
            this.txtProtectedIVFilePathSource.Name = "txtProtectedIVFilePathSource";
            this.txtProtectedIVFilePathSource.Size = new System.Drawing.Size(456, 20);
            this.txtProtectedIVFilePathSource.TabIndex = 12;
            // 
            // btnLoadProtected
            // 
            this.btnLoadProtected.Location = new System.Drawing.Point(488, 80);
            this.btnLoadProtected.Name = "btnLoadProtected";
            this.btnLoadProtected.Size = new System.Drawing.Size(75, 23);
            this.btnLoadProtected.TabIndex = 13;
            this.btnLoadProtected.Text = "Load";
            this.btnLoadProtected.UseVisualStyleBackColor = true;
            this.btnLoadProtected.Click += new System.EventHandler(this.btnLoadProtected_Click);
            // 
            // Protect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 537);
            this.Controls.Add(this.tabControl1);
            this.Name = "Protect";
            this.Text = "Protect";
            this.Load += new System.EventHandler(this.Protect_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtExecutionLog;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnProtect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWriteIVPath;
        private System.Windows.Forms.TextBox txtWriteKeypath;
        private System.Windows.Forms.TextBox txtKeyBase64Source;
        private System.Windows.Forms.TextBox txtIVBase64Source;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblIV;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIVFilePathSource;
        private System.Windows.Forms.TextBox txtKeyFilePathSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblCurrentCredentials;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProtectedStringPath;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUnprotectedString;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProtectString;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblStringCurrentCredentials;
        private System.Windows.Forms.TextBox txtProtectedIVFilePathSource;
        private System.Windows.Forms.TextBox txtProtectedKeyFilePathSource;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnLoadProtected;


    }
}

