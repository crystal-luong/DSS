using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DSS_BaiTapLon.Properties
{
    public partial class UserControlTuVan : UserControl
    {
        SqlConnection connection;
        SqlCommand command;
        private static string str = @"Data Source=DESKTOP-7904PML\SQLEXPRESS;Initial Catalog=muabanxemay;Integrated Security=True";

        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        public UserControlTuVan()
        {
            InitializeComponent();
            dgvTuVan.AutoGenerateColumns = true;
        }

        private void UserControlTuVan_Load(object sender, EventArgs e)
        {

            connection = new SqlConnection(str);
            connection.Open();
            loadData();
            load_cbbox();

        }

        void loadData()
        {

            command = connection.CreateCommand();
            command.CommandText = "SELECT TOP (1000) \r\n      [tenXe]\r\n      ,[nhanHieu]\r\n      ,[namSanXuat]\r\n      ,[giaTien]\r\n      ,[congSuat]\r\n      ,[loaiXe]\r\n      ,[mucDich]\r\n  FROM [muaban].[dbo].[xemay]\r\n";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvTuVan.DataSource = table;
            CustomizeDataGridView();

        }

        private void load_cbbox()
        {
            cbBoxHangXe.Items.Add("Yamaha");
            cbBoxHangXe.Items.Add("HonDa");
            cbBoxHangXe.Items.Add("Suzuki");
            cbBoxKhoangGia.Items.Add("Dưới 20 triệu");
            cbBoxKhoangGia.Items.Add("Từ 20 đến 50 triệu");
            cbBoxKhoangGia.Items.Add("Trên 50 triệu");
            cbBoxLoaiXe.Items.Add("Xe số");
            cbBoxLoaiXe.Items.Add("Xe tay ga");
            cbBoxLoaiXe.Items.Add("Xe thể thao");
            cbBoxLoaiXe.Items.Add("Xe địa hình");
            cbBoxMucDich.Items.Add("Đi chơi");
            cbBoxMucDich.Items.Add("Đi làm");
            cbBoxMucDich.Items.Add("Đi phượt");
            cbBoxCongSuatXe.Items.Add("50cc");
            cbBoxCongSuatXe.Items.Add("110cc");
            cbBoxCongSuatXe.Items.Add("125cc");
            cbBoxCongSuatXe.Items.Add("150cc");
            cbBoxCongSuatXe.Items.Add("Trên 150cc");
        }
        private void CustomizeDataGridView()
        {
            // Tùy chỉnh DataGridView nếu cần
            dgvTuVan.Columns["tenXe"].HeaderText = "Tên xe"; // Đổi tên cột cho dễ hiểu
            dgvTuVan.Columns["nhanHieu"].HeaderText = "Nhãn hiệu"; // Đổi tên cột cho dễ hiểu
            dgvTuVan.Columns["namSanXuat"].HeaderText = "Năm sản xuất"; // Đổi tên cột cho dễ hiểu
            dgvTuVan.Columns["giaTien"].HeaderText = "Giá xe"; // Đổi tên cột cho dễ hiểu
            dgvTuVan.Columns["congSuat"].HeaderText = "Công suất"; // Đổi tên cột cho dễ hiểu
            dgvTuVan.Columns["loaiXe"].HeaderText = "Loại xe"; // Đổi tên cột cho dễ hiểu
            dgvTuVan.Columns["mucDich"].HeaderText = "Mục đích"; // Đổi tên cột cho dễ hiểu
            dgvTuVan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Đặt chế độ tự động co giãn cột
            dgvTuVan.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Đặt chế độ chọn toàn bộ hàng
            dgvTuVan.MultiSelect = false; // Không cho phép chọn nhiều hàng
            dgvTuVan.ReadOnly = true; // Đặt DataGridView ở chế độ chỉ đọc
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ các ComboBox
            string hangXe = cbBoxHangXe.SelectedItem?.ToString();
            string khoangGia = cbBoxKhoangGia.SelectedItem?.ToString();
            string loaiXe = cbBoxLoaiXe.SelectedItem?.ToString();
            string mucDich = cbBoxMucDich.SelectedItem?.ToString();
            string congSuat = cbBoxCongSuatXe.SelectedItem?.ToString();

            // Tạo câu lệnh SQL động dựa trên các tiêu chí đã chọn
            string query = "SELECT TOP (1000) [tenXe], [nhanHieu], [namSanXuat], [giaTien], [congSuat], [loaiXe], [mucDich] FROM [muaban].[dbo].[xemay] WHERE 1=1";

            if (!string.IsNullOrEmpty(hangXe))
            {
                query += " AND nhanHieu = @nhanHieu";
            }
            if (!string.IsNullOrEmpty(khoangGia))
            {
                switch (khoangGia)
                {
                    case "Dưới 20 triệu":
                        query += " AND giaTien < 20000000";
                        break;
                    case "Từ 20 đến 50 triệu":
                        query += " AND giaTien >= 20000000 AND giaTien <= 50000000";
                        break;
                    case "Trên 50 triệu":
                        query += " AND giaTien > 50000000";
                        break;
                }
            }
            if (!string.IsNullOrEmpty(loaiXe))
            {
                query += " AND loaiXe = @loaiXe";
            }
            if (!string.IsNullOrEmpty(mucDich))
            {
                query += " AND mucDich = @mucDich";
            }
            if (!string.IsNullOrEmpty(congSuat))
            {
                if (congSuat == "Trên 150cc")
                {
                    query += " AND CAST(REPLACE(congSuat, 'cc', '') AS INT) > 150";
                }
                else
                {
                    query += " AND congSuat = @congSuat";
                }
            }

            // Thực hiện truy vấn
            using (SqlConnection connection = new SqlConnection(str))
            {
                SqlCommand command = new SqlCommand(query, connection);
                if (!string.IsNullOrEmpty(hangXe))
                {
                    command.Parameters.AddWithValue("@nhanHieu", hangXe);
                }
                if (!string.IsNullOrEmpty(loaiXe))
                {
                    command.Parameters.AddWithValue("@loaiXe", loaiXe);
                }
                if (!string.IsNullOrEmpty(mucDich))
                {
                    command.Parameters.AddWithValue("@mucDich", mucDich);
                }
                if (!string.IsNullOrEmpty(congSuat) && congSuat != "Trên 150cc")
                {
                    command.Parameters.AddWithValue("@congSuat", congSuat);
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    dgvTuVan.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy kết quả phù hợp!");
                }
            }
        }
    }
}
