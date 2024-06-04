using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSS_BaiTapLon.Properties
{
    public partial class UserControlTimKiem : UserControl
    {
        SqlConnection connection;
        SqlCommand command;
        private static string str = @"Data Source=DESKTOP-7904PML\SQLEXPRESS;Initial Catalog=muaban;Integrated Security=True;Encrypt=False";

        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public UserControlTimKiem()
        {
            InitializeComponent();
            dgvTimKiem.AutoGenerateColumns = true;
        }

        private void UserControlTimKiem_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }
        void loadData()
        {

            command = connection.CreateCommand();
            command.CommandText = "SELECT TOP (1000) \r\n      [tenXe]\r\n      ,[nhanHieu]\r\n      ,[namSanXuat]\r\n      ,[giaTien]\r\n      ,[congSuat]\r\n      ,[loaiXe]\r\n      ,[mucDich]\r\n  FROM [muaban].[dbo].[xemay]\r\n";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvTimKiem.DataSource = table;
            CustomizeDataGridView();

        }
        private void CustomizeDataGridView()
        {
            // Tùy chỉnh DataGridView nếu cần
            dgvTimKiem.Columns["tenXe"].HeaderText = "Tên xe"; // Đổi tên cột cho dễ hiểu
            dgvTimKiem.Columns["nhanHieu"].HeaderText = "Nhãn hiệu"; // Đổi tên cột cho dễ hiểu
            dgvTimKiem.Columns["namSanXuat"].HeaderText = "Năm sản xuất"; // Đổi tên cột cho dễ hiểu
            dgvTimKiem.Columns["giaTien"].HeaderText = "Giá xe"; // Đổi tên cột cho dễ hiểu
            dgvTimKiem.Columns["congSuat"].HeaderText = "Công suất"; // Đổi tên cột cho dễ hiểu
            dgvTimKiem.Columns["loaiXe"].HeaderText = "Loại xe"; // Đổi tên cột cho dễ hiểu
            dgvTimKiem.Columns["mucDich"].HeaderText = "Mục đích"; // Đổi tên cột cho dễ hiểu
            dgvTimKiem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Đặt chế độ tự động co giãn cột
            dgvTimKiem.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Đặt chế độ chọn toàn bộ hàng
            dgvTimKiem.MultiSelect = false; // Không cho phép chọn nhiều hàng
            dgvTimKiem.ReadOnly = true; // Đặt DataGridView ở chế độ chỉ đọc
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-7904PML\\SQLEXPRESS;Initial Catalog=muaban;Integrated Security=True;Encrypt=False"; // Thay thế bằng chuỗi kết nối của bạn
            string searchValue = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT TOP (1000) [tenXe], [nhanHieu], [namSanXuat], [giaTien], [congSuat], [loaiXe], [mucDich]
            FROM [muaban].[dbo].[xemay]
            WHERE tenXe LIKE @searchValue 
            OR nhanHieu LIKE @searchValue 
            OR CAST(namSanXuat AS VARCHAR) LIKE @searchValue
            OR CAST(giaTien AS VARCHAR) LIKE @searchValue
            OR congSuat LIKE @searchValue
            OR loaiXe LIKE @searchValue
            OR mucDich LIKE @searchValue";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@searchValue", "%" + searchValue + "%");

                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        dgvTimKiem.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy kết quả phù hợp!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi tìm kiếm: " + ex.Message);
                }
            }
        }
    }
}
