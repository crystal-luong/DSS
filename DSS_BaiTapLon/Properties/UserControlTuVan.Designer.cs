namespace DSS_BaiTapLon.Properties
{
    partial class UserControlTuVan
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
            cbBoxKhoangGia = new ComboBox();
            label2 = new Label();
            cbBoxHangXe = new ComboBox();
            label3 = new Label();
            cbBoxCongSuatXe = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            cbBoxMucDich = new ComboBox();
            cbBoxLoaiXe = new ComboBox();
            button1 = new Button();
            dgvTuVan = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvTuVan).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(24, 65);
            label1.Name = "label1";
            label1.Size = new Size(105, 23);
            label1.TabIndex = 0;
            label1.Text = "Khoảng giá";
            // 
            // cbBoxKhoangGia
            // 
            cbBoxKhoangGia.FormattingEnabled = true;
            cbBoxKhoangGia.Location = new Point(159, 65);
            cbBoxKhoangGia.Name = "cbBoxKhoangGia";
            cbBoxKhoangGia.Size = new Size(121, 23);
            cbBoxKhoangGia.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(24, 111);
            label2.Name = "label2";
            label2.Size = new Size(80, 23);
            label2.TabIndex = 2;
            label2.Text = "Hãng xe";
            // 
            // cbBoxHangXe
            // 
            cbBoxHangXe.FormattingEnabled = true;
            cbBoxHangXe.Location = new Point(159, 115);
            cbBoxHangXe.Name = "cbBoxHangXe";
            cbBoxHangXe.Size = new Size(121, 23);
            cbBoxHangXe.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(24, 158);
            label3.Name = "label3";
            label3.Size = new Size(119, 23);
            label3.TabIndex = 4;
            label3.Text = "Công suất xe";
            // 
            // cbBoxCongSuatXe
            // 
            cbBoxCongSuatXe.FormattingEnabled = true;
            cbBoxCongSuatXe.Location = new Point(159, 162);
            cbBoxCongSuatXe.Name = "cbBoxCongSuatXe";
            cbBoxCongSuatXe.Size = new Size(121, 23);
            cbBoxCongSuatXe.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(353, 65);
            label4.Name = "label4";
            label4.Size = new Size(86, 23);
            label4.TabIndex = 6;
            label4.Text = "Mục đích";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(353, 111);
            label5.Name = "label5";
            label5.Size = new Size(68, 23);
            label5.TabIndex = 7;
            label5.Text = "Loại xe";
            // 
            // cbBoxMucDich
            // 
            cbBoxMucDich.FormattingEnabled = true;
            cbBoxMucDich.Location = new Point(455, 65);
            cbBoxMucDich.Name = "cbBoxMucDich";
            cbBoxMucDich.Size = new Size(121, 23);
            cbBoxMucDich.TabIndex = 8;
            // 
            // cbBoxLoaiXe
            // 
            cbBoxLoaiXe.FormattingEnabled = true;
            cbBoxLoaiXe.Location = new Point(455, 115);
            cbBoxLoaiXe.Name = "cbBoxLoaiXe";
            cbBoxLoaiXe.Size = new Size(121, 23);
            cbBoxLoaiXe.TabIndex = 9;
            // 
            // button1
            // 
            button1.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(24, 238);
            button1.Name = "button1";
            button1.Size = new Size(106, 30);
            button1.TabIndex = 10;
            button1.Text = "Tư vấn";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgvTuVan
            // 
            dgvTuVan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTuVan.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTuVan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTuVan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTuVan.Location = new Point(136, 238);
            dgvTuVan.Name = "dgvTuVan";
            dgvTuVan.RowTemplate.Height = 25;
            dgvTuVan.Size = new Size(587, 450);
            dgvTuVan.TabIndex = 11;
            // 
            // UserControlTuVan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvTuVan);
            Controls.Add(button1);
            Controls.Add(cbBoxLoaiXe);
            Controls.Add(cbBoxMucDich);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cbBoxCongSuatXe);
            Controls.Add(label3);
            Controls.Add(cbBoxHangXe);
            Controls.Add(label2);
            Controls.Add(cbBoxKhoangGia);
            Controls.Add(label1);
            Name = "UserControlTuVan";
            Size = new Size(745, 706);
            Load += UserControlTuVan_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTuVan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbBoxKhoangGia;
        private Label label2;
        private ComboBox cbBoxHangXe;
        private Label label3;
        private ComboBox cbBoxCongSuatXe;
        private Label label4;
        private Label label5;
        private ComboBox cbBoxMucDich;
        private ComboBox cbBoxLoaiXe;
        private Button button1;
        private DataGridView dgvTuVan;
    }
}
