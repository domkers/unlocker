using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Unlocker
{
    public partial class FormSettings : Form
    {
        private Schedule schedule = null;

        public FormSettings()
        {
            InitializeComponent();
            schedule = new Schedule(this.timerTask);
        }

        private void comboBoxTime_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 初始化默认候选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormSettings_Load(object sender, EventArgs e)
        {
            this.comboBoxTime.SelectedIndex = 4;
        }

        /// <summary>
        /// 确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOk_Click(object sender, EventArgs e)
        {
            doTask();
            hideSettingsWindow();
        }

        private void doTask()
        {
            int min = this.comboBoxTime.SelectedIndex + 1;
            schedule.doTask(min);
        }
        /// <summary>
        /// 隐藏窗口，显示tips提示
        /// </summary>
        private void hideSettingsWindow()
        {
            //this.Hide();
            this.notifyIconUnlocker.Visible = true;//在通知区显示Form的Icon
            this.notifyIconUnlocker.ShowBalloonTip(1000, "运行提示", "防锁屏已经开始运行", ToolTipIcon.Info);
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;//使Form不在任务栏上显示
        }

        /// <summary>
        /// 显示设置界面
        /// </summary>
        private void showSettingsWindow()
        {
            this.WindowState = FormWindowState.Normal;
            this.notifyIconUnlocker.Visible = false;
            this.ShowInTaskbar = true;
        }

        /// <summary>
        /// 点击关闭按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            doTask();
            hideSettingsWindow();
        }

        /// <summary>
        /// 任务栏右键退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItemQuit_Click(object sender, EventArgs e)
        {
            this.schedule.stopTask();
            this.notifyIconUnlocker.Visible = false;
            this.Close();
        }

        /// <summary>
        /// 双击任务栏图标，出现设置界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void notifyIconUnlocker_DoubleClick(object sender, EventArgs e)
        {
            showSettingsWindow();
        }

        /// <summary>
        /// 任务栏右键设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItemSettings_Click(object sender, EventArgs e)
        {
            showSettingsWindow();
        }

        /// <summary>
        /// 任务栏右键关于
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItemAbout_Click(object sender, EventArgs e)
        {
            new FormAbout().ShowDialog();
        }
    }
}
