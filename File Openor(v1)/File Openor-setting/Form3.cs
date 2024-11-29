using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Policy;

namespace File_Openor_setting
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            string x1 = Convert.ToString(this.Left);
            string y1 = Convert.ToString(this.Top);
            string w1 = Convert.ToString(this.Width);
            string h1 = Convert.ToString(this.Height);
            LocateX1.Text = "位置（X軸）" + x1;
            LocateY1.Text = "位置（Y軸）" + y1;
            Width1.Text= "横幅" + w1;
            Height1.Text= "縦幅" + h1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x1 = Convert.ToString(this.Left);
            string y1 = Convert.ToString(this.Top);
            string w1 = Convert.ToString(this.Width);
            string h1 = Convert.ToString(this.Height);
            LocateX1.Text = "位置（X軸）" + x1;
            LocateY1.Text = "位置（Y軸）" + y1;
            Width1.Text = "横幅" + w1;
            Height1.Text = "縦幅" + h1;
        }
    }
}
