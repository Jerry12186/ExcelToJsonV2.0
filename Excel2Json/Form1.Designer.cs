namespace Excel2Json
{
    partial class Excel2JSON工具
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.SelectExcel = new System.Windows.Forms.Button();
            this.Tips = new System.Windows.Forms.TextBox();
            this.SingleOrMul = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // SelectExcel
            // 
            this.SelectExcel.Location = new System.Drawing.Point(71, 30);
            this.SelectExcel.Name = "SelectExcel";
            this.SelectExcel.Size = new System.Drawing.Size(116, 65);
            this.SelectExcel.TabIndex = 0;
            this.SelectExcel.Text = "选择Excel文件";
            this.SelectExcel.UseVisualStyleBackColor = true;
            this.SelectExcel.Click += new System.EventHandler(this.SelectExcel_Click);
            // 
            // Tips
            // 
            this.Tips.Enabled = false;
            this.Tips.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Tips.Location = new System.Drawing.Point(40, 211);
            this.Tips.Multiline = true;
            this.Tips.Name = "Tips";
            this.Tips.Size = new System.Drawing.Size(593, 284);
            this.Tips.TabIndex = 2;
            // 
            // SingleOrMul
            // 
            this.SingleOrMul.AutoSize = true;
            this.SingleOrMul.Location = new System.Drawing.Point(71, 121);
            this.SingleOrMul.Name = "SingleOrMul";
            this.SingleOrMul.Size = new System.Drawing.Size(132, 16);
            this.SingleOrMul.TabIndex = 3;
            this.SingleOrMul.Text = "每个表单都生成文件";
            this.SingleOrMul.UseVisualStyleBackColor = true;
            // 
            // Excel2JSON工具
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 509);
            this.Controls.Add(this.SingleOrMul);
            this.Controls.Add(this.Tips);
            this.Controls.Add(this.SelectExcel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Excel2JSON工具";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "本地化工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectExcel;
        private System.Windows.Forms.TextBox Tips;
        private System.Windows.Forms.CheckBox SingleOrMul;
    }
}

