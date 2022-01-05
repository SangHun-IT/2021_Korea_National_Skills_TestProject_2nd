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
    public partial class InputTextForm : TemplateForm
    {
        public string TextResult { get { return this.txtText.Text; } }
        public InputTextForm()
        {
            InitializeComponent();
        }

        public InputTextForm(string val): this()
        {
            this.txtText.Text = val;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void InputTextForm_Load(object sender, EventArgs e)
        {
            this.picIcon.Image = SystemIcons.Question.ToBitmap();
        }
    }
}
