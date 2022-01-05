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
    public partial class LoginForm : TemplateForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (this.txtID.textResult == "")
            {
                new MessageBoxForm("아이디를 입력해주세요.").ShowDialog();
                return;
            }

            if (this.txtPW.textResult == "")
            {
                new MessageBoxForm("비밀번호를 입력해주세요.").ShowDialog();
                return;
            }

            if (this.txtID.textResult == "admin")
            {
                if (this.txtPW.textResult == "1234")
                {
                    new MessageBoxForm("관리자로 로그인합니다.", false).ShowDialog();

                    this.Hide();

                    new AdministratorForm().ShowDialog();

                    this.txtID.textResult = "";
                    this.txtPW.textResult = "";
                    this.Show();
                }
                else
                    new MessageBoxForm("아이디 혹은 비밀번호를 확인해주세요.").ShowDialog();
            }
            else
            {
                /////// entity framework를 사용한 데이터베이스 내용과 비교하는 곳 ///////

                Model.busticketbookingEntities entities = new Model.busticketbookingEntities();

                // 데이터베이스의 user 테이블에서 id가 현재 입력된 id랑 일치하는 개수가 0개이면
                // 일치하는 유저 정보가 없다는 것
                if (entities.user.Count(x => x.id == this.txtID.textResult) == 0)
                {
                    new MessageBoxForm("아이디 혹은 비밀번호를 확인해주세요.").ShowDialog();
                    return;
                }

                // 일치하는 정보가 있다면 해당 정보를 불러옴.
                // 이렇게 조회한 경우 만약 일치하는 데이터가 없으면 null 값이 리턴됨. 
                // 따라서 위의 count 메서드를 사용한 비교대신 이 메서드를 사용해서 존재하는 아이디 유무를 활용할 수도 있음.
                Model.user user = entities.user.SingleOrDefault(x => x.id == this.txtID.textResult);

                // 찾은 user 정보와 password 를 비교함.
                if (user.pwd != this.txtPW.textResult)
                {
                    new MessageBoxForm("아이디 혹은 비밀번호를 확인해주세요.").ShowDialog();
                    return;
                }

                // 이제 모두 성공했음. 폼을 닫고 새로운 폼으로 이동하면 됨.
                // 단 현재 mainthread에 등록된 폼은 이 loginform 이므로 이 폼이 닫히면 application 
                // 즉 응용프로그램이 모두 완전히 종료됨. 따라서 숨김 처리 후 
                // 다시 보여주기 방식으로 진행
                this.Hide();

                // 로그인 정보를 런타임 중에 사용할 수 있게 DataHelper 클래스에 
                // 만들어 놓은 static user 변수에 저장

                DataHelper.loginedUser = user;

                // dialog로 화면을 실행하는 경우 해당 화면에서 응답이 오기전까지 
                // 더 이상의 코드 실행은 진행하지 않는다. 
                // usermainform 화면이 모두 종료된 이후에 그 다음 코드 블럭이 실행된다.
                new UserMainForm().ShowDialog();

                this.txtID.textResult = "";
                this.txtPW.textResult = "";
                this.Show();

                ////////////////////////////////////////////////////////////////////////////
            }
        }

        private void lbFind_Click(object sender, EventArgs e)
        {
            new FindAccountForm().ShowDialog();
        }

        private void lbJoin_Click(object sender, EventArgs e)
        {
            new AddAccountForm().ShowDialog();
        }

        private void btnTheme_Click(object sender, EventArgs e)
        {
            DataHelper.changeColorMode();
        }
    }
}
