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

namespace Project.View.AdministratorMenu
{
    public partial class ManageLocationControl : TemplateControl
    {
        private Model.busticketbookingEntities entities;
        private Model.recommend currentRecommend;
        private List<Model.recommend_info> recommend_Infos;
        public ManageLocationControl()
        {
            InitializeComponent();
            this.entities = new Model.busticketbookingEntities();
        }

        private void loadRecommends()
        {
            List<Model.recommend> recommends = this.entities.recommend.OrderBy(x => x.no).ToList();

            for (int i = 1; i <= 5; i++)
            {
                GroupBox gBox = (GroupBox)this.flpRecommend.Controls["gbLocation" + i];

                gBox.Text = recommends[i - 1].location.name;

                PictureBox pb = (PictureBox)gBox.Controls[0];
                MemoryStream ms = new MemoryStream(recommends[i - 1].recommend_info.OrderBy(x => x.title).ToList()[0].img);

                pb.Image = Image.FromStream(ms);

                ms.Close();

                gBox.Tag = recommends[i - 1];
            }
        }

        private void ManageLocationControl_Load(object sender, EventArgs e)
        {
            loadRecommends();
            this.currentRecommend = (Model.recommend)this.gbLocation1.Tag;
            SetRecommendInfos();
        }

        private void menuImageSet_Click(object sender, EventArgs e)
        {
            // 바로가기 메뉴 - 이미지 설정
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG & png Images (*.jpg; *.png) | *.jpg; *.png";
            ofd.Multiselect = false;
            ofd.Title = "열기";

            if(ofd.ShowDialog () == DialogResult.OK) 
            {
                GroupBox gb = (GroupBox)this.contextRecommend.Tag;
                Model.recommend recommend = (Model.recommend)gb.Tag;

                if(recommend.recommend_info.Count > 0)
                {
                    Model.recommend_info firstRecommend = recommend.recommend_info.OrderBy(x => x.title).ToList()[0];

                    firstRecommend.img = File.ReadAllBytes(ofd.FileName);
                    firstRecommend.title = ofd.SafeFileName.Substring(0, ofd.SafeFileName.LastIndexOf('.'));

                    this.entities.SaveChanges();

                    loadRecommends();

                    if (this.currentRecommend == recommend)
                        SetRecommendInfos();
                }
                else
                {
                    Model.recommend_info item = new Model.recommend_info();
                    item.recommend_no = recommend.no;
                    item.img = File.ReadAllBytes(ofd.FileName);
                    item.title = ofd.SafeFileName.Substring(0, ofd.SafeFileName.LastIndexOf('.'));
                    this.entities.recommend_info.Add(item);
                    this.entities.SaveChanges();
                }
            }
        }

        private void menuDesciptionSet_Click(object sender, EventArgs e)
        {
            // 바로가기 메뉴 - 설명 설정
            GroupBox gb = (GroupBox)this.contextRecommend.Tag;
            this.currentRecommend = (Model.recommend)gb.Tag;
            SetRecommendInfos();
        }


        // 추천 여행지 이미지 우클릭시 
        private void recommendPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                // groupBox로 셋
                contextRecommend.Tag = ((PictureBox)sender).Parent;

                contextRecommend.Show((PictureBox)sender, e.Location);
            }
        }

        //설명 설정 이미지 우클릭시
        private void descriptionPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // groupBox로 셋
                contextDescription.Tag = ((PictureBox)sender).Tag;

                contextDescription.Show((PictureBox)sender, e.Location);
            }
        }

        private void SetRecommendInfos()
        {
            this.recommend_Infos = this.entities.recommend_info.Where(x => x.recommend_no == this.currentRecommend.no).OrderBy(x => x.title).ToList();

            this.flpDescription.Controls.Clear();

            foreach(var item in this.recommend_Infos)
            {
                PictureBox pb = new PictureBox();
                MemoryStream ms = new MemoryStream(item.img);

                pb.Image = Image.FromStream(ms);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Size = new Size(this.flpDescription.Height - 20, this.flpDescription.Height - 20);
                pb.BorderStyle = BorderStyle.FixedSingle;
                pb.Tag = item;
                pb.MouseDown += this.descriptionPictureBox_MouseDown;

                ms.Close();

                this.flpDescription.Controls.Add(pb);
            }
        }

        private void menuDelete_Click(object sender, EventArgs e)
        {
            // 바로가기 메뉴 - recommend_info 삭제
            Model.recommend_info recommend_Info = (Model.recommend_info)this.contextDescription.Tag;

            this.entities.recommend_info.Remove(recommend_Info);
            this.entities.SaveChanges();

            SetRecommendInfos();
        }

        private void menuInputDescription_Click(object sender, EventArgs e)
        {
            // 바로가기 메뉴 - 설명 텍스트 입력
            Model.recommend_info recommend_Info = (Model.recommend_info)this.contextDescription.Tag;

            InputTextForm inputTextForm = new InputTextForm(recommend_Info.description);

           if (inputTextForm.ShowDialog() == DialogResult.OK)
            {
                recommend_Info.description = inputTextForm.TextResult;
                this.entities.SaveChanges();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // 추가 버튼
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG & png Images (*.jpg; *.png) | *.jpg; *.png";
            ofd.Multiselect = false;
            ofd.Title = "열기";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string title = ofd.SafeFileName.Substring(0, ofd.SafeFileName.LastIndexOf('.'));

                if (currentRecommend.recommend_info.Count(x=>x.title == title) > 0)
                {
                    new MessageBoxForm("중복된 제목입니다.").ShowDialog();
                }
                else
                {
                    Model.recommend_info item = new Model.recommend_info();
                    item.recommend_no = currentRecommend.no;
                    item.img = File.ReadAllBytes(ofd.FileName);
                    item.title = ofd.SafeFileName.Substring(0, ofd.SafeFileName.LastIndexOf('.'));
                    this.entities.recommend_info.Add(item);
                    this.entities.SaveChanges();

                    loadRecommends();
                    SetRecommendInfos();
                }
            }
        }
    }
}
