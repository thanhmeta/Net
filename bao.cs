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

namespace baitaplon
{
    public partial class bao : UserControl
    {
        public bao()
        {
            InitializeComponent();
            SetupDataGridView();
            LoadComboBoxes();
            LoadData();
            dgvQuangCao.CellClick += dgvQuangCao_CellClick;
            



            buttonLayout.ColumnCount = 6;
            buttonLayout.Dock = DockStyle.Fill;
            for (int i = 0; i < 6; i++)
                buttonLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66F));
            string[] labels = { "➕ Thêm", "✏️ Sửa", "🗑️ Xoá", "💾 Lưu", "↩️ Bỏ Qua", "🚪 Thoát" };
            Button[] buttons = { btnThem, btnSua, btnXoa, btnLuu, btnBoQua, btnThoat };
            EventHandler[] events = { btnThem_Click, btnSua_Click, btnXoa_Click, btnLuu_Click, btnBoQua_Click, btnThoat_Click};
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



        private void LoadComboBoxes()
        {
            try
            {
                string sqlChucNang = "SELECT MaChucNang FROM ChucNang";
                
                DataTable dtBao = ketnoi.LoadDataToTable(sqlChucNang);
                

                cboMaChucNang.DataSource = dtBao;
                cboMaChucNang.DisplayMember = "MaChucNang";
                cboMaChucNang.ValueMember = "MaChucNang";

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải ComboBox: " + ex.Message);
            }
        }

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

            dgvQuangCao.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MaBao",
                HeaderText = "Mã Báo",
                DataPropertyName = "MaBao",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvQuangCao.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TenBao",
                HeaderText = " Tên Báo",
                DataPropertyName = "TenBao",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvQuangCao.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MaChucNang",
                HeaderText = "Mã CN",
                DataPropertyName = "MaChucNang",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });


            dgvQuangCao.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DiaChi",
                HeaderText = "Địa Chỉ",
                DataPropertyName = "DiaChi",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvQuangCao.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DienThoai",
                HeaderText = "Điện Thoại ",
                DataPropertyName = "DienThoai",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvQuangCao.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Email",
                HeaderText = "Email ",
                DataPropertyName = "Email",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
        }

        private void LoadData()
        {
            try
            {
                string sql = "SELECT * FROM Bao";
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
                txtMaBao.Text = dgvQuangCao.Rows[e.RowIndex].Cells["MaBao"].Value.ToString();
                txtTenBao.Text = dgvQuangCao.Rows[e.RowIndex].Cells["TenBao"].Value.ToString();
                txtDiaChi.Text = dgvQuangCao.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
                txtDienThoai.Text = dgvQuangCao.Rows[e.RowIndex].Cells["DienThoai"].Value.ToString();
                txtEmail.Text = dgvQuangCao.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                txtMaBao.ReadOnly = true; // Khóa không cho sửa Mã báo
                btnBoQua.Enabled = true;
                btnThem.Enabled = false;
                btnLuu.Enabled = false;
            }
        }



        // Nút Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            cboMaChucNang.SelectedIndex = -1;
            cboMaChucNang.SelectedIndex = -1;
            txtDienThoai.Text = "";
            txtMaBao.Text = "";
            txtTenBao.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            cboMaChucNang.Enabled = true;

            txtMaBao.ReadOnly = true;
            txtTenBao.Focus();
            txtDiaChi.Focus();
            txtDienThoai.Focus();
            txtEmail.Focus();

            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string thongBaoLoi = "";

            if (string.IsNullOrWhiteSpace(txtTenBao.Text))
                thongBaoLoi += "- Vui lòng nhập Tên Báo.\n";

            if (cboMaChucNang.SelectedValue == null || string.IsNullOrWhiteSpace(cboMaChucNang.Text))
                thongBaoLoi += "- Vui lòng chọn Mã Chức Năng.\n";

            if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
                thongBaoLoi += "- Vui lòng nhập Địa Chỉ.\n";
            if (string.IsNullOrWhiteSpace(txtDienThoai.Text))
                thongBaoLoi += "- Vui lòng nhập Điện Thoại.\n";
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
                thongBaoLoi += "- Vui lòng nhập Email.\n";

            if (!string.IsNullOrEmpty(thongBaoLoi))
            {
                MessageBox.Show(thongBaoLoi, "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                

                string sqlInsert = "INSERT INTO Bao ( TenBao, DiaChi, DienThoai, Email) " +
                                   "VALUES ( @TenBao, @DiaChi, @DienThoai, @Email)";
                using (SqlCommand cmd = new SqlCommand(sqlInsert, ketnoi.con))
                {
                    ketnoi.Connect();
                    
                    cmd.Parameters.AddWithValue("@TenBao", txtTenBao.Text.Trim());
                    cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text.Trim());
                    cmd.Parameters.AddWithValue("@DienThoai", txtDienThoai.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                    cmd.ExecuteNonQuery();
                    ketnoi.Close();
                }

                MessageBox.Show("Thêm báo thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm báo: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaBao.Text))
            {
                MessageBox.Show("Vui lòng chọn báo để sửa.");
                return;
            }

            try
            {
                string sqlUpdate = "UPDATE Bao SET TenBao = @TenBao, DiaChi = @DiaChi, DienThoai = @DienThoai, Email = @Email " +
                                   "WHERE MaBao = @MaBao";
                using (SqlCommand cmd = new SqlCommand(sqlUpdate, ketnoi.con))
                {
                    ketnoi.Connect();
                    cmd.Parameters.AddWithValue("@MaBao", txtMaBao.Text.Trim());
                    cmd.Parameters.AddWithValue("@TenBao", txtTenBao.Text.Trim());
                    cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text.Trim());
                    cmd.Parameters.AddWithValue("@DienThoai", txtDienThoai.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                    cmd.ExecuteNonQuery();
                    ketnoi.Close();
                }

                MessageBox.Show("Cập nhật thông tin báo thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật báo: " + ex.Message);
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaBao.Text))
            {
                MessageBox.Show("Vui lòng chọn báo để xóa.");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa báo này không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    string sqlDelete = "DELETE FROM Bao WHERE MaBao = @MaBao";
                    ketnoi.Connect();

                    using (SqlCommand cmd = new SqlCommand(sqlDelete, ketnoi.con))
                    {
                        cmd.Parameters.AddWithValue("@MaBao", txtMaBao.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Xóa báo thành công!");
                    LoadData();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547)
                    {
                        MessageBox.Show("Không thể xóa báo này vì đang được sử dụng ở bảng khác.", "Lỗi khóa ngoại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi SQL: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa báo: " + ex.Message);
                }
                finally
                {
                    ketnoi.Close();
                }
            }
        }

        // Nút Bỏ Qua (reset form, reload data)
        private void btnBoQua_Click(object sender, EventArgs e)
        {
            txtMaBao.Text = "";
            txtTenBao.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtEmail.Text = "";

            txtMaBao.Enabled = true;

            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
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


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                LoadData(); // Tải lại toàn bộ dữ liệu nếu không nhập từ khóa
                return;
            }

            try
            {
                string sqlSearch = $"SELECT * FROM Bao WHERE MaBao LIKE N'%{keyword}%' OR TenBao LIKE N'%{keyword}%' OR DiaChi LIKE N'%{keyword}%' OR Email LIKE N'%{keyword}%'";
                DataTable dt = ketnoi.LoadDataToTable(sqlSearch);
                dgvQuangCao.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
            txtMaBao.ReadOnly = true; // Khóa không cho sửa Mã báo
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

        private void bao_Load(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}

