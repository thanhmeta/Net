using System.Windows.Forms;

namespace baitaplon
{
    partial class baocaokh
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.RptKhachHang = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.charttop5KHGB = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.charttop5KHQC = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.btnLoc = new System.Windows.Forms.Button();
            this.cboThoiGian = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charttop5KHGB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charttop5KHQC)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTieuDe.Location = new System.Drawing.Point(475, 20);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(221, 26);
            this.lblTieuDe.TabIndex = 2;
            this.lblTieuDe.Text = "Báo cáo khách hàng";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.RptKhachHang, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(531, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.02902F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(624, 567);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // RptKhachHang
            // 
            this.RptKhachHang.Location = new System.Drawing.Point(3, 3);
            this.RptKhachHang.Name = "RptKhachHang";
            this.RptKhachHang.ServerReport.BearerToken = null;
            this.RptKhachHang.Size = new System.Drawing.Size(615, 561);
            this.RptKhachHang.TabIndex = 0;
            this.RptKhachHang.Load += new System.EventHandler(this.RptKhachHang_Load);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(14, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1155, 601);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn Thời Gian(Báo cáo theo thời gian)";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.charttop5KHGB, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.charttop5KHQC, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 90);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 257F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(528, 496);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // charttop5KHGB
            // 
            chartArea3.Name = "ChartArea1";
            this.charttop5KHGB.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.charttop5KHGB.Legends.Add(legend3);
            this.charttop5KHGB.Location = new System.Drawing.Point(3, 3);
            this.charttop5KHGB.Name = "charttop5KHGB";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.charttop5KHGB.Series.Add(series3);
            this.charttop5KHGB.Size = new System.Drawing.Size(522, 233);
            this.charttop5KHGB.TabIndex = 0;
            this.charttop5KHGB.Text = "chart1";
            // 
            // charttop5KHQC
            // 
            chartArea4.Name = "ChartArea1";
            this.charttop5KHQC.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.charttop5KHQC.Legends.Add(legend4);
            this.charttop5KHQC.Location = new System.Drawing.Point(3, 242);
            this.charttop5KHQC.Name = "charttop5KHQC";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.charttop5KHQC.Series.Add(series4);
            this.charttop5KHQC.Size = new System.Drawing.Size(522, 251);
            this.charttop5KHQC.TabIndex = 1;
            this.charttop5KHQC.Text = "chart2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.dtpDenNgay);
            this.panel1.Controls.Add(this.dtpTuNgay);
            this.panel1.Controls.Add(this.btnLoc);
            this.panel1.Controls.Add(this.cboThoiGian);
            this.panel1.Location = new System.Drawing.Point(0, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 65);
            this.panel1.TabIndex = 1;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Location = new System.Drawing.Point(334, 10);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(145, 20);
            this.dtpDenNgay.TabIndex = 3;
            this.dtpDenNgay.Visible = false;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Location = new System.Drawing.Point(166, 10);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(148, 20);
            this.dtpTuNgay.TabIndex = 2;
            this.dtpTuNgay.Visible = false;
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(6, 36);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(75, 23);
            this.btnLoc.TabIndex = 1;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // cboThoiGian
            // 
            this.cboThoiGian.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThoiGian.FormattingEnabled = true;
            this.cboThoiGian.Items.AddRange(new object[] {
            "Hôm nay",
            "Tuần này",
            "Tháng này",
            "Năm nay",
            "Tùy chọn"});
            this.cboThoiGian.Location = new System.Drawing.Point(6, 9);
            this.cboThoiGian.Name = "cboThoiGian";
            this.cboThoiGian.Size = new System.Drawing.Size(143, 21);
            this.cboThoiGian.TabIndex = 0;
            this.cboThoiGian.SelectedIndexChanged += new System.EventHandler(this.cboThoiGian_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1182, 696);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // baocaokh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "baocaokh";
            this.Size = new System.Drawing.Size(1182, 696);
            this.Load += new System.EventHandler(this.baocaokh_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.charttop5KHGB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charttop5KHQC)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox1;
        private Microsoft.Reporting.WinForms.ReportViewer RptKhachHang;
        private System.Windows.Forms.DataVisualization.Charting.Chart charttop5KHQC;
        private System.Windows.Forms.DataVisualization.Charting.Chart charttop5KHGB;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox cboThoiGian;
        private Button btnLoc;
        private DateTimePicker dtpTuNgay;
        private DateTimePicker dtpDenNgay;
        private Panel panel1;
        private GroupBox groupBox2;
    }
}

   