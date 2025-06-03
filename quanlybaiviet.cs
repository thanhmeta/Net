
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace baitaplon
{

    public partial class quanlybaiviet : UserControl
    {
        private bool isEditing = false;
        private bool isAdding = false;
        string maLanGui, maKH, maTheLoai, maBao, tieuDe, noiDung, maNV, ngayDang, nhuanBut;

        public quanlybaiviet()
        {
            InitializeComponent();
            LoadData();
            LoadCombos();

            btnIn.Click += new EventHandler(btnIn_Click);
            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnLuu.Click += btnLuu_Click;
            btnBoQua.Click += btnBoQua_Click;
            btnThoat.Click += btnThoat_Click;
            btnTimKiem.Click += btnTimKiem_Click;
            dgvBaiViet.CellClick += dgvBaiViet_CellClick;

            cbbMaBao.SelectedIndexChanged += (s, e) => TinhNhuanBut();
            cbbMaTheLoai.SelectedIndexChanged += (s, e) => TinhNhuanBut();
            printDocument = new PrintDocument();
            printPreviewDialog = new PrintPreviewDialog();

            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
            printPreviewDialog.Document = printDocument;
        }
        private PrintDocument printDocument;
        private PrintPreviewDialog printPreviewDialog;
        private void btnIn_Click(object sender, EventArgs e)
        {
            if (dgvBaiViet.CurrentRow != null)
            {
                var row = dgvBaiViet.CurrentRow;

                maLanGui = row.Cells["Mã Lần Gửi"].Value.ToString();
                maKH = row.Cells["Mã KH"].Value.ToString();
                maTheLoai = row.Cells["Mã Thể Loại"].Value.ToString();
                maBao = row.Cells["Mã Báo"].Value.ToString();
                tieuDe = row.Cells["Tiêu Đề"].Value.ToString();
                noiDung = row.Cells["Nội Dung"].Value.ToString();
                maNV = row.Cells["Mã NV"].Value.ToString();
                ngayDang = Convert.ToDateTime(row.Cells["Ngày Đăng"].Value).ToString("dd/MM/yyyy");
                nhuanBut = row.Cells["Nhuận Bút"].Value.ToString();

                printPreviewDialog.Document = printDocument;
                printPreviewDialog.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một bài viết để in!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font fontTitle = new Font("Arial", 16, FontStyle.Bold);
            Font fontSubTitle = new Font("Arial", 14, FontStyle.Bold);
            Font font = new Font("Arial", 12);
            Brush brush = Brushes.Black;
            int y = 50;

            // Tiêu đề công ty
            g.DrawString("CÔNG TY TNHH QUẢNG CÁO VÀ VIẾT BÀI", font, brush, 50, y);
            y += 40;

            // Tiêu đề hợp đồng
            g.DrawString("HỢP ĐỒNG BÀI VIẾT", fontTitle, brush, 250, y);
            y += 40;

            // Mã hợp đồng
            g.DrawString("Mã hợp đồng: " + maLanGui, font, brush, 250, y);
            y += 30;

            g.DrawLine(Pens.Black, 30, y, 770, y); // Dòng kẻ ngang
            y += 20;

            // Thông tin khách hàng
            g.DrawString("Thông tin khách hàng:", fontSubTitle, brush, 50, y);
            y += 30;
            g.DrawString("- Tên khách hàng: " + maKH, font, brush, 70, y); y += 25;
            g.DrawString("- Tên nhân viên phụ trách: " + maNV, font, brush, 70, y); y += 30;

            // Nội dung bài viết
            g.DrawString("Nội dung bài viết:", fontSubTitle, brush, 50, y);
            y += 30;
            g.DrawString("- Báo: " + maBao, font, brush, 70, y); y += 25;
            g.DrawString("- Thể loại: " + maTheLoai, font, brush, 70, y); y += 25;
            g.DrawString("- Ngày đăng: " + ngayDang, font, brush, 70, y); y += 25;
            g.DrawString("- Tiêu đề: " + tieuDe, font, brush, 70, y); y += 25;
            g.DrawString("- Nội dung:", font, brush, 70, y); y += 25;
            g.DrawString(noiDung, font, brush, new RectangleF(90, y, 680, 150)); y += 160;

            // Tổng nhuận bút
            g.DrawString("Tổng nhuận bút: " + string.Format("{0:N0}", nhuanBut) + " VNĐ", font, brush, 50, y);
            y += 30;

          /*  // Tổng tiền bằng chữ
            try
            {
                decimal tien = Convert.ToDecimal(nhuanBut);
                string bangChu = ChuyenSoSangChu(tien);
                g.DrawString("Tổng tiền bằng chữ: " + bangChu, font, brush, 50, y);
                y += 30;
            }
            catch
            {
                g.DrawString("Tổng tiền bằng chữ: (Lỗi chuyển số)", font, brush, 50, y);
                y += 30;
            }*/

            y += 50;

            // Ký tên
            g.DrawString("KHÁCH HÀNG", font, brush, 150, y);
            g.DrawString("CÔNG TY", font, brush, 550, y);
            y += 20;
            g.DrawString("(Ký tên)", font, brush, 150, y);
            g.DrawString("(Ký tên, đóng dấu)", font, brush, 550, y);
        }



        private void LoadData()
        {
            ketnoi.Connect();
            string query = "SELECT MaLanGui AS [Mã Lần Gửi], MaKH AS [Mã KH], MaTheLoai AS [Mã Thể Loại], MaBao AS [Mã Báo], TieuDe AS [Tiêu Đề], NoiDung AS [Nội Dung], MaNV AS [Mã NV], NgayDang AS [Ngày Đăng], NhuanBut AS [Nhuận Bút] FROM KhachGuiBai";
            SqlDataAdapter da = new SqlDataAdapter(query, ketnoi.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvBaiViet.DataSource = dt;
        }

        private void LoadCombos()
        {
            LoadComboBox(cbbMaKH, "SELECT MaKH FROM KhachHang");
            LoadComboBox(cbbMaBao, "SELECT MaBao FROM Bao");
            LoadComboBox(cbbMaTheLoai, "SELECT MaTheLoai FROM TheLoai");
            LoadComboBox(cbbMaNV, "SELECT MaNV FROM NhanVien");
        }

        private void LoadComboBox(ComboBox combo, string query)
        {
            SqlDataAdapter da = new SqlDataAdapter(query, ketnoi.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            combo.DataSource = dt;
            combo.DisplayMember = dt.Columns[0].ColumnName;
            combo.ValueMember = dt.Columns[0].ColumnName;
        }

        private void TinhNhuanBut()
        {
            if (cbbMaTheLoai.SelectedIndex == -1)
                return;

            string maTheLoai = cbbMaTheLoai.SelectedValue.ToString();
            string query = "SELECT TOP 1 NhuanBut FROM Bao_TheLoai WHERE MaTheLoai = @maTheLoai";

            using (SqlCommand cmd = new SqlCommand(query, ketnoi.con))
            {
                cmd.Parameters.AddWithValue("@maTheLoai", maTheLoai);

                try
                {
                    if (ketnoi.con.State == ConnectionState.Closed)
                        ketnoi.con.Open();

                    object result = cmd.ExecuteScalar();

                    if (result != null && decimal.TryParse(result.ToString(), out decimal nhuanBut))
                        txtNhuanBut.Text = nhuanBut.ToString("N0"); // Format: 500,000
                    else
                        txtNhuanBut.Text = "0";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lấy nhuận bút: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (ketnoi.con.State == ConnectionState.Open)
                        ketnoi.con.Close();
                }
            }
        }

        private void dgvBaiViet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvBaiViet.Rows[e.RowIndex].Cells["Mã Lần Gửi"].Value != null)
            {
                DataGridViewRow row = dgvBaiViet.Rows[e.RowIndex];
                txtMaLanGui.Text = row.Cells["Mã Lần Gửi"].Value.ToString();
                cbbMaKH.SelectedValue = row.Cells["Mã KH"].Value;
                cbbMaTheLoai.SelectedValue = row.Cells["Mã Thể Loại"].Value;
                cbbMaBao.SelectedValue = row.Cells["Mã Báo"].Value;
                txtTieuDe.Text = row.Cells["Tiêu Đề"].Value.ToString();
                txtNoiDung.Text = row.Cells["Nội Dung"].Value.ToString();
                cbbMaNV.SelectedValue = row.Cells["Mã NV"].Value;
                dtpNgayDang.Value = Convert.ToDateTime(row.Cells["Ngày Đăng"].Value);
                txtNhuanBut.Text = row.Cells["Nhuận Bút"].Value.ToString();

                txtMaLanGui.ReadOnly = true;
                txtMaLanGui.BackColor = Color.LightGray;

                isAdding = false;
                isEditing = false;

                btnThem.Enabled = false;
                btnLuu.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearInputs();
            isAdding = true;
            txtTieuDe.Focus();

            // Vô hiệu hoá các nút không cần thiết trong lúc thêm mới
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
            btnThem.Enabled = false;

            // Vô hiệu hoá DataGridView để tránh chọn dòng khi đang thêm
            dgvBaiViet.Enabled = false;
        }



        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ClearInputs();

            isAdding = false;
            isEditing = false;

            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }



        private void ClearInputs()
        {
            txtMaLanGui.Clear();
            txtMaLanGui.ReadOnly = true; // không cho sửa
            txtMaLanGui.BackColor = Color.LightGray; // làm mờ
            txtMaLanGui.TabStop = false; // không cho focus

            txtTieuDe.Clear();
            txtNoiDung.Clear();
            txtNhuanBut.Clear();
            dtpNgayDang.Value = DateTime.Today;
            cbbMaKH.SelectedIndex = -1;
            cbbMaBao.SelectedIndex = -1;
            cbbMaTheLoai.SelectedIndex = -1;
            cbbMaNV.SelectedIndex = -1;
        }


        private bool ValidateInputs()
        {
            if (cbbMaTheLoai.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Mã Thể Loại.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cbbMaBao.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Mã Báo.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTieuDe.Text))
            {
                MessageBox.Show("Vui lòng nhập Tiêu Đề.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNoiDung.Text))
            {
                MessageBox.Show("Vui lòng nhập Nội Dung đầy đủ.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cbbMaNV.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Mã NV.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!isAdding) return;

            // Kiểm tra bắt buộc các trường
            if (cbbMaKH.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Mã KH.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            if (cbbMaTheLoai.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Mã Thể Loại.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            if (cbbMaBao.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Mã Báo.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            if (string.IsNullOrWhiteSpace(txtTieuDe.Text))
            {
                MessageBox.Show("Vui lòng nhập Tiêu đề.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            if (string.IsNullOrWhiteSpace(txtNoiDung.Text))
            {
                MessageBox.Show("Vui lòng nhập Nội dung.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            if (cbbMaNV.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Mã NV.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            // Xử lý định dạng nhuận bút
            string rawNhuanBut = txtNhuanBut.Text.Replace(",", "").Replace(".", "").Trim();
            if (!decimal.TryParse(rawNhuanBut, out decimal nhuanBut))
            {
                MessageBox.Show("Nhuận bút không hợp lệ. Vui lòng chỉ nhập số (không ký tự hoặc chữ).", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                ketnoi.Connect();
                string query = @"INSERT INTO KhachGuiBai 
                        (MaKH, MaTheLoai, MaBao, TieuDe, NoiDung, MaNV, NgayDang, NhuanBut) 
                        VALUES 
                        (@MaKH, @MaTheLoai, @MaBao, @TieuDe, @NoiDung, @MaNV, @NgayDang, @NhuanBut)";

                using (SqlCommand cmd = new SqlCommand(query, ketnoi.con))
                {
                    cmd.Parameters.AddWithValue("@MaKH", cbbMaKH.SelectedValue);
                    cmd.Parameters.AddWithValue("@MaTheLoai", cbbMaTheLoai.SelectedValue);
                    cmd.Parameters.AddWithValue("@MaBao", cbbMaBao.SelectedValue);
                    cmd.Parameters.AddWithValue("@TieuDe", txtTieuDe.Text.Trim());
                    cmd.Parameters.AddWithValue("@NoiDung", txtNoiDung.Text.Trim());
                    cmd.Parameters.AddWithValue("@MaNV", cbbMaNV.SelectedValue);
                    cmd.Parameters.AddWithValue("@NgayDang", dtpNgayDang.Value);
                    cmd.Parameters.AddWithValue("@NhuanBut", nhuanBut);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        LoadData();
                        ClearInputs();
                        MessageBox.Show("Thêm bài viết thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm bài viết: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string maLanGui = txtMaLanGui.Text.Trim();
            if (string.IsNullOrWhiteSpace(maLanGui))
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs()) return;

            string rawNhuanBut = txtNhuanBut.Text.Replace(",", "").Trim();
            if (!decimal.TryParse(rawNhuanBut, out decimal nhuanBut))
            {
                MessageBox.Show("Nhuận bút không hợp lệ. Vui lòng nhập đúng định dạng, ví dụ: 60000.00", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                ketnoi.Connect();

                string query = "UPDATE KhachGuiBai SET " +
                               "MaKH = @MaKH, MaTheLoai = @MaTheLoai, MaBao = @MaBao, " +
                               "TieuDe = @TieuDe, NoiDung = @NoiDung, MaNV = @MaNV, " +
                               "NgayDang = @NgayDang, NhuanBut = @NhuanBut " +
                               "WHERE MaLanGui = @MaLanGui";

                SqlCommand cmd = new SqlCommand(query, ketnoi.con);
                cmd.Parameters.AddWithValue("@MaLanGui", maLanGui);
                cmd.Parameters.AddWithValue("@MaKH", cbbMaKH.SelectedValue);
                cmd.Parameters.AddWithValue("@MaTheLoai", cbbMaTheLoai.SelectedValue);
                cmd.Parameters.AddWithValue("@MaBao", cbbMaBao.SelectedValue);
                cmd.Parameters.AddWithValue("@TieuDe", txtTieuDe.Text.Trim());
                cmd.Parameters.AddWithValue("@NoiDung", txtNoiDung.Text.Trim());
                cmd.Parameters.AddWithValue("@MaNV", cbbMaNV.SelectedValue);
                cmd.Parameters.AddWithValue("@NgayDang", dtpNgayDang.Value);
                cmd.Parameters.AddWithValue("@NhuanBut", nhuanBut);

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    LoadData();
                    ClearInputs();
                    MessageBox.Show("Bạn đã cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dòng cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ketnoi.Close();
            }

            // Không cho sửa khóa chính
            txtMaLanGui.Enabled = false;
            txtMaLanGui.ReadOnly = true;
            txtMaLanGui.TabStop = false;
            txtMaLanGui.BackColor = Color.LightGray;
        }



        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maLanGui = txtMaLanGui.Text.Trim();
            if (string.IsNullOrEmpty(maLanGui))
            {
                MessageBox.Show("Vui lòng chọn dòng cần xoá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá không?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string sql = $"DELETE FROM KhachGuiBai WHERE MaLanGui = '{maLanGui}'";
                    ketnoi.RunSql(sql);  // giả định bạn có hàm RunSql trong lớp ketnoi
                    LoadData();          // reload lại lưới
                    ClearInputs();       // xoá trắng form
                    MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xoá: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            string query = "SELECT MaLanGui AS [Mã Lần Gửi], MaKH AS [Mã KH], MaTheLoai AS [Mã Thể Loại], MaBao AS [Mã Báo], TieuDe AS [Tiêu Đề], NoiDung AS [Nội Dung], MaNV AS [Mã NV], NgayDang AS [Ngày Đăng], NhuanBut AS [Nhuận Bút] FROM KhachGuiBai WHERE MaLanGui LIKE @kw OR TieuDe LIKE @kw";
            SqlDataAdapter da = new SqlDataAdapter(query, ketnoi.con);
            da.SelectCommand.Parameters.AddWithValue("@kw", "%" + keyword + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvBaiViet.DataSource = dt;
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
    }
}
