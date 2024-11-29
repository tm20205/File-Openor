using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;
using File_Openor_setting;

namespace File_Openor_writer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<string> Pathlist = new List<string>();
            List<string> Applylist = new List<string>();

            foreach (string Applyline in File.ReadLines(@"Read_Path\adjustor_Apply.ini"))
            {
                Applylist.Add(Applyline);

            }
            string adjustorApplyR = Applylist[0];

            foreach (string Pathline in System.IO.File.ReadLines(@"Read_Path\Path.ini"))//ファイル数がやばくなってきたので行で分けて管理するようにしました。
            {
                Pathlist.Add(Pathline);//リストに行のパスをそれぞれ追加。
            }

            try
            {
                if (!(Pathlist[0] == @"null"))
                {
                    textBox1.Text = Pathlist[0];//ぼっくすに前に保存した文字を書き込むよ。
                }
            }
            catch (Exception) { }
            try
            {
                if (!(Pathlist[1] == @"null"))
                {
                    textBox2.Text = Pathlist[1];
                }
            }
            catch (Exception) { }
            try
            {
                if (!(Pathlist[2] == @"null"))
                {
                    textBox3.Text = Pathlist[2];
                }
            }
            catch (Exception) { }
            try
            {
                if (!(Pathlist[3] == @"null"))
                {
                    textBox4.Text = Pathlist[3];
                }
            }
            catch (Exception) { }
            try
            {
                if (!(Pathlist[4] == @"null"))
                {
                    textBox5.Text = Pathlist[4];
                }
            }
            catch (Exception) { }
            try
            {
                if (!(Pathlist[5] == @"null"))
                {
                    textBox6.Text = Pathlist[5];
                }
            }
            catch (Exception) { }
            try
            {
                if (!(Pathlist[6] == @"null"))
                {
                    textBox7.Text = Pathlist[6];
                }
            }
            catch (Exception) { }
            try
            {
                if (!(Pathlist[7] == @"null"))
                {
                    textBox8.Text = Pathlist[7];
                }
            }
            catch (Exception) { }

            if (adjustorApplyR == "true")
            {
                label9.Text = "位置調節機能（現在有効）";
                button3.Text = "無効化";
            }
            else if (adjustorApplyR == "false")
            {
                label9.Text = "位置調節機能（現在無効）";
                button3.Text = "有効化";
            }
        }
        public void button1_Click(object sender, EventArgs e)//なんかわからないけどボタン押したら動くってよ。
        {
            Encoding enc = Encoding.GetEncoding("utf-8");
            DialogResult result = MessageBox.Show("本当に書き込みますか？（無記入だと削除されます。）", "確認", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string FilePath1 = textBox1.Text;//Boxにinしたtextを取得するネ。
                string FilePath2 = textBox2.Text;
                string FilePath3 = textBox3.Text;
                string FilePath4 = textBox4.Text;
                string ProgramPath1 = textBox5.Text;
                string ProgramPath2 = textBox6.Text;
                string ProgramPath3 = textBox7.Text;
                string ProgramPath4 = textBox8.Text;

                StreamWriter streamWriter = new StreamWriter(@"Read_Path\Path.ini", false, Encoding.GetEncoding("utf-8"));
                if (FilePath1 == "") { streamWriter.WriteLine(@"null"); }
                else { streamWriter.WriteLine(FilePath1); }

                if (FilePath2 == "") { streamWriter.WriteLine(@"null"); }
                else { streamWriter.WriteLine(FilePath2); }

                if (FilePath3 == "") { streamWriter.WriteLine(@"null"); }
                else { streamWriter.WriteLine(FilePath3); }

                if (FilePath4 == "") { streamWriter.WriteLine(@"null"); }
                else { streamWriter.WriteLine(FilePath4); }

                if (ProgramPath1 == "") { streamWriter.WriteLine(@"null"); }
                else { streamWriter.WriteLine(ProgramPath1); }

                if (ProgramPath2 == "") { streamWriter.WriteLine(@"null"); }
                else { streamWriter.WriteLine(ProgramPath2); }

                if (ProgramPath3 == "") { streamWriter.WriteLine(@"null"); }
                else { streamWriter.WriteLine(ProgramPath3); }

                if (ProgramPath4 == "") { streamWriter.WriteLine(@"null"); }
                else { streamWriter.Write(ProgramPath4); }

                streamWriter.Close();

                MessageBox.Show("書き込みました");
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("書き込まれませんでした。");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            form2.BringToFront();
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

            if (adjustorApplyR == "true")
            {
                label9.Text = "位置調節機能（現在無効）";
                button3.Text = "有効化";
                StreamWriter applyFalse = new StreamWriter(@"Read_Path\adjustor_Apply.ini");
                applyFalse.WriteLine("false");
                applyFalse.Write(foregroundApplyR);
                applyFalse.Close();
            }
            else if (adjustorApplyR == "false")
            {
                label9.Text = "位置調節機能（現在有効）";
                button3.Text = "無効化";
                StreamWriter applyFalse = new StreamWriter(@"Read_Path\adjustor_Apply.ini");
                applyFalse.WriteLine("true");
                applyFalse.Write(foregroundApplyR);
                applyFalse.Close();
            }
        }
    }
}