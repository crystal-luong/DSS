namespace DSS_BaiTapLon.Properties
{
    partial class UserControlTimKiem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            txtSearch = new TextBox();
            btnTimKiem = new Button();
            dgvTimKiem = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvTimKiem).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(40, 54);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 0;
            label1.Text = "Nhập tên xe";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(161, 53);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(223, 23);
            txtSearch.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.Linen;
            btnTimKiem.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTimKiem.ForeColor = SystemColors.ActiveCaptionText;
            btnTimKiem.Location = new Point(419, 53);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(120, 26);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // dgvTimKiem
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTimKiem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTimKiem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTimKiem.Location = new Point(40, 128);
            dgvTimKiem.Name = "dgvTimKiem";
            dgvTimKiem.RowTemplate.Height = 25;
            dgvTimKiem.Size = new Size(702, 421);
            dgvTimKiem.TabIndex = 3;
            // 
            // UserControlTimKiem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvTimKiem);
            Controls.Add(btnTimKiem);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Name = "UserControlTimKiem";
            Size = new Size(745, 706);
            Load += UserControlTimKiem_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTimKiem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSearch;
        private Button btnTimKiem;
        private DataGridView dgvTimKiem;
    }
}
