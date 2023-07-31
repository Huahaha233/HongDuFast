using HongDuFast.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HongDuFast
{
    internal class FormsExpose
    {
        private FormsExpose(){

        }

        public BeginForm beginForm = null;
        public HuJianZuForm zuForm = null;
        public GeBieJiaoYuForm yuForm = null;
        public JianXinForm xinForm = null;
        public static FormsExpose instance = new FormsExpose();

        //public FormsExpose getInstance()
        //{
        //    return instance;
        //}
        
        // 开始界面
        public void setBeginForm(BeginForm form)
        {
           
            beginForm = form;
        }
        public BeginForm getBeginForm()
        {
            return beginForm;
        }

        //互监组界面
        public void setHuJianZuForm(HuJianZuForm form)
        {

            zuForm = form;
        }
        public HuJianZuForm getHuJianZuForm()
        {
            return zuForm;
        }

        //
        public void setGeBieJiaoYuForm(GeBieJiaoYuForm form)
        {

            yuForm = form;
        }
        public GeBieJiaoYuForm getGeBieJiaoYuForm()
        {
            return yuForm;
        }

        //
        public void setJianXinForm(JianXinForm form)
        {

            xinForm = form;
        }
        public JianXinForm getJianXinForm()
        {
            return xinForm;
        }
    }
}
