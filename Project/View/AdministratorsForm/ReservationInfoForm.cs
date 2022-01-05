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
    public partial class ReservationInfoForm : TemplateForm
    {
        private int userNo;
        private List<Model.reservation> reservations;

        public ReservationInfoForm()
        {
            InitializeComponent();
        }

        public ReservationInfoForm(int userNo) : this()
        {
            this.userNo = userNo;
        }

        private void ReservationInfoForm_Load(object sender, EventArgs e)
        {
            Model.busticketbookingEntities entities = new Model.busticketbookingEntities();

            this.reservations = entities.reservation.Where(x => x.user_no == this.userNo).OrderBy(y => y.schedule.date).ToList();

            int no = 1;

            foreach(var item in this.reservations)
            {

                string departure = item.schedule.location21.location.name + " " + item.schedule.location21.name;
                string arrival = item.schedule.location2.location.name + " " + item.schedule.location2.name;

                this.dgvData.Rows.Add(no ++, departure, arrival, (item.schedule.date + item.schedule.elapsed_time).ToString("HH:mm:ss"), item.schedule.date.ToString("yyyy-MM-dd HH:mm:ss"));
            }

            if(this.reservations.Count > 0)
            {
                int month = this.reservations[0].schedule.date.Month;

                int minval = int.MaxValue;
                int maxval = 0;

                for(int i = 0; i < 3; i ++)
                {
                    int cnt = this.reservations.Count(x => x.schedule.date.Month == month + i);
                    this.chart.Series[0].Points.AddXY((month + i) + "월", cnt);
                    this.chart.Series[1].Points.AddXY((month + i) + "월", cnt);

                    if (maxval < cnt) maxval = cnt;
                    if (minval > cnt) minval = cnt;
                }

                this.chart.ChartAreas[0].AxisY.Minimum = minval;
                this.chart.ChartAreas[0].AxisY.Maximum = maxval;
            }
            

        }
    }
}
