using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace wf_usercontrol_test_20190715
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       // private float curValue = 0;
        private void Btn_temperature_Click(object sender, EventArgs e)
        {
            //         private float curValue = 0;
          //  UserControl1 userControl = new UserControl1();
            userControl1.CurValue = float.Parse(tb_temperature.Text);
            userControl1.Refresh();

        }
    }
}
