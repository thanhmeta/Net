using System;
using System.Drawing;
using System.Windows.Forms;

namespace baitaplon
{
    partial class phongban
    {
        private TableLayoutPanel layoutMain, layoutContent, layoutInputs, layoutButtons, layoutSearch;
        private GroupBox groupBoxThongTin;
        private DataGridView dgvPhongBan;
        private Label lblTitle, lblSearch, lblMaPhong, lblTenPhong, lblMaBao, lblDienThoai;
        private TextBox txtMaPhong, txtTenPhong, txtDienThoai, txtTimKiem;
        private ComboBox cbbMaBao;
        private Button btnThem, btnSua, btnXoa, btnLuu, btnBoQua, btnThoat, btnTimKiem;

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.lblMaPhong = new System.Windows.Forms.Label();
            this.lblTenPhong = new System.Windows.Forms.Label();
            this.lblMaBao = new System.Windows.Forms.Label();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.cbbMaBao = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvPhongBan = new System.Windows.Forms.DataGridView();
            this.layoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.layoutSearch = new System.Windows.Forms.TableLayoutPanel();
            this.layoutContent = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxThongTin = new System.Windows.Forms.GroupBox();
            this.layoutInputs = new System.Windows.Forms.TableLayoutPanel();
            this.layoutButtons = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).BeginInit();
            this.layoutMain.SuspendLayout();
            this.layoutSearch.SuspendLayout();
            this.layoutContent.SuspendLayout();
            this.groupBoxThongTin.SuspendLayout();
            this.layoutInputs.SuspendLayout();
            this.layoutButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1422, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📁 THÔNG TIN PHÒNG BAN";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSearch.Location = new System.Drawing.Point(3, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(74, 34);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Tìm kiếm:";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTimKiem.Location = new System.Drawing.Point(83, 3);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(1286, 30);
            this.txtTimKiem.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(1375, 3);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(44, 28);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "🔍";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // lblMaPhong
            // 
            this.lblMaPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaPhong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMaPhong.Location = new System.Drawing.Point(3, 0);
            this.lblMaPhong.Name = "lblMaPhong";
            this.lblMaPhong.Size = new System.Drawing.Size(114, 35);
            this.lblMaPhong.TabIndex = 0;
            this.lblMaPhong.Text = "Mã Phòng:";
            this.lblMaPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTenPhong
            // 
            this.lblTenPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTenPhong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTenPhong.Location = new System.Drawing.Point(3, 35);
            this.lblTenPhong.Name = "lblTenPhong";
            this.lblTenPhong.Size = new System.Drawing.Size(114, 35);
            this.lblTenPhong.TabIndex = 2;
            this.lblTenPhong.Text = "Tên Phòng:";
            this.lblTenPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMaBao
            // 
            this.lblMaBao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaBao.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMaBao.Location = new System.Drawing.Point(3, 70);
            this.lblMaBao.Name = "lblMaBao";
            this.lblMaBao.Size = new System.Drawing.Size(114, 35);
            this.lblMaBao.TabIndex = 4;
            this.lblMaBao.Text = "Mã Báo:";
            this.lblMaBao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDienThoai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDienThoai.Location = new System.Drawing.Point(3, 105);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(114, 35);
            this.lblDienThoai.TabIndex = 6;
            this.lblDienThoai.Text = "Điện Thoại:";
            this.lblDienThoai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaPhong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaPhong.Location = new System.Drawing.Point(120, 5);
            this.txtMaPhong.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(351, 30);
            this.txtMaPhong.TabIndex = 1;
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenPhong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTenPhong.Location = new System.Drawing.Point(120, 40);
            this.txtTenPhong.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(351, 30);
            this.txtTenPhong.TabIndex = 3;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDienThoai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDienThoai.Location = new System.Drawing.Point(120, 110);
            this.txtDienThoai.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(351, 30);
            this.txtDienThoai.TabIndex = 7;
            // 
            // cbbMaBao
            // 
            this.cbbMaBao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbMaBao.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbMaBao.Location = new System.Drawing.Point(120, 75);
            this.cbbMaBao.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.cbbMaBao.Name = "cbbMaBao";
            this.cbbMaBao.Size = new System.Drawing.Size(351, 31);
            this.cbbMaBao.TabIndex = 5;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(3, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(230, 48);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "➕ Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(239, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(230, 48);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "✏️ Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(475, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(230, 48);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "🗑️ Xoá";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLuu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(711, 3);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(230, 48);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "💾 Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBoQua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBoQua.FlatAppearance.BorderSize = 0;
            this.btnBoQua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoQua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBoQua.ForeColor = System.Drawing.Color.White;
            this.btnBoQua.Location = new System.Drawing.Point(947, 3);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(230, 48);
            this.btnBoQua.TabIndex = 4;
            this.btnBoQua.Text = "↩️ Bỏ Qua";
            this.btnBoQua.UseVisualStyleBackColor = false;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(1183, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(236, 48);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "🚪 Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvPhongBan
            // 
            this.dgvPhongBan.AllowUserToAddRows = false;
            this.dgvPhongBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhongBan.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhongBan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhongBan.ColumnHeadersHeight = 29;
            this.dgvPhongBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhongBan.EnableHeadersVisualStyles = false;
            this.dgvPhongBan.Location = new System.Drawing.Point(500, 3);
            this.dgvPhongBan.Name = "dgvPhongBan";
            this.dgvPhongBan.ReadOnly = true;
            this.dgvPhongBan.RowHeadersWidth = 51;
            this.dgvPhongBan.RowTemplate.Height = 30;
            this.dgvPhongBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhongBan.Size = new System.Drawing.Size(919, 410);
            this.dgvPhongBan.TabIndex = 1;
            this.dgvPhongBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhongBan_CellClick);
            this.dgvPhongBan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhongBan_CellContentClick);
            this.dgvPhongBan.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvPhongBan_RowPostPaint);
            // 
            // layoutMain
            // 
            this.layoutMain.ColumnCount = 1;
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutMain.Controls.Add(this.lblTitle, 0, 0);
            this.layoutMain.Controls.Add(this.layoutSearch, 0, 1);
            this.layoutMain.Controls.Add(this.layoutContent, 0, 2);
            this.layoutMain.Controls.Add(this.layoutButtons, 0, 3);
            this.layoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutMain.Location = new System.Drawing.Point(0, 0);
            this.layoutMain.Name = "layoutMain";
            this.layoutMain.RowCount = 4;
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.layoutMain.Size = new System.Drawing.Size(1428, 582);
            this.layoutMain.TabIndex = 0;
            // 
            // layoutSearch
            // 
            this.layoutSearch.ColumnCount = 3;
            this.layoutSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.layoutSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.layoutSearch.Controls.Add(this.lblSearch, 0, 0);
            this.layoutSearch.Controls.Add(this.txtTimKiem, 1, 0);
            this.layoutSearch.Controls.Add(this.btnTimKiem, 2, 0);
            this.layoutSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutSearch.Location = new System.Drawing.Point(3, 63);
            this.layoutSearch.Name = "layoutSearch";
            this.layoutSearch.RowCount = 1;
            this.layoutSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutSearch.Size = new System.Drawing.Size(1422, 34);
            this.layoutSearch.TabIndex = 1;
            // 
            // layoutContent
            // 
            this.layoutContent.ColumnCount = 2;
            this.layoutContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.layoutContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.layoutContent.Controls.Add(this.groupBoxThongTin, 0, 0);
            this.layoutContent.Controls.Add(this.dgvPhongBan, 1, 0);
            this.layoutContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutContent.Location = new System.Drawing.Point(3, 103);
            this.layoutContent.Name = "layoutContent";
            this.layoutContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutContent.Size = new System.Drawing.Size(1422, 416);
            this.layoutContent.TabIndex = 2;
            // 
            // groupBoxThongTin
            // 
            this.groupBoxThongTin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBoxThongTin.Controls.Add(this.layoutInputs);
            this.groupBoxThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxThongTin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxThongTin.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBoxThongTin.Location = new System.Drawing.Point(3, 3);
            this.groupBoxThongTin.Name = "groupBoxThongTin";
            this.groupBoxThongTin.Padding = new System.Windows.Forms.Padding(10);
            this.groupBoxThongTin.Size = new System.Drawing.Size(491, 410);
            this.groupBoxThongTin.TabIndex = 0;
            this.groupBoxThongTin.TabStop = false;
            this.groupBoxThongTin.Text = "Nhập Thông Tin";
            // 
            // layoutInputs
            // 
            this.layoutInputs.AutoSize = true;
            this.layoutInputs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.layoutInputs.ColumnCount = 2;
            this.layoutInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.layoutInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutInputs.Controls.Add(this.lblMaPhong, 0, 0);
            this.layoutInputs.Controls.Add(this.txtMaPhong, 1, 0);
            this.layoutInputs.Controls.Add(this.lblTenPhong, 0, 1);
            this.layoutInputs.Controls.Add(this.txtTenPhong, 1, 1);
            this.layoutInputs.Controls.Add(this.lblMaBao, 0, 2);
            this.layoutInputs.Controls.Add(this.cbbMaBao, 1, 2);
            this.layoutInputs.Controls.Add(this.lblDienThoai, 0, 3);
            this.layoutInputs.Controls.Add(this.txtDienThoai, 1, 3);
            this.layoutInputs.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutInputs.Location = new System.Drawing.Point(10, 37);
            this.layoutInputs.Name = "layoutInputs";
            this.layoutInputs.RowCount = 4;
            this.layoutInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.layoutInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.layoutInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.layoutInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.layoutInputs.Size = new System.Drawing.Size(471, 140);
            this.layoutInputs.TabIndex = 0;
            // 
            // layoutButtons
            // 
            this.layoutButtons.ColumnCount = 6;
            this.layoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66F));
            this.layoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66F));
            this.layoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66F));
            this.layoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66F));
            this.layoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66F));
            this.layoutButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66F));
            this.layoutButtons.Controls.Add(this.btnThem, 0, 0);
            this.layoutButtons.Controls.Add(this.btnSua, 1, 0);
            this.layoutButtons.Controls.Add(this.btnXoa, 2, 0);
            this.layoutButtons.Controls.Add(this.btnLuu, 3, 0);
            this.layoutButtons.Controls.Add(this.btnBoQua, 4, 0);
            this.layoutButtons.Controls.Add(this.btnThoat, 5, 0);
            this.layoutButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutButtons.Location = new System.Drawing.Point(3, 525);
            this.layoutButtons.Name = "layoutButtons";
            this.layoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutButtons.Size = new System.Drawing.Size(1422, 54);
            this.layoutButtons.TabIndex = 3;
            // 
            // phongban
            // 
            this.Controls.Add(this.layoutMain);
            this.Name = "phongban";
            this.Size = new System.Drawing.Size(1428, 582);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).EndInit();
            this.layoutMain.ResumeLayout(false);
            this.layoutSearch.ResumeLayout(false);
            this.layoutSearch.PerformLayout();
            this.layoutContent.ResumeLayout(false);
            this.groupBoxThongTin.ResumeLayout(false);
            this.groupBoxThongTin.PerformLayout();
            this.layoutInputs.ResumeLayout(false);
            this.layoutInputs.PerformLayout();
            this.layoutButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}

