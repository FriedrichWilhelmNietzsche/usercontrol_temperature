using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_usercontrol_test_20190715
{
    public partial class UserControl_Panel : UserControl
    {
        private int radius = 15;//弧度半径

        public int Radius
        {
            get { return radius; }

            set { radius = value; }
        }

        private Color borderColor = Color.Red;

        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; }
        }
        public UserControl_Panel()
        {
            InitializeComponent();
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            int width = this.Width;
            int height = this.Height;
            int d = 2 * radius;
            int p = 1;//偏移量
            Pen borderPen = new Pen(borderColor, 1);
            Brush brush = new SolidBrush(this.BackColor);
            //左上
            g.DrawPie(borderPen, new Rectangle(0, 0, d, d), 180, 90);
            g.FillPie(brush, new Rectangle(p, p, d, d), 180, 90);

            //左下
            g.DrawPie(borderPen, new Rectangle(0, height - d, d, d), 90, 90);
            g.FillPie(brush, new Rectangle(p, height - d - p, d, d), 90, 90);
            //右上
            g.DrawPie(borderPen, new Rectangle(width - d, 0, d, d), 270, 90);
            g.FillPie(brush, new Rectangle(width - d - p, p, d, d), 270, 90);
            //右下
            g.DrawPie(borderPen, new Rectangle(width - d, height - d, d, d), 0, 90);
            g.FillPie(brush, new Rectangle(width - d - p, height - d - p, d, d), 0, 90);
            //左边竖线
            g.DrawLine(borderPen, 0, radius, 0, height - radius);

            //上边竖线
            g.DrawLine(borderPen, radius, 0, width - radius, 0);

            //右边竖线
            g.DrawLine(borderPen, width - 1, radius - 3, width - 1, height - radius + 3);

            //下边竖线
            g.DrawLine(borderPen, radius - 3, height - 1, width - radius + 3, height - 1);
        }
    }
}