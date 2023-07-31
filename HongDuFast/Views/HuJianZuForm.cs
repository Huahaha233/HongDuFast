using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HongDuFast.Views
{
    public partial class HuJianZuForm : Form
    {
        public HuJianZuForm()
        {
            InitializeComponent();
        }

        //关闭互监组界面
        private void HuJianZuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //显示开始界面
            FormsExpose.instance.getBeginForm().Show();
        }
    }
}
