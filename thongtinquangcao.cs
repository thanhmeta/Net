using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace baitaplon
{
    public partial class thongtinquangcao : UserControl
    {




        private void SetButtonStyle(Button btn, Image icon, string text)
        {
            btn.Text = text;
            btn.Image = new Bitmap(icon, new Size(24, 24));
            btn.ImageAlign = ContentAlignment.MiddleLeft;
            btn.TextAlign = ContentAlignment.MiddleRight;
            btn.Padding = new Padding(5, 0, 5, 0);
            btn.BackColor = Color.SteelBlue;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            btn.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue;
        }

        public thongtinquangcao()
        {
            InitializeComponent();
            SetupDataGridView();
            LoadData();
            dgvQuangCao.CellClick += dgvQuangCao_CellClick;
       
            buttonLayout.ColumnCount = 6;
            buttonLayout.Dock = DockStyle.Fill;
            for (int i = 0; i < 6; i++)
                buttonLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66F));
            string[] labels = { "➕ Thêm", "✏️ Sửa", "🗑️ Xoá", "💾 Lưu", "↩️ Bỏ Qua", "🚪 Thoát" };
            Button[] buttons = { btnThem, btnSua, btnXoa, btnLuu, btnBoQua, btnThoat };
            EventHandler[] events = { btnThem_Click, btnSua_Click, btnXoa_Click, btnLuu_Click, btnBoQua_Click, btnThoat_Click };
            for (int i = 0; i < 6; i++)
            {
                buttons[i].Text = labels[i];
                buttons[i].Dock = DockStyle.Fill;
                buttons[i].BackColor = Color.FromArgb(76, 175, 80);
                buttons[i].ForeColor = Color.White;
                buttons[i].Font = new Font("Segoe UI", 10, FontStyle.Bold);
                buttons[i].FlatStyle = FlatStyle.Flat;
                buttons[i].FlatAppearance.BorderSize = 0;
                buttons[i].Click += events[i];
                buttonLayout.Controls.Add(buttons[i], i, 0);
            }
        }

        // Thiết lập cột DataGridView thủ công

        private void SetupDataGridView()
        {
            dgvQuangCao.Columns.Clear();
            dgvQuangCao.AutoGenerateColumns = false;
            dgvQuangCao.EnableHeadersVisualStyles = false;

            dgvQuangCao.BackgroundColor = Color.White;
            dgvQuangCao.GridColor = Color.LightGray;

            dgvQuangCao.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvQuangCao.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvQuangCao.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            dgvQuangCao.ColumnHeadersHeight = 40;

            dgvQuangCao.DefaultCellStyle.BackColor = Color.White;
            dgvQuangCao.DefaultCellStyle.ForeColor = Color.Black;
            dgvQuangCao.DefaultCellStyle.Font = new Font("Segoe UI", 11);
            dgvQuangCao.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            dgvQuangCao.DefaultCellStyle.SelectionForeColor = Color.Black;

            var colMa = new DataGridViewTextBoxColumn
            {
                Name = "MaQCao",
                HeaderText = "Mã Quảng Cáo",
                DataPropertyName = "MaQCao",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            dgvQuangCao.Columns.Add(colMa);

            var colTen = new DataGridViewTextBoxColumn
            {
                Name = "TenQCao",
                HeaderText = "Tên Quảng Cáo",
                DataPropertyName = "TenQCao",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            dgvQuangCao.Columns.Add(colTen);
        }


        // Load dữ liệu lên dgv
        private void LoadData()
        {
            try
            {
                string sql = "SELECT * FROM TTQuangCao";
                DataTable dt = ketnoi.LoadDataToTable(sql);
                dgvQuangCao.DataSource = dt;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void dgvQuangCao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaQCao.Text = dgvQuangCao.Rows[e.RowIndex].Cells["MaQCao"].Value.ToString();
                txtTenQCao.Text = dgvQuangCao.Rows[e.RowIndex].Cells["TenQCao"].Value.ToString();

                btnBoQua.Enabled = true;
                btnThem.Enabled = false;
                btnLuu.Enabled = false;
                txtMaQCao.Enabled = false; // không cho sửa mã khi chỉnh sửa
            }
        }

        // Nút Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaQCao.Text = "";
            txtTenQCao.Text = "";
           
            txtMaQCao.Enabled = false;

            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        // Nút Lưu (thêm mới)
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ma = txtMaQCao.Text.Trim();
            string ten = txtTenQCao.Text.Trim();

           
            if (string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Bạn phải nhập Tên quảng cáo.");
                txtTenQCao.Focus();
                return;
            }

            

            try
            {
                string sqlInsert = "INSERT INTO TTQuangCao ( TenQCao) VALUES ( @Ten)";
                using (SqlCommand cmd = new SqlCommand(sqlInsert, ketnoi.con))
                {
                    ketnoi.Connect();
                    
                    cmd.Parameters.AddWithValue("@Ten", ten);
                    cmd.ExecuteNonQuery();
                    ketnoi.Close();
                }

                MessageBox.Show("Thêm dữ liệu thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message);
            }
        }

        // Nút Sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMaQCao.Text.Trim();
            string ten = txtTenQCao.Text.Trim();

            if (string.IsNullOrEmpty(ma))
            {
                MessageBox.Show("Vui lòng chọn quảng cáo để sửa.");
                return;
            }
            if (string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Bạn phải nhập Tên quảng cáo.");
                txtTenQCao.Focus();
                return;
            }

            try
            {
                string sqlUpdate = "UPDATE TTQuangCao SET TenQCao = @Ten WHERE MaQCao = @Ma";
                using (SqlCommand cmd = new SqlCommand(sqlUpdate, ketnoi.con))
                {
                    ketnoi.Connect();
                    cmd.Parameters.AddWithValue("@Ma", ma);
                    cmd.Parameters.AddWithValue("@Ten", ten);
                    cmd.ExecuteNonQuery();
                    ketnoi.Close();
                }

                MessageBox.Show("Cập nhật dữ liệu thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message);
            }
        }

        // Nút Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaQCao.Text.Trim();

            if (string.IsNullOrEmpty(ma))
            {
                MessageBox.Show("Vui lòng chọn quảng cáo để xóa.");
                return;
            }

            if (MessageBox.Show($"Bạn có chắc muốn xóa quảng cáo '{ma}' không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string sqlDelete = "DELETE FROM TTQuangCao WHERE MaQCao = @Ma";
                    using (SqlCommand cmd = new SqlCommand(sqlDelete, ketnoi.con))
                    {
                        ketnoi.Connect();
                        cmd.Parameters.AddWithValue("@Ma", ma);
                        cmd.ExecuteNonQuery();
                        ketnoi.Close();
                    }

                    MessageBox.Show("Xóa dữ liệu thành công!");
                    LoadData();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547) // Vi phạm ràng buộc khóa ngoại
                    {
                        MessageBox.Show("Không thể xóa vì bản ghi đang được sử dụng ở bảng khác.", "Lỗi khóa ngoại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi SQL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        // Nút Bỏ Qua (reset form, reload data)
        private void btnBoQua_Click(object sender, EventArgs e)
        {
            LoadData();
            txtMaQCao.Enabled = true;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        // Nút Thoát (đóng UserControl)
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
          "Bạn có chắc chắn muốn đóng giao diện này không?",
          "Xác nhận",
          MessageBoxButtons.OKCancel,
           MessageBoxIcon.Question
       );

            if (result == DialogResult.OK)
            {
                this.Parent?.Controls.Remove(this); // Xóa UserControl khỏi panel
            }
        }
        private void dgvQuangCao_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Nếu bạn không cần xử lý gì ở đây, để trống cũng được
        }

        private void lblTenQCao_Click(object sender, EventArgs e)
        {

        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();

            if (string.IsNullOrEmpty(tuKhoa))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // Sử dụng LIKE để tìm theo Mã hoặc Tên quảng cáo
                string sql = $@"
            SELECT * 
            FROM TTQuangCao 
            WHERE MaQCao LIKE N'%{tuKhoa}%' OR TenQCao LIKE N'%{tuKhoa}%'";

                DataTable dt = ketnoi.LoadDataToTable(sql);
                dgvQuangCao.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu phù hợp.", "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
        }

        private Image ResizeImage(Image image, int width, int height)
        {
            return new Bitmap(image, new Size(width, height));
        }

        private void mainLayout_Paint(object sender, PaintEventArgs e)
        {


            btnTimKiem.Image = ResizeImage(Properties.Resources.loupe, 20, 20);

            // Danh sách các nút
            Button[] buttons = { btnThem, btnSua, btnXoa, btnLuu, btnBoQua, btnThoat, btnTimKiem };

            // Thiết lập màu tím
            foreach (var btn in buttons)
            {
                btn.BackColor = Color.DodgerBlue;             // Màu nền xanh dương
                btn.ForeColor = Color.White;                   // Màu chữ trắng cho nổi bật
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderColor = Color.RoyalBlue; // Màu viền xanh dương đậm hơn
                btn.FlatAppearance.BorderSize = 1;
                btn.Font = new Font("Segoe UI", 12);

                btn.TextImageRelation = TextImageRelation.ImageBeforeText;
                btn.ImageAlign = ContentAlignment.MiddleLeft;
            }


        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
