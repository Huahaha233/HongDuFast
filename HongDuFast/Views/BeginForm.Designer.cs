namespace HongDuFast
{
    partial class BeginForm
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
            this.HuJianZuBtn = new System.Windows.Forms.Button();
            this.GeBieJiaoYuBtn = new System.Windows.Forms.Button();
            this.JianXinBtn = new System.Windows.Forms.Button();
            this.ChuYuBtn = new System.Windows.Forms.Button();
            this.BeginTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HuJianZuBtn
            // 
            this.HuJianZuBtn.Location = new System.Drawing.Point(82, 127);
            this.HuJianZuBtn.Name = "HuJianZuBtn";
            this.HuJianZuBtn.Size = new System.Drawing.Size(140, 60);
            this.HuJianZuBtn.TabIndex = 0;
            this.HuJianZuBtn.Text = "互监组";
            this.HuJianZuBtn.UseVisualStyleBackColor = true;
            this.HuJianZuBtn.Click += new System.EventHandler(this.HuJianZuBtn_Click);
            // 
            // GeBieJiaoYuBtn
            // 
            this.GeBieJiaoYuBtn.Location = new System.Drawing.Point(228, 127);
            this.GeBieJiaoYuBtn.Name = "GeBieJiaoYuBtn";
            this.GeBieJiaoYuBtn.Size = new System.Drawing.Size(140, 60);
            this.GeBieJiaoYuBtn.TabIndex = 1;
            this.GeBieJiaoYuBtn.Text = "个别教育谈话";
            this.GeBieJiaoYuBtn.UseVisualStyleBackColor = true;
            this.GeBieJiaoYuBtn.Click += new System.EventHandler(this.GeBieJiaoYuBtn_Click);
            // 
            // JianXinBtn
            // 
            this.JianXinBtn.Location = new System.Drawing.Point(374, 127);
            this.JianXinBtn.Name = "JianXinBtn";
            this.JianXinBtn.Size = new System.Drawing.Size(140, 60);
            this.JianXinBtn.TabIndex = 2;
            this.JianXinBtn.Text = "减刑摸底";
            this.JianXinBtn.UseVisualStyleBackColor = true;
            this.JianXinBtn.Click += new System.EventHandler(this.JianXinBtn_Click);
            // 
            // ChuYuBtn
            // 
            this.ChuYuBtn.Location = new System.Drawing.Point(520, 127);
            this.ChuYuBtn.Name = "ChuYuBtn";
            this.ChuYuBtn.Size = new System.Drawing.Size(140, 60);
            this.ChuYuBtn.TabIndex = 3;
            this.ChuYuBtn.Text = "处遇等级";
            this.ChuYuBtn.UseVisualStyleBackColor = true;
            this.ChuYuBtn.Click += new System.EventHandler(this.ChuYuBtn_Click);
            // 
            // BeginTitle
            // 
            this.BeginTitle.AutoSize = true;
            this.BeginTitle.Font = new System.Drawing.Font("黑体", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BeginTitle.Location = new System.Drawing.Point(191, 9);
            this.BeginTitle.Name = "BeginTitle";
            this.BeginTitle.Size = new System.Drawing.Size(347, 53);
            this.BeginTitle.TabIndex = 4;
            this.BeginTitle.Text = "洪都快捷工具";
            // 
            // BeginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BeginTitle);
            this.Controls.Add(this.ChuYuBtn);
            this.Controls.Add(this.JianXinBtn);
            this.Controls.Add(this.GeBieJiaoYuBtn);
            this.Controls.Add(this.HuJianZuBtn);
            this.Name = "BeginForm";
            this.Text = "洪都快捷工具";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HuJianZuBtn;
        private System.Windows.Forms.Button GeBieJiaoYuBtn;
        private System.Windows.Forms.Button JianXinBtn;
        private System.Windows.Forms.Button ChuYuBtn;
        private System.Windows.Forms.Label BeginTitle;
    }
}

