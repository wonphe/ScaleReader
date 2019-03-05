namespace ScaleReader
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDatabits = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ddlParity = new System.Windows.Forms.ComboBox();
            this.ddlStopbits = new System.Windows.Forms.ComboBox();
            this.gbParams = new System.Windows.Forms.GroupBox();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.ddlBaudrate = new System.Windows.Forms.ComboBox();
            this.ddlPort = new System.Windows.Forms.ComboBox();
            this.gbParams.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "串口";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "波特率";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "数据位";
            // 
            // txtDatabits
            // 
            this.txtDatabits.Location = new System.Drawing.Point(80, 82);
            this.txtDatabits.Name = "txtDatabits";
            this.txtDatabits.Size = new System.Drawing.Size(212, 21);
            this.txtDatabits.TabIndex = 1;
            this.txtDatabits.Text = "8";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "奇偶校验";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "停止位";
            // 
            // ddlParity
            // 
            this.ddlParity.BackColor = System.Drawing.SystemColors.Window;
            this.ddlParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlParity.FormattingEnabled = true;
            this.ddlParity.Items.AddRange(new object[] {
            "None|不发生奇偶校验检查",
            "Odd|设置奇偶校验位,使位数等于奇数",
            "Even|设置奇偶校验位,使位数等于偶数",
            "Mark|将奇偶校验位保留为1",
            "Space|将奇偶校验位保留为0"});
            this.ddlParity.Location = new System.Drawing.Point(80, 109);
            this.ddlParity.Name = "ddlParity";
            this.ddlParity.Size = new System.Drawing.Size(212, 20);
            this.ddlParity.TabIndex = 2;
            // 
            // ddlStopbits
            // 
            this.ddlStopbits.BackColor = System.Drawing.SystemColors.Window;
            this.ddlStopbits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlStopbits.FormattingEnabled = true;
            this.ddlStopbits.Items.AddRange(new object[] {
            "None|不使用停止位",
            "One|使用一个停止位",
            "Two|使用两个停止位",
            "OnePointFive|使用 1.5 个停止位"});
            this.ddlStopbits.Location = new System.Drawing.Point(80, 136);
            this.ddlStopbits.Name = "ddlStopbits";
            this.ddlStopbits.Size = new System.Drawing.Size(212, 20);
            this.ddlStopbits.TabIndex = 2;
            // 
            // gbParams
            // 
            this.gbParams.Controls.Add(this.ddlPort);
            this.gbParams.Controls.Add(this.ddlBaudrate);
            this.gbParams.Controls.Add(this.ddlStopbits);
            this.gbParams.Controls.Add(this.label1);
            this.gbParams.Controls.Add(this.ddlParity);
            this.gbParams.Controls.Add(this.label5);
            this.gbParams.Controls.Add(this.label2);
            this.gbParams.Controls.Add(this.label4);
            this.gbParams.Controls.Add(this.txtDatabits);
            this.gbParams.Controls.Add(this.label3);
            this.gbParams.Location = new System.Drawing.Point(12, 12);
            this.gbParams.Name = "gbParams";
            this.gbParams.Size = new System.Drawing.Size(310, 179);
            this.gbParams.TabIndex = 3;
            this.gbParams.TabStop = false;
            this.gbParams.Text = "参数";
            // 
            // btnStartStop
            // 
            this.btnStartStop.Location = new System.Drawing.Point(246, 198);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(75, 43);
            this.btnStartStop.TabIndex = 4;
            this.btnStartStop.Text = "开始";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // ddlBaudrate
            // 
            this.ddlBaudrate.BackColor = System.Drawing.SystemColors.Window;
            this.ddlBaudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlBaudrate.FormattingEnabled = true;
            this.ddlBaudrate.Items.AddRange(new object[] {
            "9600",
            "1200",
            "2400",
            "4800",
            "19200",
            "38400",
            "57600",
            "11520"});
            this.ddlBaudrate.Location = new System.Drawing.Point(80, 55);
            this.ddlBaudrate.Name = "ddlBaudrate";
            this.ddlBaudrate.Size = new System.Drawing.Size(212, 20);
            this.ddlBaudrate.TabIndex = 3;
            // 
            // ddlPort
            // 
            this.ddlPort.BackColor = System.Drawing.SystemColors.Window;
            this.ddlPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlPort.FormattingEnabled = true;
            this.ddlPort.Location = new System.Drawing.Point(80, 28);
            this.ddlPort.Name = "ddlPort";
            this.ddlPort.Size = new System.Drawing.Size(212, 20);
            this.ddlPort.TabIndex = 3;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 250);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.gbParams);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "电子秤读取";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.gbParams.ResumeLayout(false);
            this.gbParams.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDatabits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ddlParity;
        private System.Windows.Forms.ComboBox ddlStopbits;
        private System.Windows.Forms.GroupBox gbParams;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.ComboBox ddlBaudrate;
        private System.Windows.Forms.ComboBox ddlPort;
    }
}

