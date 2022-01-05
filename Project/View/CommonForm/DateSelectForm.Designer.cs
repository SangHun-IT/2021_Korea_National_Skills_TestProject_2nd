
namespace Project.View
{
    partial class DateSelectForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDownDay = new System.Windows.Forms.Button();
            this.btnDownMonth = new System.Windows.Forms.Button();
            this.btnDownYear = new System.Windows.Forms.Button();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.btnUpDay = new System.Windows.Forms.Button();
            this.btnUpMonth = new System.Windows.Forms.Button();
            this.btnUpYear = new System.Windows.Forms.Button();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnDownDay, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnDownMonth, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnDownYear, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtDay, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtMonth, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnUpDay, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnUpMonth, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnUpYear, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtYear, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(246, 99);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnDownDay
            // 
            this.btnDownDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDownDay.Location = new System.Drawing.Point(167, 69);
            this.btnDownDay.Name = "btnDownDay";
            this.btnDownDay.Size = new System.Drawing.Size(76, 27);
            this.btnDownDay.TabIndex = 8;
            this.btnDownDay.Text = "▼";
            this.btnDownDay.UseVisualStyleBackColor = true;
            this.btnDownDay.Click += new System.EventHandler(this.btnDownDay_Click);
            // 
            // btnDownMonth
            // 
            this.btnDownMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDownMonth.Location = new System.Drawing.Point(85, 69);
            this.btnDownMonth.Name = "btnDownMonth";
            this.btnDownMonth.Size = new System.Drawing.Size(76, 27);
            this.btnDownMonth.TabIndex = 7;
            this.btnDownMonth.Text = "▼";
            this.btnDownMonth.UseVisualStyleBackColor = true;
            this.btnDownMonth.Click += new System.EventHandler(this.btnDownMonth_Click);
            // 
            // btnDownYear
            // 
            this.btnDownYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDownYear.Location = new System.Drawing.Point(3, 69);
            this.btnDownYear.Name = "btnDownYear";
            this.btnDownYear.Size = new System.Drawing.Size(76, 27);
            this.btnDownYear.TabIndex = 6;
            this.btnDownYear.Text = "▼";
            this.btnDownYear.UseVisualStyleBackColor = true;
            this.btnDownYear.Click += new System.EventHandler(this.btnDownYear_Click);
            // 
            // txtDay
            // 
            this.txtDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDay.Location = new System.Drawing.Point(167, 36);
            this.txtDay.MaxLength = 2;
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(76, 27);
            this.txtDay.TabIndex = 5;
            this.txtDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDay.Validating += new System.ComponentModel.CancelEventHandler(this.txtDay_Validating);
            // 
            // txtMonth
            // 
            this.txtMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMonth.Location = new System.Drawing.Point(85, 36);
            this.txtMonth.MaxLength = 2;
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(76, 27);
            this.txtMonth.TabIndex = 4;
            this.txtMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMonth.Validating += new System.ComponentModel.CancelEventHandler(this.txtMonth_Validating);
            // 
            // btnUpDay
            // 
            this.btnUpDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpDay.Location = new System.Drawing.Point(167, 3);
            this.btnUpDay.Name = "btnUpDay";
            this.btnUpDay.Size = new System.Drawing.Size(76, 27);
            this.btnUpDay.TabIndex = 2;
            this.btnUpDay.Text = "▲";
            this.btnUpDay.UseVisualStyleBackColor = true;
            this.btnUpDay.Click += new System.EventHandler(this.btnUpDay_Click);
            // 
            // btnUpMonth
            // 
            this.btnUpMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpMonth.Location = new System.Drawing.Point(85, 3);
            this.btnUpMonth.Name = "btnUpMonth";
            this.btnUpMonth.Size = new System.Drawing.Size(76, 27);
            this.btnUpMonth.TabIndex = 1;
            this.btnUpMonth.Text = "▲";
            this.btnUpMonth.UseVisualStyleBackColor = true;
            this.btnUpMonth.Click += new System.EventHandler(this.btnUpMonth_Click);
            // 
            // btnUpYear
            // 
            this.btnUpYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpYear.Location = new System.Drawing.Point(3, 3);
            this.btnUpYear.Name = "btnUpYear";
            this.btnUpYear.Size = new System.Drawing.Size(76, 27);
            this.btnUpYear.TabIndex = 0;
            this.btnUpYear.Text = "▲";
            this.btnUpYear.UseVisualStyleBackColor = true;
            this.btnUpYear.Click += new System.EventHandler(this.btnUpYear_Click);
            // 
            // txtYear
            // 
            this.txtYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYear.Location = new System.Drawing.Point(3, 36);
            this.txtYear.MaxLength = 4;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(76, 27);
            this.txtYear.TabIndex = 3;
            this.txtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtYear.Validating += new System.ComponentModel.CancelEventHandler(this.txtYear_Validating);
            // 
            // DateSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 99);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DateSelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "DateSelectForm";
            this.Deactivate += new System.EventHandler(this.DateSelectForm_Deactivate);
            this.Load += new System.EventHandler(this.DateSelectForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnUpYear;
        private System.Windows.Forms.Button btnUpDay;
        private System.Windows.Forms.Button btnUpMonth;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Button btnDownYear;
        private System.Windows.Forms.Button btnDownDay;
        private System.Windows.Forms.Button btnDownMonth;
    }
}