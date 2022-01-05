using Project.Controller;
using Project.View.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.View
{
    public partial class TemplateForm : Form
    {

        public Action<DateTime> OnSelectedDate;
        public Action<Model.location2> OnSelectedLocation;

        public TemplateForm()
        {
            InitializeComponent();
        }

        private void TemplateForm_Load(object sender, EventArgs e)
        {
            DataHelper.colorChangedEvent += this.colorChangedEvent;

            this.colorChangedEvent(DataHelper.colorMode);
        }

        private void colorChangedEvent(Color c)
        {
            this.BackColor = c;

            if (this.BackColor == DataHelper.COLOR_MODE_BLACK)
                this.ForeColor = Color.White;
            else
                this.ForeColor = Color.Black;

            foreach (Control con in this.Controls)
                if (con is Panel || con is PlaceHolderTextBox || con is GroupBox) ChangeControlColor(con, c);
        }

        private void ChangeControlColor(Control con, Color c)
        {
            if (con is PlaceHolderTextBox)
            {
                (con as PlaceHolderTextBox).ChangeColorMode(c);
            }
            else
            {
                if (con.Tag == null || con.Tag.ToString() != "Skip")
                {

                    con.BackColor = c;

                    if (con.BackColor == DataHelper.COLOR_MODE_BLACK)
                        con.ForeColor = Color.White;
                    else
                        con.ForeColor = Color.Black;
                }
            }

            foreach (Control cons in con.Controls)
                if (cons is Panel || cons is PlaceHolderTextBox || cons is GroupBox) ChangeControlColor(cons, c);
        }

        private void TemplateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataHelper.colorChangedEvent -= this.colorChangedEvent;
        }
    }
}
