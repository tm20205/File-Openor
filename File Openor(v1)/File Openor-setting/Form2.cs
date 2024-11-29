using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Openor_setting
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            List<string> WindowNamelist = new List<string>();
            List<string> settinglist = new List<string>();
            List<string> Applylist = new List<string>();

            foreach (string WindowNameline in File.ReadLines(@"Read_Path\WindowName.ini"))//ファイル数がやばくなってきたので行で分けて管理するようにしました。
            {
                WindowNamelist.Add(WindowNameline);//リストにそれぞれの行のウィンドウタイトルを追加。
            }
            foreach (string settingline in File.ReadLines(@"Read_Path\adjustor_setting.ini"))
            {
                settinglist.Add(settingline);
            }
            foreach (string Applyline in File.ReadLines(@"Read_Path\adjustor_Apply.ini"))
            {
                Applylist.Add(Applyline);

            }
            string foregroundApplyR = Applylist[1];

            if (foregroundApplyR == "true")
            {
                label16.Text = "多重起動防止（現在有効）";
                button3.Text = "無効化";
            }
            else if (foregroundApplyR == "false")
            {
                label16.Text = "多重起動防止（現在無効）";
                button3.Text = "有効化";
            }

            try
            {
                if (!(WindowNamelist[0] == @"null"))
                {
                    WindowName1.Text = WindowNamelist[0];
                }
            }catch { }
            try
            {
                if (!(WindowNamelist[1] == @"null"))
                {
                    WindowName2.Text = WindowNamelist[1];
                }
            }
            catch { }
            try
            {
                if (!(WindowNamelist[2] == @"null"))
                {
                    WindowName3.Text = WindowNamelist[2];
                }
            }
            catch { }
            try
            {
                if (!(WindowNamelist[3] == @"null"))
                {
                    WindowName4.Text = WindowNamelist[3];
                }
            }
            catch { }
            try
            {
                if (!(WindowNamelist[4] == @"null"))
                {
                    WindowName5.Text = WindowNamelist[4];
                }
            }
            catch { }
            try
            {
                if (!(WindowNamelist[5] == @"null"))
                {
                    WindowName6.Text = WindowNamelist[5];
                }
            }
            catch { }
            try
            {
                if (!(WindowNamelist[6] == @"null"))
                {
                    WindowName7.Text = WindowNamelist[6];
                }
            }
            catch { }
            try
            {
                if (!(WindowNamelist[7] == @"null"))
                {
                    WindowName8.Text = WindowNamelist[7];
                }
            }
            catch { }

            try
            {
                    LocateX1.Text = settinglist[0];
            }
            catch { }
            try
            {
                    LocateY1.Text = settinglist[1];
            }
            catch { }
            try
            {
                    Width1.Text = settinglist[2];
            }
            catch { }
            try
            {
                    Height1.Text = settinglist[3];
            }
            catch { }
            try
            {
                    LocateX2.Text = settinglist[4];
            }
            catch { }
            try
            {
                    LocateY2.Text = settinglist[5];
            }
            catch { }
            try
            {
                    Width2.Text = settinglist[6];
            }
            catch { }
            try
            {
                    Height2.Text = settinglist[7];
            }
            catch { }
            try
            {
                    LocateX3.Text = settinglist[8];
            }
            catch { }
            try
            {
                    LocateY3.Text = settinglist[9];
            }
            catch { }
            try
            {
                    Width3.Text = settinglist[10];
            }
            catch { }
            try
            {
                Height3.Text = settinglist[11];
            }
            catch { }
            try
            {
                    LocateX4.Text = settinglist[12];
            }
            catch { }
            try
            {
                    LocateY4.Text = settinglist[13];
            }
            catch { }
            try
            {
                    Width4.Text = settinglist[14];
            }
            catch { }
            try
            {
                    Height4.Text = settinglist[15];
            }
            catch { }
            try
            {
                    LocateX5.Text = settinglist[16];
            }
            catch { }
            try
            {
                    LocateY5.Text = settinglist[17];
            }
            catch { }
            try
            {
                    Width5.Text = settinglist[18];
            }
            catch { }
            try
            {
                    Height5.Text = settinglist[19];
            }
            catch { }
            try
            {
                    LocateX6.Text = settinglist[20];
            }
            catch { }
            try
            {
                    LocateY6.Text = settinglist[21];
            }
            catch { }
            try
            {
                    Width6.Text = settinglist[22];
            }
            catch { }
            try
            {
                    Height6.Text = settinglist[23];
            }
            catch { }
            try
            {
                    LocateX7.Text = settinglist[24];
            }
            catch { }
            try
            {
                    LocateY7.Text = settinglist[25];
            }
            catch { }
            try
            {
                Width7.Text = settinglist[26];   
            }
            catch { }
            try
            {
                    Height7.Text = settinglist[27];
            }
            catch { }
            try
            {
                    LocateX8.Text = settinglist[28];
            }
            catch { }
            try
            {

                    LocateY8.Text = settinglist[29];
            }
            catch { }
            try
            {
                    Width8.Text = settinglist[30];
            }
            catch { }
            try
            {
                Height8.Text = settinglist[31];
            }
            catch { }
            try
            {
                    Looptime.Text = settinglist[32];
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("本当に書き込みますか？（無記入だと削除されます。）", "確認", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
            string windowName1W = WindowName1.Text;
            string windowName2W = WindowName2.Text;
            string windowName3W = WindowName3.Text;
            string windowName4W = WindowName4.Text;
            string windowName5W = WindowName5.Text;
            string windowName6W = WindowName6.Text;
            string windowName7W = WindowName7.Text;
            string windowName8W = WindowName8.Text;

            StreamWriter streamWriter = new StreamWriter(@"Read_Path\WindowName.ini", false, Encoding.GetEncoding("utf-8"));
                if (windowName1W == "") {streamWriter.WriteLine(@"null");}
                else{streamWriter.WriteLine(@windowName1W);}

                if (windowName2W == ""){streamWriter.WriteLine(@"null");}
                else{streamWriter.WriteLine(@windowName2W);}
                
                if (windowName3W == ""){streamWriter.WriteLine(@"null");}
                else{streamWriter.WriteLine(@windowName3W);}
                
                if (windowName4W == ""){streamWriter.WriteLine(@"null");}
                else{streamWriter.WriteLine(@windowName4W);}
                
                if (windowName5W == ""){streamWriter.WriteLine(@"null");}
                else{streamWriter.WriteLine(@windowName5W);}
               
                if (windowName6W == ""){streamWriter.WriteLine(@"null");}
                else{streamWriter.WriteLine(@windowName6W);}
                
                if (windowName7W == ""){streamWriter.WriteLine(@"null");}
                else{streamWriter.WriteLine(@windowName7W);}
                
                if (windowName8W == ""){streamWriter.Write(@"null");}
                else{streamWriter.Write(@windowName8W);}
            streamWriter.Close();

            StreamWriter streamWriter1 = new StreamWriter(@"Read_Path\adjustor_setting.ini", false, Encoding.GetEncoding("utf-8"));
                if (LocateX1.Text == ""){streamWriter1.WriteLine(@"0");}
                else{streamWriter1.WriteLine(LocateX1.Text);}

                if (LocateY1.Text == ""){streamWriter1.WriteLine(@"0");}
                else{streamWriter1.WriteLine(LocateY1.Text);}

                if (Width1.Text == ""){streamWriter1.WriteLine(@"0");}
                else{streamWriter1.WriteLine(Width1.Text);}
                
                if (Height1.Text == ""){streamWriter1.WriteLine(@"0");}
                else{streamWriter1.WriteLine(Height1.Text);}

                if (LocateX2.Text == ""){streamWriter1.WriteLine(@"0");}
                else{streamWriter1.WriteLine(LocateX2.Text);}

                if (LocateY2.Text == ""){streamWriter1.WriteLine(@"0");}
                else{streamWriter1.WriteLine(LocateY2.Text);}

                if (Width2.Text== ""){streamWriter1.WriteLine(@"0");}
                else{streamWriter1.WriteLine(Width2.Text);}

                if (Height2.Text== ""){streamWriter1.WriteLine(@"0");}
                else{streamWriter1.WriteLine(Height2.Text);}

                if (LocateX3.Text == ""){streamWriter1.WriteLine(@"0");}
                else{streamWriter1.WriteLine(LocateX3.Text);}
                
                if (LocateY3.Text == ""){streamWriter1.WriteLine(@"0");}
                else{streamWriter1.WriteLine(LocateY3.Text);}
                
                if (Width3.Text == ""){streamWriter1.WriteLine(@"0");}
                else{streamWriter1.WriteLine(Width3.Text);}
                
                if (Height3.Text == ""){streamWriter1.WriteLine(@"0");}
                else{streamWriter1.WriteLine(Height3.Text);}
                
                if (LocateX4.Text == ""){streamWriter1.WriteLine(@"0");}
                else{streamWriter1.WriteLine(LocateX4.Text);}
                
                if (LocateY4.Text == ""){streamWriter1.WriteLine(@"0");}
                else{streamWriter1.WriteLine(LocateY4.Text);}
                
                if (Width4.Text == ""){streamWriter1.WriteLine(@"0");}
                else{streamWriter1.WriteLine(Width4.Text);}
                
                if (Height4.Text == ""){streamWriter1.WriteLine(@"0");}
                else{streamWriter1.WriteLine(Height4.Text);}

                if (LocateX5.Text == ""){ streamWriter1.WriteLine(@"0"); }
                else{streamWriter1.WriteLine(LocateX5.Text);}

                if (LocateY5.Text == "") { streamWriter1.WriteLine(@"0"); }
                else { streamWriter1.WriteLine(LocateY5.Text); }
                
                if (Width5.Text == "") { streamWriter1.WriteLine(@"0"); }
                else { streamWriter1.WriteLine(Width5.Text); }

                if (Height5.Text == "") { streamWriter1.WriteLine(@"0"); }
                else { streamWriter1.WriteLine(Height5.Text); }

                if (LocateX6.Text == "") { streamWriter1.WriteLine(@"0"); }
                else { streamWriter1.WriteLine(LocateX6.Text); }

                if (LocateY6.Text == "") { streamWriter1.WriteLine(@"0"); }
                else { streamWriter1.WriteLine(LocateY6.Text); }

                if (Width6.Text == "") { streamWriter1.WriteLine(@"0"); }
                else { streamWriter1.WriteLine(Width6.Text); }

                if (Height6.Text == "") { streamWriter1.WriteLine(@"0"); }
                else { streamWriter1.WriteLine(Height6.Text); }

                if (LocateX7.Text == "") { streamWriter1.WriteLine(@"0"); }
                else { streamWriter1.WriteLine(LocateX7.Text); }

                if (LocateY7.Text == "") { streamWriter1.WriteLine(@"0"); }
                else { streamWriter1.WriteLine(LocateY7.Text); }

                if (Width7.Text == "") { streamWriter1.WriteLine(@"0"); }
                else { streamWriter1.WriteLine(Width7.Text); }

                if (Height7.Text == "") { streamWriter1.WriteLine(@"0"); }
                else { streamWriter1.WriteLine(Height7.Text); }

                if (LocateX8.Text == "") { streamWriter1.WriteLine(@"0"); }
                else { streamWriter1.WriteLine(LocateX8.Text); }

                if (LocateY8.Text == "") { streamWriter1.WriteLine(@"0"); }
                else { streamWriter1.WriteLine(LocateY8.Text); }

                if (Width8.Text == "") { streamWriter1.WriteLine(@"0"); }
                else { streamWriter1.WriteLine(Width8.Text); }

                if (Height8.Text == "") { streamWriter1.WriteLine(@"0"); }
                else { streamWriter1.WriteLine(Height8.Text); }

                if (Looptime.Text == "") { streamWriter1.Write(@"0"); }
                else { streamWriter1.Write(Looptime.Text); }
            streamWriter1.Close();

                MessageBox.Show("書き込みました");
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("書き込まれませんでした。");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            form3.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> Applylist = new List<string>();

            foreach (string Applyline in File.ReadLines(@"Read_Path\adjustor_Apply.ini"))
            {
                Applylist.Add(Applyline);

            }
            string adjustorApplyR = Applylist[0];
            string foregroundApplyR = Applylist[1];

            if (foregroundApplyR == "true")
            {
                label16.Text = "多重起動防止（現在無効）";
                button3.Text = "有効化";
                StreamWriter applyFalse = new StreamWriter(@"Read_Path\adjustor_Apply.ini");
                applyFalse.WriteLine(adjustorApplyR);
                applyFalse.Write("false");
                applyFalse.Close();
            }
            else if (foregroundApplyR == "false")
            {
                label16.Text = "多重起動防止（現在有効）";
                button3.Text = "無効化";
                StreamWriter applyFalse = new StreamWriter(@"Read_Path\adjustor_Apply.ini");
                applyFalse.WriteLine(adjustorApplyR);
                applyFalse.Write("true");
                applyFalse.Close();
            }
        }
    }
}
