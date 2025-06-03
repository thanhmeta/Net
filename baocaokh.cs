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

namespace baitaplon
{
    public partial class baocaokh : UserControl
    {
        public baocaokh()
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
            LoadTop5KhachHangGB();
            LoadTop5KhachQC();
            LoadBaoCaoKhachHang();
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
        private void LoadTop5KhachQC()
        {
            // XÓA DỮ LIỆU CŨ
            charttop5KHQC.Series.Clear();
            charttop5KHQC.Titles.Clear();
            charttop5KHQC.Legends.Clear();

            // Tạo series mới, kiểu cột
            var series = new System.Windows.Forms.DataVisualization.Charting.Series("bcnhuanbut")
            {
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
            };
            charttop5KHQC.Series.Add(series);

            // Thêm tiêu đề biểu đồ
            charttop5KHQC.Titles.Add("Top 5 khach hang quảng cáo cho doanh thu cao nhat");

            ketnoi.Connect();

            string dieuKienThoiGian = GetDateCondition("kqc.NgayBD"); // <-- rất tốt, dùng lại hàm bạn đã viết!

            string query = $@"
        SELECT TOP 5 kh.TenKH, SUM(kqc.TongTien) AS DoanhThu
        FROM Khach_QuangCao kqc
        JOIN KhachHang kh ON kqc.MaKH = kh.MaKH
        WHERE {dieuKienThoiGian}
        GROUP BY kh.TenKH
        ORDER BY DoanhThu DESC";

            SqlCommand cmd = new SqlCommand(query, ketnoi.con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string tenKH = reader["TenKH"].ToString();
                double doanhThu = Convert.ToDouble(reader["DoanhThu"]);
                charttop5KHQC.Series[0].Points.AddXY(tenKH, doanhThu);
            }

            reader.Close();
            ketnoi.Close();
            // Ẩn đường kẻ lưới ngang dọc
            charttop5KHQC.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            charttop5KHQC.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

        }
        private void LoadTop5KhachHangGB()
        {
            // XÓA DỮ LIỆU CŨ
            charttop5KHGB.Series.Clear();
            charttop5KHGB.Titles.Clear();
            charttop5KHGB.Legends.Clear();

            // Tạo series mới, kiểu cột
            var series = new System.Windows.Forms.DataVisualization.Charting.Series("bcnhuanbut")
            {
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
            };
            charttop5KHGB.Series.Add(series);


            // Thêm tiêu đề biểu đồ
            charttop5KHGB.Titles.Add("Top 5 khach hang co nhuan but cao nhat");

            ketnoi.Connect();

            string dieuKienThoiGian = GetDateCondition("kgb.NgayDang"); // <-- rất tốt, dùng lại hàm bạn đã viết!

            string query = $@"
        SELECT TOP 5 kh.TenKH, SUM(kgb.NhuanBut) AS nhuanbut
        FROM KhachGuiBai kgb
        JOIN KhachHang kh ON kgb.MaKH = kh.MaKH
        WHERE {dieuKienThoiGian}
        GROUP BY kh.TenKH
        ORDER BY nhuanbut DESC";

            SqlCommand cmd = new SqlCommand(query, ketnoi.con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string tenKH = reader["TenKH"].ToString();
                double nhuanbut = Convert.ToDouble(reader["nhuanbut"]);
                charttop5KHGB.Series[0].Points.AddXY(tenKH, nhuanbut);
            }

            reader.Close();
            ketnoi.Close();
            // Ẩn đường kẻ lưới ngang dọc
            charttop5KHGB.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            charttop5KHGB.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
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
        private void LoadBaoCaoKhachHang()
        {
            try
            {
                ketnoi.Connect();

                var (tuNgay, denNgay) = GetDateRange();

               // MessageBox.Show($"Lọc dữ liệu từ {tuNgay:yyyy-MM-dd} đến {denNgay:yyyy-MM-dd}");
               
                SqlCommand cmd = new SqlCommand("sp_BaoCaoKhachHangCoBai", ketnoi.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TuNgay", tuNgay);
                cmd.Parameters.AddWithValue("@DenNgay", denNgay);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

               // MessageBox.Show("Số dòng dữ liệu lấy được: " + dt.Rows.Count);

                if (dt.Rows.Count > 0)
                {
                    RptKhachHang.Reset();
                    RptKhachHang.LocalReport.DataSources.Clear();

                    string reportPath = Path.Combine(Application.StartupPath, "RptKhachHang.rdlc");
                    if (!File.Exists(reportPath))
                    {
                        MessageBox.Show("Không tìm thấy file báo cáo: " + reportPath);
                        return;
                    }
                    RptKhachHang.LocalReport.ReportPath = reportPath;
                    

                    ReportDataSource rds = new ReportDataSource("DataSet1", dt); // Đổi "DataSetKhachHang" đúng tên DataSet trong RDLC
                    RptKhachHang.LocalReport.DataSources.Add(rds);

                    RptKhachHang.Dock = DockStyle.Fill;
                    RptKhachHang.ZoomMode = ZoomMode.PageWidth;
                    RptKhachHang.LocalReport.Refresh();


                    RptKhachHang.RefreshReport();
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu để hiển thị.");
                    RptKhachHang.Clear();
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

        private void baocaokh_Load(object sender, EventArgs e)
        {

        }

        private void RptKhachHang_Load(object sender, EventArgs e)
        {

        }
    }
}
