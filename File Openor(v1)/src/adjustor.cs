 using System;
 using System.Diagnostics;
 using System.Threading;
 using System.Runtime.InteropServices;
 using System.Collections.Generic;
 using System.IO;
 using System.Text;

 
 
 namespace WindowsFormsApp1
 {
  static class Program
  {
    [STAThread]
    static void Main()
    {
      List<string> WindowNamelist = new List<string>();
      List<string> settinglist = new List<string>();


      foreach (string WindowNameline in File.ReadLines(@"Read_Path\WindowName.ini"))//ファイル数がやばくなってきたので行で分けて管理するようにしました。
      {
          WindowNamelist.Add(WindowNameline);//リストにそれぞれの行のウィンドウタイトルを追加。
      }
      foreach (string settingline in File.ReadLines(@"Read_Path\adjustor_setting.ini"))
      {
          settinglist.Add(settingline);
      }

      string WindowName1 = WindowNamelist[0];
      string WindowName2 = WindowNamelist[1];
      string WindowName3 = WindowNamelist[2];
      string WindowName4 = WindowNamelist[3];
      string WindowName5 = WindowNamelist[4];
      string WindowName6 = WindowNamelist[5];
      string WindowName7 = WindowNamelist[6];
      string WindowName8 = WindowNamelist[7];
      int x1 = Convert.ToInt32(settinglist[0]);
      int y1 = Convert.ToInt32(settinglist[1]);
      int w1 = Convert.ToInt32(settinglist[2]);
      int h1 = Convert.ToInt32(settinglist[3]);
      int x2 = Convert.ToInt32(settinglist[4]);
      int y2 = Convert.ToInt32(settinglist[5]);
      int w2 = Convert.ToInt32(settinglist[6]);
      int h2 = Convert.ToInt32(settinglist[7]);
      int x3 = Convert.ToInt32(settinglist[8]);
      int y3 = Convert.ToInt32(settinglist[9]);
      int w3 = Convert.ToInt32(settinglist[10]);
      int h3 = Convert.ToInt32(settinglist[11]);
      int x4 = Convert.ToInt32(settinglist[12]);
      int y4 = Convert.ToInt32(settinglist[13]);
      int w4 = Convert.ToInt32(settinglist[14]);
      int h4 = Convert.ToInt32(settinglist[15]);
      int x5 = Convert.ToInt32(settinglist[16]);
      int y5 = Convert.ToInt32(settinglist[17]);
      int w5 = Convert.ToInt32(settinglist[18]);
      int h5 = Convert.ToInt32(settinglist[19]);
      int x6 = Convert.ToInt32(settinglist[20]);
      int y6 = Convert.ToInt32(settinglist[21]);
      int w6 = Convert.ToInt32(settinglist[22]);
      int h6 = Convert.ToInt32(settinglist[23]);
      int x7 = Convert.ToInt32(settinglist[24]);
      int y7 = Convert.ToInt32(settinglist[25]);
      int w7 = Convert.ToInt32(settinglist[26]);
      int h7 = Convert.ToInt32(settinglist[27]);
      int x8 = Convert.ToInt32(settinglist[28]);
      int y8 = Convert.ToInt32(settinglist[29]);
      int w8 = Convert.ToInt32(settinglist[30]);
      int h8 = Convert.ToInt32(settinglist[31]);
      int Looptime = Convert.ToInt32(settinglist[32]);

      int count1 = 0;
      int count2 = 0;
      int count3 = 0;
      int count4 = 0;
      int count5 = 0;
      int count6 = 0;
      int count7 = 0;
      int count8 = 0;

      int WNcount1 = 0;
      int WNcount2 = 0;
      int WNcount3 = 0;
      int WNcount4 = 0;
      int WNcount5 = 0;
      int WNcount6 = 0;
      int WNcount7 = 0;
      int WNcount8 = 0;


      if (Looptime == 0)
      {
            if (WindowName1 != @"null")
            {
              IntPtr hWnd1a = FindWindow(null, WindowName1);
              Thread.Sleep(1);
              ShowWindow(hWnd1a, 1);
              SetForegroundWindow(hWnd1a);
              MoveWindow(hWnd1a, x1, y1, w1, h1, 1);
            }

          if (WindowName2 != @"null")
          {
            IntPtr hWnd2a = FindWindow(null, WindowName2);
            Thread.Sleep(1);
            ShowWindow(hWnd2a, 1);
            SetForegroundWindow(hWnd2a);
            MoveWindow(hWnd2a, x2, y2, w2, h2, 1);
          }

          if (WindowName3 != @"null")
          {
            IntPtr hWnd3a = FindWindow(null, WindowName3);
            Thread.Sleep(1);
            ShowWindow(hWnd3a, 1);
            SetForegroundWindow(hWnd3a);
            MoveWindow(hWnd3a, x3, y3, w3, h3, 1);
          }
          
          if (WindowName4 != @"null")
          {
            IntPtr hWnd4a = FindWindow(null, WindowName4);
            Thread.Sleep(1);
            ShowWindow(hWnd4a, 1);
            SetForegroundWindow(hWnd4a);
            MoveWindow(hWnd4a, x4, y4, w4, h4, 1);
          }
          
          if (WindowName5 != @"null")
          {
            IntPtr hWnd5a = FindWindow(null, WindowName5);
            Thread.Sleep(1);
            ShowWindow(hWnd5a, 1);
            SetForegroundWindow(hWnd5a);
            MoveWindow(hWnd5a, x5, y5, w5, h5, 1);
          }
          
          if (WindowName6 != @"null")
          {
            IntPtr hWnd6a = FindWindow(null, WindowName6);
            Thread.Sleep(1);
            ShowWindow(hWnd6a, 1);
            SetForegroundWindow(hWnd6a);
            MoveWindow(hWnd6a, x6, y6, w6, h6, 1);
          }
          
          if (WindowName7 != @"null")
          {
            IntPtr hWnd7a = FindWindow(null, WindowName7);
            Thread.Sleep(1);
            ShowWindow(hWnd7a, 1);
            SetForegroundWindow(hWnd7a);
            MoveWindow(hWnd7a, x7, y7, w7, h7, 1);
          }
          
          if (WindowName8 != @"null")
          {
            IntPtr hWnd8a = FindWindow(null, WindowName8);
            Thread.Sleep(1);
            ShowWindow(hWnd8a, 1);
            SetForegroundWindow(hWnd8a);
            MoveWindow(hWnd8a, x8, y8, w8, h8, 1);
          }
          
      }
      else if (Looptime != 0)
      {
        while (true)
        {

          if(!(WindowName1 == @"null") && count1 == 0) //1個め
          {
            IntPtr hWnd1bS = FindWindow(null, WindowName1);
            if (hWnd1bS != IntPtr.Zero && count1 == 0)
             {
                  IntPtr hWnd1b = FindWindow(null, WindowName1);
                  ShowWindow(hWnd1b, 1);
                  MoveWindow(hWnd1b, x1, y1, w1, h1, 1);
                  count1 = 1;
             }
          }
          else if (WindowName1 == @"null" && count1 == 0)
          {
            count1 = 2;
            WNcount1 = 2;
          }

          if(!(WindowName2 == @"null") && count2 == 0) //2個め
          {
                  IntPtr hWnd2bS = FindWindow(null, WindowName2);
                  if (!(hWnd2bS == IntPtr.Zero) && count2 == 0)
                  {
                      IntPtr hWnd2b = FindWindow(null, WindowName2);
                      ShowWindow(hWnd2b, 1);
                      MoveWindow(hWnd2b, x2, y2, w2, h2, 1);
                      count2 = 1;
                  }
          }
          else if (WindowName2 == @"null" && count2 == 0)
          {
            count2 = 2;
            WNcount2 = 2;  
          }

          if(!(WindowName3 == @"null") && count3 == 0) //3個め
          {
                IntPtr hWnd3bS = FindWindow(null, WindowName3);
                if (!(hWnd3bS == IntPtr.Zero) && count3 == 0)
                {
                      IntPtr hWnd3b = FindWindow(null, WindowName3);
                      ShowWindow(hWnd3b, 1);
                      MoveWindow(hWnd3b, x3, y3, w3, h3, 1);
                      count3 = 1;
                }
          }
          else if (WindowName3 == @"null" && count3 == 0)
          {
            count3 = 2;
            WNcount3 = 2;
          }

          if(!(WindowName4 == @"null") && count4 == 0) //4個目
          {
                IntPtr hWnd4bS = FindWindow(null, WindowName4);
                if (!(hWnd4bS == IntPtr.Zero) && count4 == 0)
                {
                      IntPtr hWnd4b = FindWindow(null, WindowName4);
                      ShowWindow(hWnd4b, 1);
                      MoveWindow(hWnd4b, x4, y4, w4, h4, 1);
                      count4 = 1;
                }
          }
          else if (WindowName4 == @"null" && count4 == 0)
          {
            count4 = 2;
            WNcount4 = 2;
          }

          if(!(WindowName5 == @"null") && count5 == 0) //5個目
          {
                IntPtr hWnd5bS = FindWindow(null, WindowName5);
                if (!(hWnd5bS == IntPtr.Zero) && count5 == 0)
                {
                    IntPtr hWnd5b = FindWindow(null, WindowName5);
                    ShowWindow(hWnd5b, 1);
                    MoveWindow(hWnd5b, x5, y5, w5, h5, 1);
                    count5 = 1;
                }
          }
          else if (WindowName5 == @"null" && count5 == 0)
          {
            count5 = 2;
            WNcount5 = 2;
          }

          if(!(WindowName6 == @"null") && count6 == 0)
          {
                IntPtr hWnd6bS = FindWindow(null, WindowName6);
                if (!(hWnd6bS == IntPtr.Zero))
                {
                    IntPtr hWnd6b = FindWindow(null, WindowName6);
                    ShowWindow(hWnd6b, 1);
                    MoveWindow(hWnd6b, x6, y6, w6, h6, 1);
                    count6 = 1;
                }
          }
          else if (WindowName6 == @"null" && count6 == 0)
          {
            count6 = 2;
            WNcount6 = 2;
          }

          if (!(WindowName7 == @"null") && count7 == 0)
          {
                IntPtr hWnd7bS = FindWindow(null, WindowName7);
                if (!(hWnd7bS == IntPtr.Zero) && count7 == 0)
                {
                    IntPtr hWnd7b = FindWindow(null, WindowName7);
                    ShowWindow(hWnd7b, 1);
                    MoveWindow(hWnd7b, x7, y7, w7, h7, 1);
                    count7 = 1;
                }
          }
          else if (WindowName7 == @"null" && count7 == 0)
          {
            count7 = 2;
            WNcount7 = 2;
          }

          if(!(WindowName8 == @"null") && count8 == 0)
          {
                IntPtr hWnd8bS = FindWindow(null, WindowName8);
                if (!(hWnd8bS == IntPtr.Zero) && count8 == 0)
                {
                    IntPtr hWnd8b = FindWindow(null, WindowName8);
                    ShowWindow(hWnd8b, 1);
                    MoveWindow(hWnd8b, x8, y8, w8, h8, 1);
                    count8 = 1;
                }
          }
          else if (WindowName8 == @"null" && count8 == 0)
          {
            count8 = 2;
            WNcount8 = 2;
          }
          
          if (count1 == 1 && WNcount1 == 0)
          {
            IntPtr hWnd1bS = FindWindow(null, WindowName1);
            var WT1checkTOP = SetWindowPos(hWnd1bS, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE);
            var WT1checkNOTOP = SetWindowPos(hWnd1bS, HWND_NOTOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE | SWP_SHOWWINDOW);
            SetForegroundWindow(hWnd1bS);
            if (WT1checkTOP && WT1checkNOTOP)
            {
              WNcount1 = 1;
            }
          }
          if (count2 == 1 && WNcount2 == 0)
          {
            IntPtr hWnd2bS = FindWindow(null, WindowName2);
            var WT2checkTOP = SetWindowPos(hWnd2bS, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE);
            var WT2checkNOTOP = SetWindowPos(hWnd2bS, HWND_NOTOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE | SWP_SHOWWINDOW);
            SetForegroundWindow(hWnd2bS);
            if (WT2checkTOP && WT2checkNOTOP)
            {
              WNcount2 = 1;
            }
          }
          if (count3 == 1 && WNcount3 == 0)
          {
            IntPtr hWnd3bS = FindWindow(null, WindowName3);
            var WT3checkTOP = SetWindowPos(hWnd3bS, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE);
            var WT3checkNOTOP = SetWindowPos(hWnd3bS, HWND_NOTOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE | SWP_SHOWWINDOW);
            SetForegroundWindow(hWnd3bS);
            if (WT3checkTOP && WT3checkNOTOP)
            {
              WNcount3 = 1;
            }
          }
          if (count4 == 1 && WNcount4 == 0)
          {
            IntPtr hWnd4bS = FindWindow(null, WindowName4);
            var WT4checkTOP = SetWindowPos(hWnd4bS, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE);
            var WT4checkNOTOP = SetWindowPos(hWnd4bS, HWND_NOTOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE | SWP_SHOWWINDOW);
            SetForegroundWindow(hWnd4bS);
            if (WT4checkTOP && WT4checkNOTOP)
            {
              WNcount4 = 1;
            }
          }
          if (count5 == 1 && WNcount5 == 0)
          {
            IntPtr hWnd5bS = FindWindow(null, WindowName5);
            var WT5checkTOP = SetWindowPos(hWnd5bS, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE);
            var WT5checkNOTOP = SetWindowPos(hWnd5bS, HWND_NOTOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE | SWP_SHOWWINDOW);
            SetForegroundWindow(hWnd5bS);
            if (WT5checkTOP && WT5checkNOTOP)
            {
              WNcount5 = 1;
            }
          }
          if (count6 == 1 && WNcount6 == 0)
          {
            IntPtr hWnd6bS = FindWindow(null, WindowName6);
            var WT6checkTOP = SetWindowPos(hWnd6bS, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE);
            var WT6checkNOTOP = SetWindowPos(hWnd6bS, HWND_NOTOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE | SWP_SHOWWINDOW);
            SetForegroundWindow(hWnd6bS);
            if (WT6checkTOP && WT6checkNOTOP)
            {
              WNcount6 = 1;
            }
          }
          if (count7 == 1 && WNcount7 == 0)
          {
            IntPtr hWnd7bS = FindWindow(null, WindowName7);
            var WT7checkTOP = SetWindowPos(hWnd7bS, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE);
            var WT7checkNOTOP = SetWindowPos(hWnd7bS, HWND_NOTOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE | SWP_SHOWWINDOW);
            SetForegroundWindow(hWnd7bS);
            if (WT7checkTOP && WT7checkNOTOP)
            {
              WNcount7 = 1;
            }
          }
          if (count8 == 1 && WNcount8 == 0)
          {
            IntPtr hWnd8bS = FindWindow(null, WindowName8);
            var WT8checkTOP = SetWindowPos(hWnd8bS, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE);
            var WT8checkNOTOP = SetWindowPos(hWnd8bS, HWND_NOTOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE | SWP_SHOWWINDOW);
            SetForegroundWindow(hWnd8bS);
            if (WT8checkTOP && WT8checkNOTOP)
            {
              WNcount8 = 1;
            }
          }
          
          if (count1 > 0 && count2 > 0 && count3 > 0 && count4 > 0 && count5 > 0 && count6 > 0 && count7 > 0 && count8 > 0 &&
           WNcount1 > 0 && WNcount2 > 0 && WNcount3 > 0 && WNcount4 > 0 && WNcount5 > 0 && WNcount6 > 0 && WNcount7 > 0 && WNcount8 > 0)
          {
            break;
          }
          else
          {Thread.Sleep(Looptime);}
        }
      }
    }
    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
      public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
    [DllImport("user32.dll")]
      private static extern int MoveWindow(IntPtr hwnd, int x, int y, int nWidth,int nHeight, int bRepaint);
    [DllImport("User32.Dll")]
      public static extern long ShowWindow(IntPtr hWnd /* 送信先ウィンドウのハンドル */, uint nCmdShow /* メッセージ*/);
    [DllImport("user32.dll", SetLastError = true)]
      [return: MarshalAs(UnmanagedType.Bool)]
      private static extern bool SetWindowPos (IntPtr hWnd, int hWndInsertAfter, int x, int y, int cx, int cy, int uFlags);
      private const int SWP_NOSIZE = 0x0001;
      private const int SWP_NOMOVE = 0x0002;
      private const int SWP_SHOWWINDOW = 0x0040;
      private const int HWND_TOPMOST = -1;
      private const int HWND_NOTOPMOST = -2;

    [DllImport("user32.dll")]
      private static extern bool SetForegroundWindow(IntPtr hWnd);
}
}