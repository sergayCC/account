namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.accdate = new System.Windows.Forms.DateTimePicker();
            this.acctype = new System.Windows.Forms.ComboBox();
            this.accmoney = new System.Windows.Forms.TextBox();
            this.accsp = new System.Windows.Forms.TextBox();
            this.accsave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.accpath = new System.Windows.Forms.TextBox();
            this.accopen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // accdate
            // 
            this.accdate.Location = new System.Drawing.Point(12, 53);
            this.accdate.Name = "accdate";
            this.accdate.Size = new System.Drawing.Size(200, 22);
            this.accdate.TabIndex = 0;
            // 
            // acctype
            // 
            this.acctype.FormattingEnabled = true;
            this.acctype.Items.AddRange(new object[] {
            "早餐",
            "午餐",
            "晚餐",
            "飲料",
            "油費"});
            this.acctype.Location = new System.Drawing.Point(12, 81);
            this.acctype.Name = "acctype";
            this.acctype.Size = new System.Drawing.Size(121, 20);
            this.acctype.TabIndex = 1;
            // 
            // accmoney
            // 
            this.accmoney.Location = new System.Drawing.Point(13, 108);
            this.accmoney.Name = "accmoney";
            this.accmoney.Size = new System.Drawing.Size(100, 22);
            this.accmoney.TabIndex = 2;
            // 
            // accsp
            // 
            this.accsp.Location = new System.Drawing.Point(13, 137);
            this.accsp.Name = "accsp";
            this.accsp.Size = new System.Drawing.Size(100, 22);
            this.accsp.TabIndex = 3;
            // 
            // accsave
            // 
            this.accsave.Location = new System.Drawing.Point(13, 166);
            this.accsave.Name = "accsave";
            this.accsave.Size = new System.Drawing.Size(75, 23);
            this.accsave.TabIndex = 4;
            this.accsave.Text = "save";
            this.accsave.UseVisualStyleBackColor = true;
            this.accsave.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(330, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "EXCEL路徑";
            // 
            // accpath
            // 
            this.accpath.Location = new System.Drawing.Point(85, 13);
            this.accpath.Name = "accpath";
            this.accpath.Size = new System.Drawing.Size(127, 22);
            this.accpath.TabIndex = 8;
            this.accpath.Text = "E:\\\\accounttemp.xlsx";
            // 
            // accopen
            // 
            this.accopen.Location = new System.Drawing.Point(218, 13);
            this.accopen.Name = "accopen";
            this.accopen.Size = new System.Drawing.Size(75, 23);
            this.accopen.TabIndex = 9;
            this.accopen.Text = "OPEN";
            this.accopen.UseVisualStyleBackColor = true;
            this.accopen.Click += new System.EventHandler(this.accopen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 508);
            this.Controls.Add(this.accopen);
            this.Controls.Add(this.accpath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.accsave);
            this.Controls.Add(this.accsp);
            this.Controls.Add(this.accmoney);
            this.Controls.Add(this.acctype);
            this.Controls.Add(this.accdate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker accdate;
        private System.Windows.Forms.ComboBox acctype;
        private System.Windows.Forms.TextBox accmoney;
        private System.Windows.Forms.TextBox accsp;
        private System.Windows.Forms.Button accsave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox accpath;
        private System.Windows.Forms.Button accopen;
    }
}

