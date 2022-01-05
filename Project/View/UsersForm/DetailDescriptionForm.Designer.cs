
namespace Project.View
{
    partial class DetailDescriptionForm
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
            this.panBack = new System.Windows.Forms.Panel();
            this.flowContent = new System.Windows.Forms.FlowLayoutPanel();
            this.lbHeader = new System.Windows.Forms.Label();
            this.panBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // panBack
            // 
            this.panBack.Controls.Add(this.flowContent);
            this.panBack.Controls.Add(this.lbHeader);
            this.panBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panBack.Location = new System.Drawing.Point(20, 20);
            this.panBack.Name = "panBack";
            this.panBack.Size = new System.Drawing.Size(370, 617);
            this.panBack.TabIndex = 0;
            // 
            // flowContent
            // 
            this.flowContent.AutoScroll = true;
            this.flowContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowContent.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowContent.Location = new System.Drawing.Point(0, 55);
            this.flowContent.Name = "flowContent";
            this.flowContent.Size = new System.Drawing.Size(370, 562);
            this.flowContent.TabIndex = 1;
            this.flowContent.WrapContents = false;
            // 
            // lbHeader
            // 
            this.lbHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbHeader.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold);
            this.lbHeader.Location = new System.Drawing.Point(0, 0);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(370, 55);
            this.lbHeader.TabIndex = 0;
            this.lbHeader.Text = "상세설명";
            this.lbHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DetailDescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 657);
            this.Controls.Add(this.panBack);
            this.MinimizeBox = false;
            this.Name = "DetailDescriptionForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.ShowIcon = false;
            this.Text = "상세설명";
            this.Load += new System.EventHandler(this.DetailDescriptionForm_Load);
            this.panBack.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panBack;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.FlowLayoutPanel flowContent;
    }
}