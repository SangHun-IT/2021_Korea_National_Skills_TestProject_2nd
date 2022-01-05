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

namespace Project.View.AdministratorMenu
{
    public partial class ManageUserControl : TemplateControl
    {
        private Model.busticketbookingEntities entities;
        List<Model.user> users;
        private bool isEdit;
        public ManageUserControl()
        {
            InitializeComponent();
            this.isEdit = false;
        }

        private void ManageUserControl_Load(object sender, EventArgs e)
        {
            if(this.IsHandleCreated)
            {
                this.entities = new Model.busticketbookingEntities();
                this.users = entities.user.ToList();
                UpdateList();
            }
        }

        private void UpdateList()
        {
            this.dgvUsers.Rows.Clear();

            foreach (var item in this.users)
            {
                this.dgvUsers.Rows.Add(item.no, item.id, item.pwd, item.name, item.email, item.point, item.reservation.Count);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.phtName.textResult == "")
                this.users = this.entities.user.ToList();
            else
            {
                this.users = this.entities.user.Where(x => x.name.Contains(phtName.textResult)).ToList();
            }

            UpdateList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(isEdit)
            {
                entities.SaveChanges();
                new MessageBoxForm("수정내용을 저장 완료하였습니다.", false).ShowDialog();
            }
            else
            {
                new MessageBoxForm("수정한 데이터가 없습니다.").ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // 삭제 버튼
            if(this.dgvUsers.CurrentRow.Cells.Count > 0)
            {
                Model.user selectedUser = this.users[this.dgvUsers.CurrentRow.Index];


                this.users.Remove(selectedUser);

                entities.user.Remove(entities.user.Single(x => x.no == selectedUser.no));
                entities.SaveChanges();

                this.dgvUsers.Rows.RemoveAt(this.dgvUsers.CurrentRow.Index);

                new MessageBoxForm("삭제를 완료하였습니다.", false).ShowDialog();
            }
            else
            {
                new MessageBoxForm("삭제할 사용자를 선택하세요.").ShowDialog();
            }
        }

        private void dgvUsers_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            // 사용자를 선택하고 해당 셀에서 우측 클릭했을 경우에!?
            if(e.RowIndex == this.dgvUsers.CurrentRow.Index && e.Button == MouseButtons.Right)
            {
                Rectangle cellRange = this.dgvUsers.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                this.contextMenuStrip1.Show(this.dgvUsers, new Point(cellRange.X + e.X, cellRange.Y + e.Y));
            }
        }

        private void ctMenuSearchReservation_Click(object sender, EventArgs e)
        {
            // 바로가기 메뉴 - 예매 조회 버튼
            if(this.dgvUsers.CurrentRow.Cells.Count > 0)
            {
                Model.user user = this.users[this.dgvUsers.CurrentRow.Index];

                ReservationInfoForm form = new ReservationInfoForm(user.no);

                form.ShowDialog();
            }
        }

        private void dgvUsers_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(this.users != null && e.RowIndex >= 0)
            {
                this.isEdit = true;

                Model.user curuser = this.users[e.RowIndex];

                curuser.id = (string)this.dgvUsers[1, e.RowIndex].Value;
                curuser.pwd = (string)this.dgvUsers[2, e.RowIndex].Value;
                curuser.name = (string)this.dgvUsers[3, e.RowIndex].Value;
                curuser.email = (string)this.dgvUsers[4, e.RowIndex].Value;
            }
        }

        private void dgvUsers_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            Model.user curuser = this.users[e.RowIndex];

            // 빈칸 입력 제어
            if (e.FormattedValue.ToString() == "")
            {
                new MessageBoxForm("내용을 입력하세요.").ShowDialog();
                e.Cancel = true;
                return;
            }
            else if (e.ColumnIndex == 1)
            {
                //아이디 중복 검사
                //ID 중복 체크
                if (curuser.id != e.FormattedValue.ToString() && entities.user.Count(x => x.id == e.FormattedValue.ToString()) > 0)
                {
                    new MessageBoxForm("Id가 중복되었습니다.").ShowDialog();
                    e.Cancel = true;
                }

            }
            else if (e.ColumnIndex == 2)
            {
                // 특수 문자 확인
                Regex exp = new Regex(@"[~!@#$%^&*()_+<>?\|]");
                if(exp.IsMatch(e.FormattedValue.ToString()) == false)
                {
                    new MessageBoxForm("특수문자를 포함해주세요.").ShowDialog();
                    e.Cancel = true;
                }

            }
            else if (e.ColumnIndex == 4)
            {
                // 이메일 중복 검사
                //Email 중복 체크
                if (curuser.email != e.FormattedValue.ToString() && entities.user.Count(x => x.email == e.FormattedValue.ToString()) > 0)
                {
                    new MessageBoxForm("E-mail가 중복되었습니다.").ShowDialog();
                    e.Cancel = true;
                }
            }
        }
    }
}
