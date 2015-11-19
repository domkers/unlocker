using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;

namespace Unlocker
{
    class MouseLocation
    {
        public const int MOUSEEVENTF_MOVE = 0x0001; // 移动鼠标
        public const int MOUSEEVENTF_LEFTDOWN = 0x0002; // 模拟鼠标左键按下
        public const int MOUSEEVENTF_LEFTUP = 0x0004; // 模拟鼠标左键抬起
        public const int MOUSEEVENTF_RIGHTDOWN = 0x0008; // 模拟鼠标右键按下
        public const int MOUSEEVENTF_RIGHTUP = 0x0010; // 模拟鼠标右键抬起
        public const int MOUSEEVENTF_MIDDLEDOWN = 0x0020; // 模拟鼠标中键按下
        public const int MOUSEEVENTF_MIDDLEUP = 0x0040; // 模拟鼠标中键抬起
        public const int MOUSEEVENTF_ABSOLUTE = 0x8000; // 标示是否采用绝对坐标

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
        public bool SetCursorPos(int x, int y)
        {
            return mouse_event(MOUSEEVENTF_MOVE, x, y, 0, 0) > 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dwFlags">Long，下表中标志之一或它们的组合 </param>
        /// <param name="dx"> Long，根据MOUSEEVENTF_ABSOLUTE标志，指定x，y方向的绝对位置或相对位置 </param>
        /// <param name="dy"> Long，根据MOUSEEVENTF_ABSOLUTE标志，指定x，y方向的绝对位置或相对位置 </param>
        /// <param name="cButtons">Long，没有使用 </param>
        /// <param name="dwExtraInfo">Long，没有使用 </param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern int mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        /// <summary>
        /// 让鼠标移位，然后再还原
        /// </summary>
        /// <returns></returns>
        public bool ShakeMouse()
        {
            int x = 1;
            int y = 1;
            SetCursorPos(x, y);
            SetCursorPos(-x, -y);
            return true;
        }
    }
}
