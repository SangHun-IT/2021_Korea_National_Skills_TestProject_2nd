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
    public partial class AddAccountForm : TemplateForm
    {
        public AddAccountForm()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            // 공란 제어
            if (this.txtName.textResult == "" || this.txtId.textResult == "" || this.txtPassword.textResult =="" || this.txtPasswordConfirm.textResult == "" || this.txtEmail.textResult == "") 
            {
                new MessageBoxForm("공란을 확인해주세요.").ShowDialog();
                return;
            }

            // PW <-> PW 확인 비교
            if(this.txtPassword.textResult != this.txtPasswordConfirm.textResult )
            {
                new MessageBoxForm("PW확인이 일치하지 않습니다.").ShowDialog();
                return;
            }

            // 특수문자 확인
            Regex exp = new Regex(@"[~!@#$%^&*()_+<>?\|]");
            if(exp.IsMatch(this.txtPassword.textResult) == false)
            {
                new MessageBoxForm("특수문자를 포함해주세요.").ShowDialog();
                return;
            }

            Model.busticketbookingEntities entities = new Model.busticketbookingEntities();

            //ID 중복 체크
            if (entities.user.Count(x => x.id == this.txtId.textResult) > 0)
            {
                new MessageBoxForm("Id가 중복되었습니다.").ShowDialog();
                return;
            }

            //Email 중복 체크
            if (entities.user.Count(x => x.email == this.txtEmail.textResult) > 0)
            {
                new MessageBoxForm("E-mail가 중복되었습니다.").ShowDialog();
                return;
            }

            // 새 유저 추가
            Model.user user = new Model.user();

            user.name = this.txtName.textResult;
            user.id = this.txtId.textResult;
            user.pwd = this.txtPassword.textResult;
            user.email = this.txtEmail.textResult;

            entities.user.Add(user);
            entities.SaveChanges();

            new MessageBoxForm("회원가입이 완료되었습니다.").ShowDialog();

            this.Close();
        }
    }
}
