
namespace Project.View.Controls
{
    partial class PlaceHolderTextBox
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
            this.txtText = new System.Windows.Forms.TextBox();
            this.panBorder = new System.Windows.Forms.Panel();
            this.lbPlaceHolder = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // txtText
            // 
            this.txtText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtText.ContextMenuStrip = this.contextMenuStrip1;
            this.txtText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtText.Location = new System.Drawing.Point(0, 0);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(200, 20);
            this.txtText.TabIndex = 0;
            this.txtText.Leave += new System.EventHandler(this.txtText_Leave);
            this.txtText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlaceHolderTextBox_MouseClick);
            // 
            // panBorder
            // 
            this.panBorder.BackColor = System.Drawing.Color.Black;
            this.panBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBorder.Location = new System.Drawing.Point(0, 20);
            this.panBorder.Name = "panBorder";
            this.panBorder.Size = new System.Drawing.Size(200, 1);
            this.panBorder.TabIndex = 2;
            this.panBorder.Tag = "Skip";
            // 
            // lbPlaceHolder
            // 
            this.lbPlaceHolder.BackColor = System.Drawing.Color.Transparent;
            this.lbPlaceHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPlaceHolder.ForeColor = System.Drawing.Color.Gray;
            this.lbPlaceHolder.Location = new System.Drawing.Point(0, 0);
            this.lbPlaceHolder.Name = "lbPlaceHolder";
            this.lbPlaceHolder.Size = new System.Drawing.Size(200, 20);
            this.lbPlaceHolder.TabIndex = 1;
            this.lbPlaceHolder.Tag = "Skip";
            this.lbPlaceHolder.Text = "label1";
            this.lbPlaceHolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbPlaceHolder.Click += new System.EventHandler(this.lbPlaceHolder_Click);
            this.lbPlaceHolder.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PlaceHolderTextBox_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            // 
            // PlaceHolderTextBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbPlaceHolder);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.panBorder);
            this.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.MaximumSize = new System.Drawing.Size(99999, 21);
            this.MinimumSize = new System.Drawing.Size(50, 21);
            this.Name = "PlaceHolderTextBox";
            this.Size = new System.Drawing.Size(200, 21);
            this.Enter += new System.EventHandler(this.PlaceHolderTextBox_Enter);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PlaceHolderTextBox_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Panel panBorder;
        private System.Windows.Forms.Label lbPlaceHolder;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
