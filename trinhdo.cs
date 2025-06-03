using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace baitaplon
{
    public partial class trinhdo : UserControl
    {
        int currentIndex = -1;
        bool isAdding = false, isEditing = false;
        DataTable dt;

        public trinhdo()
        {
            InitializeComponent();
            LoadData();

            // Gán sự kiện
            dgvTrinhDo.CellClick += dgvTrinhDo_CellClick;
            dgvTrinhDo.RowPostPaint += dgvTrinhDo_RowPostPaint;

            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnLuu.Click += btnLuu_Click;
            btnBoQua.Click += btnBoQua_Click;
            btnThoat.Click += btnThoat_Click;
            btnTimKiem.Click += btnTimKiem_Click;
        }

        private void LoadData()
        {
            string query = "SELECT MaTD, TenTD FROM TrinhDo";
            dt = ketnoi.LoadDataToTable(query);
            dgvTrinhDo.DataSource = dt;

            dgvTrinhDo.Columns["MaTD"].HeaderText = "Mã Trình Độ";
            dgvTrinhDo.Columns["TenTD"].HeaderText = "Tên Trình Độ";
        }

        private void dgvTrinhDo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvTrinhDo.Rows.Count)
            {
                DataGridViewRow row = dgvTrinhDo.Rows[e.RowIndex];
                txtMaTD.Text = row.Cells["MaTD"].Value?.ToString();
                txtTenTD.Text = row.Cells["TenTD"].Value?.ToString();
                currentIndex = e.RowIndex;

                txtMaTD.ReadOnly = true;
                txtMaTD.BackColor = Color.LightGray;

                isAdding = false;
                isEditing = false;

                btnThem.Enabled = false;
                btnLuu.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }


        private void ClearInputs()
        {
            txtMaTD.Clear();
            txtMaTD.ReadOnly = true;
            txtMaTD.BackColor = Color.LightGray;
            txtMaTD.TabStop = false;

            txtTenTD.Clear();
            isAdding = false;
            isEditing = false;
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtTenTD.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên Trình Độ.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaTD.Clear();
            txtTenTD.Clear();

            txtMaTD.ReadOnly = true;
            txtMaTD.BackColor = Color.LightGray;

            isAdding = true;
            isEditing = false;

            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;

            txtTenTD.Focus();
        }


        private void btnBoQua_Click(object sender, EventArgs e)
        {
            txtMaTD.Clear();
            txtTenTD.Clear();

            isAdding = false;
            isEditing = false;

            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!isAdding) return;

            if (string.IsNullOrWhiteSpace(txtTenTD.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên trình độ.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ketnoi.Connect();

                string sql = "INSERT INTO TrinhDo (TenTD) VALUES (@TenTD)";
                SqlCommand cmd = new SqlCommand(sql, ketnoi.con);
                cmd.Parameters.AddWithValue("@TenTD", txtTenTD.Text.Trim());

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm mới: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ketnoi.Close();
                isAdding = false;
                btnLuu.Enabled = false;
                btnThem.Enabled = true;
            }
        }




        private void btnSua_Click(object sender, EventArgs e)
        {
            string maTD = txtMaTD.Text.Trim();
            if (string.IsNullOrWhiteSpace(maTD))
            {
                MessageBox.Show("Vui lòng chọn trình độ cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTenTD.Text))
            {
                MessageBox.Show("Vui lòng nhập tên trình độ.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ketnoi.Connect();

                string query = "UPDATE TrinhDo SET TenTD = @TenTD WHERE MaTD = @MaTD";

                SqlCommand cmd = new SqlCommand(query, ketnoi.con);
                cmd.Parameters.AddWithValue("@TenTD", txtTenTD.Text.Trim());
                cmd.Parameters.AddWithValue("@MaTD", maTD);

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    LoadData();  // cập nhật lại DataGridView hoặc danh sách dữ liệu
                    ClearInputs(); // nếu bạn có hàm này để xóa dữ liệu trên form
                    MessageBox.Show("Bạn đã cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy trình độ cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (string.IsNullOrWhiteSpace(txtMaTD.Text))
            {
                MessageBox.Show("Vui lòng chọn trình độ cần xoá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá không?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    ketnoi.Connect();
                    SqlCommand cmd = new SqlCommand("DELETE FROM TrinhDo WHERE MaTD = @MaTD", ketnoi.con);
                    cmd.Parameters.AddWithValue("@MaTD", txtMaTD.Text.Trim());

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        LoadData();
                        ClearInputs();
                        MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy dòng để xoá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xoá: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    ketnoi.Close();
                }
            }
        }


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            string sql = $"SELECT * FROM TrinhDo WHERE MaTD LIKE '%{keyword}%' OR TenTD LIKE N'%{keyword}%'";
            DataTable searchResult = ketnoi.LoadDataToTable(sql);
            dgvTrinhDo.DataSource = searchResult;
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
        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void dgvTrinhDo_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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
