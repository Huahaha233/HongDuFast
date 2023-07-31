using HongDuFast.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HongDuFast
{
    public partial class BeginForm : Form
    {
        public BeginForm()
        {
            InitializeComponent();
        }

        // 互监组功能按钮
        private void HuJianZuBtn_Click(object sender, EventArgs e)
        {
            HuJianZuForm huJianZuForm = new HuJianZuForm();
            FormsExpose.instance.setHuJianZuForm(huJianZuForm);
            huJianZuForm.Show();
            FormsExpose.instance.getBeginForm().Hide();
        }

        //个别教育谈话按钮
        private void GeBieJiaoYuBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("该功能暂未开放，敬请期待！");
        }

        //减刑摸底按钮
        private void JianXinBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("该功能暂未开放，敬请期待！");
        }

        //处遇等级摸排按钮
        private void ChuYuBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("该功能暂未开放，敬请期待！");
        }
    }
}
