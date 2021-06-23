
namespace sfrpc
{
    partial class Form1
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
            this.Operator = new System.Windows.Forms.Button();
            this.editconf = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Operator
            // 
            this.Operator.Location = new System.Drawing.Point(183, 123);
            this.Operator.Name = "Operator";
            this.Operator.Size = new System.Drawing.Size(121, 43);
            this.Operator.TabIndex = 0;
            this.Operator.Text = "启动Frpc代理";
            this.Operator.UseVisualStyleBackColor = true;
            this.Operator.Click += new System.EventHandler(this.Operator_Click);
            // 
            // editconf
            // 
            this.editconf.Location = new System.Drawing.Point(12, 123);
            this.editconf.Name = "editconf";
            this.editconf.Size = new System.Drawing.Size(121, 43);
            this.editconf.TabIndex = 5;
            this.editconf.Text = "编辑配置文件";
            this.editconf.UseVisualStyleBackColor = true;
            this.editconf.Click += new System.EventHandler(this.editconf_Click);
            // 
            // info
            // 
            this.info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.info.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.info.Location = new System.Drawing.Point(12, 12);
            this.info.Multiline = true;
            this.info.Name = "info";
            this.info.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.info.Size = new System.Drawing.Size(292, 96);
            this.info.TabIndex = 6;
            this.info.Text = "系统初始化完成，等待指令...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 178);
            this.Controls.Add(this.info);
            this.Controls.Add(this.editconf);
            this.Controls.Add(this.Operator);
            this.Name = "Form1";
            this.Text = "Simple Frpc Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Operator;
        private System.Windows.Forms.Button editconf;
        private System.Windows.Forms.TextBox info;
    }
}

