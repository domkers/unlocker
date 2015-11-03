using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;

namespace Unlocker
{
    
    class Schedule
    {
        private Timer timer = null;
        private MouseLocation mouseLocation = null;

        public Schedule(Timer timer)
        {
            this.timer = timer;
            this.timer.Tick += timer_Tick;
            this.mouseLocation = new MouseLocation();
        }

        /// <summary>
        /// 间隔时间做的事情
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void timer_Tick(object sender, EventArgs e)
        {
            mouseLocation.ShakeMouse();
        }

        /// <summary>
        /// 执行调度
        /// </summary>
        /// <param name="minitues">分钟数</param>
        public void doTask(int minitues)
        {
            int miliseconds = minitues  * 1000;
            if (timer != null && timer.Enabled)
            {
                timer.Stop();
            }
            timer.Interval = miliseconds;
            timer.Enabled = true;
            timer.Start();
        }

        /// <summary>
        /// 停止任务
        /// </summary>
        public void stopTask()
        {
            if (timer != null)
            {
                timer.Stop();
            }
            timer = null;
        }
    }
}
