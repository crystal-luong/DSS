namespace DSS_BaiTapLon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnTimKiem = new Button();
            btnTuVan = new Button();
            mainPanel = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(168, 156, 240);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnTimKiem);
            panel1.Controls.Add(btnTuVan);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(325, 706);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(233, 116, 81);
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(79, 25);
            label1.Name = "label1";
            label1.Size = new Size(164, 41);
            label1.TabIndex = 4;
            label1.Text = "Nhóm 13";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(3, 218, 198);
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = Properties.Resources.icons8_user_30;
            pictureBox2.Location = new Point(37, 254);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 29);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(3, 218, 198);
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(37, 138);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(3, 218, 198);
            btnTimKiem.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnTimKiem.ForeColor = Color.Black;
            btnTimKiem.Location = new Point(12, 105);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(303, 93);
            btnTimKiem.TabIndex = 0;
            btnTimKiem.Text = "Tìm kiếm xe máy";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnShowPanelTimKiem_Click;
            // 
            // btnTuVan
            // 
            btnTuVan.BackColor = Color.FromArgb(3, 218, 198);
            btnTuVan.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnTuVan.ForeColor = Color.Black;
            btnTuVan.Location = new Point(12, 222);
            btnTuVan.Name = "btnTuVan";
            btnTuVan.Size = new Size(303, 93);
            btnTuVan.TabIndex = 1;
            btnTuVan.Text = "Tư vấn chọn xe máy";
            btnTuVan.UseVisualStyleBackColor = false;
            btnTuVan.Click += btnShowPanelTuVan_Click;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(168, 156, 240);
            mainPanel.Location = new Point(351, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(745, 706);
            mainPanel.TabIndex = 0;
            mainPanel.Paint += panelTuVan_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 704);
            Controls.Add(mainPanel);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ Chuyên Gia Tư Vấn Mua Bán Xe Máy";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnTimKiem;
        private Button btnTuVan;
        private Panel mainPanel;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
    }
}
