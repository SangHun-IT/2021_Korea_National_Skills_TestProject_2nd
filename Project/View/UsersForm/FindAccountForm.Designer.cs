
namespace Project.View
{
    partial class FindAccountForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDName = new Project.View.Controls.PlaceHolderTextBox();
            this.txtIDEmail = new Project.View.Controls.PlaceHolderTextBox();
            this.btnIDContinue = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPWName = new Project.View.Controls.PlaceHolderTextBox();
            this.txtPWID = new Project.View.Controls.PlaceHolderTextBox();
            this.txtPWEmail = new Project.View.Controls.PlaceHolderTextBox();
            this.btnPWContinue = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.txtIDName);
            this.flowLayoutPanel1.Controls.Add(this.txtIDEmail);
            this.flowLayoutPanel1.Controls.Add(this.btnIDContinue);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.txtPWName);
            this.flowLayoutPanel1.Controls.Add(this.txtPWID);
            this.flowLayoutPanel1.Controls.Add(this.txtPWEmail);
            this.flowLayoutPanel1.Controls.Add(this.btnPWContinue);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(40, 40);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(423, 522);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 50);
            this.label1.TabIndex = 7;
            this.label1.Text = "아이디 찾기";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIDName
            // 
            this.txtIDName.BackColor = System.Drawing.Color.White;
            this.txtIDName.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.txtIDName.Location = new System.Drawing.Point(3, 90);
            this.txtIDName.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.txtIDName.MaximumSize = new System.Drawing.Size(96999, 21);
            this.txtIDName.MinimumSize = new System.Drawing.Size(50, 21);
            this.txtIDName.Name = "txtIDName";
            this.txtIDName.passwordChar = '\0';
            this.txtIDName.placeHolder = "Name";
            this.txtIDName.Size = new System.Drawing.Size(420, 21);
            this.txtIDName.TabIndex = 5;
            // 
            // txtIDEmail
            // 
            this.txtIDEmail.BackColor = System.Drawing.Color.White;
            this.txtIDEmail.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.txtIDEmail.Location = new System.Drawing.Point(3, 134);
            this.txtIDEmail.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.txtIDEmail.MaximumSize = new System.Drawing.Size(96999, 21);
            this.txtIDEmail.MinimumSize = new System.Drawing.Size(50, 21);
            this.txtIDEmail.Name = "txtIDEmail";
            this.txtIDEmail.passwordChar = '\0';
            this.txtIDEmail.placeHolder = "E-mail";
            this.txtIDEmail.Size = new System.Drawing.Size(420, 21);
            this.txtIDEmail.TabIndex = 6;
            // 
            // btnIDContinue
            // 
            this.btnIDContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnIDContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIDContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIDContinue.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold);
            this.btnIDContinue.ForeColor = System.Drawing.Color.White;
            this.btnIDContinue.Location = new System.Drawing.Point(0, 178);
            this.btnIDContinue.Margin = new System.Windows.Forms.Padding(0, 20, 3, 3);
            this.btnIDContinue.Name = "btnIDContinue";
            this.btnIDContinue.Size = new System.Drawing.Size(420, 39);
            this.btnIDContinue.TabIndex = 8;
            this.btnIDContinue.Text = "계속";
            this.btnIDContinue.UseVisualStyleBackColor = false;
            this.btnIDContinue.Click += new System.EventHandler(this.btnIDContinue_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 240);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(423, 46);
            this.label2.TabIndex = 9;
            this.label2.Text = "비밀번호 찾기";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPWName
            // 
            this.txtPWName.BackColor = System.Drawing.Color.White;
            this.txtPWName.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.txtPWName.Location = new System.Drawing.Point(3, 306);
            this.txtPWName.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.txtPWName.MaximumSize = new System.Drawing.Size(9999, 21);
            this.txtPWName.MinimumSize = new System.Drawing.Size(50, 21);
            this.txtPWName.Name = "txtPWName";
            this.txtPWName.passwordChar = '\0';
            this.txtPWName.placeHolder = "Name";
            this.txtPWName.Size = new System.Drawing.Size(420, 21);
            this.txtPWName.TabIndex = 10;
            // 
            // txtPWID
            // 
            this.txtPWID.BackColor = System.Drawing.Color.White;
            this.txtPWID.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.txtPWID.Location = new System.Drawing.Point(3, 350);
            this.txtPWID.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.txtPWID.MaximumSize = new System.Drawing.Size(9999, 21);
            this.txtPWID.MinimumSize = new System.Drawing.Size(50, 21);
            this.txtPWID.Name = "txtPWID";
            this.txtPWID.passwordChar = '\0';
            this.txtPWID.placeHolder = "Id";
            this.txtPWID.Size = new System.Drawing.Size(420, 21);
            this.txtPWID.TabIndex = 11;
            // 
            // txtPWEmail
            // 
            this.txtPWEmail.BackColor = System.Drawing.Color.White;
            this.txtPWEmail.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.txtPWEmail.Location = new System.Drawing.Point(3, 394);
            this.txtPWEmail.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.txtPWEmail.MaximumSize = new System.Drawing.Size(9999, 21);
            this.txtPWEmail.MinimumSize = new System.Drawing.Size(50, 21);
            this.txtPWEmail.Name = "txtPWEmail";
            this.txtPWEmail.passwordChar = '\0';
            this.txtPWEmail.placeHolder = "E-mail";
            this.txtPWEmail.Size = new System.Drawing.Size(420, 21);
            this.txtPWEmail.TabIndex = 12;
            // 
            // btnPWContinue
            // 
            this.btnPWContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnPWContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPWContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPWContinue.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold);
            this.btnPWContinue.ForeColor = System.Drawing.Color.White;
            this.btnPWContinue.Location = new System.Drawing.Point(0, 438);
            this.btnPWContinue.Margin = new System.Windows.Forms.Padding(0, 20, 3, 3);
            this.btnPWContinue.Name = "btnPWContinue";
            this.btnPWContinue.Size = new System.Drawing.Size(420, 39);
            this.btnPWContinue.TabIndex = 13;
            this.btnPWContinue.Text = "계속";
            this.btnPWContinue.UseVisualStyleBackColor = false;
            this.btnPWContinue.Click += new System.EventHandler(this.btnPWContinue_Click);
            // 
            // FindAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 602);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MinimizeBox = false;
            this.Name = "FindAccountForm";
            this.Padding = new System.Windows.Forms.Padding(40);
            this.ShowIcon = false;
            this.Text = "아이디/비밀번호 찾기";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Controls.PlaceHolderTextBox txtIDEmail;
        private Controls.PlaceHolderTextBox txtIDName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIDContinue;
        private System.Windows.Forms.Label label2;
        private Controls.PlaceHolderTextBox txtPWName;
        private Controls.PlaceHolderTextBox txtPWID;
        private Controls.PlaceHolderTextBox txtPWEmail;
        private System.Windows.Forms.Button btnPWContinue;
    }
}