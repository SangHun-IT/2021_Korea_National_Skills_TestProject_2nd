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
    public partial class LocationListPopupForm : TemplateForm
    {
        Model.busticketbookingEntities entities;
        List<Model.location> locations;
        List<Model.location2> location2s;

        public Model.location2 selectedLocation2;

        public LocationListPopupForm()
        {
            InitializeComponent();
            this.entities = new Model.busticketbookingEntities();
            this.locations = this.entities.location.ToList();
        }

        public LocationListPopupForm(Model.location location) : this()
        {
            this.location2s = this.entities.location2.Where(x => x.location_no == location.no).ToList();

            this.dgvLocation2.Rows.Clear();
            this.dgvLocation2.Visible = true;

            foreach (var i in this.location2s)
            {
                this.dgvLocation2.Rows.Add(i.name);
            }
        }

        private void LocationListPopupForm_Load(object sender, EventArgs e)
        {
            foreach(var item in this.locations)
            {
                this.dgvLocation1.Rows.Add(item.name);
            }
        }

        private void dgvLocation1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Location 1 클릭 했을 때
            Model.location item = this.locations[e.RowIndex];

            this.location2s = this.entities.location2.Where(x => x.location_no == item.no).ToList();

            this.dgvLocation2.Rows.Clear();
            this.dgvLocation2.Visible = true;

            foreach(var i in this.location2s)
            {
                this.dgvLocation2.Rows.Add(i.name);
            }
        }

        private void dgvLocation2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Model.location2 item = this.location2s[e.RowIndex];

            this.selectedLocation2 = item;
            if (this.OnSelectedLocation != null) this.OnSelectedLocation(item);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void LocationListPopupForm_Deactivate(object sender, EventArgs e)
        {
            if(this.DialogResult != DialogResult.OK)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}
