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
    public partial class ManageScheduleControl : TemplateControl
    {
        private Model.busticketbookingEntities entities;
        private List<Model.schedule> schedules;
        private int selectedRowIndex;
        private int selectedColIndex;
        private bool isEdited;

        public ManageScheduleControl()
        {
            InitializeComponent();
        }

        private void ManageScheduleControl_Load(object sender, EventArgs e)
        {
            this.entities = new Model.busticketbookingEntities();
            this.schedules = this.entities.schedule.ToList();

            foreach(var sc in this.schedules)
            {
                string departure = sc.location21.location.name + " " + sc.location21.name;
                string arrival = sc.location2.location.name + " " + sc.location2.name;

                this.dgvSchedules.Rows.Add(sc.no, departure, arrival, sc.date.ToString("yyyy-MM-dd HH:mm:ss"), sc.elapsed_time.ToString(@"hh\:mm\:ss"));
            }
        }

        private void dgvSchedules_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex == this.dgvSchedules.CurrentRow.Index && e.ColumnIndex >= 1 && e.ColumnIndex <= 2) 
            {
                Model.location2 location2 = e.ColumnIndex == 1 ? this.schedules[e.RowIndex].location21 : this.schedules[e.RowIndex].location2;

                selectedRowIndex = e.RowIndex;
                selectedColIndex = e.ColumnIndex;

                LocationListPopupForm popup = new LocationListPopupForm(location2.location);

                popup.OnSelectedLocation += this.OnSelectedLocation;
                // 위치 잡아야 함
                Rectangle cellRange = this.dgvSchedules.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);

                popup.StartPosition = FormStartPosition.Manual;

                Point controlPosition = this.FindForm().PointToClient(this.dgvSchedules.PointToScreen(cellRange.Location));

                popup.Location = new Point(this.FindForm().Location.X + controlPosition.X + e.X, this.FindForm().Location.Y + controlPosition.Y + e.Y + cellRange.Height);

                popup.Show();
            }
        }

        private void OnSelectedLocation(Model.location2 location)
        {
            if(selectedColIndex == 1)
            {
                // 출발지 변경
                this.schedules[this.selectedRowIndex].location21 = location;
                this.dgvSchedules[1, selectedRowIndex].Value = location.location.name + " " + location.name;
            }
            else
            {
                // 도착지 변경
                this.schedules[this.selectedRowIndex].location2 = location;
                this.dgvSchedules[2, selectedRowIndex].Value = location.location.name + " " + location.name;
            }
            isEdited = true;
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
            if (this.dgvSchedules.CurrentRow.Cells.Count == 0)
                new MessageBoxForm("삭제할 데이터를 선택하세요.").ShowDialog();
            else
            {
                Model.schedule sc = this.schedules[this.dgvSchedules.CurrentRow.Index];

                this.schedules.Remove(sc);

                this.entities.schedule.Remove(sc);
                this.entities.SaveChanges();

                this.dgvSchedules.Rows.RemoveAt(this.dgvSchedules.CurrentRow.Index);
                
                new MessageBoxForm("삭제를 완료하였습니다.", false).ShowDialog();
            }
        }
    }
}
