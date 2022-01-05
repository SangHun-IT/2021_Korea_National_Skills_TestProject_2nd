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
    public partial class FindAccountForm : TemplateForm
    {
        public FindAccountForm()
        {
            InitializeComponent();
        }

        private void btnIDContinue_Click(object sender, EventArgs e)
        {
            // 아이디 찾기
            if (this.txtIDName.textResult == "" || this.txtIDEmail.textResult == "")
            {
                new MessageBoxForm("공란을 확인해주세요.").ShowDialog();
                return;
            }

            Model.busticketbookingEntities entities = new Model.busticketbookingEntities();

            if(entities.user.Count(x=>x.name == this.txtIDName.textResult && x.email == this.txtIDEmail.textResult) == 0)
            {
                new MessageBoxForm("존재하지 않는 정보입니다.").ShowDialog();
                return;
            }

            Model.user user = entities.user.SingleOrDefault(x => x.name == this.txtIDName.textResult && x.email == this.txtIDEmail.textResult);

            new MessageBoxForm("귀하의 id는 " + user.id + "입니다.", false).ShowDialog();

        }

        private void btnPWContinue_Click(object sender, EventArgs e)
        {
            // 비밀번호 찾기
            if (this.txtPWName.textResult == "" || this.txtPWID.textResult == "" || this.txtPWEmail.textResult == "")
            {
                new MessageBoxForm("공란을 확인해주세요.").ShowDialog();
                return;
            }

            Model.busticketbookingEntities entities = new Model.busticketbookingEntities();

            if (entities.user.Count(x => x.id == this.txtPWID.textResult && x.name == this.txtPWName.textResult && x.email == this.txtPWEmail.textResult) == 0)
            {
                new MessageBoxForm("존재하지 않는 정보입니다.").ShowDialog();
                return;
            }

            Model.user user = entities.user.SingleOrDefault(x => x.id == this.txtPWID.textResult && x.name == this.txtPWName.textResult && x.email == this.txtPWEmail.textResult);

            new MessageBoxForm("귀하의 id에 PW는 " + user.pwd + "입니다.", false).ShowDialog();
        }
    }
}
