using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace baitaplon
{
    public partial class baocaonv : UserControl
    {
        public baocaonv()
        {
            InitializeComponent();
        }

        private void cboThoiGian_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string selected = cboThoiGian.SelectedItem.ToString();

            if (selected == "Tùy chọn")
            {
                dtpTuNgay.Visible = true;
                dtpDenNgay.Visible = true;
            }
            else
            {
                dtpTuNgay.Visible = false;
                dtpDenNgay.Visible = false;

                // (Tuỳ chọn) Reset ngày nếu muốn
                dtpTuNgay.Value = DateTime.Today;
                dtpDenNgay.Value = DateTime.Today;

            }
        }
        private void btnLoc_Click(object sender, EventArgs e)
        {
            string selected = cboThoiGian.Text.Trim();

            // Kiểm tra nếu chưa chọn thời gian
            if (string.IsNullOrEmpty(selected))
            {
                MessageBox.Show("Bạn chưa chọn thời gian lọc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selected == "Tùy chọn")
            {
                DateTime tuNgay = dtpTuNgay.Value.Date;
                DateTime denNgay = dtpDenNgay.Value.Date;
                DateTime homNay = DateTime.Today;

                // Kiểm tra Từ ngày phải <= Đến ngày
                if (tuNgay > denNgay)
                {
                    MessageBox.Show("Ngày bắt đầu phải < hoặc = ngày kết thúc", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra không được chọn ngày trong tương lai
                if (tuNgay > homNay || denNgay > homNay)
                {
                    MessageBox.Show("Không được chọn thời gian trong tương lai.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string tuyChon = $"{tuNgay:dd/MM/yyyy}-{denNgay:dd/MM/yyyy}";

                // Kiểm tra xem đã tồn tại trong ComboBox chưa
                bool daTonTai = false;
                foreach (var item in cboThoiGian.Items)
                {
                    if (item.ToString() == tuyChon)
                    {
                        daTonTai = true;
                        break;
                    }
                }

                // Nếu chưa tồn tại thì thêm vào
                if (!daTonTai)
                {
                    cboThoiGian.Items.Add(tuyChon);
                }

                // Set dòng đó là dòng đang được chọn
                cboThoiGian.SelectedItem = tuyChon;
            }

            // Gọi hàm load dữ liệu
            LoadBaoCaoNhanVien();
            LoadTop5NVBV();
            LoadTop5NhanVienQuangCao();
        }
        private (DateTime TuNgay, DateTime DenNgay) GetDateRange()
        {
            string selected = cboThoiGian.Text.Trim();
            DateTime today = DateTime.Today;

            if (selected.Contains("-") &&
                DateTime.TryParseExact(selected.Split('-')[0], "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime fromDate) &&
                DateTime.TryParseExact(selected.Split('-')[1], "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime toDate))
            {
                return (fromDate, toDate);
            }

            switch (selected)
            {
                case "Hôm nay":
                    return (today, today);
                case "Tuần này":
                    int delta = DayOfWeek.Monday - today.DayOfWeek;
                    DateTime monday = today.AddDays(delta);
                    DateTime sunday = monday.AddDays(6);
                    return (monday, sunday);
                case "Tháng này":
                    DateTime firstOfMonth = new DateTime(today.Year, today.Month, 1);
                    DateTime lastOfMonth = firstOfMonth.AddMonths(1).AddDays(-1);
                    return (firstOfMonth, lastOfMonth);
                case "Năm nay":
                    return (new DateTime(today.Year, 1, 1), new DateTime(today.Year, 12, 31));
                case "Tùy chọn":
                    return (dtpTuNgay.Value.Date, dtpDenNgay.Value.Date);
                default:
                    return (DateTime.MinValue, DateTime.MaxValue); // fallback nếu không chọn gì
            }
        }
        
        private void LoadBaoCaoNhanVien()
        {
            try
            {
                ketnoi.Connect();

                var (tuNgay, denNgay) = GetDateRange();
               // MessageBox.Show($"Lọc dữ liệu từ {tuNgay:yyyy-MM-dd} đến {denNgay:yyyy-MM-dd}");

                SqlCommand cmd = new SqlCommand("sp_BaoCaoNhanVienCoBai", ketnoi.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TuNgay", tuNgay);
                cmd.Parameters.AddWithValue("@DenNgay", denNgay);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

              //  MessageBox.Show("Số dòng dữ liệu lấy được: " + dt.Rows.Count);

                if (dt.Rows.Count > 0)
                {
                    rptNhanVien.Reset();
                    rptNhanVien.LocalReport.DataSources.Clear();

                    string reportPath = Path.Combine(Application.StartupPath, "RptNhanVien.rdlc");
                    rptNhanVien.LocalReport.ReportPath = reportPath;

                    ReportDataSource rds = new ReportDataSource("DataSet1", dt); // đổi "DataSet1" theo đúng tên dataset trong rdlc
                    rptNhanVien.LocalReport.DataSources.Add(rds);
                    // >>> Thêm phần cấu hình hiển thị tại đây <<<
                    rptNhanVien.Dock = DockStyle.Fill;
                    rptNhanVien.ZoomMode = ZoomMode.PageWidth;

                    rptNhanVien.RefreshReport();
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu để hiển thị.");
                    rptNhanVien.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo báo cáo: " + ex.Message);
            }
            finally
            {
                if (ketnoi.con.State == ConnectionState.Open)
                    ketnoi.con.Close();
            }
        }

        private void lblTieuDe_Click(object sender, EventArgs e)
        {

        }
        private string GetDateCondition(string columnName)
        {
            string selected = cboThoiGian.Text.Trim();

            // Kiểm tra nếu selected là dạng "dd/MM/yyyy-dd/MM/yyyy"
            if (selected.Contains("-") && DateTime.TryParseExact(selected.Split('-')[0], "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime fromDate)
                && DateTime.TryParseExact(selected.Split('-')[1], "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime toDate))
            {
                return $"{columnName} BETWEEN '{fromDate:yyyy-MM-dd}' AND '{toDate:yyyy-MM-dd}'";
            }

            switch (selected)
            {
                case "Hôm nay":
                    return $"{columnName} = CAST(GETDATE() AS DATE)";
                case "Tuần này":
    (DateTime monday, DateTime sunday) = GetDateRange();
    return $"{columnName} BETWEEN '{monday:yyyy-MM-dd}' AND '{sunday:yyyy-MM-dd}'";

                case "Tháng này":
                    return $"{columnName} >= DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1) " +
                           $"AND {columnName} < DATEADD(MONTH, 1, DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1))";
                case "Năm nay":
                    return $"{columnName} >= DATEFROMPARTS(YEAR(GETDATE()), 1, 1) " +
                           $"AND {columnName} < DATEFROMPARTS(YEAR(GETDATE()) + 1, 1, 1)";
                case "Tùy chọn":
                    // fallback, lấy ngày hiện tại của dtp nếu không có chuỗi ngày format chuẩn
                    DateTime from = dtpTuNgay.Value.Date;
                    DateTime to = dtpDenNgay.Value.Date;
                    return $"{columnName} BETWEEN '{from:yyyy-MM-dd}' AND '{to:yyyy-MM-dd}'";
                default:
                    return "1=1";
            }
        }
        private void LoadTop5NVBV()
        {
            // XÓA DỮ LIỆU CŨ
            charttop5Bv.Series.Clear();
            charttop5Bv.Titles.Clear();
            charttop5Bv.Legends.Clear();

            // Tạo series mới, kiểu cột
            var series = new System.Windows.Forms.DataVisualization.Charting.Series("TopNV")
            {
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
            };
            charttop5Bv.Series.Add(series);

            // Thêm tiêu đề biểu đồ
            charttop5Bv.Titles.Add("Top 5 nhân viên phụ trách nhiều bài viết nhất");

            ketnoi.Connect();

            string dieuKienThoiGian = GetDateCondition("kgb.NgayDang"); // dùng điều kiện thời gian nếu có

            string query = $@"
        SELECT TOP 5 nv.TenNV, COUNT(*) AS SoLuongBai
        FROM KhachGuiBai kgb
        JOIN NhanVien nv ON kgb.MaNV = nv.MaNV
        WHERE {dieuKienThoiGian}
        GROUP BY nv.TenNV
        ORDER BY SoLuongBai DESC";

            SqlCommand cmd = new SqlCommand(query, ketnoi.con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string tenNV = reader["TenNV"].ToString();
                int soLuong = Convert.ToInt32(reader["SoLuongBai"]);
                charttop5Bv.Series[0].Points.AddXY(tenNV, soLuong);
            }

            reader.Close();
            ketnoi.Close();
            // Ép trục Y chỉ hiển thị số nguyên
            charttop5Bv.ChartAreas[0].AxisY.Interval = 1;
            charttop5Bv.ChartAreas[0].AxisY.Minimum = 0;
            charttop5Bv.ChartAreas[0].AxisY.LabelStyle.Format = "0";
            charttop5Bv.Series["TopNV"].IsVisibleInLegend = false;
            // Ẩn đường kẻ lưới ngang dọc
            charttop5Bv.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            charttop5Bv.ChartAreas[0].AxisY.MajorGrid.Enabled = false;


        }
        private void LoadTop5NhanVienQuangCao()
        {
            // XÓA DỮ LIỆU CŨ
            charttop5QC.Series.Clear();
            charttop5QC.Titles.Clear();
            charttop5QC.Legends.Clear();

            // Tạo series mới
            charttop5QC.Series.Add("TopQC");
            charttop5QC.Series["TopQC"].ChartType = SeriesChartType.Column;

            // Thêm tiêu đề biểu đồ
            charttop5QC.Titles.Add("Top 5 nhân viên phụ trách nhiều quảng cáo nhất");

            ketnoi.Connect();

            string dieuKienThoiGian = GetDateCondition("qc.NgayBD"); // dùng lại hàm lọc thời gian bạn đã viết

            string query = $@"
        SELECT TOP 5 nv.TenNV, COUNT(*) AS SoLuongQC
        FROM Khach_QuangCao qc
        JOIN NhanVien nv ON qc.MaNV = nv.MaNV
        WHERE {dieuKienThoiGian}
        GROUP BY nv.TenNV
        ORDER BY SoLuongQC DESC";

            SqlCommand cmd = new SqlCommand(query, ketnoi.con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string tenNV = reader["TenNV"].ToString();
                int soLuong = Convert.ToInt32(reader["SoLuongQC"]);
                charttop5QC.Series["TopQC"].Points.AddXY(tenNV, soLuong);
            }

            reader.Close();
            ketnoi.Close();

            // Trục Y hiển thị số nguyên
            charttop5QC.ChartAreas[0].AxisY.Interval = 1;
            charttop5QC.ChartAreas[0].AxisY.Minimum = 0;
            charttop5QC.ChartAreas[0].AxisY.LabelStyle.Format = "0";

            // Ẩn chú thích series
            charttop5QC.Series["TopQC"].IsVisibleInLegend = false;
            // Ẩn đường kẻ lưới ngang dọc
            charttop5QC.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            charttop5QC.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        }

        private void baocaonv_Load(object sender, EventArgs e)
        {

        }
    }
}
