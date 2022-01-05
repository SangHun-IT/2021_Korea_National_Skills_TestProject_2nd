using Project.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.View
{
    public partial class PasswordBoxConfirmForm : TemplateForm
    {
        public PasswordBoxConfirmForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(this.txtPassword.Text == "")
            {
                this.txtPassword.Focus();
                new MessageBoxForm("비밀번호를 입력하세요.").ShowDialog();
                DialogResult = DialogResult.None;
                return;
            }
            
            if(this.txtPassword.Text != DataHelper.loginedUser.pwd)
            {
                this.txtPassword.Focus();
                new MessageBoxForm("비밀번호가 일치하지 않습니다.").ShowDialog();
                this.txtPassword.Text = "";
                DialogResult = DialogResult.None;
                return;
            }

            DialogResult = DialogResult.OK;
            this.Hide();
            new AccountForm().ShowDialog();
            this.Close();
        }

        private void PasswordBoxConfirmForm_Load(object sender, EventArgs e)
        {
            this.picIcon.Image = SystemIcons.Question.ToBitmap();
        }
    }
}
