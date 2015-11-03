using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;

namespace Unlocker
{
    class MouseLocation
    {
        /// <summary>
        /// 获取鼠标位置
        /// </summary>
        /// <param name="pt"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out Point pt);

        /// <summary>
        /// 设置鼠标位置
        /// </summary>
        /// <param name="pt"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern bool SetCursorPos(int x, int y);

        /// <summary>
        /// 让鼠标移位，然后再还原
        /// </summary>
        /// <returns></returns>
        public bool ShakeMouse()
        {
            Random r = new Random();
            Point point = new Point();
            GetCursorPos(out point);
            int x = point.X + r.Next(-100, 100);
            int y = point.Y + r.Next(-100, 100);
            SetCursorPos(x, y);
            SetCursorPos(point.X, point.Y);
            return true;
        }
    }
}
