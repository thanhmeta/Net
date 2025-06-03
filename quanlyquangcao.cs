using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;


namespace baitaplon
{
    public partial class quanlyquangcao : UserControl
    {
        bool isAdding = false, isEditing = false;
        string maLanQC, maKH, maNV, maBao, maQC, noiDung, ngayBD, ngayKT, tongTien;
        public quanlyquangcao()
        {
            InitializeComponent();
            LoadCombos();
            LoadData();
            btnIn.Click += new EventHandler(btnIn_Click);
            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnLuu.Click += btnLuu_Click;
            btnBoQua.Click += btnBoQua_Click;
            btnThoat.Click += btnThoat_Click;
            btnTimKiem.Click += btnTimKiem_Click;
            dgvQuangCao.CellClick += dgvQuangCao_CellClick;
            dgvQuangCao.DataBindingComplete += dgvQuangCao_DataBindingComplete;
            dgvQuangCao.RowPostPaint += dgvQuangCao_RowPostPaint; // ⭐ Gán sự kiện vẽ STT
            printDocument = new PrintDocument();
            printPreviewDialog = new PrintPreviewDialog();

            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
            printPreviewDialog.Document = printDocument;
        }
        private PrintDocument printDocument;
        private PrintPreviewDialog printPreviewDialog;
        private void btnIn_Click(object sender, EventArgs e)
        {
            if (dgvQuangCao.CurrentRow != null)
            {
                DataGridViewRow row = dgvQuangCao.CurrentRow;
                maLanQC = row.Cells["MaLanQC"].Value.ToString();
                maKH = row.Cells["MaKH"].Value.ToString();
                maNV = row.Cells["MaNV"].Value.ToString();
                maBao = row.Cells["MaBao"].Value.ToString();
                maQC = row.Cells["MaQCao"].Value.ToString();
                noiDung = row.Cells["NoiDung"].Value.ToString();
                ngayBD = Convert.ToDateTime(row.Cells["NgayBD"].Value).ToShortDateString();
                ngayKT = Convert.ToDateTime(row.Cells["NgayKT"].Value).ToShortDateString();
                tongTien = row.Cells["TongTien"].Value.ToString();

                printPreviewDialog.Document = printDocument;
                printPreviewDialog.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để in hợp đồng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font titleFont = new Font("Arial", 18, FontStyle.Bold);
            Font subTitleFont = new Font("Arial", 14, FontStyle.Bold);
            Font normalFont = new Font("Arial", 12);
            Font smallFont = new Font("Arial", 11, FontStyle.Italic);

            float x = 100, y = 100;
            float pageWidth = e.PageBounds.Width;


            // ⬆️ Tên công ty
            e.Graphics.DrawString("CÔNG TY TNHH QUẢNG CÁO VÀ VIẾT BÀI", subTitleFont, Brushes.Black, x, y);
            y += 40;

            // ⬆️ Tiêu đề hợp đồng (căn giữa)
            string title = "HỢP ĐỒNG QUẢNG CÁO";
            SizeF titleSize = e.Graphics.MeasureString(title, titleFont);
            float centerX = (pageWidth - titleSize.Width) / 2;
            e.Graphics.DrawString(title, titleFont, Brushes.Black, centerX, y);
            y += 40;

            // ⬆️ Mã lần QC
            float centerY = (pageWidth - titleSize.Width) / 2;
            e.Graphics.DrawString($"Mã hợp đồng: {maLanQC}", normalFont, Brushes.Black, centerY, y);
            y += 40;


            // ⬇️ Thông tin khách hàng
            e.Graphics.DrawString("Thông tin khách hàng:", subTitleFont, Brushes.Black, x, y);
            y += 30;
            e.Graphics.DrawString($"- Mã KH: {maKH}", normalFont, Brushes.Black, x + 20, y); y += 25;
            e.Graphics.DrawString($"- Nhân viên phụ trách: {maNV}", normalFont, Brushes.Black, x + 20, y); y += 40;

            // ⬇️ Nội dung QC
            e.Graphics.DrawString("Nội dung quảng cáo:", subTitleFont, Brushes.Black, x, y);
            y += 30;
            e.Graphics.DrawString($"- Mã báo: {maBao}", normalFont, Brushes.Black, x + 20, y); y += 25;
            e.Graphics.DrawString($"- Mã quảng cáo: {maQC}", normalFont, Brushes.Black, x + 20, y); y += 25;
            e.Graphics.DrawString($"- Ngày bắt đầu: {ngayBD}", normalFont, Brushes.Black, x + 20, y); y += 25;
            e.Graphics.DrawString($"- Ngày kết thúc: {ngayKT}", normalFont, Brushes.Black, x + 20, y); y += 25;
            e.Graphics.DrawString($"- Nội dung: {noiDung}", normalFont, Brushes.Black, x + 20, y); y += 60;

            // ⬇️ Tổng tiền
            e.Graphics.DrawString($"Tổng tiền: {tongTien} VNĐ", normalFont, Brushes.Black, x, y); y += 30;

            // string tongTienChu = ChuyenSoSangChu(tongTien);
            //  e.Graphics.DrawString($"Bằng chữ: {tongTienChu}", smallFont, Brushes.Black, x, y); y += 60;

            // ⬇️ Chữ ký
            e.Graphics.DrawString("KHÁCH HÀNG", normalFont, Brushes.Black, x + 50, y);

            e.Graphics.DrawString("ĐẠI DIỆN CÔNG TY", normalFont, Brushes.Black, x + 350, y);



        }
        private void LoadCombos()
        {
            cbbMaKH.DataSource = ketnoi.LoadDataToTable("SELECT MaKH FROM KhachHang");
            cbbMaKH.DisplayMember = "MaKH";
            cbbMaKH.ValueMember = "MaKH";

            cbbMaNV.DataSource = ketnoi.LoadDataToTable("SELECT MaNV FROM NhanVien");
            cbbMaNV.DisplayMember = "MaNV";
            cbbMaNV.ValueMember = "MaNV";

            cbbMaBao.DataSource = ketnoi.LoadDataToTable("SELECT MaBao FROM Bao");
            cbbMaBao.DisplayMember = "MaBao";
            cbbMaBao.ValueMember = "MaBao";

            cbbMaQCao.DataSource = ketnoi.LoadDataToTable("SELECT MaQCao FROM TTQuangCao");
            cbbMaQCao.DisplayMember = "MaQCao";
            cbbMaQCao.ValueMember = "MaQCao";
            txtTongTien.ReadOnly = true;
        }

        private void LoadData()
        {
            string sql = "SELECT * FROM Khach_QuangCao";
            dgvQuangCao.DataSource = ketnoi.LoadDataToTable(sql);
            cbbMaBao.SelectedIndexChanged += (s, e) => TinhTongTien();
            cbbMaQCao.SelectedIndexChanged += (s, e) => TinhTongTien();
            dtpNgayBD.ValueChanged += (s, e) => TinhTongTien();
            dtpNgayKT.ValueChanged += (s, e) => TinhTongTien();

        }

        private void dgvQuangCao_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                dgvQuangCao.Columns["MaLanQC"].HeaderText = "Mã Lần QC";
                dgvQuangCao.Columns["MaKH"].HeaderText = "Mã KH";
                dgvQuangCao.Columns["MaNV"].HeaderText = "Mã NV";
                dgvQuangCao.Columns["MaBao"].HeaderText = "Mã Báo";
                dgvQuangCao.Columns["MaQCao"].HeaderText = "Mã QC";
                dgvQuangCao.Columns["NoiDung"].HeaderText = "Nội dung";
                dgvQuangCao.Columns["NgayBD"].HeaderText = "Ngày BĐ";
                dgvQuangCao.Columns["NgayKT"].HeaderText = "Ngày KT";
                dgvQuangCao.Columns["TongTien"].HeaderText = "Tổng tiền";
            }
            catch { }
        }

        private void dgvQuangCao_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private void ClearInputs()
        {
            txtMaLanQC.Clear();
            txtNoiDung.Clear();
            txtTongTien.Clear();
            dtpNgayBD.Value = DateTime.Now;
            dtpNgayKT.Value = DateTime.Now;
        }
        private void TinhTongTien()
        {
            if (cbbMaQCao.SelectedIndex == -1 || cbbMaBao.SelectedIndex == -1) return;

            DateTime ngayBD = dtpNgayBD.Value;
            DateTime ngayKT = dtpNgayKT.Value;

            if (ngayKT < ngayBD) return;

            int soNgay = (ngayKT - ngayBD).Days + 1;

            string maQCao = cbbMaQCao.SelectedValue.ToString();
            string maBao = cbbMaBao.SelectedValue.ToString();

            string sqlGia = $"SELECT DonGia FROM BangGia WHERE MaQCao = '{maQCao}' AND MaBao = '{maBao}'";
            string giaStr = ketnoi.GetFieldValue(sqlGia);
            if (!decimal.TryParse(giaStr, out decimal giaTien))
            {
                txtTongTien.Text = "Không hợp lệ";
                return;
            }

            decimal tongTien = giaTien * soNgay * (soNgay + 1) / 2;
            txtTongTien.Text = tongTien.ToString("N0"); // định dạng số đẹp
        }


        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvQuangCao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvQuangCao.Rows.Count)
            {
                DataGridViewRow row = dgvQuangCao.Rows[e.RowIndex];
                txtMaLanQC.Text = row.Cells["MaLanQC"].Value.ToString();
                cbbMaKH.SelectedValue = row.Cells["MaKH"].Value.ToString();
                cbbMaNV.SelectedValue = row.Cells["MaNV"].Value.ToString();
                cbbMaBao.SelectedValue = row.Cells["MaBao"].Value.ToString();
                cbbMaQCao.SelectedValue = row.Cells["MaQCao"].Value.ToString();
                txtNoiDung.Text = row.Cells["NoiDung"].Value.ToString();
                dtpNgayBD.Value = Convert.ToDateTime(row.Cells["NgayBD"].Value);
                dtpNgayKT.Value = Convert.ToDateTime(row.Cells["NgayKT"].Value);
                txtTongTien.Text = row.Cells["TongTien"].Value.ToString();

                // Vô hiệu nút Thêm và Lưu khi đang chọn dòng
                btnThem.Enabled = true;
                btnLuu.Enabled = false;
                isAdding = false;
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearInputs();
            isAdding = true;

            // Ẩn, mờ ô nhập khóa chính
            txtMaLanQC.ReadOnly = true;
            txtMaLanQC.BackColor = Color.LightGray;
            txtMaLanQC.TabStop = false;

            txtNoiDung.Focus();

            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }



        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ClearInputs();
            isAdding = false;

            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!isAdding) return;

            // Kiểm tra dữ liệu đầu vào
            if (cbbMaKH.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Mã KH.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbbMaNV.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Mã NV.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbbMaBao.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Mã Báo.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbbMaQCao.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Mã QC.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNoiDung.Text))
            {
                MessageBox.Show("Vui lòng nhập nội dung quảng cáo.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime ngayBD = dtpNgayBD.Value;
            DateTime ngayKT = dtpNgayKT.Value;

            if (ngayKT < ngayBD)
            {
                MessageBox.Show("Ngày kết thúc không được nhỏ hơn ngày bắt đầu.", "Lỗi ngày tháng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int soNgay = (ngayKT - ngayBD).Days + 1;

            string maQCao = cbbMaQCao.SelectedValue.ToString();
            string maBao = cbbMaBao.SelectedValue.ToString();

            // Lấy đơn giá từ bảng giá
            string sqlGia = $"SELECT DonGia FROM BangGia WHERE MaQCao = '{maQCao}' AND MaBao = '{maBao}'";
            string giaStr = ketnoi.GetFieldValue(sqlGia);
            if (!decimal.TryParse(giaStr, out decimal giaTien))
            {
                MessageBox.Show($"Vui lòng kiểm tra lại Mã QC và Mã Báo: {giaStr}", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal tongTien = giaTien * soNgay * (soNgay + 1) / 2;

            try
            {
                ketnoi.Connect();
                string sql = @"INSERT INTO Khach_QuangCao 
            (MaKH, MaNV, MaBao, MaQCao, NoiDung, NgayBD, NgayKT, TongTien)
            VALUES 
            (@MaKH, @MaNV, @MaBao, @MaQCao, @NoiDung, @NgayBD, @NgayKT, @TongTien)";
                using (SqlCommand cmd = new SqlCommand(sql, ketnoi.con))
                {
                    cmd.Parameters.AddWithValue("@MaKH", cbbMaKH.SelectedValue);
                    cmd.Parameters.AddWithValue("@MaNV", cbbMaNV.SelectedValue);
                    cmd.Parameters.AddWithValue("@MaBao", cbbMaBao.SelectedValue);
                    cmd.Parameters.AddWithValue("@MaQCao", cbbMaQCao.SelectedValue);
                    cmd.Parameters.AddWithValue("@NoiDung", txtNoiDung.Text.Trim());
                    cmd.Parameters.AddWithValue("@NgayBD", ngayBD);
                    cmd.Parameters.AddWithValue("@NgayKT", ngayKT);
                    cmd.Parameters.AddWithValue("@TongTien", tongTien);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearInputs();
                isAdding = false;

                // Bật lại nút Sửa, Xóa; Ẩn Thêm, Lưu
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnLuu.Enabled = false;
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







        private void btnSua_Click(object sender, EventArgs e)
        {
            string maLanQC = txtMaLanQC.Text.Trim();
            if (string.IsNullOrWhiteSpace(maLanQC))
            {
                MessageBox.Show("Vui lòng chọn dòng quảng cáo cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra đầu vào
            if (cbbMaKH.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Mã KH.");
                return;
            }
            if (cbbMaNV.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Mã NV.");
                return;
            }
            if (cbbMaBao.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Mã Báo.");
                return;
            }
            if (cbbMaQCao.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Mã QC.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNoiDung.Text))
            {
                MessageBox.Show("Vui lòng nhập nội dung quảng cáo.");
                return;
            }

            string maKH = cbbMaKH.SelectedValue.ToString();
            string maNV = cbbMaNV.SelectedValue.ToString();
            string maBao = cbbMaBao.SelectedValue.ToString();
            string maQCao = cbbMaQCao.SelectedValue.ToString();
            string noiDung = txtNoiDung.Text.Trim();
            DateTime ngayBD = dtpNgayBD.Value;
            DateTime ngayKT = dtpNgayKT.Value;

            if (ngayKT < ngayBD)
            {
                MessageBox.Show("Ngày kết thúc không được nhỏ hơn ngày bắt đầu.");
                return;
            }

            int soNgay = (ngayKT - ngayBD).Days + 1;

            string sqlGia = $"SELECT DonGia FROM BangGia WHERE MaQCao = '{maQCao}' AND MaBao = '{maBao}'";
            string giaStr = ketnoi.GetFieldValue(sqlGia);
            if (!decimal.TryParse(giaStr, out decimal giaTien))
            {
                MessageBox.Show($"Lỗi định dạng đơn giá: {giaStr}");
                return;
            }

            decimal tongTien = giaTien * soNgay * (soNgay + 1) / 2;

            try
            {
                ketnoi.Connect();
                string sql = @"UPDATE Khach_QuangCao 
                       SET MaKH=@MaKH, MaNV=@MaNV, MaBao=@MaBao, MaQCao=@MaQCao, NoiDung=@NoiDung, 
                           NgayBD=@NgayBD, NgayKT=@NgayKT, TongTien=@TongTien 
                       WHERE MaLanQC=@MaLanQC";
                using (SqlCommand cmd = new SqlCommand(sql, ketnoi.con))
                {
                    cmd.Parameters.AddWithValue("@MaLanQC", maLanQC);
                    cmd.Parameters.AddWithValue("@MaKH", maKH);
                    cmd.Parameters.AddWithValue("@MaNV", maNV);
                    cmd.Parameters.AddWithValue("@MaBao", maBao);
                    cmd.Parameters.AddWithValue("@MaQCao", maQCao);
                    cmd.Parameters.AddWithValue("@NoiDung", noiDung);
                    cmd.Parameters.AddWithValue("@NgayBD", ngayBD);
                    cmd.Parameters.AddWithValue("@NgayKT", ngayKT);
                    cmd.Parameters.AddWithValue("@TongTien", tongTien);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Bạn đã cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ketnoi.Close();
            }

            // Không cho sửa mã lần QC
            txtMaLanQC.Enabled = false;
            txtMaLanQC.ReadOnly = true;
            txtMaLanQC.BackColor = Color.LightGray;
            txtMaLanQC.TabStop = false;

            isEditing = false;
            isAdding = false;
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maLanQC = txtMaLanQC.Text.Trim();
            if (string.IsNullOrEmpty(maLanQC))
            {
                MessageBox.Show("Vui lòng chọn dòng cần xoá.");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string sql = $"DELETE FROM Khach_QuangCao WHERE MaLanQC = '{maLanQC}'";
                ketnoi.RunSql(sql);
                LoadData();
                ClearInputs();
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            string sql = $"SELECT * FROM Khach_QuangCao WHERE MaLanQC LIKE '%{keyword}%' OR NoiDung LIKE N'%{keyword}%'";
            dgvQuangCao.DataSource = ketnoi.LoadDataToTable(sql);
        }
    }
}
