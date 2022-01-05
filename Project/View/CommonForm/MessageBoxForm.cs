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
    public partial class MessageBoxForm : TemplateForm
    {
        public MessageBoxForm()
        {
            InitializeComponent();
        }

        public MessageBoxForm(string message, bool isError = true) : this()
        {
            if(isError)
            {
                this.picIcon.Image = SystemIcons.Error.ToBitmap();
                this.Text = "오류";
            }
            else
            {
                this.picIcon.Image = SystemIcons.Information.ToBitmap();
                this.Text = "안내";
            }
                

            this.lbMessage.Text = message;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void MessageBoxForm_Load(object sender, EventArgs e)
        {

        }
    }
}
