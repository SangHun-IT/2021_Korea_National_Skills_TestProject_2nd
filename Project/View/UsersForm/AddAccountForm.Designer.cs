
namespace Project.View
{
    partial class AddAccountForm
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
            this.txtName = new Project.View.Controls.PlaceHolderTextBox();
            this.txtId = new Project.View.Controls.PlaceHolderTextBox();
            this.txtPassword = new Project.View.Controls.PlaceHolderTextBox();
            this.txtPasswordConfirm = new Project.View.Controls.PlaceHolderTextBox();
            this.txtEmail = new Project.View.Controls.PlaceHolderTextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.txtName);
            this.flowLayoutPanel1.Controls.Add(this.txtId);
            this.flowLayoutPanel1.Controls.Add(this.txtPassword);
            this.flowLayoutPanel1.Controls.Add(this.txtPasswordConfirm);
            this.flowLayoutPanel1.Controls.Add(this.txtEmail);
            this.flowLayoutPanel1.Controls.Add(this.btnSignUp);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(50);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(534, 610);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(53, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 40, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 50);
            this.label1.TabIndex = 7;
            this.label1.Text = "계정 정보";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.txtName.Location = new System.Drawing.Point(53, 180);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 40, 3, 3);
            this.txtName.MaximumSize = new System.Drawing.Size(96999, 21);
            this.txtName.MinimumSize = new System.Drawing.Size(50, 21);
            this.txtName.Name = "txtName";
            this.txtName.passwordChar = '\0';
            this.txtName.placeHolder = "Name";
            this.txtName.Size = new System.Drawing.Size(420, 21);
            this.txtName.TabIndex = 5;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.White;
            this.txtId.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.txtId.Location = new System.Drawing.Point(53, 244);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 40, 3, 3);
            this.txtId.MaximumSize = new System.Drawing.Size(96999, 21);
            this.txtId.MinimumSize = new System.Drawing.Size(50, 21);
            this.txtId.Name = "txtId";
            this.txtId.passwordChar = '\0';
            this.txtId.placeHolder = "Id";
            this.txtId.Size = new System.Drawing.Size(420, 21);
            this.txtId.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.txtPassword.Location = new System.Drawing.Point(53, 308);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 40, 3, 3);
            this.txtPassword.MaximumSize = new System.Drawing.Size(9999, 21);
            this.txtPassword.MinimumSize = new System.Drawing.Size(50, 21);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.passwordChar = '*';
            this.txtPassword.placeHolder = "Password";
            this.txtPassword.Size = new System.Drawing.Size(420, 21);
            this.txtPassword.TabIndex = 10;
            // 
            // txtPasswordConfirm
            // 
            this.txtPasswordConfirm.BackColor = System.Drawing.Color.White;
            this.txtPasswordConfirm.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.txtPasswordConfirm.Location = new System.Drawing.Point(53, 372);
            this.txtPasswordConfirm.Margin = new System.Windows.Forms.Padding(3, 40, 3, 3);
            this.txtPasswordConfirm.MaximumSize = new System.Drawing.Size(9999, 21);
            this.txtPasswordConfirm.MinimumSize = new System.Drawing.Size(50, 21);
            this.txtPasswordConfirm.Name = "txtPasswordConfirm";
            this.txtPasswordConfirm.passwordChar = '*';
            this.txtPasswordConfirm.placeHolder = "Password 확인";
            this.txtPasswordConfirm.Size = new System.Drawing.Size(420, 21);
            this.txtPasswordConfirm.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.txtEmail.Location = new System.Drawing.Point(53, 436);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 40, 3, 3);
            this.txtEmail.MaximumSize = new System.Drawing.Size(9999, 21);
            this.txtEmail.MinimumSize = new System.Drawing.Size(50, 21);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.passwordChar = '\0';
            this.txtEmail.placeHolder = "E-mail";
            this.txtEmail.Size = new System.Drawing.Size(420, 21);
            this.txtEmail.TabIndex = 12;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold);
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(50, 500);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(0, 40, 3, 3);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(420, 39);
            this.btnSignUp.TabIndex = 13;
            this.btnSignUp.Text = "회원가입";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // AddAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 610);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MinimizeBox = false;
            this.Name = "AddAccountForm";
            this.ShowIcon = false;
            this.Text = "계정 등록하기";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private Controls.PlaceHolderTextBox txtName;
        private Controls.PlaceHolderTextBox txtId;
        private Controls.PlaceHolderTextBox txtPassword;
        private Controls.PlaceHolderTextBox txtPasswordConfirm;
        private Controls.PlaceHolderTextBox txtEmail;
        private System.Windows.Forms.Button btnSignUp;
    }
}