using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Configuration;

namespace StudentManager
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }    

        #region Ƕ�봰����ʾ

     
        //��ʾ�����ѧԱ����       
        private void tsmiAddStudent_Click(object sender, EventArgs e)
        {          
            FrmAddStudent objForm = new FrmAddStudent();
          
        }
        //���ڴ�      
        private void tsmi_Card_Click(object sender, EventArgs e)
        {
            //FrmAttendance objForm = new FrmAttendance();
            
        }
        //�ɼ����ٲ�ѯ��Ƕ����ʾ��
        private void tsmiQuery_Click(object sender, EventArgs e)
        {
          //  FrmScoreQuery objForm = new FrmScoreQuery();
            
        }
        //ѧԱ�����Ƕ����ʾ��
        private void tsmiManageStudent_Click(object sender, EventArgs e)
        {
           // FrmStudentManage objForm = new FrmStudentManage();
           
        }
        //��ʾ�ɼ���ѯ���������    
        private void tsmiQueryAndAnalysis_Click(object sender, EventArgs e)
        {
            FrmScoreManage objForm = new FrmScoreManage();
            //
        }
        //���ڲ�ѯ
        private void tsmi_AQuery_Click(object sender, EventArgs e)
        {
            FrmAttendanceQuery objForm = new FrmAttendanceQuery();
          //
        }
        #endregion

        #region �˳�ϵͳȷ��

        //�˳�ϵͳ
        private void tmiClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }      

        #endregion

        #region ����

        //�����޸�
        private void tmiModifyPwd_Click(object sender, EventArgs e)
        {
            FrmModifyPwd objPwd = new FrmModifyPwd();
            objPwd.ShowDialog();
        }

        private void tsbAddStudent_Click(object sender, EventArgs e)
        {
            tsmiAddStudent_Click(null, null);
            FrmAddStudent objForm = new FrmAddStudent();
            objForm.Show();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            tsmiManageStudent_Click(null, null);
        }
        private void tsbScoreAnalysis_Click(object sender, EventArgs e)
        {
            tsmiQueryAndAnalysis_Click(null, null);
        }
        private void tsbModifyPwd_Click(object sender, EventArgs e)
        {
            tmiModifyPwd_Click(null, null);
        }
        private void tsbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tsbQuery_Click(object sender, EventArgs e)
        {
            tsmiQuery_Click(null, null);
        }   
     
        //���ʹ���
        private void tsmi_linkxkt_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("iexplore.exe", "http://www.xiketang.com");
        }

        private void tsmi_about_Click(object sender, EventArgs e)
        {
            FrmAbout objAbout = new FrmAbout();
            objAbout.Show();
        }
        private void tms_GetCourse_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("iexplore.exe", "https://ke.qq.com/course/59314");
        }


        #endregion

        private void panelForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblVersion_Click(object sender, EventArgs e)
        {

        }
    }
}