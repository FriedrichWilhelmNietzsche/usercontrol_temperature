using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace wf_usercontrol_test_20190715
{
    public partial class UserControl1 : UserControl
    {
        #region 属性与构造函数

        private int interval = 10;    //温度间隔  前是10

        /// <summary>
        /// 刻度间隔
        /// </summary>
        public int Interval
        {
            get { return interval; }

            set { interval = value; }
        }

        private int minValue = -20;    //修改前是-50

        /// <summary>
        /// 最低温度
        /// </summary>
        public int MinValue
        {
            get { return minValue; }

            set { minValue = value; }
        }

        private int maxValue = 80;   //修改前是50

        /// <summary>
        /// 最高温度
        /// </summary>
        public int MaxValue
        {
            get { return maxValue; }

            set { maxValue = value; }
        }

        private float curValue = 0;

        /// <summary>
        /// 当前温度
        /// </summary>
        public float CurValue
        {
            get { return curValue; }

            set { curValue = value; }
        }

        private Color thermoColor = Color.Red;

        /// <summary>
        /// 温度条颜色
        /// </summary>
        public Color ThermoColor
        {
            get { return thermoColor; }

            set { thermoColor = value; }
        }

        private Color backGroundColor = Color.SkyBlue;

        /// <summary>
        /// 温度计背景色
        /// </summary>
        public Color BackGroundColor
        {
            get { return backGroundColor; }

            set { backGroundColor = value; }
        }

        private Font thermoFont = new Font("宋体", 10, FontStyle.Regular);

        /// <summary>
        /// 温度计上字体
        /// </summary>
        public Font ThermoFont
        {
            get { return thermoFont; }

            set { thermoFont = value; }
        }

        private string thermoTitle = "温度计";

        /// <summary>
        /// 标题
        /// </summary>
        public string ThermoTitle
        {
            get { return this.thermoTitle; }
            set { this.thermoTitle = value; }
        }

        private bool showTip = false;

        /// <summary>
        /// 是否显示提示
        /// </summary>
        public bool ShowTip
        {
            get { return showTip; }

            set { showTip = value; }
        }

        private ToolTip tip = new ToolTip();
        public UserControl1()
        {
            InitializeComponent();
        }

        #endregion

        protected override void OnPaint(PaintEventArgs e)
        {

            //base.OnPaint(e);
            //this.BackColor = this.backGroundColor;
            int width = this.Width;
            int height = this.Height - 50;
            Graphics g = e.Graphics;
            int c_x = width / 2;
            int c_y = height / 2;
            int padding = this.Padding.All;//空白
            int r = (width - 2 * padding) / 2;//半径  
            int d = 2 * r ;//直径
            int dis = 2;//两个半圆之间的间隔
            int dis2 = 2 * dis;//填充与边框之间的距离
            int startAngle1 = -180;
            int startAngle2 = 0;
            int sweepAngle1 = 180;
            //首先画顶端一个半圆
            g.DrawPie(Pens.Black, new Rectangle(padding, padding, d, d), startAngle1, sweepAngle1);
            g.DrawPie(Pens.Black, new Rectangle(padding + dis, padding + dis, d - 2 * dis, d - 2 * dis), startAngle1, sweepAngle1);
            //填充背景色
            g.FillPie(new SolidBrush(this.backGroundColor), new Rectangle(padding + dis2, padding + dis2, d - 2 * dis2, d - 2 * dis2), startAngle1, sweepAngle1);
            //画底端一个半圆
            g.DrawPie(Pens.Black, new Rectangle(padding, height - d - padding, d, d), startAngle2, sweepAngle1);
            g.DrawPie(Pens.Black, new Rectangle(padding + dis, height - d - padding + dis, d - 2 * dis, d - 2 * dis), startAngle2, sweepAngle1);
            g.FillPie(new SolidBrush(this.backGroundColor), new Rectangle(padding + dis2, height - d - padding + dis2, d - 2 * dis2, d - 2 * dis2), startAngle2, sweepAngle1);
            //画一个矩形
            g.DrawRectangle(Pens.Black, new Rectangle(padding, padding + r, d, height - d - 2 * padding));
            g.DrawRectangle(Pens.Black, new Rectangle(padding + dis, padding + r + dis, d - 2 * dis, height - d - 2 * padding - 2 * dis));
            //背景色填充，去掉边界线
            g.FillRectangle(new SolidBrush(this.backGroundColor), new Rectangle(padding + 3, padding + r - 2, 2 * r - 6, 6));
            g.FillRectangle(new SolidBrush(this.backGroundColor), new Rectangle(padding + 3, height - r - padding - 4, 2 * r - 6, 8));
            //背景色填充中间部分
            g.FillRectangle(new SolidBrush(this.backGroundColor), new Rectangle(padding + dis2, padding + r + dis2, d - 2 * dis2, height - d - 2 * padding - 2 * dis2));
            //画刻度
            int s_s_x_1 = padding + r - 20;
            int s_s_x_2 = width - padding - r + 20;
            int s_s_y = padding + r + 4;
            int total = this.maxValue - this.minValue;
            int scale_width = 5;//刻度宽度
            int scale = total / this.interval;
            int pscale = (height - 2 * r - 2 * padding) / this.interval;//像素间隔

            //竖线
            g.DrawLine(Pens.Black, new Point(s_s_x_1, s_s_y), new Point(s_s_x_1, s_s_y + this.interval * pscale));
            g.DrawLine(Pens.Black, new Point(s_s_x_2, s_s_y), new Point(s_s_x_2, s_s_y + this.interval * pscale));
            for (int i = 0; i <= this.interval; i++)
            {
                //横线刻度
                g.DrawLine(Pens.Black, new Point(s_s_x_1 - scale_width, s_s_y + i * pscale), new Point(s_s_x_1, s_s_y + i * pscale));
                g.DrawLine(Pens.Black, new Point(s_s_x_2, s_s_y + i * pscale), new Point(s_s_x_2 + scale_width, s_s_y + i * pscale));
                //画刻度数字

                g.DrawString((this.maxValue - (scale * i)).ToString(), this.thermoFont, new SolidBrush(this.ForeColor), new Point(s_s_x_1 - 35, s_s_y + i * pscale - 10));
                g.DrawString((this.maxValue - (scale * i)).ToString(), this.thermoFont, new SolidBrush(this.ForeColor), new Point(s_s_x_2 + 10, s_s_y + i * pscale - 10));
            }
            int white_width = 3;//中间白色线宽度
            //画条白色细线
            g.FillRectangle(Brushes.White, new Rectangle(c_x - white_width, r / 2, white_width * 2, height - r));
            //在底部画一个圆球
            g.FillPie(new SolidBrush(this.thermoColor), new Rectangle(c_x - r / 2 + 5, height - r - padding, r-10 , r-10), 0, 360);  //修改前是（c_x - r / 2 + 5, height - r - padding, r - 10, r - 10), 0, 360）
            //根据当前温度画红色线
            int red_width = 3;//红色温度线宽度
            float ii = (this.curValue - this.minValue) / this.interval;
            g.FillRectangle(new SolidBrush(this.thermoColor), new RectangleF(c_x - red_width, height - r - padding - (ii * pscale) - 4, 2 * red_width, ii * pscale + 5));//此处有一像素的误差
            //画标志字符单℃位
            g.DrawString("℃", this.thermoFont, new SolidBrush(this.ForeColor), new Point(c_x - 30, r / 2 - 10));
            Font titleFont = new Font("宋体", 13, FontStyle.Bold);
            //绘制标题
            SizeF tsize = g.MeasureString(this.thermoTitle, titleFont);
            g.DrawString(this.thermoTitle, titleFont, new SolidBrush(this.ForeColor), new PointF(c_x - (tsize.Width / 2), height + 5));
            string cur = string.Format("当前温度：{0}℃", this.curValue);
            SizeF tsize2 = g.MeasureString(cur, this.thermoFont);
            g.DrawString(cur, this.thermoFont, new SolidBrush(this.thermoColor), new PointF(c_x - (tsize2.Width / 2), height + 10 + tsize.Height));
        }

        /// <summary>
        /// 当鼠标覆盖进去时
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseHover(EventArgs e)
        {
            this.showTip = true;
            //需要显示的内容
            int x = this.Width / 2;
            int y = (this.Height - 50) / 2;
            StringBuilder sbTips = new StringBuilder();
            //sbTips.AppendLine(this.ThermoTitle);
            sbTips.AppendLine(string.Format("当前温度：{0}", this.curValue));
            sbTips.AppendLine("单位：℃");
            tip.ToolTipTitle = this.ThermoTitle;
            tip.IsBalloon = true;
            tip.UseFading = true;
            //t.SetToolTip(this, sbTips.ToString());
            tip.Show(sbTips.ToString(), this, x, y);
        }


        protected override void OnMouseLeave(EventArgs e)
        {
            this.showTip = false;
            tip.Hide(this);
        }
    }
}
    

