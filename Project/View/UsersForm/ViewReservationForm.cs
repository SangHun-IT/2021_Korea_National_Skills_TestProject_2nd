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
    public partial class ViewReservationForm : TemplateForm
    {

        Model.busticketbookingEntities Entities;
        List<Model.reservation> Reservations;

        public ViewReservationForm()
        {
            InitializeComponent();
            this.Entities = new Model.busticketbookingEntities();
            this.Reservations = this.Entities.reservation.Where(x => x.user_no == DataHelper.loginedUser.no).ToList();
        }

        private void ViewReservationForm_Load(object sender, EventArgs e)
        {
            int no = 1;
            foreach(Model.reservation r in this.Reservations)
            {
                this.dgvData.Rows.Add(no ++,
                                      r.schedule.location21.location.name + " " + r.schedule.location21.name,
                                      r.schedule.location2.location.name + " " + r.schedule.location2.name, 
                                      (r.schedule.date + r.schedule.elapsed_time).ToString("HH:mm:ss"), 
                                      r.schedule.date.ToString("yyyy-MM-dd HH:mm:ss"));
            }
        }

        private void ctCancelMenu_Click(object sender, EventArgs e)
        {
            if(this.dgvData.CurrentRow != null)
            {
                Model.reservation reservation = this.Reservations[this.dgvData.CurrentRow.Index];

                if(reservation.schedule.date < DateTime.Now)
                {
                    new MessageBoxForm("취소 불가능한 일정입니다.").ShowDialog();
                }
                else
                {
                    Model.user targetUser = this.Entities.user.Single(x => x.no == DataHelper.loginedUser.no);
                    
                    // Point 환불
                    if (reservation.schedule.elapsed_time <= new TimeSpan(1, 0, 0))
                        targetUser.point += 100;
                    else if(reservation.schedule.elapsed_time <= new TimeSpan(2, 0, 0))
                        targetUser.point += 300;
                    else if (reservation.schedule.elapsed_time <= new TimeSpan(3, 0, 0))
                        targetUser.point += 500;
                    else
                        targetUser.point += 700;

                    // 예약 정보 삭제
                    this.Entities.reservation.Remove(reservation);

                    this.Entities.SaveChanges();
                    
                    this.Reservations.Remove(reservation);
                    this.dgvData.Rows.RemoveAt(this.dgvData.CurrentRow.Index);

                    new MessageBoxForm("예매 취소가 완료되었습니다.", false).ShowDialog();
                }
            }
            else
            {
                new MessageBoxForm("예매 취소할 데이터를 먼저 선택해주세요.").ShowDialog();
            }
        }
    }
}
