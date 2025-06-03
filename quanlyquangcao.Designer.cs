// File: quanlyquangcao.Designer.cs
using System;
using System.Drawing;
using System.Windows.Forms;

namespace baitaplon
{
    partial class quanlyquangcao
    {
        private TableLayoutPanel layoutMain, layoutSearch, layoutContent, layoutInputs, layoutButtons;
        private GroupBox groupBoxThongTin;
        private DataGridView dgvQuangCao;
        private Label lblTitle, lblSearch, lblMaLanQC, lblMaKH, lblMaNV, lblMaBao, lblMaQCao, lblNoiDung, lblNgayBD, lblNgayKT, lblTongTien;
        private TextBox txtMaLanQC, txtNoiDung, txtTongTien, txtTimKiem;
        private ComboBox cbbMaKH, cbbMaNV, cbbMaBao, cbbMaQCao;
        private DateTimePicker dtpNgayBD, dtpNgayKT;
        private Button btnThem, btnSua, btnXoa, btnLuu, btnBoQua, btnThoat, btnTimKiem;
        private System.Windows.Forms.Button btnIn;
        private void InitializeComponent()
        {
            this.layoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.layoutSearch = new System.Windows.Forms.TableLayoutPanel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.layoutContent = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxThongTin = new System.Windows.Forms.GroupBox();
            this.layoutInputs = new System.Windows.Forms.TableLayoutPanel();
            this.lblMaLanQC = new System.Windows.Forms.Label();
            this.txtMaLanQC = new System.Windows.Forms.TextBox();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.cbbMaKH = new System.Windows.Forms.ComboBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.cbbMaNV = new System.Windows.Forms.ComboBox();
            this.lblMaBao = new System.Windows.Forms.Label();
            this.cbbMaBao = new System.Windows.Forms.ComboBox();
            this.lblMaQCao = new System.Windows.Forms.Label();
            this.cbbMaQCao = new System.Windows.Forms.ComboBox();
            this.lblNoiDung = new System.Windows.Forms.Label();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.lblNgayBD = new System.Windows.Forms.Label();
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.lblNgayKT = new System.Windows.Forms.Label();
            this.dtpNgayKT = new System.Windows.Forms.DateTimePicker();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.dgvQuangCao = new System.Windows.Forms.DataGridView();
            this.layoutButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.layoutMain.SuspendLayout();
            this.layoutSearch.SuspendLayout();
            this.layoutContent.SuspendLayout();
            this.groupBoxThongTin.SuspendLayout();
            this.layoutInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuangCao)).BeginInit();
            this.layoutButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutMain
            // 
            this.layoutMain.ColumnCount = 1;
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
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
            this.layoutMain.Size = new System.Drawing.Size(1428, 616);
            this.layoutMain.TabIndex = 0;
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
            this.lblTitle.Text = "📊 QUẢN LÝ QUẢNG CÁO";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // layoutSearch
            // 
            this.layoutSearch.ColumnCount = 4;
            this.layoutSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
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
            this.layoutSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutSearch.Size = new System.Drawing.Size(1422, 34);
            this.layoutSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSearch.Location = new System.Drawing.Point(3, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(94, 34);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Tìm kiếm:";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimKiem.Location = new System.Drawing.Point(103, 3);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(1216, 22);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            // layoutContent
            // 
            this.layoutContent.ColumnCount = 2;
            this.layoutContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.layoutContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.layoutContent.Controls.Add(this.groupBoxThongTin, 0, 0);
            this.layoutContent.Controls.Add(this.dgvQuangCao, 1, 0);
            this.layoutContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutContent.Location = new System.Drawing.Point(3, 103);
            this.layoutContent.Name = "layoutContent";
            this.layoutContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutContent.Size = new System.Drawing.Size(1422, 450);
            this.layoutContent.TabIndex = 2;
            // 
            // groupBoxThongTin
            // 
            this.groupBoxThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.groupBoxThongTin.Controls.Add(this.layoutInputs);
            this.groupBoxThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxThongTin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxThongTin.Location = new System.Drawing.Point(3, 3);
            this.groupBoxThongTin.Name = "groupBoxThongTin";
            this.groupBoxThongTin.Size = new System.Drawing.Size(562, 444);
            this.groupBoxThongTin.TabIndex = 0;
            this.groupBoxThongTin.TabStop = false;
            this.groupBoxThongTin.Text = "Nhập Thông Tin";
            // 
            // layoutInputs
            // 
            this.layoutInputs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.layoutInputs.ColumnCount = 2;
            this.layoutInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.layoutInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutInputs.Controls.Add(this.lblMaLanQC, 0, 0);
            this.layoutInputs.Controls.Add(this.txtMaLanQC, 1, 0);
            this.layoutInputs.Controls.Add(this.lblMaKH, 0, 1);
            this.layoutInputs.Controls.Add(this.cbbMaKH, 1, 1);
            this.layoutInputs.Controls.Add(this.lblMaNV, 0, 2);
            this.layoutInputs.Controls.Add(this.cbbMaNV, 1, 2);
            this.layoutInputs.Controls.Add(this.lblMaBao, 0, 3);
            this.layoutInputs.Controls.Add(this.cbbMaBao, 1, 3);
            this.layoutInputs.Controls.Add(this.lblMaQCao, 0, 4);
            this.layoutInputs.Controls.Add(this.cbbMaQCao, 1, 4);
            this.layoutInputs.Controls.Add(this.lblNoiDung, 0, 5);
            this.layoutInputs.Controls.Add(this.txtNoiDung, 1, 5);
            this.layoutInputs.Controls.Add(this.lblNgayBD, 0, 6);
            this.layoutInputs.Controls.Add(this.dtpNgayBD, 1, 6);
            this.layoutInputs.Controls.Add(this.lblNgayKT, 0, 7);
            this.layoutInputs.Controls.Add(this.dtpNgayKT, 1, 7);
            this.layoutInputs.Controls.Add(this.lblTongTien, 0, 8);
            this.layoutInputs.Controls.Add(this.txtTongTien, 1, 8);
            this.layoutInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutInputs.Location = new System.Drawing.Point(3, 30);
            this.layoutInputs.Name = "layoutInputs";
            this.layoutInputs.RowCount = 9;
            this.layoutInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layoutInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layoutInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layoutInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layoutInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layoutInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layoutInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layoutInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layoutInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layoutInputs.Size = new System.Drawing.Size(556, 411);
            this.layoutInputs.TabIndex = 0;
            // 
            // lblMaLanQC
            // 
            this.lblMaLanQC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMaLanQC.Location = new System.Drawing.Point(3, 0);
            this.lblMaLanQC.Name = "lblMaLanQC";
            this.lblMaLanQC.Size = new System.Drawing.Size(100, 23);
            this.lblMaLanQC.TabIndex = 0;
            this.lblMaLanQC.Text = "Mã Lần QC:";
            // 
            // txtMaLanQC
            // 
            this.txtMaLanQC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaLanQC.Location = new System.Drawing.Point(133, 3);
            this.txtMaLanQC.Name = "txtMaLanQC";
            this.txtMaLanQC.Size = new System.Drawing.Size(420, 34);
            this.txtMaLanQC.TabIndex = 1;
            // 
            // lblMaKH
            // 
            this.lblMaKH.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMaKH.Location = new System.Drawing.Point(3, 40);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(100, 23);
            this.lblMaKH.TabIndex = 2;
            this.lblMaKH.Text = "Mã KH:";
            // 
            // cbbMaKH
            // 
            this.cbbMaKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbMaKH.Location = new System.Drawing.Point(133, 43);
            this.cbbMaKH.Name = "cbbMaKH";
            this.cbbMaKH.Size = new System.Drawing.Size(420, 36);
            this.cbbMaKH.TabIndex = 3;
            // 
            // lblMaNV
            // 
            this.lblMaNV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMaNV.Location = new System.Drawing.Point(3, 80);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(100, 23);
            this.lblMaNV.TabIndex = 4;
            this.lblMaNV.Text = "Mã NV:";
            // 
            // cbbMaNV
            // 
            this.cbbMaNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbMaNV.Location = new System.Drawing.Point(133, 83);
            this.cbbMaNV.Name = "cbbMaNV";
            this.cbbMaNV.Size = new System.Drawing.Size(420, 36);
            this.cbbMaNV.TabIndex = 5;
            // 
            // lblMaBao
            // 
            this.lblMaBao.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMaBao.Location = new System.Drawing.Point(3, 120);
            this.lblMaBao.Name = "lblMaBao";
            this.lblMaBao.Size = new System.Drawing.Size(100, 23);
            this.lblMaBao.TabIndex = 6;
            this.lblMaBao.Text = "Mã Báo:";
            // 
            // cbbMaBao
            // 
            this.cbbMaBao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbMaBao.Location = new System.Drawing.Point(133, 123);
            this.cbbMaBao.Name = "cbbMaBao";
            this.cbbMaBao.Size = new System.Drawing.Size(420, 36);
            this.cbbMaBao.TabIndex = 7;
            // 
            // lblMaQCao
            // 
            this.lblMaQCao.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMaQCao.Location = new System.Drawing.Point(3, 160);
            this.lblMaQCao.Name = "lblMaQCao";
            this.lblMaQCao.Size = new System.Drawing.Size(100, 23);
            this.lblMaQCao.TabIndex = 8;
            this.lblMaQCao.Text = "Mã QC:";
            // 
            // cbbMaQCao
            // 
            this.cbbMaQCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbMaQCao.Location = new System.Drawing.Point(133, 163);
            this.cbbMaQCao.Name = "cbbMaQCao";
            this.cbbMaQCao.Size = new System.Drawing.Size(420, 36);
            this.cbbMaQCao.TabIndex = 9;
            // 
            // lblNoiDung
            // 
            this.lblNoiDung.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNoiDung.Location = new System.Drawing.Point(3, 200);
            this.lblNoiDung.Name = "lblNoiDung";
            this.lblNoiDung.Size = new System.Drawing.Size(100, 23);
            this.lblNoiDung.TabIndex = 10;
            this.lblNoiDung.Text = "Nội dung:";
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNoiDung.Location = new System.Drawing.Point(133, 203);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(420, 34);
            this.txtNoiDung.TabIndex = 11;
            // 
            // lblNgayBD
            // 
            this.lblNgayBD.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNgayBD.Location = new System.Drawing.Point(3, 240);
            this.lblNgayBD.Name = "lblNgayBD";
            this.lblNgayBD.Size = new System.Drawing.Size(100, 23);
            this.lblNgayBD.TabIndex = 12;
            this.lblNgayBD.Text = "Ngày BĐ:";
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBD.Location = new System.Drawing.Point(133, 243);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(420, 34);
            this.dtpNgayBD.TabIndex = 13;
            // 
            // lblNgayKT
            // 
            this.lblNgayKT.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNgayKT.Location = new System.Drawing.Point(3, 280);
            this.lblNgayKT.Name = "lblNgayKT";
            this.lblNgayKT.Size = new System.Drawing.Size(100, 23);
            this.lblNgayKT.TabIndex = 14;
            this.lblNgayKT.Text = "Ngày KT:";
            // 
            // dtpNgayKT
            // 
            this.dtpNgayKT.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKT.Location = new System.Drawing.Point(133, 283);
            this.dtpNgayKT.Name = "dtpNgayKT";
            this.dtpNgayKT.Size = new System.Drawing.Size(420, 34);
            this.dtpNgayKT.TabIndex = 15;
            // 
            // lblTongTien
            // 
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTongTien.Location = new System.Drawing.Point(3, 320);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(100, 23);
            this.lblTongTien.TabIndex = 16;
            this.lblTongTien.Text = "Tổng tiền:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTongTien.Location = new System.Drawing.Point(133, 323);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(420, 34);
            this.txtTongTien.TabIndex = 17;
            // 
            // dgvQuangCao
            // 
            this.dgvQuangCao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuangCao.BackgroundColor = System.Drawing.Color.White;
            this.dgvQuangCao.ColumnHeadersHeight = 29;
            this.dgvQuangCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQuangCao.Location = new System.Drawing.Point(571, 3);
            this.dgvQuangCao.Name = "dgvQuangCao";
            this.dgvQuangCao.ReadOnly = true;
            this.dgvQuangCao.RowHeadersWidth = 51;
            this.dgvQuangCao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuangCao.Size = new System.Drawing.Size(848, 444);
            this.dgvQuangCao.TabIndex = 1;
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
            this.layoutButtons.Location = new System.Drawing.Point(3, 559);
            this.layoutButtons.Name = "layoutButtons";
            this.layoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutButtons.Size = new System.Drawing.Size(1422, 54);
            this.layoutButtons.TabIndex = 3;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(3, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(230, 48);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "➕ Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(239, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(230, 48);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "✏️ Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(475, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(230, 48);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "🗑️ Xoá";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLuu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(711, 3);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(230, 48);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "💾 Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnBoQua
            // 
            this.btnBoQua.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBoQua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBoQua.FlatAppearance.BorderSize = 0;
            this.btnBoQua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoQua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBoQua.ForeColor = System.Drawing.Color.White;
            this.btnBoQua.Location = new System.Drawing.Point(947, 3);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(230, 48);
            this.btnBoQua.TabIndex = 4;
            this.btnBoQua.Text = "↩️ Bỏ Qua";
            this.btnBoQua.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(1183, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(236, 48);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "🚪 Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // quanlyquangcao
            // 
            this.Controls.Add(this.layoutMain);
            this.Name = "quanlyquangcao";
            this.Size = new System.Drawing.Size(1428, 616);
            this.layoutMain.ResumeLayout(false);
            this.layoutSearch.ResumeLayout(false);
            this.layoutSearch.PerformLayout();
            this.layoutContent.ResumeLayout(false);
            this.groupBoxThongTin.ResumeLayout(false);
            this.layoutInputs.ResumeLayout(false);
            this.layoutInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuangCao)).EndInit();
            this.layoutButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}