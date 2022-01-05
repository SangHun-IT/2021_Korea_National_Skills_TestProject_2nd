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
    public partial class ReservationForm : TemplateForm
    {
        private List<Model.schedule> Schedules;
        public ReservationForm()
        {
            InitializeComponent();
        }

        public ReservationForm(List<Model.schedule> schedules) : this()
        {
            this.Schedules = schedules;
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 5)
            {
                if(new QuestionMessageForm().ShowDialog() == DialogResult.Yes)
                {
                    Model.busticketbookingEntities entities = new Model.busticketbookingEntities();
                    Model.schedule item = this.Schedules[e.RowIndex];

                    if (item.date < DateTime.Now)
                    {
                        new MessageBoxForm("예매할 수 없는 일정입니다.").ShowDialog();
                        return;
                    }

                    if (entities.reservation.Count(x => x.schedule_no == item.no) >= 25)
                    {
                        new MessageBoxForm("해당 일정에 좌석이 모두 매진되었습니다.").ShowDialog();
                        return;
                    }

                    int point = 0;

                    if (item.elapsed_time <= new TimeSpan(1, 0, 0))
                        point = 100;
                    else if (item.elapsed_time <= new TimeSpan(2, 0, 0))
                        point = 300;
                    else if (item.elapsed_time <= new TimeSpan(3, 0, 0))
                        point = 500;
                    else
                        point = 700;

                    if(DataHelper.loginedUser.point < point)
                    {
                        new MessageBoxForm("포인트가 부족합니다.").ShowDialog();
                        return;
                    }

                    Model.user user = entities.user.Single(x => x.no == DataHelper.loginedUser.no);

                    user.point -= point;

                    Model.reservation reservationItem = new Model.reservation();

                    reservationItem.schedule_no = item.no;
                    reservationItem.user_no = user.no;

                    entities.reservation.Add(reservationItem);

                    entities.SaveChanges();

                    new MessageBoxForm("예매가 완료되었습니다.", false).ShowDialog();

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            if(this.Schedules != null)
            {
                int no = 1;

                foreach(var item in this.Schedules)
                {
                    this.dgvData.Rows.Add(no++,
                                          item.location21.location.name + " " + item.location21.name,
                                          item.location2.location.name + " " + item.location2.name,
                                          item.date.ToString("HH:mm:ss"),
                                          (item.date + item.elapsed_time).ToString("HH:mm:ss"),
                                          "예매");
                }
            }
        }
    }
}
