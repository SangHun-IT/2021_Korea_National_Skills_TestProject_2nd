
namespace Project.View
{
    partial class UserMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tblBackPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panBottom = new System.Windows.Forms.Panel();
            this.gbLocation5 = new System.Windows.Forms.GroupBox();
            this.picLocation5 = new System.Windows.Forms.PictureBox();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxtDescriptionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxtReserveMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.gbLocation4 = new System.Windows.Forms.GroupBox();
            this.picLocation4 = new System.Windows.Forms.PictureBox();
            this.gbLocation3 = new System.Windows.Forms.GroupBox();
            this.picLocation3 = new System.Windows.Forms.PictureBox();
            this.gbLocation2 = new System.Windows.Forms.GroupBox();
            this.picLocation2 = new System.Windows.Forms.PictureBox();
            this.gbLocation1 = new System.Windows.Forms.GroupBox();
            this.picLocation1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panTop = new System.Windows.Forms.Panel();
            this.panCenter = new System.Windows.Forms.Panel();
            this.panSearchPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panDate = new System.Windows.Forms.Panel();
            this.phtDate = new Project.View.Controls.PlaceHolderTextBox();
            this.panArrival = new System.Windows.Forms.Panel();
            this.phtArrival = new Project.View.Controls.PlaceHolderTextBox();
            this.btnExchange = new System.Windows.Forms.Button();
            this.panDeparture = new System.Windows.Forms.Panel();
            this.phtDeparture = new Project.View.Controls.PlaceHolderTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flTopMenuPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReservation = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnTheme = new System.Windows.Forms.Button();
            this.tblBackPanel.SuspendLayout();
            this.panBottom.SuspendLayout();
            this.gbLocation5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLocation5)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.gbLocation4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLocation4)).BeginInit();
            this.gbLocation3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLocation3)).BeginInit();
            this.gbLocation2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLocation2)).BeginInit();
            this.gbLocation1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLocation1)).BeginInit();
            this.panTop.SuspendLayout();
            this.panCenter.SuspendLayout();
            this.panSearchPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panDate.SuspendLayout();
            this.panArrival.SuspendLayout();
            this.panDeparture.SuspendLayout();
            this.flTopMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblBackPanel
            // 
            this.tblBackPanel.BackColor = System.Drawing.Color.Transparent;
            this.tblBackPanel.ColumnCount = 1;
            this.tblBackPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblBackPanel.Controls.Add(this.panBottom, 0, 1);
            this.tblBackPanel.Controls.Add(this.panTop, 0, 0);
            this.tblBackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblBackPanel.Location = new System.Drawing.Point(0, 0);
            this.tblBackPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tblBackPanel.Name = "tblBackPanel";
            this.tblBackPanel.RowCount = 2;
            this.tblBackPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblBackPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblBackPanel.Size = new System.Drawing.Size(1280, 721);
            this.tblBackPanel.TabIndex = 0;
            // 
            // panBottom
            // 
            this.panBottom.BackColor = System.Drawing.Color.Transparent;
            this.panBottom.Controls.Add(this.gbLocation5);
            this.panBottom.Controls.Add(this.gbLocation4);
            this.panBottom.Controls.Add(this.gbLocation3);
            this.panBottom.Controls.Add(this.gbLocation2);
            this.panBottom.Controls.Add(this.gbLocation1);
            this.panBottom.Controls.Add(this.label2);
            this.panBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panBottom.Location = new System.Drawing.Point(0, 360);
            this.panBottom.Margin = new System.Windows.Forms.Padding(0);
            this.panBottom.Name = "panBottom";
            this.panBottom.Size = new System.Drawing.Size(1280, 361);
            this.panBottom.TabIndex = 1;
            // 
            // gbLocation5
            // 
            this.gbLocation5.Controls.Add(this.picLocation5);
            this.gbLocation5.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold);
            this.gbLocation5.Location = new System.Drawing.Point(1047, 95);
            this.gbLocation5.Name = "gbLocation5";
            this.gbLocation5.Size = new System.Drawing.Size(200, 191);
            this.gbLocation5.TabIndex = 3;
            this.gbLocation5.TabStop = false;
            this.gbLocation5.Text = "서울";
            // 
            // picLocation5
            // 
            this.picLocation5.ContextMenuStrip = this.contextMenu;
            this.picLocation5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLocation5.Location = new System.Drawing.Point(3, 23);
            this.picLocation5.Name = "picLocation5";
            this.picLocation5.Size = new System.Drawing.Size(194, 165);
            this.picLocation5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLocation5.TabIndex = 0;
            this.picLocation5.TabStop = false;
            this.picLocation5.Tag = "4";
            this.picLocation5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picLocation_MouseDown);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxtDescriptionMenu,
            this.ctxtReserveMenu});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(123, 48);
            // 
            // ctxtDescriptionMenu
            // 
            this.ctxtDescriptionMenu.Name = "ctxtDescriptionMenu";
            this.ctxtDescriptionMenu.Size = new System.Drawing.Size(122, 22);
            this.ctxtDescriptionMenu.Text = "상세설명";
            this.ctxtDescriptionMenu.Click += new System.EventHandler(this.ctxtDescriptionMenu_Click);
            // 
            // ctxtReserveMenu
            // 
            this.ctxtReserveMenu.Name = "ctxtReserveMenu";
            this.ctxtReserveMenu.Size = new System.Drawing.Size(122, 22);
            this.ctxtReserveMenu.Text = "예매";
            this.ctxtReserveMenu.Click += new System.EventHandler(this.ctxtReserveMenu_Click);
            // 
            // gbLocation4
            // 
            this.gbLocation4.Controls.Add(this.picLocation4);
            this.gbLocation4.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold);
            this.gbLocation4.Location = new System.Drawing.Point(796, 158);
            this.gbLocation4.Name = "gbLocation4";
            this.gbLocation4.Size = new System.Drawing.Size(200, 191);
            this.gbLocation4.TabIndex = 3;
            this.gbLocation4.TabStop = false;
            this.gbLocation4.Text = "전라남도";
            // 
            // picLocation4
            // 
            this.picLocation4.ContextMenuStrip = this.contextMenu;
            this.picLocation4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLocation4.Location = new System.Drawing.Point(3, 23);
            this.picLocation4.Name = "picLocation4";
            this.picLocation4.Size = new System.Drawing.Size(194, 165);
            this.picLocation4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLocation4.TabIndex = 0;
            this.picLocation4.TabStop = false;
            this.picLocation4.Tag = "3";
            this.picLocation4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picLocation_MouseDown);
            // 
            // gbLocation3
            // 
            this.gbLocation3.Controls.Add(this.picLocation3);
            this.gbLocation3.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold);
            this.gbLocation3.Location = new System.Drawing.Point(545, 98);
            this.gbLocation3.Name = "gbLocation3";
            this.gbLocation3.Size = new System.Drawing.Size(200, 191);
            this.gbLocation3.TabIndex = 3;
            this.gbLocation3.TabStop = false;
            this.gbLocation3.Text = "광주";
            // 
            // picLocation3
            // 
            this.picLocation3.ContextMenuStrip = this.contextMenu;
            this.picLocation3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLocation3.Location = new System.Drawing.Point(3, 23);
            this.picLocation3.Name = "picLocation3";
            this.picLocation3.Size = new System.Drawing.Size(194, 165);
            this.picLocation3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLocation3.TabIndex = 0;
            this.picLocation3.TabStop = false;
            this.picLocation3.Tag = "2";
            this.picLocation3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picLocation_MouseDown);
            // 
            // gbLocation2
            // 
            this.gbLocation2.Controls.Add(this.picLocation2);
            this.gbLocation2.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold);
            this.gbLocation2.Location = new System.Drawing.Point(294, 158);
            this.gbLocation2.Name = "gbLocation2";
            this.gbLocation2.Size = new System.Drawing.Size(200, 191);
            this.gbLocation2.TabIndex = 3;
            this.gbLocation2.TabStop = false;
            this.gbLocation2.Text = "강원도";
            // 
            // picLocation2
            // 
            this.picLocation2.ContextMenuStrip = this.contextMenu;
            this.picLocation2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLocation2.Location = new System.Drawing.Point(3, 23);
            this.picLocation2.Name = "picLocation2";
            this.picLocation2.Size = new System.Drawing.Size(194, 165);
            this.picLocation2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLocation2.TabIndex = 0;
            this.picLocation2.TabStop = false;
            this.picLocation2.Tag = "1";
            this.picLocation2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picLocation_MouseDown);
            // 
            // gbLocation1
            // 
            this.gbLocation1.Controls.Add(this.picLocation1);
            this.gbLocation1.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold);
            this.gbLocation1.Location = new System.Drawing.Point(43, 98);
            this.gbLocation1.Name = "gbLocation1";
            this.gbLocation1.Size = new System.Drawing.Size(200, 191);
            this.gbLocation1.TabIndex = 2;
            this.gbLocation1.TabStop = false;
            this.gbLocation1.Text = "부산";
            // 
            // picLocation1
            // 
            this.picLocation1.ContextMenuStrip = this.contextMenu;
            this.picLocation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLocation1.Location = new System.Drawing.Point(3, 23);
            this.picLocation1.Name = "picLocation1";
            this.picLocation1.Size = new System.Drawing.Size(194, 165);
            this.picLocation1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLocation1.TabIndex = 0;
            this.picLocation1.TabStop = false;
            this.picLocation1.Tag = "0";
            this.picLocation1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picLocation_MouseDown);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(37, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 49);
            this.label2.TabIndex = 1;
            this.label2.Text = "추천 여행지";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panTop
            // 
            this.panTop.BackgroundImage = global::Project.Properties.Resources.main;
            this.panTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panTop.Controls.Add(this.panCenter);
            this.panTop.Controls.Add(this.flTopMenuPanel);
            this.panTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panTop.Location = new System.Drawing.Point(0, 0);
            this.panTop.Margin = new System.Windows.Forms.Padding(0);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(1280, 360);
            this.panTop.TabIndex = 0;
            // 
            // panCenter
            // 
            this.panCenter.BackColor = System.Drawing.Color.Transparent;
            this.panCenter.Controls.Add(this.panSearchPanel);
            this.panCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panCenter.Location = new System.Drawing.Point(0, 51);
            this.panCenter.Name = "panCenter";
            this.panCenter.Padding = new System.Windows.Forms.Padding(100, 75, 100, 74);
            this.panCenter.Size = new System.Drawing.Size(1280, 309);
            this.panCenter.TabIndex = 1;
            this.panCenter.Tag = "Skip";
            // 
            // panSearchPanel
            // 
            this.panSearchPanel.BackColor = System.Drawing.Color.White;
            this.panSearchPanel.Controls.Add(this.tableLayoutPanel1);
            this.panSearchPanel.Controls.Add(this.label1);
            this.panSearchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panSearchPanel.Location = new System.Drawing.Point(100, 75);
            this.panSearchPanel.Name = "panSearchPanel";
            this.panSearchPanel.Padding = new System.Windows.Forms.Padding(5);
            this.panSearchPanel.Size = new System.Drawing.Size(1080, 160);
            this.panSearchPanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnSearch, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.panDate, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panArrival, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnExchange, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panDeparture, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 89);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1070, 66);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(824, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(243, 60);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panDate
            // 
            this.panDate.BackColor = System.Drawing.Color.Transparent;
            this.panDate.Controls.Add(this.phtDate);
            this.panDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panDate.Location = new System.Drawing.Point(577, 3);
            this.panDate.Name = "panDate";
            this.panDate.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.panDate.Size = new System.Drawing.Size(241, 60);
            this.panDate.TabIndex = 5;
            // 
            // phtDate
            // 
            this.phtDate.BackColor = System.Drawing.Color.White;
            this.phtDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phtDate.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.phtDate.isDateSelect = true;
            this.phtDate.isListMode = true;
            this.phtDate.isReadOnly = true;
            this.phtDate.Location = new System.Drawing.Point(0, 20);
            this.phtDate.MaximumSize = new System.Drawing.Size(0, 21);
            this.phtDate.MinimumSize = new System.Drawing.Size(50, 21);
            this.phtDate.Name = "phtDate";
            this.phtDate.passwordChar = '\0';
            this.phtDate.placeHolder = "날짜";
            this.phtDate.selectedLocation = null;
            this.phtDate.Size = new System.Drawing.Size(241, 21);
            this.phtDate.TabIndex = 1;
            this.phtDate.textResult = "";
            // 
            // panArrival
            // 
            this.panArrival.BackColor = System.Drawing.Color.Transparent;
            this.panArrival.Controls.Add(this.phtArrival);
            this.panArrival.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panArrival.Location = new System.Drawing.Point(330, 3);
            this.panArrival.Name = "panArrival";
            this.panArrival.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.panArrival.Size = new System.Drawing.Size(241, 60);
            this.panArrival.TabIndex = 4;
            // 
            // phtArrival
            // 
            this.phtArrival.BackColor = System.Drawing.Color.White;
            this.phtArrival.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phtArrival.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.phtArrival.isDateSelect = false;
            this.phtArrival.isListMode = true;
            this.phtArrival.isReadOnly = true;
            this.phtArrival.Location = new System.Drawing.Point(0, 20);
            this.phtArrival.MaximumSize = new System.Drawing.Size(0, 21);
            this.phtArrival.MinimumSize = new System.Drawing.Size(50, 21);
            this.phtArrival.Name = "phtArrival";
            this.phtArrival.passwordChar = '\0';
            this.phtArrival.placeHolder = "도착지";
            this.phtArrival.selectedLocation = null;
            this.phtArrival.Size = new System.Drawing.Size(241, 21);
            this.phtArrival.TabIndex = 1;
            this.phtArrival.textResult = "";
            // 
            // btnExchange
            // 
            this.btnExchange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnExchange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExchange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExchange.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold);
            this.btnExchange.ForeColor = System.Drawing.Color.White;
            this.btnExchange.Location = new System.Drawing.Point(250, 3);
            this.btnExchange.Name = "btnExchange";
            this.btnExchange.Size = new System.Drawing.Size(72, 60);
            this.btnExchange.TabIndex = 3;
            this.btnExchange.Text = "→\r\n←";
            this.btnExchange.UseVisualStyleBackColor = false;
            this.btnExchange.Click += new System.EventHandler(this.btnExchange_Click);
            // 
            // panDeparture
            // 
            this.panDeparture.BackColor = System.Drawing.Color.Transparent;
            this.panDeparture.Controls.Add(this.phtDeparture);
            this.panDeparture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panDeparture.Location = new System.Drawing.Point(3, 3);
            this.panDeparture.Name = "panDeparture";
            this.panDeparture.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.panDeparture.Size = new System.Drawing.Size(241, 60);
            this.panDeparture.TabIndex = 0;
            // 
            // phtDeparture
            // 
            this.phtDeparture.BackColor = System.Drawing.Color.White;
            this.phtDeparture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phtDeparture.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.phtDeparture.isDateSelect = false;
            this.phtDeparture.isListMode = true;
            this.phtDeparture.isReadOnly = true;
            this.phtDeparture.Location = new System.Drawing.Point(0, 20);
            this.phtDeparture.MaximumSize = new System.Drawing.Size(0, 21);
            this.phtDeparture.MinimumSize = new System.Drawing.Size(50, 21);
            this.phtDeparture.Name = "phtDeparture";
            this.phtDeparture.passwordChar = '\0';
            this.phtDeparture.placeHolder = "출발지";
            this.phtDeparture.selectedLocation = null;
            this.phtDeparture.Size = new System.Drawing.Size(241, 21);
            this.phtDeparture.TabIndex = 1;
            this.phtDeparture.textResult = "";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1070, 84);
            this.label1.TabIndex = 0;
            this.label1.Text = "예매";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flTopMenuPanel
            // 
            this.flTopMenuPanel.BackColor = System.Drawing.Color.Transparent;
            this.flTopMenuPanel.Controls.Add(this.btnLogout);
            this.flTopMenuPanel.Controls.Add(this.btnReservation);
            this.flTopMenuPanel.Controls.Add(this.btnAccount);
            this.flTopMenuPanel.Controls.Add(this.btnTheme);
            this.flTopMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.flTopMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.flTopMenuPanel.Name = "flTopMenuPanel";
            this.flTopMenuPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flTopMenuPanel.Size = new System.Drawing.Size(1280, 51);
            this.flTopMenuPanel.TabIndex = 0;
            this.flTopMenuPanel.Tag = "Skip";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(1205, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(72, 42);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "로그아웃";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnReservation
            // 
            this.btnReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservation.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnReservation.ForeColor = System.Drawing.Color.White;
            this.btnReservation.Location = new System.Drawing.Point(1127, 3);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(72, 42);
            this.btnReservation.TabIndex = 2;
            this.btnReservation.Text = "예매";
            this.btnReservation.UseVisualStyleBackColor = false;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.Location = new System.Drawing.Point(1049, 3);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(72, 42);
            this.btnAccount.TabIndex = 1;
            this.btnAccount.Text = "계정";
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnTheme
            // 
            this.btnTheme.BackColor = System.Drawing.Color.DimGray;
            this.btnTheme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTheme.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnTheme.ForeColor = System.Drawing.Color.White;
            this.btnTheme.Location = new System.Drawing.Point(971, 3);
            this.btnTheme.Name = "btnTheme";
            this.btnTheme.Size = new System.Drawing.Size(72, 42);
            this.btnTheme.TabIndex = 0;
            this.btnTheme.Text = "테마";
            this.btnTheme.UseVisualStyleBackColor = false;
            this.btnTheme.Click += new System.EventHandler(this.btnTheme_Click);
            // 
            // UserMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 721);
            this.Controls.Add(this.tblBackPanel);
            this.Name = "UserMainForm";
            this.Load += new System.EventHandler(this.UserMainForm_Load);
            this.tblBackPanel.ResumeLayout(false);
            this.panBottom.ResumeLayout(false);
            this.gbLocation5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLocation5)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.gbLocation4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLocation4)).EndInit();
            this.gbLocation3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLocation3)).EndInit();
            this.gbLocation2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLocation2)).EndInit();
            this.gbLocation1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLocation1)).EndInit();
            this.panTop.ResumeLayout(false);
            this.panCenter.ResumeLayout(false);
            this.panSearchPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panDate.ResumeLayout(false);
            this.panArrival.ResumeLayout(false);
            this.panDeparture.ResumeLayout(false);
            this.flTopMenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblBackPanel;
        private System.Windows.Forms.Panel panTop;
        private System.Windows.Forms.Panel panBottom;
        private System.Windows.Forms.FlowLayoutPanel flTopMenuPanel;
        private System.Windows.Forms.Panel panCenter;
        private System.Windows.Forms.Panel panSearchPanel;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnTheme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panDeparture;
        private Controls.PlaceHolderTextBox phtDeparture;
        private System.Windows.Forms.Button btnExchange;
        private System.Windows.Forms.Panel panDate;
        private Controls.PlaceHolderTextBox phtDate;
        private System.Windows.Forms.Panel panArrival;
        private Controls.PlaceHolderTextBox phtArrival;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbLocation1;
        private System.Windows.Forms.PictureBox picLocation1;
        private System.Windows.Forms.GroupBox gbLocation5;
        private System.Windows.Forms.PictureBox picLocation5;
        private System.Windows.Forms.GroupBox gbLocation4;
        private System.Windows.Forms.PictureBox picLocation4;
        private System.Windows.Forms.GroupBox gbLocation3;
        private System.Windows.Forms.PictureBox picLocation3;
        private System.Windows.Forms.GroupBox gbLocation2;
        private System.Windows.Forms.PictureBox picLocation2;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem ctxtDescriptionMenu;
        private System.Windows.Forms.ToolStripMenuItem ctxtReserveMenu;
    }
}