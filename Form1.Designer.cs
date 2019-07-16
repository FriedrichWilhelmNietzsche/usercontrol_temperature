namespace wf_usercontrol_test_20190715
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
            this.tb_temperature = new System.Windows.Forms.TextBox();
            this.btn_temperature = new System.Windows.Forms.Button();
            this.userControl_Panel1 = new wf_usercontrol_test_20190715.UserControl_Panel();
            this.userControl1 = new wf_usercontrol_test_20190715.UserControl1();
            this.SuspendLayout();
            // 
            // tb_temperature
            // 
            this.tb_temperature.Location = new System.Drawing.Point(570, 124);
            this.tb_temperature.Name = "tb_temperature";
            this.tb_temperature.Size = new System.Drawing.Size(172, 21);
            this.tb_temperature.TabIndex = 2;
            // 
            // btn_temperature
            // 
            this.btn_temperature.Location = new System.Drawing.Point(625, 187);
            this.btn_temperature.Name = "btn_temperature";
            this.btn_temperature.Size = new System.Drawing.Size(75, 23);
            this.btn_temperature.TabIndex = 3;
            this.btn_temperature.Text = "button1";
            this.btn_temperature.UseVisualStyleBackColor = true;
            this.btn_temperature.Click += new System.EventHandler(this.Btn_temperature_Click);
            // 
            // userControl_Panel1
            // 
            this.userControl_Panel1.BorderColor = System.Drawing.Color.Red;
            this.userControl_Panel1.Location = new System.Drawing.Point(12, 12);
            this.userControl_Panel1.Name = "userControl_Panel1";
            this.userControl_Panel1.Radius = 15;
            this.userControl_Panel1.Size = new System.Drawing.Size(150, 150);
            this.userControl_Panel1.TabIndex = 0;
            // 
            // userControl1
            // 
            this.userControl1.BackGroundColor = System.Drawing.Color.SkyBlue;
            this.userControl1.CurValue = 0F;
            this.userControl1.Interval = 10;
            this.userControl1.Location = new System.Drawing.Point(225, 35);
            this.userControl1.MaxValue = 80;
            this.userControl1.MinValue = -20;
            this.userControl1.Name = "userControl1";
            this.userControl1.ShowTip = false;
            this.userControl1.Size = new System.Drawing.Size(115, 333);
            this.userControl1.TabIndex = 4;
            this.userControl1.ThermoColor = System.Drawing.Color.Red;
            this.userControl1.ThermoFont = new System.Drawing.Font("宋体", 10F);
            this.userControl1.ThermoTitle = "温度计";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 717);
            this.Controls.Add(this.userControl1);
            this.Controls.Add(this.btn_temperature);
            this.Controls.Add(this.tb_temperature);
            this.Controls.Add(this.userControl_Panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControl_Panel userControl_Panel1;
        private System.Windows.Forms.TextBox tb_temperature;
        private System.Windows.Forms.Button btn_temperature;
        private UserControl1 userControl1;
    }
}

