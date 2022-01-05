using Project.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.View
{
    public partial class UserMainForm : TemplateForm
    {
        private List<Model.recommend> recommendList;

        public UserMainForm()
        {
            InitializeComponent();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            new PasswordBoxConfirmForm().ShowDialog();
        }

        private void UserMainForm_Load(object sender, EventArgs e)
        {
            Model.busticketbookingEntities entities = new Model.busticketbookingEntities();

            this.recommendList = entities.recommend.OrderBy(x => x.no).ToList();

            for(int i = 1; i <= 5; i++)
            {
                
                this.panBottom.Controls["gbLocation" + i].Text = recommendList[i - 1].location.name;

                if(recommendList[i - 1].recommend_info.Count > 0)
                {
                    Model.recommend_info firstRecommend_Info = recommendList[i - 1].recommend_info.ToList()[0];
                    
                    if(firstRecommend_Info.img != null)
                    {
                        PictureBox pic = this.panBottom.Controls["gbLocation" + i].Controls[0] as PictureBox;

                        MemoryStream ms = new MemoryStream(firstRecommend_Info.img);
                        pic.Image = Image.FromStream(ms);
                        ms.Close();
                    }
                }
            }
        }

        private void btnTheme_Click(object sender, EventArgs e)
        {
            DataHelper.changeColorMode();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            new ViewReservationForm().ShowDialog();
        }

        private void btnExchange_Click(object sender, EventArgs e)
        {
            if (phtDeparture.selectedLocation != null && phtArrival.selectedLocation != null)
            {
                Model.location2 temp = phtDeparture.selectedLocation;
                phtDeparture.selectedLocation = phtArrival.selectedLocation;
                phtArrival.selectedLocation = temp;

                phtArrival.textResult = phtArrival.selectedLocation.location.name + " " + phtArrival.selectedLocation.name;
                phtDeparture.textResult = phtDeparture.selectedLocation.location.name + " " + phtDeparture.selectedLocation.name;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // 조회 버튼
            if(this.phtDeparture.selectedLocation == null || this.phtArrival.selectedLocation == null || this.phtDate.selectedDate == null)
            {
                new MessageBoxForm("출발지, 도착지, 날짜 중 공한이 있습니다.").ShowDialog();
                return;
            }

            Model.busticketbookingEntities entities = new Model.busticketbookingEntities();

            Model.location2 departure = this.phtDeparture.selectedLocation;
            Model.location2 arrival = this.phtArrival.selectedLocation;
            DateTime date = this.phtDate.selectedDate.Value;

            if(entities.schedule.Count(x=>x.departure_location2_no == departure.no && x.arrival_location2_no == arrival.no && x.date == date) > 0)
            {
                List<Model.schedule> schedules = entities.schedule.Where(x => x.departure_location2_no == departure.no && x.arrival_location2_no == arrival.no && x.date == date).ToList();

                new ReservationForm(schedules).ShowDialog();
            }
            else
            {
                new MessageBoxForm("예매 가능한 일정이 없습니다.").ShowDialog();
                return;
            }
        }

        private void ctxtDescriptionMenu_Click(object sender, EventArgs e)
        {
            // 상세설명 팝업 메뉴
            int index = int.Parse(this.ctxtReserveMenu.Tag.ToString());
            Model.recommend item = this.recommendList[index];
            
            DetailDescriptionForm popup = new DetailDescriptionForm(item.no);

            popup.ShowDialog();
        }

        private void ctxtReserveMenu_Click(object sender, EventArgs e)
        {
            // 예매 팝업 메뉴
            int index = int.Parse(this.ctxtReserveMenu.Tag.ToString());
            Model.recommend item = this.recommendList[index];

            LocationListPopupForm popup = new LocationListPopupForm(item.location);
            popup.OnSelectedLocation += this.OnSelectedLocation;

            popup.StartPosition = FormStartPosition.Manual;

            Point controlPosition = this.phtArrival.FindForm().PointToClient(this.phtArrival.Parent.PointToScreen(this.phtArrival.Location));

            popup.Location = new Point(this.phtArrival.FindForm().Location.X + controlPosition.X, this.phtArrival.FindForm().Location.Y + controlPosition.Y + this.phtArrival.Parent.Height);

            popup.Show();
        }

        private void OnSelectedLocation(Model.location2 location)
        {
            this.phtArrival.OnSelectedLocation(location);
        }

        private void picLocation_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                this.ctxtReserveMenu.Tag = ((Control)sender).Tag;
            }
        }


    }
}
