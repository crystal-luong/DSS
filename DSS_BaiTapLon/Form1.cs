using DSS_BaiTapLon.Properties;

namespace DSS_BaiTapLon
{
    public partial class Form1 : Form
    {
        private UserControlTimKiem userControlTimKiem;
        private UserControlTuVan userControlTuVan;
        public Form1()
        {
            InitializeComponent();
            InitializeUserControls();
        }
        private void InitializeUserControls()
        {
            userControlTimKiem = new UserControlTimKiem();
            userControlTuVan = new UserControlTuVan();

            // Ban đầu hiển thị userControlTimKiem
            mainPanel.Controls.Add(userControlTimKiem);
            mainPanel.Controls.Add(userControlTuVan);
            userControlTimKiem.Dock = DockStyle.Fill;
            userControlTimKiem.Visible = true;

            userControlTuVan.Dock = DockStyle.Fill;
            userControlTuVan.Visible = false;
        }
        private void btnShowPanelTimKiem_Click(object sender, EventArgs e)
        {
            userControlTimKiem.Visible = true;
            userControlTuVan.Visible = false;
        }
        private void btnShowPanelTuVan_Click(object sender, EventArgs e)
        {
            userControlTimKiem.Visible = false;
            userControlTuVan.Visible = true;
        }





        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panelTimKiem_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTuVan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
