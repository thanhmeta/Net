
using System;
using System.Drawing;
using System.Windows.Forms;

namespace baitaplon
{
    partial class quanlybaiviet
    {
        private TableLayoutPanel layoutMain, layoutContent, layoutInputs, layoutButtons, layoutSearch;
        private GroupBox groupBoxThongTin;
        private DataGridView dgvBaiViet;
        private Label lblTitle, lblSearch;
        private Label lblMaLanGui, lblMaKH, lblMaTheLoai, lblMaBao, lblTieuDe, lblNoiDung, lblMaNV, lblNgayDang, lblNhuanBut;
        private TextBox txtMaLanGui, txtTieuDe, txtNoiDung, txtNhuanBut, txtTimKiem;
        private ComboBox cbbMaKH, cbbMaTheLoai, cbbMaBao, cbbMaNV;
        private Button btnThem, btnSua, btnXoa, btnLuu, btnBoQua, btnThoat, btnTimKiem;
        private DateTimePicker dtpNgayDang;
        private System.Windows.Forms.Button btnIn;
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.layoutSearch = new System.Windows.Forms.TableLayoutPanel();
            this.txtMaLanGui = new System.Windows.Forms.TextBox();
            this.txtTieuDe = new System.Windows.Forms.TextBox();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.txtNhuanBut = new System.Windows.Forms.TextBox();
            this.dtpNgayDang = new System.Windows.Forms.DateTimePicker();
            this.cbbMaKH = new System.Windows.Forms.ComboBox();
            this.cbbMaTheLoai = new System.Windows.Forms.ComboBox();
            this.cbbMaBao = new System.Windows.Forms.ComboBox();
            this.cbbMaNV = new System.Windows.Forms.ComboBox();
            this.lblMaLanGui = new System.Windows.Forms.Label();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.lblMaTheLoai = new System.Windows.Forms.Label();
            this.lblMaBao = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblNoiDung = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblNgayDang = new System.Windows.Forms.Label();
            this.lblNhuanBut = new System.Windows.Forms.Label();
            this.layoutInputs = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxThongTin = new System.Windows.Forms.GroupBox();
            this.dgvBaiViet = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.layoutButtons = new System.Windows.Forms.TableLayoutPanel();
            this.layoutContent = new System.Windows.Forms.TableLayoutPanel();
            this.layoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.layoutSearch.SuspendLayout();
            this.layoutInputs.SuspendLayout();
            this.groupBoxThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaiViet)).BeginInit();
            this.layoutButtons.SuspendLayout();
            this.layoutContent.SuspendLayout();
            this.layoutMain.SuspendLayout();
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
            this.lblTitle.Text = "📄 QUẢN LÝ BÀI VIẾT";
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
            this.txtTimKiem.Size = new System.Drawing.Size(1236, 30);
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
            this.btnTimKiem.Location = new System.Drawing.Point(1325, 3);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(44, 28);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "🔍";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.IndianRed;
            this.btnIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIn.Location = new System.Drawing.Point(1375, 3);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(44, 28);
            this.btnIn.TabIndex = 3;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = false;
            // 
            // layoutSearch
            // 
            this.layoutSearch.ColumnCount = 4;
            this.layoutSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.layoutSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.layoutSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.layoutSearch.Controls.Add(this.lblSearch, 0, 0);
            this.layoutSearch.Controls.Add(this.txtTimKiem, 1, 0);
            this.layoutSearch.Controls.Add(this.btnTimKiem, 2, 0);
            this.layoutSearch.Controls.Add(this.btnIn, 3, 0);
            this.layoutSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutSearch.Location = new System.Drawing.Point(3, 63);
            this.layoutSearch.Name = "layoutSearch";
            this.layoutSearch.RowCount = 1;
            this.layoutSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutSearch.Size = new System.Drawing.Size(1422, 34);
            this.layoutSearch.TabIndex = 1;
            // 
            // txtMaLanGui
            // 
            this.txtMaLanGui.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaLanGui.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaLanGui.Location = new System.Drawing.Point(123, 3);
            this.txtMaLanGui.Name = "txtMaLanGui";
            this.txtMaLanGui.Size = new System.Drawing.Size(345, 30);
            this.txtMaLanGui.TabIndex = 1;
            // 
            // txtTieuDe
            // 
            this.txtTieuDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTieuDe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTieuDe.Location = new System.Drawing.Point(123, 143);
            this.txtTieuDe.Name = "txtTieuDe";
            this.txtTieuDe.Size = new System.Drawing.Size(345, 30);
            this.txtTieuDe.TabIndex = 9;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNoiDung.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNoiDung.Location = new System.Drawing.Point(123, 178);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(345, 30);
            this.txtNoiDung.TabIndex = 11;
            // 
            // txtNhuanBut
            // 
            this.txtNhuanBut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNhuanBut.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNhuanBut.Location = new System.Drawing.Point(123, 283);
            this.txtNhuanBut.Name = "txtNhuanBut";
            this.txtNhuanBut.ReadOnly = true;
            this.txtNhuanBut.Size = new System.Drawing.Size(345, 30);
            this.txtNhuanBut.TabIndex = 17;
            // 
            // dtpNgayDang
            // 
            this.dtpNgayDang.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayDang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpNgayDang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpNgayDang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDang.Location = new System.Drawing.Point(123, 248);
            this.dtpNgayDang.Name = "dtpNgayDang";
            this.dtpNgayDang.Size = new System.Drawing.Size(345, 30);
            this.dtpNgayDang.TabIndex = 15;
            // 
            // cbbMaKH
            // 
            this.cbbMaKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbMaKH.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbMaKH.Location = new System.Drawing.Point(123, 38);
            this.cbbMaKH.Name = "cbbMaKH";
            this.cbbMaKH.Size = new System.Drawing.Size(345, 31);
            this.cbbMaKH.TabIndex = 3;
            // 
            // cbbMaTheLoai
            // 
            this.cbbMaTheLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbMaTheLoai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbMaTheLoai.Location = new System.Drawing.Point(123, 73);
            this.cbbMaTheLoai.Name = "cbbMaTheLoai";
            this.cbbMaTheLoai.Size = new System.Drawing.Size(345, 31);
            this.cbbMaTheLoai.TabIndex = 5;
            // 
            // cbbMaBao
            // 
            this.cbbMaBao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbMaBao.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbMaBao.Location = new System.Drawing.Point(123, 108);
            this.cbbMaBao.Name = "cbbMaBao";
            this.cbbMaBao.Size = new System.Drawing.Size(345, 31);
            this.cbbMaBao.TabIndex = 7;
            // 
            // cbbMaNV
            // 
            this.cbbMaNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbMaNV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbMaNV.Location = new System.Drawing.Point(123, 213);
            this.cbbMaNV.Name = "cbbMaNV";
            this.cbbMaNV.Size = new System.Drawing.Size(345, 31);
            this.cbbMaNV.TabIndex = 13;
            // 
            // lblMaLanGui
            // 
            this.lblMaLanGui.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaLanGui.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMaLanGui.Location = new System.Drawing.Point(3, 0);
            this.lblMaLanGui.Name = "lblMaLanGui";
            this.lblMaLanGui.Size = new System.Drawing.Size(114, 35);
            this.lblMaLanGui.TabIndex = 0;
            this.lblMaLanGui.Text = "Mã Lần Gửi:";
            this.lblMaLanGui.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMaKH
            // 
            this.lblMaKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaKH.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMaKH.Location = new System.Drawing.Point(3, 35);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(114, 35);
            this.lblMaKH.TabIndex = 2;
            this.lblMaKH.Text = "Mã KH:";
            this.lblMaKH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMaTheLoai
            // 
            this.lblMaTheLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaTheLoai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMaTheLoai.Location = new System.Drawing.Point(3, 70);
            this.lblMaTheLoai.Name = "lblMaTheLoai";
            this.lblMaTheLoai.Size = new System.Drawing.Size(114, 35);
            this.lblMaTheLoai.TabIndex = 4;
            this.lblMaTheLoai.Text = "Mã Thể Loại:";
            this.lblMaTheLoai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMaBao
            // 
            this.lblMaBao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaBao.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMaBao.Location = new System.Drawing.Point(3, 105);
            this.lblMaBao.Name = "lblMaBao";
            this.lblMaBao.Size = new System.Drawing.Size(114, 35);
            this.lblMaBao.TabIndex = 6;
            this.lblMaBao.Text = "Mã Báo:";
            this.lblMaBao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTieuDe.Location = new System.Drawing.Point(3, 140);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(114, 35);
            this.lblTieuDe.TabIndex = 8;
            this.lblTieuDe.Text = "Tiêu Đề:";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNoiDung
            // 
            this.lblNoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNoiDung.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNoiDung.Location = new System.Drawing.Point(3, 175);
            this.lblNoiDung.Name = "lblNoiDung";
            this.lblNoiDung.Size = new System.Drawing.Size(114, 35);
            this.lblNoiDung.TabIndex = 10;
            this.lblNoiDung.Text = "Nội Dung:";
            this.lblNoiDung.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMaNV
            // 
            this.lblMaNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaNV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMaNV.Location = new System.Drawing.Point(3, 210);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(114, 35);
            this.lblMaNV.TabIndex = 12;
            this.lblMaNV.Text = "Mã NV:";
            this.lblMaNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNgayDang
            // 
            this.lblNgayDang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNgayDang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNgayDang.Location = new System.Drawing.Point(3, 245);
            this.lblNgayDang.Name = "lblNgayDang";
            this.lblNgayDang.Size = new System.Drawing.Size(114, 35);
            this.lblNgayDang.TabIndex = 14;
            this.lblNgayDang.Text = "Ngày Đăng:";
            this.lblNgayDang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNhuanBut
            // 
            this.lblNhuanBut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNhuanBut.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNhuanBut.Location = new System.Drawing.Point(3, 280);
            this.lblNhuanBut.Name = "lblNhuanBut";
            this.lblNhuanBut.Size = new System.Drawing.Size(114, 35);
            this.lblNhuanBut.TabIndex = 16;
            this.lblNhuanBut.Text = "Nhuận Bút:";
            this.lblNhuanBut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // layoutInputs
            // 
            this.layoutInputs.AutoSize = true;
            this.layoutInputs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.layoutInputs.ColumnCount = 2;
            this.layoutInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.layoutInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutInputs.Controls.Add(this.lblMaLanGui, 0, 0);
            this.layoutInputs.Controls.Add(this.txtMaLanGui, 1, 0);
            this.layoutInputs.Controls.Add(this.lblMaKH, 0, 1);
            this.layoutInputs.Controls.Add(this.cbbMaKH, 1, 1);
            this.layoutInputs.Controls.Add(this.lblMaTheLoai, 0, 2);
            this.layoutInputs.Controls.Add(this.cbbMaTheLoai, 1, 2);
            this.layoutInputs.Controls.Add(this.lblMaBao, 0, 3);
            this.layoutInputs.Controls.Add(this.cbbMaBao, 1, 3);
            this.layoutInputs.Controls.Add(this.lblTieuDe, 0, 4);
            this.layoutInputs.Controls.Add(this.txtTieuDe, 1, 4);
            this.layoutInputs.Controls.Add(this.lblNoiDung, 0, 5);
            this.layoutInputs.Controls.Add(this.txtNoiDung, 1, 5);
            this.layoutInputs.Controls.Add(this.lblMaNV, 0, 6);
            this.layoutInputs.Controls.Add(this.cbbMaNV, 1, 6);
            this.layoutInputs.Controls.Add(this.lblNgayDang, 0, 7);
            this.layoutInputs.Controls.Add(this.dtpNgayDang, 1, 7);
            this.layoutInputs.Controls.Add(this.lblNhuanBut, 0, 8);
            this.layoutInputs.Controls.Add(this.txtNhuanBut, 1, 8);
            this.layoutInputs.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutInputs.Location = new System.Drawing.Point(10, 37);
            this.layoutInputs.Name = "layoutInputs";
            this.layoutInputs.RowCount = 9;
            this.layoutInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.layoutInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.layoutInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.layoutInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.layoutInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.layoutInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.layoutInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.layoutInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.layoutInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.layoutInputs.Size = new System.Drawing.Size(471, 315);
            this.layoutInputs.TabIndex = 0;
            // 
            // groupBoxThongTin
            // 
            this.groupBoxThongTin.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBoxThongTin.Controls.Add(this.layoutInputs);
            this.groupBoxThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxThongTin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxThongTin.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBoxThongTin.Location = new System.Drawing.Point(3, 3);
            this.groupBoxThongTin.Name = "groupBoxThongTin";
            this.groupBoxThongTin.Padding = new System.Windows.Forms.Padding(10);
            this.groupBoxThongTin.Size = new System.Drawing.Size(491, 332);
            this.groupBoxThongTin.TabIndex = 0;
            this.groupBoxThongTin.TabStop = false;
            this.groupBoxThongTin.Text = "Thông Tin";
            // 
            // dgvBaiViet
            // 
            this.dgvBaiViet.AllowUserToAddRows = false;
            this.dgvBaiViet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBaiViet.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBaiViet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBaiViet.ColumnHeadersHeight = 29;
            this.dgvBaiViet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBaiViet.EnableHeadersVisualStyles = false;
            this.dgvBaiViet.Location = new System.Drawing.Point(500, 3);
            this.dgvBaiViet.Name = "dgvBaiViet";
            this.dgvBaiViet.ReadOnly = true;
            this.dgvBaiViet.RowHeadersWidth = 51;
            this.dgvBaiViet.RowTemplate.Height = 30;
            this.dgvBaiViet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBaiViet.Size = new System.Drawing.Size(919, 332);
            this.dgvBaiViet.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(3, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(230, 48);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "   ➕ Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(239, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(230, 48);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "   🖊️ Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(475, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(230, 48);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "   🗑️ Xoá";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLuu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(711, 3);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(230, 48);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "   💾 Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnBoQua
            // 
            this.btnBoQua.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBoQua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBoQua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoQua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBoQua.ForeColor = System.Drawing.Color.White;
            this.btnBoQua.Location = new System.Drawing.Point(947, 3);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(230, 48);
            this.btnBoQua.TabIndex = 4;
            this.btnBoQua.Text = "   ↩️ Bỏ Qua";
            this.btnBoQua.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(1183, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(236, 48);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "   📋 Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
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
            this.layoutButtons.Location = new System.Drawing.Point(3, 447);
            this.layoutButtons.Name = "layoutButtons";
            this.layoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutButtons.Size = new System.Drawing.Size(1422, 54);
            this.layoutButtons.TabIndex = 3;
            // 
            // layoutContent
            // 
            this.layoutContent.ColumnCount = 2;
            this.layoutContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.layoutContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.layoutContent.Controls.Add(this.groupBoxThongTin, 0, 0);
            this.layoutContent.Controls.Add(this.dgvBaiViet, 1, 0);
            this.layoutContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutContent.Location = new System.Drawing.Point(3, 103);
            this.layoutContent.Name = "layoutContent";
            this.layoutContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutContent.Size = new System.Drawing.Size(1422, 338);
            this.layoutContent.TabIndex = 2;
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
            this.layoutMain.Size = new System.Drawing.Size(1428, 504);
            this.layoutMain.TabIndex = 0;
            // 
            // quanlybaiviet
            // 
            this.Controls.Add(this.layoutMain);
            this.Name = "quanlybaiviet";
            this.Size = new System.Drawing.Size(1428, 504);
            this.layoutSearch.ResumeLayout(false);
            this.layoutSearch.PerformLayout();
            this.layoutInputs.ResumeLayout(false);
            this.layoutInputs.PerformLayout();
            this.groupBoxThongTin.ResumeLayout(false);
            this.groupBoxThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaiViet)).EndInit();
            this.layoutButtons.ResumeLayout(false);
            this.layoutContent.ResumeLayout(false);
            this.layoutMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        private void AddInput(string labelText, Control control, int row)
        {
            var label = new Label
            {
                Text = labelText,
                Font = new Font("Segoe UI", 10),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft
            };
            control.Font = new Font("Segoe UI", 10);
            control.Dock = DockStyle.Fill;

            this.layoutInputs.RowStyles.Add(new RowStyle(SizeType.Absolute, 35));
            this.layoutInputs.Controls.Add(label, 0, row);
            this.layoutInputs.Controls.Add(control, 1, row);
        }
    }
}
