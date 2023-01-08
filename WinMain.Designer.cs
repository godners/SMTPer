namespace SMTPer
{
    partial class WinMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinMain));
            this.LabelUsnm = new System.Windows.Forms.Label();
            this.CheckBoxAuthentication = new System.Windows.Forms.CheckBox();
            this.TextBoxUsnm = new System.Windows.Forms.TextBox();
            this.TextBoxPswd = new System.Windows.Forms.TextBox();
            this.LabelPswd = new System.Windows.Forms.Label();
            this.LabelFrom = new System.Windows.Forms.Label();
            this.TextBoxFrom = new System.Windows.Forms.TextBox();
            this.CheckBoxFrom = new System.Windows.Forms.CheckBox();
            this.LabelTo = new System.Windows.Forms.Label();
            this.LabelServer = new System.Windows.Forms.Label();
            this.TextBoxServer = new System.Windows.Forms.TextBox();
            this.CheckBoxTo = new System.Windows.Forms.CheckBox();
            this.TextBoxTo = new System.Windows.Forms.TextBox();
            this.TextBoxCC = new System.Windows.Forms.TextBox();
            this.CheckBoxCC = new System.Windows.Forms.CheckBox();
            this.LabelCC = new System.Windows.Forms.Label();
            this.TextBoxBC = new System.Windows.Forms.TextBox();
            this.CheckBoxBC = new System.Windows.Forms.CheckBox();
            this.LabelBC = new System.Windows.Forms.Label();
            this.TextBoxSubject = new System.Windows.Forms.TextBox();
            this.CheckBoxSubject = new System.Windows.Forms.CheckBox();
            this.LabelSubject = new System.Windows.Forms.Label();
            this.TextBoxBody = new System.Windows.Forms.TextBox();
            this.CheckBoxBody = new System.Windows.Forms.CheckBox();
            this.LabelBody = new System.Windows.Forms.Label();
            this.PictureBoxAuthor = new System.Windows.Forms.PictureBox();
            this.ButtonSend = new System.Windows.Forms.Button();
            this.LabelResult = new System.Windows.Forms.Label();
            this.LabelDispaly = new System.Windows.Forms.Label();
            this.TextBoxDisplay = new System.Windows.Forms.TextBox();
            this.RadioLow = new System.Windows.Forms.RadioButton();
            this.RadioNormal = new System.Windows.Forms.RadioButton();
            this.RadioHigh = new System.Windows.Forms.RadioButton();
            this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAuthor)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelUsnm
            // 
            this.LabelUsnm.Location = new System.Drawing.Point(42, 42);
            this.LabelUsnm.Margin = new System.Windows.Forms.Padding(4);
            this.LabelUsnm.Name = "LabelUsnm";
            this.LabelUsnm.Padding = new System.Windows.Forms.Padding(4);
            this.LabelUsnm.Size = new System.Drawing.Size(106, 26);
            this.LabelUsnm.TabIndex = 102;
            this.LabelUsnm.Text = "Username:";
            this.LabelUsnm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CheckBoxAuthentication
            // 
            this.CheckBoxAuthentication.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckBoxAuthentication.Location = new System.Drawing.Point(8, 42);
            this.CheckBoxAuthentication.Margin = new System.Windows.Forms.Padding(4);
            this.CheckBoxAuthentication.Name = "CheckBoxAuthentication";
            this.CheckBoxAuthentication.Padding = new System.Windows.Forms.Padding(4);
            this.CheckBoxAuthentication.Size = new System.Drawing.Size(26, 26);
            this.CheckBoxAuthentication.TabIndex = 5;
            this.CheckBoxAuthentication.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckBoxAuthentication.UseVisualStyleBackColor = true;
            this.CheckBoxAuthentication.CheckedChanged += new System.EventHandler(this.CheckBoxAuthentication_CheckedChanged);
            // 
            // TextBoxUsnm
            // 
            this.TextBoxUsnm.Enabled = false;
            this.TextBoxUsnm.Location = new System.Drawing.Point(156, 42);
            this.TextBoxUsnm.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxUsnm.MaxLength = 256;
            this.TextBoxUsnm.Name = "TextBoxUsnm";
            this.TextBoxUsnm.Size = new System.Drawing.Size(160, 26);
            this.TextBoxUsnm.TabIndex = 6;
            // 
            // TextBoxPswd
            // 
            this.TextBoxPswd.Enabled = false;
            this.TextBoxPswd.Location = new System.Drawing.Point(438, 42);
            this.TextBoxPswd.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxPswd.MaxLength = 256;
            this.TextBoxPswd.Name = "TextBoxPswd";
            this.TextBoxPswd.PasswordChar = '$';
            this.TextBoxPswd.Size = new System.Drawing.Size(160, 26);
            this.TextBoxPswd.TabIndex = 7;
            // 
            // LabelPswd
            // 
            this.LabelPswd.Location = new System.Drawing.Point(324, 42);
            this.LabelPswd.Margin = new System.Windows.Forms.Padding(4);
            this.LabelPswd.Name = "LabelPswd";
            this.LabelPswd.Padding = new System.Windows.Forms.Padding(4);
            this.LabelPswd.Size = new System.Drawing.Size(106, 26);
            this.LabelPswd.TabIndex = 203;
            this.LabelPswd.Text = "Password:";
            this.LabelPswd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelFrom
            // 
            this.LabelFrom.Location = new System.Drawing.Point(42, 76);
            this.LabelFrom.Margin = new System.Windows.Forms.Padding(4);
            this.LabelFrom.Name = "LabelFrom";
            this.LabelFrom.Padding = new System.Windows.Forms.Padding(4);
            this.LabelFrom.Size = new System.Drawing.Size(66, 26);
            this.LabelFrom.TabIndex = 104;
            this.LabelFrom.Text = "Form:";
            this.LabelFrom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxFrom
            // 
            this.TextBoxFrom.Enabled = false;
            this.TextBoxFrom.Location = new System.Drawing.Point(116, 76);
            this.TextBoxFrom.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxFrom.MaxLength = 256;
            this.TextBoxFrom.Name = "TextBoxFrom";
            this.TextBoxFrom.Size = new System.Drawing.Size(200, 26);
            this.TextBoxFrom.TabIndex = 9;
            // 
            // CheckBoxFrom
            // 
            this.CheckBoxFrom.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckBoxFrom.Location = new System.Drawing.Point(8, 76);
            this.CheckBoxFrom.Margin = new System.Windows.Forms.Padding(4);
            this.CheckBoxFrom.Name = "CheckBoxFrom";
            this.CheckBoxFrom.Padding = new System.Windows.Forms.Padding(4);
            this.CheckBoxFrom.Size = new System.Drawing.Size(26, 26);
            this.CheckBoxFrom.TabIndex = 8;
            this.CheckBoxFrom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckBoxFrom.UseVisualStyleBackColor = true;
            this.CheckBoxFrom.CheckedChanged += new System.EventHandler(this.CheckBoxFrom_CheckedChanged);
            // 
            // LabelTo
            // 
            this.LabelTo.Location = new System.Drawing.Point(42, 110);
            this.LabelTo.Margin = new System.Windows.Forms.Padding(4);
            this.LabelTo.Name = "LabelTo";
            this.LabelTo.Padding = new System.Windows.Forms.Padding(4);
            this.LabelTo.Size = new System.Drawing.Size(46, 26);
            this.LabelTo.TabIndex = 106;
            this.LabelTo.Text = "To:";
            this.LabelTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelServer
            // 
            this.LabelServer.Location = new System.Drawing.Point(8, 8);
            this.LabelServer.Margin = new System.Windows.Forms.Padding(4);
            this.LabelServer.Name = "LabelServer";
            this.LabelServer.Padding = new System.Windows.Forms.Padding(4);
            this.LabelServer.Size = new System.Drawing.Size(86, 26);
            this.LabelServer.TabIndex = 101;
            this.LabelServer.Text = "Server:";
            this.LabelServer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxServer
            // 
            this.TextBoxServer.Location = new System.Drawing.Point(102, 8);
            this.TextBoxServer.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxServer.MaxLength = 256;
            this.TextBoxServer.Name = "TextBoxServer";
            this.TextBoxServer.Size = new System.Drawing.Size(214, 26);
            this.TextBoxServer.TabIndex = 1;
            // 
            // CheckBoxTo
            // 
            this.CheckBoxTo.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckBoxTo.Checked = true;
            this.CheckBoxTo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxTo.Location = new System.Drawing.Point(8, 111);
            this.CheckBoxTo.Margin = new System.Windows.Forms.Padding(4);
            this.CheckBoxTo.Name = "CheckBoxTo";
            this.CheckBoxTo.Padding = new System.Windows.Forms.Padding(4);
            this.CheckBoxTo.Size = new System.Drawing.Size(26, 26);
            this.CheckBoxTo.TabIndex = 11;
            this.CheckBoxTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckBoxTo.UseVisualStyleBackColor = true;
            this.CheckBoxTo.CheckedChanged += new System.EventHandler(this.CheckBoxTo_CheckedChanged);
            // 
            // TextBoxTo
            // 
            this.TextBoxTo.Location = new System.Drawing.Point(96, 110);
            this.TextBoxTo.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxTo.MaxLength = 256;
            this.TextBoxTo.Name = "TextBoxTo";
            this.TextBoxTo.Size = new System.Drawing.Size(502, 26);
            this.TextBoxTo.TabIndex = 12;
            // 
            // TextBoxCC
            // 
            this.TextBoxCC.Enabled = false;
            this.TextBoxCC.Location = new System.Drawing.Point(96, 144);
            this.TextBoxCC.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxCC.MaxLength = 256;
            this.TextBoxCC.Name = "TextBoxCC";
            this.TextBoxCC.Size = new System.Drawing.Size(502, 26);
            this.TextBoxCC.TabIndex = 14;
            // 
            // CheckBoxCC
            // 
            this.CheckBoxCC.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckBoxCC.Location = new System.Drawing.Point(8, 145);
            this.CheckBoxCC.Margin = new System.Windows.Forms.Padding(4);
            this.CheckBoxCC.Name = "CheckBoxCC";
            this.CheckBoxCC.Padding = new System.Windows.Forms.Padding(4);
            this.CheckBoxCC.Size = new System.Drawing.Size(26, 26);
            this.CheckBoxCC.TabIndex = 13;
            this.CheckBoxCC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckBoxCC.UseVisualStyleBackColor = true;
            this.CheckBoxCC.CheckedChanged += new System.EventHandler(this.CheckBoxCC_CheckedChanged);
            // 
            // LabelCC
            // 
            this.LabelCC.Location = new System.Drawing.Point(42, 144);
            this.LabelCC.Margin = new System.Windows.Forms.Padding(4);
            this.LabelCC.Name = "LabelCC";
            this.LabelCC.Padding = new System.Windows.Forms.Padding(4);
            this.LabelCC.Size = new System.Drawing.Size(46, 26);
            this.LabelCC.TabIndex = 107;
            this.LabelCC.Text = "CC:";
            this.LabelCC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxBC
            // 
            this.TextBoxBC.Enabled = false;
            this.TextBoxBC.Location = new System.Drawing.Point(96, 178);
            this.TextBoxBC.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxBC.MaxLength = 256;
            this.TextBoxBC.Name = "TextBoxBC";
            this.TextBoxBC.Size = new System.Drawing.Size(502, 26);
            this.TextBoxBC.TabIndex = 16;
            // 
            // CheckBoxBC
            // 
            this.CheckBoxBC.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckBoxBC.Location = new System.Drawing.Point(8, 179);
            this.CheckBoxBC.Margin = new System.Windows.Forms.Padding(4);
            this.CheckBoxBC.Name = "CheckBoxBC";
            this.CheckBoxBC.Padding = new System.Windows.Forms.Padding(4);
            this.CheckBoxBC.Size = new System.Drawing.Size(26, 26);
            this.CheckBoxBC.TabIndex = 15;
            this.CheckBoxBC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckBoxBC.UseVisualStyleBackColor = true;
            this.CheckBoxBC.CheckedChanged += new System.EventHandler(this.CheckBoxBCC_CheckedChanged);
            // 
            // LabelBC
            // 
            this.LabelBC.Location = new System.Drawing.Point(42, 178);
            this.LabelBC.Margin = new System.Windows.Forms.Padding(4);
            this.LabelBC.Name = "LabelBC";
            this.LabelBC.Padding = new System.Windows.Forms.Padding(4);
            this.LabelBC.Size = new System.Drawing.Size(46, 26);
            this.LabelBC.TabIndex = 108;
            this.LabelBC.Text = "BC:";
            this.LabelBC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxSubject
            // 
            this.TextBoxSubject.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TextBoxSubject.Location = new System.Drawing.Point(146, 212);
            this.TextBoxSubject.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxSubject.MaxLength = 256;
            this.TextBoxSubject.Name = "TextBoxSubject";
            this.TextBoxSubject.Size = new System.Drawing.Size(452, 26);
            this.TextBoxSubject.TabIndex = 18;
            // 
            // CheckBoxSubject
            // 
            this.CheckBoxSubject.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckBoxSubject.Checked = true;
            this.CheckBoxSubject.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxSubject.Location = new System.Drawing.Point(8, 213);
            this.CheckBoxSubject.Margin = new System.Windows.Forms.Padding(4);
            this.CheckBoxSubject.Name = "CheckBoxSubject";
            this.CheckBoxSubject.Padding = new System.Windows.Forms.Padding(4);
            this.CheckBoxSubject.Size = new System.Drawing.Size(26, 26);
            this.CheckBoxSubject.TabIndex = 17;
            this.CheckBoxSubject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckBoxSubject.UseVisualStyleBackColor = true;
            this.CheckBoxSubject.CheckedChanged += new System.EventHandler(this.CheckBoxSubject_CheckedChanged);
            // 
            // LabelSubject
            // 
            this.LabelSubject.Location = new System.Drawing.Point(42, 212);
            this.LabelSubject.Margin = new System.Windows.Forms.Padding(4);
            this.LabelSubject.Name = "LabelSubject";
            this.LabelSubject.Padding = new System.Windows.Forms.Padding(4);
            this.LabelSubject.Size = new System.Drawing.Size(96, 26);
            this.LabelSubject.TabIndex = 109;
            this.LabelSubject.Text = "Subject:";
            this.LabelSubject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxBody
            // 
            this.TextBoxBody.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TextBoxBody.Location = new System.Drawing.Point(116, 246);
            this.TextBoxBody.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxBody.MaxLength = 32768;
            this.TextBoxBody.Multiline = true;
            this.TextBoxBody.Name = "TextBoxBody";
            this.TextBoxBody.Size = new System.Drawing.Size(482, 134);
            this.TextBoxBody.TabIndex = 20;
            // 
            // CheckBoxBody
            // 
            this.CheckBoxBody.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckBoxBody.Checked = true;
            this.CheckBoxBody.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxBody.Location = new System.Drawing.Point(8, 247);
            this.CheckBoxBody.Margin = new System.Windows.Forms.Padding(4);
            this.CheckBoxBody.Name = "CheckBoxBody";
            this.CheckBoxBody.Padding = new System.Windows.Forms.Padding(4);
            this.CheckBoxBody.Size = new System.Drawing.Size(26, 26);
            this.CheckBoxBody.TabIndex = 19;
            this.CheckBoxBody.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckBoxBody.UseVisualStyleBackColor = true;
            this.CheckBoxBody.CheckedChanged += new System.EventHandler(this.CheckBoxBody_CheckedChanged);
            // 
            // LabelBody
            // 
            this.LabelBody.Location = new System.Drawing.Point(42, 246);
            this.LabelBody.Margin = new System.Windows.Forms.Padding(4);
            this.LabelBody.Name = "LabelBody";
            this.LabelBody.Padding = new System.Windows.Forms.Padding(4);
            this.LabelBody.Size = new System.Drawing.Size(66, 26);
            this.LabelBody.TabIndex = 110;
            this.LabelBody.Text = "Body:";
            this.LabelBody.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureBoxAuthor
            // 
            this.PictureBoxAuthor.Image = global::SMTPer.SMTPer.Author;
            this.PictureBoxAuthor.Location = new System.Drawing.Point(8, 280);
            this.PictureBoxAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBoxAuthor.Name = "PictureBoxAuthor";
            this.PictureBoxAuthor.Padding = new System.Windows.Forms.Padding(4);
            this.PictureBoxAuthor.Size = new System.Drawing.Size(100, 100);
            this.PictureBoxAuthor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxAuthor.TabIndex = 25;
            this.PictureBoxAuthor.TabStop = false;
            this.ToolTipMain.SetToolTip(this.PictureBoxAuthor, "Author: Tianyue Ren");
            // 
            // ButtonSend
            // 
            this.ButtonSend.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonSend.Location = new System.Drawing.Point(8, 388);
            this.ButtonSend.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonSend.Name = "ButtonSend";
            this.ButtonSend.Padding = new System.Windows.Forms.Padding(4);
            this.ButtonSend.Size = new System.Drawing.Size(100, 36);
            this.ButtonSend.TabIndex = 21;
            this.ButtonSend.Text = "Send";
            this.ButtonSend.UseVisualStyleBackColor = true;
            this.ButtonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // LabelResult
            // 
            this.LabelResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelResult.Location = new System.Drawing.Point(116, 388);
            this.LabelResult.Margin = new System.Windows.Forms.Padding(4);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Padding = new System.Windows.Forms.Padding(4);
            this.LabelResult.Size = new System.Drawing.Size(482, 36);
            this.LabelResult.TabIndex = 30;
            this.LabelResult.Text = "No Result";
            this.LabelResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTipMain.SetToolTip(this.LabelResult, "No Result");
            this.LabelResult.Click += new System.EventHandler(this.LabelResult_Show);
            this.LabelResult.DoubleClick += new System.EventHandler(this.LabelResult_Show);
            // 
            // LabelDispaly
            // 
            this.LabelDispaly.Location = new System.Drawing.Point(324, 76);
            this.LabelDispaly.Margin = new System.Windows.Forms.Padding(4);
            this.LabelDispaly.Name = "LabelDispaly";
            this.LabelDispaly.Padding = new System.Windows.Forms.Padding(4);
            this.LabelDispaly.Size = new System.Drawing.Size(96, 26);
            this.LabelDispaly.TabIndex = 105;
            this.LabelDispaly.Text = "Display:";
            this.LabelDispaly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxDisplay
            // 
            this.TextBoxDisplay.Enabled = false;
            this.TextBoxDisplay.Location = new System.Drawing.Point(428, 76);
            this.TextBoxDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxDisplay.MaxLength = 256;
            this.TextBoxDisplay.Name = "TextBoxDisplay";
            this.TextBoxDisplay.Size = new System.Drawing.Size(170, 26);
            this.TextBoxDisplay.TabIndex = 10;
            // 
            // RadioLow
            // 
            this.RadioLow.Location = new System.Drawing.Point(324, 8);
            this.RadioLow.Margin = new System.Windows.Forms.Padding(4);
            this.RadioLow.Name = "RadioLow";
            this.RadioLow.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.RadioLow.Size = new System.Drawing.Size(64, 26);
            this.RadioLow.TabIndex = 2;
            this.RadioLow.Text = "Low";
            this.RadioLow.CheckedChanged += new System.EventHandler(this.RadioPriority_CheckedChanged);
            // 
            // RadioNormal
            // 
            this.RadioNormal.Checked = true;
            this.RadioNormal.Location = new System.Drawing.Point(396, 8);
            this.RadioNormal.Margin = new System.Windows.Forms.Padding(4);
            this.RadioNormal.Name = "RadioNormal";
            this.RadioNormal.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.RadioNormal.Size = new System.Drawing.Size(94, 26);
            this.RadioNormal.TabIndex = 3;
            this.RadioNormal.TabStop = true;
            this.RadioNormal.Text = "Normal";
            this.RadioNormal.CheckedChanged += new System.EventHandler(this.RadioPriority_CheckedChanged);
            // 
            // RadioHigh
            // 
            this.RadioHigh.Location = new System.Drawing.Point(498, 8);
            this.RadioHigh.Margin = new System.Windows.Forms.Padding(4);
            this.RadioHigh.Name = "RadioHigh";
            this.RadioHigh.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.RadioHigh.Size = new System.Drawing.Size(74, 26);
            this.RadioHigh.TabIndex = 4;
            this.RadioHigh.Text = "High";
            this.RadioHigh.CheckedChanged += new System.EventHandler(this.RadioPriority_CheckedChanged);
            // 
            // ToolTipMain
            // 
            this.ToolTipMain.AutoPopDelay = 5000;
            this.ToolTipMain.InitialDelay = 200;
            this.ToolTipMain.ReshowDelay = 100;
            this.ToolTipMain.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ToolTipMain.ToolTipTitle = "SMTPer";
            // 
            // WinMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(606, 432);
            this.Controls.Add(this.RadioHigh);
            this.Controls.Add(this.RadioNormal);
            this.Controls.Add(this.RadioLow);
            this.Controls.Add(this.TextBoxDisplay);
            this.Controls.Add(this.LabelDispaly);
            this.Controls.Add(this.LabelResult);
            this.Controls.Add(this.ButtonSend);
            this.Controls.Add(this.PictureBoxAuthor);
            this.Controls.Add(this.TextBoxBody);
            this.Controls.Add(this.CheckBoxBody);
            this.Controls.Add(this.LabelBody);
            this.Controls.Add(this.TextBoxSubject);
            this.Controls.Add(this.CheckBoxSubject);
            this.Controls.Add(this.LabelSubject);
            this.Controls.Add(this.TextBoxBC);
            this.Controls.Add(this.CheckBoxBC);
            this.Controls.Add(this.LabelBC);
            this.Controls.Add(this.TextBoxCC);
            this.Controls.Add(this.CheckBoxCC);
            this.Controls.Add(this.LabelCC);
            this.Controls.Add(this.TextBoxTo);
            this.Controls.Add(this.CheckBoxTo);
            this.Controls.Add(this.TextBoxServer);
            this.Controls.Add(this.LabelServer);
            this.Controls.Add(this.LabelTo);
            this.Controls.Add(this.CheckBoxFrom);
            this.Controls.Add(this.TextBoxFrom);
            this.Controls.Add(this.LabelFrom);
            this.Controls.Add(this.TextBoxPswd);
            this.Controls.Add(this.LabelPswd);
            this.Controls.Add(this.TextBoxUsnm);
            this.Controls.Add(this.CheckBoxAuthentication);
            this.Controls.Add(this.LabelUsnm);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.MaximizeBox = false;
            this.Name = "WinMain";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMTPer";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAuthor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelUsnm;
        private System.Windows.Forms.CheckBox CheckBoxAuthentication;
        private System.Windows.Forms.TextBox TextBoxUsnm;
        private System.Windows.Forms.TextBox TextBoxPswd;
        private System.Windows.Forms.Label LabelPswd;
        private System.Windows.Forms.Label LabelFrom;
        private System.Windows.Forms.TextBox TextBoxFrom;
        private System.Windows.Forms.CheckBox CheckBoxFrom;
        private System.Windows.Forms.Label LabelTo;
        private System.Windows.Forms.Label LabelServer;
        private System.Windows.Forms.TextBox TextBoxServer;
        private System.Windows.Forms.CheckBox CheckBoxTo;
        private System.Windows.Forms.TextBox TextBoxTo;
        private System.Windows.Forms.TextBox TextBoxCC;
        private System.Windows.Forms.CheckBox CheckBoxCC;
        private System.Windows.Forms.Label LabelCC;
        private System.Windows.Forms.TextBox TextBoxBC;
        private System.Windows.Forms.CheckBox CheckBoxBC;
        private System.Windows.Forms.Label LabelBC;
        private System.Windows.Forms.TextBox TextBoxSubject;
        private System.Windows.Forms.CheckBox CheckBoxSubject;
        private System.Windows.Forms.Label LabelSubject;
        private System.Windows.Forms.TextBox TextBoxBody;
        private System.Windows.Forms.CheckBox CheckBoxBody;
        private System.Windows.Forms.Label LabelBody;
        private System.Windows.Forms.PictureBox PictureBoxAuthor;
        private System.Windows.Forms.Button ButtonSend;
        private System.Windows.Forms.Label LabelResult;
        private System.Windows.Forms.Label LabelDispaly;
        private System.Windows.Forms.TextBox TextBoxDisplay;
        private System.Windows.Forms.RadioButton RadioLow;
        private System.Windows.Forms.RadioButton RadioNormal;
        private System.Windows.Forms.RadioButton RadioHigh;
        private System.Windows.Forms.ToolTip ToolTipMain;
    }
}

