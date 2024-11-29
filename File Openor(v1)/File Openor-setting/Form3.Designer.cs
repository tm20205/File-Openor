namespace File_Openor_setting
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LocateX1 = new System.Windows.Forms.Label();
            this.LocateY1 = new System.Windows.Forms.Label();
            this.Width1 = new System.Windows.Forms.Label();
            this.Height1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LocateX1
            // 
            this.LocateX1.AutoSize = true;
            this.LocateX1.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.LocateX1.Location = new System.Drawing.Point(12, 9);
            this.LocateX1.Name = "LocateX1";
            this.LocateX1.Size = new System.Drawing.Size(109, 15);
            this.LocateX1.TabIndex = 0;
            this.LocateX1.Text = "位置（X軸）1000";
            // 
            // LocateY1
            // 
            this.LocateY1.AutoSize = true;
            this.LocateY1.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.LocateY1.Location = new System.Drawing.Point(127, 9);
            this.LocateY1.Name = "LocateY1";
            this.LocateY1.Size = new System.Drawing.Size(109, 15);
            this.LocateY1.TabIndex = 1;
            this.LocateY1.Text = "位置（X軸）1000";
            // 
            // Width1
            // 
            this.Width1.AutoSize = true;
            this.Width1.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.Width1.Location = new System.Drawing.Point(12, 40);
            this.Width1.Name = "Width1";
            this.Width1.Size = new System.Drawing.Size(109, 15);
            this.Width1.TabIndex = 2;
            this.Width1.Text = "位置（X軸）1000";
            // 
            // Height1
            // 
            this.Height1.AutoSize = true;
            this.Height1.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.Height1.Location = new System.Drawing.Point(127, 40);
            this.Height1.Name = "Height1";
            this.Height1.Size = new System.Drawing.Size(109, 15);
            this.Height1.TabIndex = 3;
            this.Height1.Text = "位置（X軸）1000";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.button1.Location = new System.Drawing.Point(15, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "表示更新";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 98);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Height1);
            this.Controls.Add(this.Width1);
            this.Controls.Add(this.LocateY1);
            this.Controls.Add(this.LocateX1);
            this.Name = "Form3";
            this.Text = "位置確認";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LocateX1;
        private System.Windows.Forms.Label LocateY1;
        private System.Windows.Forms.Label Width1;
        private System.Windows.Forms.Label Height1;
        private System.Windows.Forms.Button button1;
    }
}