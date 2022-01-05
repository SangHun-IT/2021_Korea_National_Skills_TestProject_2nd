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
    public partial class DateSelectForm : TemplateForm
    {
        public DateTime date;

        public DateSelectForm()
        {
            InitializeComponent();
            this.date = DateTime.Now.Date;
        }

        public DateSelectForm(DateTime date) : this()
        {
            this.date = date;
            PrintDate();
        }

        private void btnUpYear_Click(object sender, EventArgs e)
        {
            this.date = this.date.AddYears(1);
            PrintDate();
        }

        private void btnUpMonth_Click(object sender, EventArgs e)
        {
            this.date = this.date.AddMonths(1);
            PrintDate();
        }

        private void btnUpDay_Click(object sender, EventArgs e)
        {
            this.date = this.date.AddDays(1);
            PrintDate();
        }

        private void btnDownYear_Click(object sender, EventArgs e)
        {
            this.date = this.date.AddYears(-1);
            PrintDate();
        }

        private void btnDownMonth_Click(object sender, EventArgs e)
        {
            this.date = this.date.AddMonths(-1);
            PrintDate();
        }

        private void btnDownDay_Click(object sender, EventArgs e)
        {
            this.date = this.date.AddDays(-1);
            PrintDate();
        }

        private void PrintDate()
        {
            this.txtYear.Text = this.date.Year + "";
            this.txtMonth.Text = this.date.Month + "";
            this.txtDay.Text = this.date.Day + "";
        }

        private void DateSelectForm_Load(object sender, EventArgs e)
        {
            PrintDate();
        }

        private void txtYear_Validating(object sender, CancelEventArgs e)
        {
            int year = 0;

            if (!int.TryParse(this.txtYear.Text, out year))
            {
                new MessageBoxForm("숫자로만 입력하세요.").ShowDialog();
                e.Cancel = true;
            }
            else
            {
                int month = this.date.Month;
                int day = this.date.Day;

                this.date = new DateTime(year, 1, 1);
                this.date = this.date.AddMonths(month - 1);
                this.date = this.date.AddDays(day - 1);

                PrintDate();
            }
        }

        private void txtMonth_Validating(object sender, CancelEventArgs e)
        {
            int month = 0;

            if (!int.TryParse(this.txtMonth.Text, out month))
            {
                new MessageBoxForm("숫자로만 입력하세요.").ShowDialog();
                e.Cancel = true;
            }
            else
            {
                int year = this.date.Year;
                int day = this.date.Day;

                this.date = new DateTime(year, month, 1);
                this.date = this.date.AddDays(day - 1);

                PrintDate();
            }
        }

        private void txtDay_Validating(object sender, CancelEventArgs e)
        {
            int day = 0;

            if (!int.TryParse(this.txtDay.Text, out day))
            {
                new MessageBoxForm("숫자로만 입력하세요.").ShowDialog();
                e.Cancel = true;
            }
            else
            {
                int year = this.date.Year;
                int month = this.date.Month;

                this.date = new DateTime(year, month, day);

                PrintDate();
            }
        }

        private void DateSelectForm_Deactivate(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            if (this.OnSelectedDate != null) this.OnSelectedDate(this.date);
            this.Close();
        }
    }
}
