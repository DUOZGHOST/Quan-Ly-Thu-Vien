namespace Quản_Lý_Thư_Viện_Sách.Presentation.Admin
{
    partial class ManageLoansForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewLoans = new System.Windows.Forms.ListView();
            this.columnHeaderId = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderTenDangNhap = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderTieuDe = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderNgayMuon = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderNgayTra = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderTrangThai = new System.Windows.Forms.ColumnHeader();
            this.btnAddLoan = new System.Windows.Forms.Button();
            this.btnEditLoan = new System.Windows.Forms.Button();
            this.btnDeleteLoan = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnPreviousPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // listViewLoans
            // 
            this.listViewLoans.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderTenDangNhap,
            this.columnHeaderTieuDe,
            this.columnHeaderNgayMuon,
            this.columnHeaderNgayTra,
            this.columnHeaderTrangThai});
            this.listViewLoans.FullRowSelect = true;
            this.listViewLoans.GridLines = true;
            this.listViewLoans.HideSelection = false;
            this.listViewLoans.Location = new System.Drawing.Point(12, 80);
            this.listViewLoans.Name = "listViewLoans";
            this.listViewLoans.Size = new System.Drawing.Size(760, 400);
            this.listViewLoans.TabIndex = 0;
            this.listViewLoans.UseCompatibleStateImageBehavior = false;
            this.listViewLoans.View = System.Windows.Forms.View.Details;

            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "ID";
            this.columnHeaderId.Width = 50;

            // 
            // columnHeaderTenDangNhap
            // 
            this.columnHeaderTenDangNhap.Text = "Tên đăng nhập";
            this.columnHeaderTenDangNhap.Width = 100;

            // 
            // columnHeaderTieuDe
            // 
            this.columnHeaderTieuDe.Text = "Tiêu đề sách";
            this.columnHeaderTieuDe.Width = 150;

            // 
            // columnHeaderNgayMuon
            // 
            this.columnHeaderNgayMuon.Text = "Ngày Mượn";
            this.columnHeaderNgayMuon.Width = 100;

            // 
            // columnHeaderNgayTra
            // 
            this.columnHeaderNgayTra.Text = "Ngày Trả";
            this.columnHeaderNgayTra.Width = 100;

            // 
            // columnHeaderTrangThai
            // 
            this.columnHeaderTrangThai.Text = "Trạng Thái";
            this.columnHeaderTrangThai.Width = 100;

            // 
            // btnAddLoan
            // 
            this.btnAddLoan.Location = new System.Drawing.Point(12, 12);
            this.btnAddLoan.Name = "btnAddLoan";
            this.btnAddLoan.Size = new System.Drawing.Size(120, 30);
            this.btnAddLoan.TabIndex = 1;
            this.btnAddLoan.Text = "Thêm Khoản Mượn";
            this.btnAddLoan.UseVisualStyleBackColor = true;
            this.btnAddLoan.Click += new System.EventHandler(this.btnAddLoan_Click);

            // 
            // btnEditLoan
            // 
            this.btnEditLoan.Location = new System.Drawing.Point(138, 12);
            this.btnEditLoan.Name = "btnEditLoan";
            this.btnEditLoan.Size = new System.Drawing.Size(120, 30);
            this.btnEditLoan.TabIndex = 2;
            this.btnEditLoan.Text = "Sửa Khoản Mượn";
            this.btnEditLoan.UseVisualStyleBackColor = true;
            this.btnEditLoan.Click += new System.EventHandler(this.btnEditLoan_Click);

            // 
            // btnDeleteLoan
            // 
            this.btnDeleteLoan.Location = new System.Drawing.Point(264, 12);
            this.btnDeleteLoan.Name = "btnDeleteLoan";
            this.btnDeleteLoan.Size = new System.Drawing.Size(120, 30);
            this.btnDeleteLoan.TabIndex = 3;
            this.btnDeleteLoan.Text = "Xóa Khoản Mượn";
            this.btnDeleteLoan.UseVisualStyleBackColor = true;
            this.btnDeleteLoan.Click += new System.EventHandler(this.btnDeleteLoan_Click);

            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 48);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(260, 22);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);

            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.Location = new System.Drawing.Point(528, 12);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(120, 30);
            this.btnPreviousPage.TabIndex = 5;
            this.btnPreviousPage.Text = "Trang trước";
            this.btnPreviousPage.UseVisualStyleBackColor = true;
            this.btnPreviousPage.Click += new System.EventHandler(this.btnPreviousPage_Click);

            // 
            // btnNextPage
            // 
            this.btnNextPage.Location = new System.Drawing.Point(654, 12);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(120, 30);
            this.btnNextPage.TabIndex = 6;
            this.btnNextPage.Text = "Trang sau";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);

            // 
            // ManageLoansForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 500);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.btnPreviousPage);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDeleteLoan);
            this.Controls.Add(this.btnEditLoan);
            this.Controls.Add(this.btnAddLoan);
            this.Controls.Add(this.listViewLoans);
            this.Name = "ManageLoansForm";
            this.Text = "Quản Lý Mượn Sách";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.ListView listViewLoans;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.ColumnHeader columnHeaderTenDangNhap;
        private System.Windows.Forms.ColumnHeader columnHeaderTieuDe;
        private System.Windows.Forms.ColumnHeader columnHeaderNgayMuon;
        private System.Windows.Forms.ColumnHeader columnHeaderNgayTra;
        private System.Windows.Forms.ColumnHeader columnHeaderTrangThai;
        private System.Windows.Forms.Button btnAddLoan;
        private System.Windows.Forms.Button btnEditLoan;
        private System.Windows.Forms.Button btnDeleteLoan;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnPreviousPage;
        private System.Windows.Forms.Button btnNextPage;
    }
}