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
    public partial class DetailDescriptionForm : TemplateForm
    {
        private int recommendNo;
        private List<Model.recommend_info> recommend_Infos;
        public DetailDescriptionForm()
        {
            InitializeComponent();
        }

        public DetailDescriptionForm(int recommendNo) : this()
        {
            this.recommendNo = recommendNo;
            Model.busticketbookingEntities entities = new Model.busticketbookingEntities();
            this.recommend_Infos = entities.recommend_info.Where(x => x.recommend_no == this.recommendNo).OrderBy(x => x.recommend_no).ThenBy(y => y.title).ToList();
        }

        private void DetailDescriptionForm_Load(object sender, EventArgs e)
        {
            foreach(var item in this.recommend_Infos)
            {
                if(item.img != null)
                {
                    PictureBox picture = new PictureBox();
                    picture.Size = new Size(this.flowContent.Width - 25, this.flowContent.Width - 120);

                    MemoryStream ms = new MemoryStream(item.img);
                    picture.Image = Image.FromStream(ms);
                    ms.Close();

                    picture.SizeMode = PictureBoxSizeMode.StretchImage;

                    this.flowContent.Controls.Add(picture);
                }

                if(item.description != "")
                {
                    TextBox txtBox = new TextBox();
                    
                    txtBox.Text = item.description;
                    txtBox.Width = this.flowContent.Width - 25;
                    txtBox.Height = this.flowContent.Width - 120;

                    txtBox.Enabled = false;
                    txtBox.BackColor = Color.White;
                    txtBox.ForeColor = Color.Black;
                    txtBox.Multiline = true;

                    this.flowContent.Controls.Add(txtBox);
                }
            }
        }
    }
}
