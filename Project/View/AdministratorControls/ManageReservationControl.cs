using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.View.AdministratorMenu
{
    public partial class ManageReservationControl : TemplateControl
    {
        private Model.busticketbookingEntities entities;
        private List<Model.reservation> reservations;
        private List<Model.schedule> top6schedule;

        private int selectedRowIndex;
        private int selectedColIndex;
        private bool isEdited;
       
        public ManageReservationControl()
        {
            InitializeComponent();
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbType.SelectedIndex != -1)
                PaintChart();
        }

        private void PaintChart()
        {
            if(this.cmbType.SelectedIndex == 0)
            {
                // 2차원 영역형 그리기
                this.chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            }
            else
            {
                // 방사형 그리기
                this.chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar;
                this.chart.Series[0].SetCustomProperty("AreaDrawingStyle", "Polygon");
                this.chart.Series[0].SetCustomProperty("RadarDrawingStyle", "Line");
                this.chart.Series[0].BorderWidth = 2;
            }
        }

        private void ManageReservationControl_Load(object sender, EventArgs e)
        {
            this.entities = new Model.busticketbookingEntities();
            this.reservations = this.entities.reservation.ToList();


            foreach(var item in this.reservations)
            {
                string departure = item.schedule.location21.location.name + " " + item.schedule.location21.name;
                string arrival = item.schedule.location2.location.name + " " + item.schedule.location2.name;
                string departureDate = item.schedule.date.ToString("yyyy-MM-dd HH:mm:ss");
                string elapsed_time = item.schedule.elapsed_time.ToString(@"hh\:mm\:ss");

                this.dgvReservation.Rows.Add(item.no, item.user.name, departure, arrival, departureDate, elapsed_time);
            }

            this.cmbType.SelectedIndex = 0;

            this.top6schedule = this.entities.schedule.OrderByDescending(x => x.reservation.Count).ThenBy(y => y.no).Take(6).ToList();

            this.chart.Series[0].Points.Clear();

            foreach (var item in this.top6schedule)
            {
                this.chart.Series[0].Points.AddXY(item.no + " ", item.reservation.Count);
            }

            this.chart.ChartAreas[0].AxisY.Maximum = this.top6schedule[0].reservation.Count;

            if (this.top6schedule[0].reservation.Count % 2 == 0)
                this.chart.ChartAreas[0].AxisY.Minimum = 0;
            else
                this.chart.ChartAreas[0].AxisY.Minimum = 1;

            PaintChart();
        }

        private void LoadChartData()
        {
            this.top6schedule = this.entities.schedule.OrderByDescending(x => x.reservation.Count).ThenBy(y => y.no).Take(6).ToList();

            this.chart.Series[0].Points.Clear();

            foreach (var item in this.top6schedule)
            {
                this.chart.Series[0].Points.AddXY(item.no + " ", item.reservation.Count);
            }

            this.chart.ChartAreas[0].AxisY.Maximum = this.top6schedule[0].reservation.Count;

            if (this.top6schedule[0].reservation.Count % 2 == 0)
                this.chart.ChartAreas[0].AxisY.Minimum = 0;
            else
                this.chart.ChartAreas[0].AxisY.Minimum = 1;
        }

        private void dgvReservation_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex == this.dgvReservation.CurrentRow.Index && e.ColumnIndex >= 2 && e.ColumnIndex <= 3)
            {
                Model.location2 location2 = e.ColumnIndex == 1 ? this.reservations[e.RowIndex].schedule.location21 : this.reservations[e.RowIndex].schedule.location2;

                selectedRowIndex = e.RowIndex;
                selectedColIndex = e.ColumnIndex;

                LocationListPopupForm popup = new LocationListPopupForm(location2.location);

                popup.OnSelectedLocation += this.OnSelectedLocation;
                // 위치 잡아야 함
                Rectangle cellRange = this.dgvReservation.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);

                popup.StartPosition = FormStartPosition.Manual;

                Point controlPosition = this.FindForm().PointToClient(this.dgvReservation.PointToScreen(cellRange.Location));

                popup.Location = new Point(this.FindForm().Location.X + controlPosition.X + e.X, this.FindForm().Location.Y + controlPosition.Y + e.Y + cellRange.Height);

                popup.Show();
            }
        }

        private void OnSelectedLocation(Model.location2 location)
        {
            Model.reservation reservation = this.reservations[selectedRowIndex];            

            if (selectedColIndex == 2)
            {
                // 출발지 변경
                reservation.schedule.location21 = location;
            }
            else
            {
                reservation.schedule.location2 = location;
                // 도착지 변경
            }
            isEdited = true;

            // 여기서 출발지 도착지를 변경하는건 개별 변경이 아닌
            // 스케줄 정보를 변경하는 것이므로 관련된 스케줄 모두를 바꿔서 보여줘야 함.
           
            for(int i = 0; i < this.reservations.Count; i ++)
            {
                if(this.reservations[i].schedule == reservation.schedule)
                {
                    string departure = reservation.schedule.location21.location.name + " " + reservation.schedule.location21.name;
                    string arrival = reservation.schedule.location2.location.name + " " + reservation.schedule.location2.name;

                    this.dgvReservation[2, i].Value = departure;
                    this.dgvReservation[3, i].Value = arrival;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // 저장 버튼

            if (isEdited)
            {
                this.entities.SaveChanges();

                isEdited = false;

                new MessageBoxForm("수정내용을 저장 완료하였습니다.", false).ShowDialog();
            }
            else
                new MessageBoxForm("저장할 데이터가 없습니다.").ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // 삭제 버튼
            if (this.dgvReservation.CurrentRow.Cells.Count== -1)
                new MessageBoxForm("삭제할 데이터를 선택하세요.").ShowDialog();
            else
            {
                Model.reservation reservation = this.reservations[this.dgvReservation.CurrentRow.Index];

                this.reservations.Remove(reservation);

                this.entities.reservation.Remove(reservation);
                this.entities.SaveChanges();

                this.dgvReservation.Rows.RemoveAt(this.dgvReservation.CurrentRow.Index);

                // 삭제후 데이터 변동 시 차트도 업데이트 되어야 하므로 다시 불러주기
                LoadChartData();
                PaintChart();

                new MessageBoxForm("삭제를 완료하였습니다.", false).ShowDialog();
            }
        }
    }
}
