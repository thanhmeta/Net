using System.Windows.Forms;

namespace baitaplon
{
    partial class theloai
    {
        private Label lblMaQCao;
        private Label lblTenQCao;
        private Label lblTimKiem;

        private TextBox txtTimKiem;
        private TextBox txtMaQCao;
        private TextBox txtTenQCao;
        private DataGridView dgvQuangCao;

        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnBoQua;
        private Button btnThoat;
        private Button btnTimKiem;


        private TableLayoutPanel inputLayout;
        private TableLayoutPanel mainLayout;
        private TableLayoutPanel rightLayout;
        private FlowLayoutPanel searchLayout;
        private TableLayoutPanel buttonLayout;
        private TableLayoutPanel contentLayout;
        private GroupBox groupBoxThongTin;
        private Label lblTitle;

        private void InitializeComponent()
        {
            this.lblMaQCao = new System.Windows.Forms.Label();
            this.lblTenQCao = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.txtMaQCao = new System.Windows.Forms.TextBox();
            this.txtTenQCao = new System.Windows.Forms.TextBox();
            this.dgvQuangCao = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.inputLayout = new System.Windows.Forms.TableLayoutPanel();
            this.rightLayout = new System.Windows.Forms.TableLayoutPanel();
            this.searchLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonLayout = new System.Windows.Forms.TableLayoutPanel();
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.contentLayout = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxThongTin = new System.Windows.Forms.GroupBox();
            this.lblTieuDe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuangCao)).BeginInit();
            this.rightLayout.SuspendLayout();
            this.searchLayout.SuspendLayout();
            this.mainLayout.SuspendLayout();
            this.contentLayout.SuspendLayout();
            this.groupBoxThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMaQCao
            // 
            this.lblMaQCao.Location = new System.Drawing.Point(10, 90);
            this.lblMaQCao.Name = "lblMaQCao";
            this.lblMaQCao.Size = new System.Drawing.Size(110, 23);
            this.lblMaQCao.TabIndex = 1;
            this.lblMaQCao.Text = "Mã Thể Loại :";
            this.lblMaQCao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTenQCao
            // 
            this.lblTenQCao.Location = new System.Drawing.Point(10, 150);
            this.lblTenQCao.Name = "lblTenQCao";
            this.lblTenQCao.Size = new System.Drawing.Size(110, 23);
            this.lblTenQCao.TabIndex = 3;
            this.lblTenQCao.Text = "Tên Thể Loại:";
            this.lblTenQCao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(109, 3);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(300, 22);
            this.txtTimKiem.TabIndex = 1;
            // 
            // txtMaQCao
            // 
            this.txtMaQCao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaQCao.Location = new System.Drawing.Point(125, 90);
            this.txtMaQCao.Name = "txtMaQCao";
            this.txtMaQCao.Size = new System.Drawing.Size(120, 22);
            this.txtMaQCao.TabIndex = 2;
            // 
            // txtTenQCao
            // 
            this.txtTenQCao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenQCao.Location = new System.Drawing.Point(125, 150);
            this.txtTenQCao.Name = "txtTenQCao";
            this.txtTenQCao.Size = new System.Drawing.Size(120, 22);
            this.txtTenQCao.TabIndex = 4;
            // 
            // dgvQuangCao
            // 
            this.dgvQuangCao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuangCao.ColumnHeadersHeight = 29;
            this.dgvQuangCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQuangCao.Location = new System.Drawing.Point(3, 43);
            this.dgvQuangCao.Name = "dgvQuangCao";
            this.dgvQuangCao.RowHeadersWidth = 51;
            this.dgvQuangCao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuangCao.Size = new System.Drawing.Size(614, 332);
            this.dgvQuangCao.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(0, 0);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 0;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(0, 0);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 0;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(0, 0);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 0;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(0, 0);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 0;
            // 
            // btnBoQua
            // 
            this.btnBoQua.Location = new System.Drawing.Point(0, 0);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(75, 23);
            this.btnBoQua.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(415, 3);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(30, 30);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click_1);
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.Location = new System.Drawing.Point(3, 0);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.lblTimKiem.Size = new System.Drawing.Size(100, 30);
            this.lblTimKiem.TabIndex = 0;
            this.lblTimKiem.Text = "Tìm kiếm:";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(0, 0);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 0;
            // 
            // inputLayout
            // 
            this.inputLayout.ColumnCount = 2;
            this.inputLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.inputLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.inputLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputLayout.Location = new System.Drawing.Point(3, 18);
            this.inputLayout.Name = "inputLayout";
            this.inputLayout.RowCount = 2;
            this.inputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.inputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.inputLayout.Size = new System.Drawing.Size(256, 357);
            this.inputLayout.TabIndex = 0;
            // 
            // rightLayout
            // 
            this.rightLayout.ColumnCount = 1;
            this.rightLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.rightLayout.Controls.Add(this.searchLayout, 0, 0);
            this.rightLayout.Controls.Add(this.dgvQuangCao, 0, 1);
            this.rightLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightLayout.Location = new System.Drawing.Point(271, 3);
            this.rightLayout.Name = "rightLayout";
            this.rightLayout.RowCount = 2;
            this.rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rightLayout.Size = new System.Drawing.Size(620, 378);
            this.rightLayout.TabIndex = 1;
            // 
            // searchLayout
            // 
            this.searchLayout.AutoSize = true;
            this.searchLayout.Controls.Add(this.lblTimKiem);
            this.searchLayout.Controls.Add(this.txtTimKiem);
            this.searchLayout.Controls.Add(this.btnTimKiem);
            this.searchLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchLayout.Location = new System.Drawing.Point(3, 3);
            this.searchLayout.Name = "searchLayout";
            this.searchLayout.Size = new System.Drawing.Size(614, 34);
            this.searchLayout.TabIndex = 0;
            // 

            // 
            // mainLayout
            // 
            this.mainLayout.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainLayout.Controls.Add(this.lblTitle, 0, 0);
            this.mainLayout.Controls.Add(this.contentLayout, 0, 1);
            this.mainLayout.Controls.Add(this.buttonLayout, 0, 2);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 3;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.mainLayout.Size = new System.Drawing.Size(900, 500);
            this.mainLayout.TabIndex = 0;
            this.mainLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.mainLayout_Paint);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(894, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THỂ LOẠI";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // contentLayout
            // 
            this.contentLayout.ColumnCount = 2;
            this.contentLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.contentLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.contentLayout.Controls.Add(this.groupBoxThongTin, 0, 0);
            this.contentLayout.Controls.Add(this.rightLayout, 1, 0);
            this.contentLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentLayout.Location = new System.Drawing.Point(3, 53);
            this.contentLayout.Name = "contentLayout";
            this.contentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.contentLayout.Size = new System.Drawing.Size(894, 384);
            this.contentLayout.TabIndex = 1;
            // 
            // groupBoxThongTin
            // 
            this.groupBoxThongTin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBoxThongTin.Controls.Add(this.lblTieuDe);
            this.groupBoxThongTin.Controls.Add(this.lblMaQCao);
            this.groupBoxThongTin.Controls.Add(this.txtMaQCao);
            this.groupBoxThongTin.Controls.Add(this.lblTenQCao);
            this.groupBoxThongTin.Controls.Add(this.txtTenQCao);
            this.groupBoxThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxThongTin.Location = new System.Drawing.Point(3, 3);
            this.groupBoxThongTin.Name = "groupBoxThongTin";
            this.groupBoxThongTin.Size = new System.Drawing.Size(262, 378);
            this.groupBoxThongTin.TabIndex = 0;
            this.groupBoxThongTin.TabStop = false;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.Location = new System.Drawing.Point(3, 18);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(256, 30);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Nhập Thông Tin";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // theloai
            // 
            this.Controls.Add(this.mainLayout);
            this.Name = "theloai";
            this.Size = new System.Drawing.Size(900, 500);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuangCao)).EndInit();
            this.rightLayout.ResumeLayout(false);
            this.rightLayout.PerformLayout();
            this.searchLayout.ResumeLayout(false);
            this.searchLayout.PerformLayout();
            this.mainLayout.ResumeLayout(false);
            this.contentLayout.ResumeLayout(false);
            this.groupBoxThongTin.ResumeLayout(false);
            this.groupBoxThongTin.PerformLayout();
            this.ResumeLayout(false);

        }

        private Label lblTieuDe;
    }
        
    }
