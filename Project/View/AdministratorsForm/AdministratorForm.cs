using Project.Controller;
using Project.View.AdministratorMenu;
using Project.View.Controls;
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
    public partial class AdministratorForm : TemplateForm
    {
        public AdministratorForm()
        {
            InitializeComponent();
        }

        private void AdministratorForm_Load(object sender, EventArgs e)
        {
            this.btnMenu5.BackColor = (DataHelper.colorMode == DataHelper.COLOR_MODE_WHITE) ? DataHelper.COLOR_MODE_BLACK : DataHelper.COLOR_MODE_WHITE;
            this.btnMenu5.ForeColor = (DataHelper.colorMode == DataHelper.COLOR_MODE_WHITE) ? Color.White : Color.Black;

            ChangeMenu(new ManageUserControl());
        }

        private void btnMenu5_Click(object sender, EventArgs e)
        {
            // 테마 버튼
            DataHelper.changeColorMode();

            this.btnMenu5.BackColor = (DataHelper.colorMode == DataHelper.COLOR_MODE_WHITE) ? DataHelper.COLOR_MODE_BLACK : DataHelper.COLOR_MODE_WHITE;
            this.btnMenu5.ForeColor = (DataHelper.colorMode == DataHelper.COLOR_MODE_WHITE) ? Color.White : Color.Black;
        }


        private void ChangeMenu(Control con)
        {
            this.panContent.Controls.Clear();
            this.panContent.Controls.Add(con);
            con.Dock = DockStyle.Fill;
        }
        private void btnMenu1_Click(object sender, EventArgs e)
        {
            // 사용자 관리 버튼
            ChangeMenu(new ManageUserControl());
        }

        private void btnMenu6_Click(object sender, EventArgs e)
        {
            // 로그아웃 버튼
            DataHelper.loginedUser = null;
            this.Close();
        }

        private void btnMenu2_Click(object sender, EventArgs e)
        {
            // 추천 여행지 관리 버튼
            ChangeMenu(new ManageLocationControl());
        }

        private void btnMenu3_Click(object sender, EventArgs e)
        {
            // 일정 관리 버튼
            ChangeMenu(new ManageScheduleControl());
        }

        private void btnMenu4_Click(object sender, EventArgs e)
        {
            // 예매 관리 버튼
            ChangeMenu(new ManageReservationControl());
        }
    }
}
