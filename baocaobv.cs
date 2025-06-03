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
    public partial class baocaobv : UserControl
    {
        public baocaobv()
        {
            InitializeComponent();
        }

        private void baocaobv_Load(object sender, EventArgs e)
        {

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
            LoadBaoCaoTongHop();
            LoadTop5Bao();
            LoadTop5TheLoai();
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
        private void LoadBaoCaoTongHop()
        {
            try
            {
                ketnoi.Connect();

                var (tuNgay, denNgay) = GetDateRange();

                // Dataset 1: DS
                SqlCommand cmd1 = new SqlCommand("sp_DanhSachKhachGuiBai_TheoThoiGian", ketnoi.con);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@TuNgay", tuNgay);
                cmd1.Parameters.AddWithValue("@DenNgay", denNgay);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);

                // Dataset 2: Thống kê theo Báo
                SqlCommand cmd2 = new SqlCommand("sp_ThongKeGuiBai_TheoBao", ketnoi.con);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@TuNgay", tuNgay);
                cmd2.Parameters.AddWithValue("@DenNgay", denNgay);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);

                // Dataset 3: thong ke theo the loai
                SqlCommand cmd3 = new SqlCommand("sp_ThongKeGuiBai_TheoTheLoai", ketnoi.con);
                cmd3.CommandType = CommandType.StoredProcedure;
                cmd3.Parameters.AddWithValue("@TuNgay", tuNgay);
                cmd3.Parameters.AddWithValue("@DenNgay", denNgay);
                SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
                DataTable dt3 = new DataTable();
                da3.Fill(dt3);
                if (dt1.Rows.Count > 0)
                {
                    // Kiểm tra và đổ dữ liệu vào ReportViewer
                    rptBaiViet.Reset();
                rptBaiViet.LocalReport.DataSources.Clear();

                string reportPath = Path.Combine(Application.StartupPath, "RptBaiViet.rdlc");
                rptBaiViet.LocalReport.ReportPath = reportPath;

                rptBaiViet.LocalReport.DataSources.Add(new ReportDataSource("DataSetDSKGB", dt1));
                rptBaiViet.LocalReport.DataSources.Add(new ReportDataSource("DataSetBaitheoTL", dt3));
                rptBaiViet.LocalReport.DataSources.Add(new ReportDataSource("DataSetBaiTheobao", dt2));

                rptBaiViet.Dock = DockStyle.Fill;
                rptBaiViet.ZoomMode = ZoomMode.PageWidth;

                rptBaiViet.RefreshReport();
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu để hiển thị.");
                    rptBaiViet.Clear();
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
        private void LoadTop5Bao()
        {
            // XÓA DỮ LIỆU CŨ
            charttop5Bao.Series.Clear();
            charttop5Bao.Titles.Clear();
            charttop5Bao.Legends.Clear();

            // Tạo series mới, kiểu cột
            var series = new System.Windows.Forms.DataVisualization.Charting.Series("TopBao")
            {
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
            };
            charttop5Bao.Series.Add(series);

            // Thêm tiêu đề biểu đồ
            charttop5Bao.Titles.Add("Top 5 báo được gửi bài nhiều nhất");

            ketnoi.Connect();

            string dieuKienThoiGian = GetDateCondition("kgb.NgayDang"); // nếu có lọc theo thời gian

            string query = $@"
SELECT TOP 5 b.TenBao, COUNT(*) AS SoLuongBai
FROM KhachGuiBai kgb
JOIN Bao b ON kgb.MaBao = b.MaBao
WHERE {dieuKienThoiGian}
GROUP BY b.TenBao
ORDER BY SoLuongBai DESC";

            SqlCommand cmd = new SqlCommand(query, ketnoi.con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string tenBao = reader["TenBao"].ToString();
                int soLuong = Convert.ToInt32(reader["SoLuongBai"]);
                charttop5Bao.Series[0].Points.AddXY(tenBao, soLuong);
            }

            reader.Close();
            ketnoi.Close();

            // Thiết lập trục Y
            charttop5Bao.ChartAreas[0].AxisY.Interval = 1;
            charttop5Bao.ChartAreas[0].AxisY.Minimum = 0;
            charttop5Bao.ChartAreas[0].AxisY.LabelStyle.Format = "0";

            // Ẩn chú giải nếu không cần
            charttop5Bao.Series["TopBao"].IsVisibleInLegend = false;

            // Ẩn đường lưới
            charttop5Bao.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            charttop5Bao.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        }
        private void LoadTop5TheLoai()
        {
            // XÓA DỮ LIỆU CŨ
            charttop5TheLoai.Series.Clear();
            charttop5TheLoai.Titles.Clear();
            charttop5TheLoai.Legends.Clear();

            // Tạo series mới, kiểu cột
            var series = new System.Windows.Forms.DataVisualization.Charting.Series("TopTheLoai")
            {
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
            };
            charttop5TheLoai.Series.Add(series);

            // Thêm tiêu đề biểu đồ
            charttop5TheLoai.Titles.Add("Top 5 thể loại được gửi bài nhiều nhất");

            ketnoi.Connect();

            string dieuKienThoiGian = GetDateCondition("kgb.NgayDang"); // dùng điều kiện thời gian nếu có

            string query = $@"
SELECT TOP 5 tl.TenTheLoai, COUNT(*) AS SoLuongBai
FROM KhachGuiBai kgb
JOIN TheLoai tl ON kgb.MaTheLoai = tl.MaTheLoai
WHERE {dieuKienThoiGian}
GROUP BY tl.TenTheLoai
ORDER BY SoLuongBai DESC";

            SqlCommand cmd = new SqlCommand(query, ketnoi.con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string tenTheLoai = reader["TenTheLoai"].ToString();
                int soLuong = Convert.ToInt32(reader["SoLuongBai"]);
                charttop5TheLoai.Series[0].Points.AddXY(tenTheLoai, soLuong);
            }

            reader.Close();
            ketnoi.Close();

            // Thiết lập trục Y
            charttop5TheLoai.ChartAreas[0].AxisY.Interval = 1;
            charttop5TheLoai.ChartAreas[0].AxisY.Minimum = 0;
            charttop5TheLoai.ChartAreas[0].AxisY.LabelStyle.Format = "0";

            // Ẩn chú giải
            charttop5TheLoai.Series["TopTheLoai"].IsVisibleInLegend = false;

            // Ẩn đường lưới
            charttop5TheLoai.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            charttop5TheLoai.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        }

        private void lblTieuDe_Click(object sender, EventArgs e)
        {

        }
    }
}
