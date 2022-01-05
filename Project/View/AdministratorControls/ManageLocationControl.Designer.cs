
namespace Project.View.AdministratorMenu
{
    partial class ManageLocationControl
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panBack = new System.Windows.Forms.Panel();
            this.flpDescription = new System.Windows.Forms.FlowLayoutPanel();
            this.panCenterHeader = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.flpRecommend = new System.Windows.Forms.FlowLayoutPanel();
            this.gbLocation1 = new System.Windows.Forms.GroupBox();
            this.picLocation1 = new System.Windows.Forms.PictureBox();
            this.gbLocation2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbLocation3 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gbLocation4 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.gbLocation5 = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextRecommend = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuImageSet = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDesciptionSet = new System.Windows.Forms.ToolStripMenuItem();
            this.contextDescription = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInputDescription = new System.Windows.Forms.ToolStripMenuItem();
            this.panBack.SuspendLayout();
            this.panCenterHeader.SuspendLayout();
            this.flpRecommend.SuspendLayout();
            this.gbLocation1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLocation1)).BeginInit();
            this.gbLocation2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbLocation3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gbLocation4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.gbLocation5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.contextRecommend.SuspendLayout();
            this.contextDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // panBack
            // 
            this.panBack.Controls.Add(this.flpDescription);
            this.panBack.Controls.Add(this.panCenterHeader);
            this.panBack.Controls.Add(this.flpRecommend);
            this.panBack.Controls.Add(this.label1);
            this.panBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panBack.Location = new System.Drawing.Point(20, 20);
            this.panBack.Name = "panBack";
            this.panBack.Size = new System.Drawing.Size(1018, 607);
            this.panBack.TabIndex = 0;
            // 
            // flpDescription
            // 
            this.flpDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpDescription.Location = new System.Drawing.Point(0, 391);
            this.flpDescription.Name = "flpDescription";
            this.flpDescription.Size = new System.Drawing.Size(1018, 216);
            this.flpDescription.TabIndex = 3;
            // 
            // panCenterHeader
            // 
            this.panCenterHeader.Controls.Add(this.btnAdd);
            this.panCenterHeader.Controls.Add(this.label2);
            this.panCenterHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panCenterHeader.Location = new System.Drawing.Point(0, 327);
            this.panCenterHeader.Name = "panCenterHeader";
            this.panCenterHeader.Size = new System.Drawing.Size(1018, 64);
            this.panCenterHeader.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(192, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 36);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 64);
            this.label2.TabIndex = 1;
            this.label2.Text = "설명 설정";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flpRecommend
            // 
            this.flpRecommend.Controls.Add(this.gbLocation1);
            this.flpRecommend.Controls.Add(this.gbLocation2);
            this.flpRecommend.Controls.Add(this.gbLocation3);
            this.flpRecommend.Controls.Add(this.gbLocation4);
            this.flpRecommend.Controls.Add(this.gbLocation5);
            this.flpRecommend.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpRecommend.Location = new System.Drawing.Point(0, 55);
            this.flpRecommend.Name = "flpRecommend";
            this.flpRecommend.Size = new System.Drawing.Size(1018, 272);
            this.flpRecommend.TabIndex = 1;
            // 
            // gbLocation1
            // 
            this.gbLocation1.Controls.Add(this.picLocation1);
            this.gbLocation1.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold);
            this.gbLocation1.Location = new System.Drawing.Point(3, 3);
            this.gbLocation1.Name = "gbLocation1";
            this.gbLocation1.Size = new System.Drawing.Size(195, 191);
            this.gbLocation1.TabIndex = 3;
            this.gbLocation1.TabStop = false;
            this.gbLocation1.Text = "부산";
            // 
            // picLocation1
            // 
            this.picLocation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLocation1.Location = new System.Drawing.Point(3, 23);
            this.picLocation1.Name = "picLocation1";
            this.picLocation1.Size = new System.Drawing.Size(189, 165);
            this.picLocation1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLocation1.TabIndex = 0;
            this.picLocation1.TabStop = false;
            this.picLocation1.Tag = "0";
            this.picLocation1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.recommendPictureBox_MouseDown);
            // 
            // gbLocation2
            // 
            this.gbLocation2.Controls.Add(this.pictureBox1);
            this.gbLocation2.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold);
            this.gbLocation2.Location = new System.Drawing.Point(204, 3);
            this.gbLocation2.Name = "gbLocation2";
            this.gbLocation2.Size = new System.Drawing.Size(195, 191);
            this.gbLocation2.TabIndex = 4;
            this.gbLocation2.TabStop = false;
            this.gbLocation2.Text = "강원도";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "0";
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.recommendPictureBox_MouseDown);
            // 
            // gbLocation3
            // 
            this.gbLocation3.Controls.Add(this.pictureBox2);
            this.gbLocation3.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold);
            this.gbLocation3.Location = new System.Drawing.Point(405, 3);
            this.gbLocation3.Name = "gbLocation3";
            this.gbLocation3.Size = new System.Drawing.Size(195, 191);
            this.gbLocation3.TabIndex = 5;
            this.gbLocation3.TabStop = false;
            this.gbLocation3.Text = "광주";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(3, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(189, 165);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "0";
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.recommendPictureBox_MouseDown);
            // 
            // gbLocation4
            // 
            this.gbLocation4.Controls.Add(this.pictureBox3);
            this.gbLocation4.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold);
            this.gbLocation4.Location = new System.Drawing.Point(606, 3);
            this.gbLocation4.Name = "gbLocation4";
            this.gbLocation4.Size = new System.Drawing.Size(195, 191);
            this.gbLocation4.TabIndex = 6;
            this.gbLocation4.TabStop = false;
            this.gbLocation4.Text = "전라남도";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Location = new System.Drawing.Point(3, 23);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(189, 165);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "0";
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.recommendPictureBox_MouseDown);
            // 
            // gbLocation5
            // 
            this.gbLocation5.Controls.Add(this.pictureBox4);
            this.gbLocation5.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold);
            this.gbLocation5.Location = new System.Drawing.Point(807, 3);
            this.gbLocation5.Name = "gbLocation5";
            this.gbLocation5.Size = new System.Drawing.Size(195, 191);
            this.gbLocation5.TabIndex = 7;
            this.gbLocation5.TabStop = false;
            this.gbLocation5.Text = "서울";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Location = new System.Drawing.Point(3, 23);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(189, 165);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "0";
            this.pictureBox4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.recommendPictureBox_MouseDown);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1018, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "추천 여행지 관리";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // contextRecommend
            // 
            this.contextRecommend.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuImageSet,
            this.menuDesciptionSet});
            this.contextRecommend.Name = "contextRecommend";
            this.contextRecommend.Size = new System.Drawing.Size(139, 48);
            // 
            // menuImageSet
            // 
            this.menuImageSet.Name = "menuImageSet";
            this.menuImageSet.Size = new System.Drawing.Size(138, 22);
            this.menuImageSet.Text = "이미지 설정";
            this.menuImageSet.Click += new System.EventHandler(this.menuImageSet_Click);
            // 
            // menuDesciptionSet
            // 
            this.menuDesciptionSet.Name = "menuDesciptionSet";
            this.menuDesciptionSet.Size = new System.Drawing.Size(138, 22);
            this.menuDesciptionSet.Text = "설명 설정";
            this.menuDesciptionSet.Click += new System.EventHandler(this.menuDesciptionSet_Click);
            // 
            // contextDescription
            // 
            this.contextDescription.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDelete,
            this.menuInputDescription});
            this.contextDescription.Name = "contextDescription";
            this.contextDescription.Size = new System.Drawing.Size(167, 48);
            // 
            // menuDelete
            // 
            this.menuDelete.Name = "menuDelete";
            this.menuDelete.Size = new System.Drawing.Size(166, 22);
            this.menuDelete.Text = "삭제";
            this.menuDelete.Click += new System.EventHandler(this.menuDelete_Click);
            // 
            // menuInputDescription
            // 
            this.menuInputDescription.Name = "menuInputDescription";
            this.menuInputDescription.Size = new System.Drawing.Size(166, 22);
            this.menuInputDescription.Text = "설명 텍스트 입력";
            this.menuInputDescription.Click += new System.EventHandler(this.menuInputDescription_Click);
            // 
            // ManageLocationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panBack);
            this.Name = "ManageLocationControl";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Load += new System.EventHandler(this.ManageLocationControl_Load);
            this.panBack.ResumeLayout(false);
            this.panCenterHeader.ResumeLayout(false);
            this.flpRecommend.ResumeLayout(false);
            this.gbLocation1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLocation1)).EndInit();
            this.gbLocation2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbLocation3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gbLocation4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.gbLocation5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.contextRecommend.ResumeLayout(false);
            this.contextDescription.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flpRecommend;
        private System.Windows.Forms.GroupBox gbLocation1;
        private System.Windows.Forms.PictureBox picLocation1;
        private System.Windows.Forms.GroupBox gbLocation2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbLocation3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox gbLocation4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox gbLocation5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panCenterHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.FlowLayoutPanel flpDescription;
        private System.Windows.Forms.ContextMenuStrip contextRecommend;
        private System.Windows.Forms.ToolStripMenuItem menuImageSet;
        private System.Windows.Forms.ToolStripMenuItem menuDesciptionSet;
        private System.Windows.Forms.ContextMenuStrip contextDescription;
        private System.Windows.Forms.ToolStripMenuItem menuDelete;
        private System.Windows.Forms.ToolStripMenuItem menuInputDescription;
    }
}
