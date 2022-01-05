
namespace Project.View
{
    partial class LocationListPopupForm
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
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.dgvLocation2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvLocation1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocation2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocation1)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Controls.Add(this.dgvLocation2, 1, 0);
            this.tblMain.Controls.Add(this.dgvLocation1, 0, 0);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 1;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Size = new System.Drawing.Size(296, 268);
            this.tblMain.TabIndex = 0;
            // 
            // dgvLocation2
            // 
            this.dgvLocation2.AllowUserToAddRows = false;
            this.dgvLocation2.AllowUserToDeleteRows = false;
            this.dgvLocation2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLocation2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocation2.ColumnHeadersVisible = false;
            this.dgvLocation2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewButtonColumn1});
            this.dgvLocation2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLocation2.Location = new System.Drawing.Point(148, 0);
            this.dgvLocation2.Margin = new System.Windows.Forms.Padding(0);
            this.dgvLocation2.MultiSelect = false;
            this.dgvLocation2.Name = "dgvLocation2";
            this.dgvLocation2.ReadOnly = true;
            this.dgvLocation2.RowHeadersVisible = false;
            this.dgvLocation2.RowTemplate.Height = 35;
            this.dgvLocation2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvLocation2.Size = new System.Drawing.Size(148, 268);
            this.dgvLocation2.TabIndex = 1;
            this.dgvLocation2.Visible = false;
            this.dgvLocation2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLocation2_CellContentClick);
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Location";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            // 
            // dgvLocation1
            // 
            this.dgvLocation1.AllowUserToAddRows = false;
            this.dgvLocation1.AllowUserToDeleteRows = false;
            this.dgvLocation1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLocation1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocation1.ColumnHeadersVisible = false;
            this.dgvLocation1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvLocation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLocation1.Location = new System.Drawing.Point(0, 0);
            this.dgvLocation1.Margin = new System.Windows.Forms.Padding(0);
            this.dgvLocation1.MultiSelect = false;
            this.dgvLocation1.Name = "dgvLocation1";
            this.dgvLocation1.ReadOnly = true;
            this.dgvLocation1.RowHeadersVisible = false;
            this.dgvLocation1.RowTemplate.Height = 35;
            this.dgvLocation1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvLocation1.Size = new System.Drawing.Size(148, 268);
            this.dgvLocation1.TabIndex = 0;
            this.dgvLocation1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLocation1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Location";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // LocationListPopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 268);
            this.Controls.Add(this.tblMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "LocationListPopupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "LocationListPopupForm";
            this.Deactivate += new System.EventHandler(this.LocationListPopupForm_Deactivate);
            this.Load += new System.EventHandler(this.LocationListPopupForm_Load);
            this.tblMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocation2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocation1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.DataGridView dgvLocation1;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridView dgvLocation2;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
    }
}