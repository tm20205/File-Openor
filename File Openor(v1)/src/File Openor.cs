 using System;
 using System.Diagnostics;
 using System.IO;
 using System.Text;
 using System.Collections.Generic;
 using System.Runtime.InteropServices;
 using System.Drawing;

static class Program
{
  static void Main()
  {
    List<string> Pathlist = new List<string>();
    List<string> WindowNamelist = new List<string>();
    List<string> Applylist = new List<string>();
    List<string> debuglist = new List<string>();


            foreach (string Pathline in System.IO.File.ReadLines(@"Read_Path\Path.ini"))//ファイル数がやばくなってきたので行で分けて管理するようにしました。
            {
                Pathlist.Add(Pathline);//リストに行のパスをそれぞれ追加。
            }
            foreach (string Applyline in File.ReadLines(@"Read_Path\adjustor_Apply.ini"))
            {
                Applylist.Add(Applyline);
            }
            foreach (string debugline in File.ReadLines(@"Read_Path\debug.ini"))
            {
                debuglist.Add(debugline);
            }
            foreach (string WindowNameline in File.ReadLines(@"Read_Path\WindowName.ini"))
            {
                WindowNamelist.Add(WindowNameline);
            }

            string File1Path = Pathlist[0];
            string File2Path = Pathlist[1];
            string File3Path = Pathlist[2];
            string File4Path = Pathlist[3];
            string Program1Path = Pathlist[4];
            string Program2Path = Pathlist[5];
            string Program3Path = Pathlist[6];
            string Program4Path = Pathlist[7];

            
            string WindowName1 = WindowNamelist[0];
            string WindowName2 = WindowNamelist[1];
            string WindowName3 = WindowNamelist[2];
            string WindowName4 = WindowNamelist[3];
            string WindowName5 = WindowNamelist[4];
            string WindowName6 = WindowNamelist[5];
            string WindowName7 = WindowNamelist[6];
            string WindowName8 = WindowNamelist[7];
            

            string adjustorApply = Applylist[0];
            string doubleApply = Applylist[1];
            
            string sysdebug = debuglist[0];
    
    if (!(File1Path == @"null"))//中身が空白のとき｛｝内を動作させない。nullチェックとか言うらしい。
    {
      try
      {
        if (doubleApply == "true")
        {
            IntPtr hWnd1a = FindWindow(null, WindowName1);
            if (hWnd1a == IntPtr.Zero)
            {
                Process.Start("explorer.exe", @File1Path); // 指定したフォルダを開く。ドドコ、どこぉ？
            }
        }
        else if (doubleApply == "false")
        {
            Process.Start("explorer.exe", @File1Path); // 指定したフォルダを開く。ドドコ、どこぉ？
        }
      }catch(Exception){}
    }
    
    if(!(File2Path == @"null"))//2個目
    {
        try
        {
            if (doubleApply == "true")
            {
                IntPtr hWnd2a = FindWindow(null, WindowName2);
                if (hWnd2a == IntPtr.Zero)
                {
                    Process.Start("explorer.exe", @File2Path);
                }
                
            }
            else if (doubleApply == "false")
            {
                Process.Start("explorer.exe", @File2Path);
            }
        }catch(Exception){}
    }
    
    if(!(File3Path == @"null"))//3個目
    {
        try
        {
            if (doubleApply == "true")
            {
                IntPtr hWnd3a = FindWindow(null, WindowName3);
                if (hWnd3a == IntPtr.Zero)
                {
                    Process.Start("explorer.exe", @File3Path);
                }
                
            }
            else if (doubleApply == "false")
            {
                Process.Start("explorer.exe", @File3Path);
            }
        }catch(Exception){}
    }
    
    if(!(File4Path == @"null"))//4個目
    {
        try
        {
            if (doubleApply == "true")
            {
                IntPtr hWnd4a = FindWindow(null, WindowName4);
                if (hWnd4a == IntPtr.Zero)
                {
                    Process.Start("explorer.exe", @File4Path);
                }
                
            }
            else if (doubleApply == "false")
            {
                Process.Start("explorer.exe", @File4Path);
            }
        }catch(Exception){}
    }
    
    try//エラー吐くかもしれないってやつ
    {
        if (doubleApply == "true")
        {
            IntPtr hWnd5a = FindWindow(null, WindowName5);
            if (hWnd5a == IntPtr.Zero)
            {
                Process.Start(@Program1Path); // 指定したソフトを起動する
            }  
        }
        else if (doubleApply == "false")
        {
            Process.Start(@Program1Path); // 指定したソフトを起動する
        }
    }
    catch(Exception){}//エラー？なにそれおいしいの？
    
    try//2個目
    {
        if (doubleApply == "true")
        {
            IntPtr hWnd6a = FindWindow(null, WindowName6);
            if (hWnd6a == IntPtr.Zero)
            {
                Process.Start(@Program2Path); // 指定したソフトを起動する
            }            
        }
       else if (doubleApply == "false")
        {
            Process.Start(@Program2Path); // 指定したソフトを起動する
        }
    }
    catch(Exception){}

    try//3個目
    {
        if (doubleApply == "true")
        {
            IntPtr hWnd7a = FindWindow(null, WindowName7);
            if (hWnd7a == IntPtr.Zero)
            {
                Process.Start(@Program3Path);
            }
        }
        else if (doubleApply == "false")
        {
            Process.Start(@Program3Path);
        }
    }
    catch(Exception){}

    try//4個目
    {
        if (doubleApply == "true")
        {
            IntPtr hWnd8a = FindWindow(null, WindowName8);
            if (hWnd8a == IntPtr.Zero)
            {
                Process.Start(@Program4Path);
            }
        }
        else if (doubleApply == "false")
        {
            Process.Start(@Program4Path);
        }
    }
    catch(Exception){}
    
    finally//エラーかエラか知らねぇがこいつだけは実行してやる！！
    {
        if (adjustorApply == "true" && sysdebug == "false")
        {
            Process.Start(@"adjustor.exe"); // 位置調整用プログラム起動
        }
        else if (adjustorApply == "true" && sysdebug == "true")
        {
            Process.Start(@"adjustor_debug.exe");
        }
    }
  }
  [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
      public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
}