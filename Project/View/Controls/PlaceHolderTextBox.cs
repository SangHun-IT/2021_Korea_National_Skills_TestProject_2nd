using Project.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.View.Controls
{
    public partial class PlaceHolderTextBox : UserControl
    {
        public string textResult { get { return this.txtText.Text; } set { this.txtText.Text = value; } }
        public bool isListMode { get; set; }
        public bool isDateSelect { get; set; }
        public bool isReadOnly { get { return this.txtText.ReadOnly; } set { this.txtText.ReadOnly = value; } }
        public char passwordChar
        {
            get { return this.txtText.PasswordChar; }
            set { this.txtText.PasswordChar = value; }
        }
        public Model.location2 selectedLocation { get; set; }
        public Nullable<DateTime> selectedDate { get; private set; }

        public string placeHolder { 
            get
            {
                return this.lbPlaceHolder.Text;
            }
            set
            {
                this.lbPlaceHolder.Text = value;
            }
        }
        public PlaceHolderTextBox()
        {
            InitializeComponent();
            this.selectedLocation = null;
            this.selectedDate = null;
        }

        private void lbPlaceHolder_Click(object sender, EventArgs e)
        {
            if(!isListMode)
            {
                this.lbPlaceHolder.Visible = false;
                this.txtText.Focus();
            }
        }

        private void txtText_Leave(object sender, EventArgs e)
        {
            if(this.txtText.Text == "" && !isListMode)
            {
                this.lbPlaceHolder.Visible = true;
            }
        }
        private void PlaceHolderTextBox_Enter(object sender, EventArgs e)
        {
            if(!isListMode)
            {
                this.lbPlaceHolder.Visible = false;
                this.txtText.Focus();
            }
        }

        public void ChangeColorMode(Color color)
        {
            this.BackColor = color;
            this.txtText.BackColor = color;
            this.lbPlaceHolder.BackColor = color;

            if (color == DataHelper.COLOR_MODE_BLACK)
            {
                this.ForeColor = Color.White;
                this.txtText.ForeColor = Color.White;
                this.lbPlaceHolder.ForeColor = Color.Gray;
            }
            else
            {
                this.ForeColor = Color.Black;
                this.txtText.ForeColor = Color.Black;
                this.lbPlaceHolder.ForeColor = Color.Gray;
            }
        }

        private void PlaceHolderTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if(isListMode && e.Button == MouseButtons.Right)
            {
                TemplateForm popup;
                if(isDateSelect)
                {
                    if(this.selectedDate == null)
                        popup = new DateSelectForm();
                    else
                        popup = new DateSelectForm(this.selectedDate.Value);

                    popup.OnSelectedDate += this.OnSelectedDate;
                }
                else
                {
                    popup = new LocationListPopupForm();
                    popup.OnSelectedLocation += this.OnSelectedLocation;
                }
                    

                popup.StartPosition = FormStartPosition.Manual;
                
                Point controlPosition = this.FindForm().PointToClient(this.Parent.PointToScreen(this.Location));

                popup.Location = new Point(this.FindForm().Location.X + controlPosition.X, this.FindForm().Location.Y + controlPosition.Y + this.Parent.Height);

                popup.Show();
            }
        }

        public void OnSelectedDate(DateTime date)
        {
            this.selectedDate = date;
            this.textResult = this.selectedDate.Value.ToString("yyyy-MM-dd");

            this.lbPlaceHolder.Visible = false;
        }

        public void OnSelectedLocation(Model.location2 location)
        {
            this.selectedLocation = location;
            this.textResult = this.selectedLocation.location.name + " " + this.selectedLocation.name;

            this.lbPlaceHolder.Visible = false;
        }
    }
}
