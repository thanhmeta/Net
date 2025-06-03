using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace baitaplon
{
    public partial class phongban : UserControl
    {
        int currentIndex = -1;
        bool isAdding = false, isEditing = false;
        DataTable dt;

        public phongban()
        {
            InitializeComponent();
            LoadData();
            LoadComboBox();

            dgvPhongBan.RowPostPaint += dgvPhongBan_RowPostPaint; // Gán sự kiện hiển thị STT
        }

        private void LoadData()
        {
            string sql = "SELECT * FROM PhongBan";
            dt = ketnoi.LoadDataToTable(sql);
            dgvPhongBan.DataSource = dt;

            // Cập nhật tên cột
            dgvPhongBan.Columns["MaPhong"].HeaderText = "Mã Phòng";
            dgvPhongBan.Columns["TenPhong"].HeaderText = "Tên Phòng";
            dgvPhongBan.Columns["MaBao"].HeaderText = "Mã Báo";
            dgvPhongBan.Columns["DienThoai"].HeaderText = "Điện Thoại";

            // Căn giữa nội dung và tiêu đề các cột
            foreach (DataGridViewColumn col in dgvPhongBan.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgvPhongBan.RowHeadersVisible = true;
        }

        private void LoadComboBox()
        {
            DataTable dt = ketnoi.LoadDataToTable("SELECT MaBao FROM Bao");
            cbbMaBao.DataSource = dt;
            cbbMaBao.DisplayMember = "MaBao";
            cbbMaBao.ValueMember = "MaBao";
        }

        private void dgvPhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvPhongBan.Rows.Count)
            {
                DataGridViewRow row = dgvPhongBan.Rows[e.RowIndex];
                txtMaPhong.Text = row.Cells["MaPhong"].Value.ToString();
                txtTenPhong.Text = row.Cells["TenPhong"].Value.ToString();
                cbbMaBao.SelectedValue = row.Cells["MaBao"].Value.ToString();
                txtDienThoai.Text = row.Cells["DienThoai"].Value.ToString();
                currentIndex = e.RowIndex;

                txtMaPhong.ReadOnly = true;
                btnThem.Enabled = false;
                btnLuu.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnBoQua.Enabled = true;
                btnThoat.Enabled = true;
                btnLuu.Enabled = false;
                isAdding = false;
            }
        }


        private void ClearInputs()
        {
            txtMaPhong.Clear();
            txtMaPhong.ReadOnly = true;
            txtMaPhong.BackColor = Color.LightGray;
            txtMaPhong.TabStop = false;

            txtTenPhong.Clear();
            txtDienThoai.Clear();
            cbbMaBao.SelectedIndex = -1;
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtTenPhong.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên Phòng.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenPhong.Focus();
                return false;
            }

            if (cbbMaBao.SelectedIndex == -1 || cbbMaBao.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Mã Báo.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbMaBao.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDienThoai.Text))
            {
                MessageBox.Show("Vui lòng nhập Số Điện Thoại.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDienThoai.Focus();
                return false;
            }

            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearInputs();
            txtTenPhong.Focus();
            isAdding = true;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
        }



        private void btnSua_Click(object sender, EventArgs e)
        {
            string maPhong = txtMaPhong.Text.Trim();
            if (string.IsNullOrWhiteSpace(maPhong))
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTenPhong.Text) || cbbMaBao.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtDienThoai.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần sửa.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ketnoi.Connect();
                string query = "UPDATE PhongBan SET TenPhong = @TenPhong, DienThoai = @DienThoai, MaBao = @MaBao WHERE MaPhong = @MaPhong";
                SqlCommand cmd = new SqlCommand(query, ketnoi.con);
                cmd.Parameters.AddWithValue("@TenPhong", txtTenPhong.Text.Trim());
                cmd.Parameters.AddWithValue("@DienThoai", txtDienThoai.Text.Trim());
                cmd.Parameters.AddWithValue("@MaBao", cbbMaBao.SelectedValue);
                cmd.Parameters.AddWithValue("@MaPhong", maPhong);

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    LoadData();
                    ClearInputs();
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ketnoi.Close();
            }
        }




        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maPhong = txtMaPhong.Text.Trim();
            if (string.IsNullOrWhiteSpace(maPhong))
            {
                MessageBox.Show("Vui lòng chọn dòng cần xoá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá không?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string sql = $"DELETE FROM PhongBan WHERE MaPhong = '{maPhong}'";
                    ketnoi.RunSql(sql);
                    LoadData();
                    ClearInputs();
                    MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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



        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!isAdding) return;

            if (string.IsNullOrWhiteSpace(txtTenPhong.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên Phòng.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbbMaBao.SelectedIndex == -1 || cbbMaBao.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Mã Báo.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDienThoai.Text))
            {
                MessageBox.Show("Vui lòng nhập Số điện thoại.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ketnoi.Connect();
                string query = "INSERT INTO PhongBan (TenPhong, MaBao, DienThoai) VALUES (@TenPhong, @MaBao, @DienThoai)";
                SqlCommand cmd = new SqlCommand(query, ketnoi.con);
                cmd.Parameters.AddWithValue("@TenPhong", txtTenPhong.Text.Trim());
                cmd.Parameters.AddWithValue("@MaBao", cbbMaBao.SelectedValue);
                cmd.Parameters.AddWithValue("@DienThoai", txtDienThoai.Text.Trim());

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearInputs();
                    isAdding = false;
                }
                else
                {
                    MessageBox.Show("Không thể thêm dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm mới: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ketnoi.Close();
            }
        }







        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ClearInputs();
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();

            if (string.IsNullOrWhiteSpace(keyword))
            {
                LoadData(); // Nếu không nhập gì thì hiển thị lại toàn bộ
                return;
            }

            string sql = $"SELECT * FROM PhongBan WHERE MaPhong LIKE '%{keyword}%' OR TenPhong LIKE N'%{keyword}%'";
            dgvPhongBan.DataSource = ketnoi.LoadDataToTable(sql);

            // Căn giữa lại sau tìm kiếm
            foreach (DataGridViewColumn col in dgvPhongBan.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }



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

        private void dgvPhongBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void dgvPhongBan_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = (DataGridView)sender;
            var rowIdx = (e.RowIndex + 1).ToString();
            var centerFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            Rectangle headerBounds = new Rectangle(
                e.RowBounds.Left,
                e.RowBounds.Top,
                grid.RowHeadersWidth,
                e.RowBounds.Height);

            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }
    }
}
