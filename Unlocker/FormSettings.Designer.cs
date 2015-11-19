namespace Unlocker
{
    partial class FormSettings
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.buttonOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTime = new System.Windows.Forms.ComboBox();
            this.notifyIconUnlocker = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.timerTask = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStripNotify.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(136, 114);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "确定";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "间隔时间：";
            // 
            // comboBoxTime
            // 
            this.comboBoxTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTime.FormattingEnabled = true;
            this.comboBoxTime.Items.AddRange(new object[] {
            "1分钟",
            "2分钟",
            "3分钟",
            "4分钟",
            "5分钟",
            "6分钟"});
            this.comboBoxTime.Location = new System.Drawing.Point(157, 38);
            this.comboBoxTime.Name = "comboBoxTime";
            this.comboBoxTime.Size = new System.Drawing.Size(121, 20);
            this.comboBoxTime.TabIndex = 2;
            this.comboBoxTime.SelectedIndexChanged += new System.EventHandler(this.comboBoxTime_SelectedIndexChanged);
            // 
            // notifyIconUnlocker
            // 
            this.notifyIconUnlocker.BalloonTipText = "防锁已经开始运行";
            this.notifyIconUnlocker.BalloonTipTitle = "开始运行";
            this.notifyIconUnlocker.ContextMenuStrip = this.contextMenuStripNotify;
            this.notifyIconUnlocker.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconUnlocker.Icon")));
            this.notifyIconUnlocker.Text = "Unlocker";
            this.notifyIconUnlocker.Visible = true;
            this.notifyIconUnlocker.DoubleClick += new System.EventHandler(this.notifyIconUnlocker_DoubleClick);
            // 
            // contextMenuStripNotify
            // 
            this.contextMenuStripNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSettings,
            this.toolStripMenuItemAbout,
            this.toolStripMenuItemQuit});
            this.contextMenuStripNotify.Name = "contextMenuStripNotify";
            this.contextMenuStripNotify.Size = new System.Drawing.Size(119, 70);
            this.contextMenuStripNotify.Text = "打开设置";
            // 
            // toolStripMenuItemSettings
            // 
            this.toolStripMenuItemSettings.Name = "toolStripMenuItemSettings";
            this.toolStripMenuItemSettings.Size = new System.Drawing.Size(118, 22);
            this.toolStripMenuItemSettings.Text = "设置(&S)";
            this.toolStripMenuItemSettings.Click += new System.EventHandler(this.toolStripMenuItemSettings_Click);
            // 
            // toolStripMenuItemAbout
            // 
            this.toolStripMenuItemAbout.Name = "toolStripMenuItemAbout";
            this.toolStripMenuItemAbout.Size = new System.Drawing.Size(118, 22);
            this.toolStripMenuItemAbout.Text = "关于(&A)";
            this.toolStripMenuItemAbout.Click += new System.EventHandler(this.toolStripMenuItemAbout_Click);
            // 
            // toolStripMenuItemQuit
            // 
            this.toolStripMenuItemQuit.Name = "toolStripMenuItemQuit";
            this.toolStripMenuItemQuit.Size = new System.Drawing.Size(118, 22);
            this.toolStripMenuItemQuit.Text = "退出(&Q)";
            this.toolStripMenuItemQuit.Click += new System.EventHandler(this.toolStripMenuItemQuit_Click);
            // 
            // FormSettings
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 169);
            this.Controls.Add(this.comboBoxTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unlocker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSettings_FormClosing);
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.contextMenuStripNotify.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTime;
        private System.Windows.Forms.NotifyIcon notifyIconUnlocker;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNotify;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSettings;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbout;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemQuit;
        private System.Windows.Forms.Timer timerTask;
    }
}

