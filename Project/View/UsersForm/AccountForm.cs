using Project.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.View
{
    public partial class AccountForm : TemplateForm
    {
        public AccountForm()
        {
            InitializeComponent();
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            this.txtId.Text = DataHelper.loginedUser.id;
            this.txtPwd.Text = DataHelper.loginedUser.pwd;
            this.txtName.Text = DataHelper.loginedUser.name;
            this.txtEmail.Text = DataHelper.loginedUser.email;
            this.txtPoint.Text = DataHelper.loginedUser.point + "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // 수정 버튼
            if(this.txtPwd.Text == "" || this.txtName.Text == "" || this.txtEmail.Text == "")
            {
                new MessageBoxForm("공란을 확인해주세요.").ShowDialog();
                DialogResult = DialogResult.None;
                return;
            }

            Regex exp = new Regex(@"[~!@#$%^&*()_+<>?\|]");
            if (exp.IsMatch(this.txtPwd.Text) == false)
            {
                new MessageBoxForm("특수문자를 포함해주세요.").ShowDialog();
                DialogResult = DialogResult.None;
                return;
            }

            Model.busticketbookingEntities entities = new Model.busticketbookingEntities();

            Model.user editedUser = entities.user.Single(x => x.no == DataHelper.loginedUser.no);

            editedUser.pwd = this.txtPwd.Text;
            editedUser.name = this.txtName.Text;
            editedUser.email = this.txtEmail.Text;

            entities.SaveChanges();

            DataHelper.loginedUser = editedUser;

            new MessageBoxForm("수정이 완료됐습니다.").ShowDialog();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // 취소 버튼
            this.Close();
        }
    }
}
