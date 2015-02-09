using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;
using System.Windows.Forms;

namespace Evil_Operator
{
    /*[StructLayout(LayoutKind.Sequential)]
    public struct RECT
    {
        public int Left;
        public int Top;
        public int Right;
        public int Bottom;
    }*/
    class Mouse
    {
        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int X, int Y);


        [DllImport("user32.dll", CharSet = CharSet.Auto),]
        public static extern int SystemParametersInfo(uint uiAction, uint uiParam, uint pvParam, uint fWinIni);

        Rectangle screenRect = new Rectangle();
        public int speed = -1;
        public int smax = -1;
        public int smin = -1;
        public int lrpulse = -1;

        int currentX = 0;
        int currentY = 0;

        public bool sgrade = false;
        public bool srandom = false;
        public bool lrandom = false;
        public bool lscanx = false;
        public bool lscany = false;
        public bool linvX = false;
        public bool livnY = false;
        public bool scanOn = false;

        int scanRate = 1;

        public Mouse()
        {
            screenRect.Height = Screen.PrimaryScreen.Bounds.Height;
            screenRect.Width = Screen.PrimaryScreen.Bounds.Width;
            Console.WriteLine(screenRect.Height);
        }

        public void Start()
        {
            StartScan();
        }

       
        public void ApplyMouseSpeed(int speed)
        {
            int res = SystemParametersInfo(113, 0,(uint) speed, 0);
        }

        public void StartScan()
        {
            bool sinv = false;
        
            while (this != null)
            {
                Scan();
                Thread.Sleep(1);

            }


            //Speed Calculations
            while(this != null)
            {
                if(srandom)
                {
                    Random rnd = new Random();
                    speed = rnd.Next(20);
                    Thread.Sleep(100);
                }


                if(sgrade)
                {
                    if (lscanx)
                    {
                        if (sinv) { speed--; }
                        if (!sinv) { speed++; }
                        if (speed == smin)
                        {
                            sinv = false;
                        }
                        if (smax <= speed)
                        {
                            sinv = true;
                        }
                    }
                }
                Thread.Sleep(10);
            }
        }

           

        public void Scan()
        {
            if(lscanx)
            {
                if (linvX) { currentX--; }
                if (!linvX) { currentX++; }
                if (currentX == 0)
                {
                    linvX = false;
                }
                if (screenRect.Width - 10 <= currentX)
                {
                    linvX = true;
                }

                if (lscanx)
                {
                    SetCursorPos(currentX * 2, Cursor.Position.Y);
                }
            }
            if(lscany)
            {
                if (livnY) { currentY--; }
                if (!livnY) { currentY++; }
                if (currentY == 0)
                {
                    livnY = false;
                }
                if (screenRect.Height - 10 <= currentY)
                {
                    livnY = true;
                }
                if (lscany)
                {
                    SetCursorPos(Cursor.Position.X * 2, currentY);
                }
            }
        }
    }
}

