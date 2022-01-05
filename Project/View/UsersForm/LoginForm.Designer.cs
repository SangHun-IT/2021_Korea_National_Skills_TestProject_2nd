
namespace Project.View
{
    partial class LoginForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panRight = new System.Windows.Forms.Panel();
            this.txtPW = new Project.View.Controls.PlaceHolderTextBox();
            this.txtID = new Project.View.Controls.PlaceHolderTextBox();
            this.btnTheme = new System.Windows.Forms.Button();
            this.lbJoin = new System.Windows.Forms.Label();
            this.lbFind = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Project.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(839, 667);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panRight
            // 
            this.panRight.BackColor = System.Drawing.Color.Transparent;
            this.panRight.Controls.Add(this.txtPW);
            this.panRight.Controls.Add(this.txtID);
            this.panRight.Controls.Add(this.btnTheme);
            this.panRight.Controls.Add(this.lbJoin);
            this.panRight.Controls.Add(this.lbFind);
            this.panRight.Controls.Add(this.btnNext);
            this.panRight.Controls.Add(this.label1);
            this.panRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panRight.Location = new System.Drawing.Point(839, 0);
            this.panRight.Name = "panRight";
            this.panRight.Size = new System.Drawing.Size(402, 667);
            this.panRight.TabIndex = 2;
            // 
            // txtPW
            // 
            this.txtPW.BackColor = System.Drawing.Color.White;
            this.txtPW.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.txtPW.Location = new System.Drawing.Point(59, 275);
            this.txtPW.MaximumSize = new System.Drawing.Size(999, 21);
            this.txtPW.MinimumSize = new System.Drawing.Size(50, 21);
            this.txtPW.Name = "txtPW";
            this.txtPW.passwordChar = '*';
            this.txtPW.placeHolder = "Password";
            this.txtPW.Size = new System.Drawing.Size(197, 21);
            this.txtPW.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.txtID.Location = new System.Drawing.Point(59, 236);
            this.txtID.MaximumSize = new System.Drawing.Size(999, 21);
            this.txtID.MinimumSize = new System.Drawing.Size(50, 21);
            this.txtID.Name = "txtID";
            this.txtID.passwordChar = '\0';
            this.txtID.placeHolder = "Id";
            this.txtID.Size = new System.Drawing.Size(197, 21);
            this.txtID.TabIndex = 0;
            // 
            // btnTheme
            // 
            this.btnTheme.BackColor = System.Drawing.Color.DimGray;
            this.btnTheme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTheme.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold);
            this.btnTheme.ForeColor = System.Drawing.Color.White;
            this.btnTheme.Location = new System.Drawing.Point(262, 325);
            this.btnTheme.Name = "btnTheme";
            this.btnTheme.Size = new System.Drawing.Size(72, 28);
            this.btnTheme.TabIndex = 4;
            this.btnTheme.Text = "테마";
            this.btnTheme.UseVisualStyleBackColor = false;
            this.btnTheme.Click += new System.EventHandler(this.btnTheme_Click);
            // 
            // lbJoin
            // 
            this.lbJoin.AutoSize = true;
            this.lbJoin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbJoin.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold);
            this.lbJoin.Location = new System.Drawing.Point(55, 416);
            this.lbJoin.Name = "lbJoin";
            this.lbJoin.Size = new System.Drawing.Size(159, 20);
            this.lbJoin.TabIndex = 6;
            this.lbJoin.Text = "새로운 계정 만들기 →";
            this.lbJoin.Click += new System.EventHandler(this.lbJoin_Click);
            // 
            // lbFind
            // 
            this.lbFind.AutoSize = true;
            this.lbFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbFind.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold);
            this.lbFind.Location = new System.Drawing.Point(55, 329);
            this.lbFind.Name = "lbFind";
            this.lbFind.Size = new System.Drawing.Size(156, 20);
            this.lbFind.TabIndex = 5;
            this.lbFind.Text = "아이디/비밀번호 찾기";
            this.lbFind.Click += new System.EventHandler(this.lbFind_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(262, 231);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(72, 72);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "다음";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(53, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "로그인";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 667);
            this.Controls.Add(this.panRight);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("맑은 고딕", 8.25F);
            this.Name = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panRight.ResumeLayout(false);
            this.panRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panRight;
        private System.Windows.Forms.Label lbJoin;
        private System.Windows.Forms.Label lbFind;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTheme;
        private Controls.PlaceHolderTextBox txtPW;
        private Controls.PlaceHolderTextBox txtID;
    }
}