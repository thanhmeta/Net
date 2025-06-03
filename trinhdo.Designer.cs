using System;
using System.Drawing;
using System.Windows.Forms;

namespace baitaplon
{
    partial class trinhdo
    {
        private TableLayoutPanel layoutMain, layoutSearch, layoutContent, layoutInputs, layoutButtons;
        private Label lblTitle, lblSearch, lblMaTD, lblTenTD;
        private TextBox txtMaTD, txtTenTD, txtTimKiem;
        private Button btnThem, btnSua, btnXoa, btnLuu, btnBoQua, btnThoat, btnTimKiem;
        private DataGridView dgvTrinhDo;
        private GroupBox groupBoxThongTin;

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.layoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.layoutSearch = new System.Windows.Forms.TableLayoutPanel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.layoutContent = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxThongTin = new System.Windows.Forms.GroupBox();
            this.layoutInputs = new System.Windows.Forms.TableLayoutPanel();
            this.lblMaTD = new System.Windows.Forms.Label();
            this.txtMaTD = new System.Windows.Forms.TextBox();
            this.lblTenTD = new System.Windows.Forms.Label();
            this.txtTenTD = new System.Windows.Forms.TextBox();
            this.dgvTrinhDo = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrinhDo)).BeginInit();
            this.layoutButtons.SuspendLayout();
            this.SuspendLayout();
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
            this.layoutMain.Size = new System.Drawing.Size(1000, 700);
            this.layoutMain.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(994, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📘 THÔNG TIN TRÌNH ĐỘ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
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
            this.layoutSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutSearch.Size = new System.Drawing.Size(994, 34);
            this.layoutSearch.TabIndex = 1;
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
            this.txtTimKiem.Size = new System.Drawing.Size(858, 30);
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
            this.btnTimKiem.Location = new System.Drawing.Point(947, 3);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(44, 28);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "🔍";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // layoutContent
            // 
            this.layoutContent.ColumnCount = 2;
            this.layoutContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.layoutContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.layoutContent.Controls.Add(this.groupBoxThongTin, 0, 0);
            this.layoutContent.Controls.Add(this.dgvTrinhDo, 1, 0);
            this.layoutContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutContent.Location = new System.Drawing.Point(3, 103);
            this.layoutContent.Name = "layoutContent";
            this.layoutContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutContent.Size = new System.Drawing.Size(994, 534);
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
            this.groupBoxThongTin.Size = new System.Drawing.Size(391, 528);
            this.groupBoxThongTin.TabIndex = 0;
            this.groupBoxThongTin.TabStop = false;
            this.groupBoxThongTin.Text = "Nhập thông tin";
            // 
            // layoutInputs
            // 
            this.layoutInputs.ColumnCount = 2;
            this.layoutInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.layoutInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutInputs.Controls.Add(this.lblMaTD, 0, 0);
            this.layoutInputs.Controls.Add(this.txtMaTD, 1, 0);
            this.layoutInputs.Controls.Add(this.lblTenTD, 0, 1);
            this.layoutInputs.Controls.Add(this.txtTenTD, 1, 1);
            this.layoutInputs.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutInputs.Location = new System.Drawing.Point(3, 30);
            this.layoutInputs.Name = "layoutInputs";
            this.layoutInputs.RowCount = 2;
            this.layoutInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.layoutInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.layoutInputs.Size = new System.Drawing.Size(385, 100);
            this.layoutInputs.TabIndex = 0;
            // 
            // lblMaTD
            // 
            this.lblMaTD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaTD.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMaTD.Location = new System.Drawing.Point(3, 0);
            this.lblMaTD.Name = "lblMaTD";
            this.lblMaTD.Size = new System.Drawing.Size(114, 45);
            this.lblMaTD.TabIndex = 0;
            this.lblMaTD.Text = "Mã Trình Độ:";
            this.lblMaTD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMaTD
            // 
            this.txtMaTD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaTD.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaTD.Location = new System.Drawing.Point(120, 8);
            this.txtMaTD.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.txtMaTD.Name = "txtMaTD";
            this.txtMaTD.Size = new System.Drawing.Size(265, 30);
            this.txtMaTD.TabIndex = 1;
            // 
            // lblTenTD
            // 
            this.lblTenTD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTenTD.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTenTD.Location = new System.Drawing.Point(3, 45);
            this.lblTenTD.Name = "lblTenTD";
            this.lblTenTD.Size = new System.Drawing.Size(114, 55);
            this.lblTenTD.TabIndex = 2;
            this.lblTenTD.Text = "Tên Trình Độ:";
            this.lblTenTD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTenTD
            // 
            this.txtTenTD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenTD.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTenTD.Location = new System.Drawing.Point(120, 53);
            this.txtTenTD.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.txtTenTD.Name = "txtTenTD";
            this.txtTenTD.Size = new System.Drawing.Size(265, 30);
            this.txtTenTD.TabIndex = 3;
            // 
            // dgvTrinhDo
            // 
            this.dgvTrinhDo.AllowUserToAddRows = false;
            this.dgvTrinhDo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTrinhDo.BackgroundColor = System.Drawing.Color.White;
            this.dgvTrinhDo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTrinhDo.ColumnHeadersHeight = 29;
            this.dgvTrinhDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTrinhDo.EnableHeadersVisualStyles = false;
            this.dgvTrinhDo.Location = new System.Drawing.Point(400, 3);
            this.dgvTrinhDo.Name = "dgvTrinhDo";
            this.dgvTrinhDo.ReadOnly = true;
            this.dgvTrinhDo.RowHeadersWidth = 51;
            this.dgvTrinhDo.RowTemplate.Height = 30;
            this.dgvTrinhDo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrinhDo.Size = new System.Drawing.Size(591, 528);
            this.dgvTrinhDo.TabIndex = 1;
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
            this.layoutButtons.Location = new System.Drawing.Point(3, 643);
            this.layoutButtons.Name = "layoutButtons";
            this.layoutButtons.RowCount = 1;
            this.layoutButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutButtons.Size = new System.Drawing.Size(994, 54);
            this.layoutButtons.TabIndex = 3;
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
            this.btnThem.Size = new System.Drawing.Size(159, 48);
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
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(168, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(159, 48);
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
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(333, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(159, 48);
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
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(498, 3);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(159, 48);
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
            this.btnBoQua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBoQua.ForeColor = System.Drawing.Color.White;
            this.btnBoQua.Location = new System.Drawing.Point(663, 3);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(159, 48);
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
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(828, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(163, 48);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "🚪 Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // trinhdo
            // 
            this.Controls.Add(this.layoutMain);
            this.Name = "trinhdo";
            this.Size = new System.Drawing.Size(1000, 700);
            this.layoutMain.ResumeLayout(false);
            this.layoutSearch.ResumeLayout(false);
            this.layoutSearch.PerformLayout();
            this.layoutContent.ResumeLayout(false);
            this.groupBoxThongTin.ResumeLayout(false);
            this.layoutInputs.ResumeLayout(false);
            this.layoutInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrinhDo)).EndInit();
            this.layoutButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void SetupButton(Button btn, string text, EventHandler handler)
        {
            btn.Text = text;
            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btn.BackColor = Color.MediumSeaGreen;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Dock = DockStyle.Fill;
            if (handler != null)
                btn.Click += handler;
        }
    }
}
