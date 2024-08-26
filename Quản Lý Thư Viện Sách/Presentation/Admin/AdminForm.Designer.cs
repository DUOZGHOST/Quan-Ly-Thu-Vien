using System.Windows.Forms;

namespace Quản_Lý_Thư_Viện_Sách.Presentation.Admin
{
    partial class AdminForm
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
            this.btnManageAccounts = new System.Windows.Forms.Button();
            this.btnManageBooks = new System.Windows.Forms.Button();
            this.btnManageLoans = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelFunctionality = new System.Windows.Forms.Panel();
            this.lvBooks = new System.Windows.Forms.ListView();
            this.columnHeaderTitle = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderAuthor = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderCategory = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderPublisher = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderPublicationYear = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderStockQuantity = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderStatus = new System.Windows.Forms.ColumnHeader();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBackToBooks = new System.Windows.Forms.Button();
            this.panelFunctionality.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnManageAccounts
            // 
            this.btnManageAccounts.Location = new System.Drawing.Point(12, 12);
            this.btnManageAccounts.Name = "btnManageAccounts";
            this.btnManageAccounts.Size = new System.Drawing.Size(150, 30);
            this.btnManageAccounts.TabIndex = 0;
            this.btnManageAccounts.Text = "Quản lý tài khoản";
            this.btnManageAccounts.UseVisualStyleBackColor = true;
            this.btnManageAccounts.Click += new System.EventHandler(this.btnManageAccounts_Click);
            // 
            // btnManageBooks
            // 
            this.btnManageBooks.Location = new System.Drawing.Point(168, 12);
            this.btnManageBooks.Name = "btnManageBooks";
            this.btnManageBooks.Size = new System.Drawing.Size(150, 30);
            this.btnManageBooks.TabIndex = 1;
            this.btnManageBooks.Text = "Quản lý sách";
            this.btnManageBooks.UseVisualStyleBackColor = true;
            this.btnManageBooks.Click += new System.EventHandler(this.btnManageBooks_Click);
            // 
            // btnManageLoans
            // 
            this.btnManageLoans.Location = new System.Drawing.Point(324, 12);
            this.btnManageLoans.Name = "btnManageLoans";
            this.btnManageLoans.Size = new System.Drawing.Size(150, 30);
            this.btnManageLoans.TabIndex = 2;
            this.btnManageLoans.Text = "Quản lý mượn sách";
            this.btnManageLoans.UseVisualStyleBackColor = true;
            this.btnManageLoans.Click += new System.EventHandler(this.btnManageLoans_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Location = new System.Drawing.Point(480, 12);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(150, 30);
            this.btnStatistics.TabIndex = 3;
            this.btnStatistics.Text = "Thống kê";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(636, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(150, 30);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lvBooks
            // 
            this.lvBooks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTitle,
            this.columnHeaderAuthor,
            this.columnHeaderCategory,
            this.columnHeaderPublisher,
            this.columnHeaderPublicationYear,
            this.columnHeaderStockQuantity,
            this.columnHeaderStatus});
            this.lvBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvBooks.FullRowSelect = true;
            this.lvBooks.GridLines = true;
            this.lvBooks.HideSelection = false;
            this.lvBooks.Location = new System.Drawing.Point(0, 0);
            this.lvBooks.Name = "lvBooks";
            this.lvBooks.Size = new System.Drawing.Size(776, 390);
            this.lvBooks.TabIndex = 0;
            this.lvBooks.UseCompatibleStateImageBehavior = false;
            this.lvBooks.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderTitle
            // 
            this.columnHeaderTitle.Text = "Tiêu đề";
            this.columnHeaderTitle.Width = 150;
            // 
            // columnHeaderAuthor
            // 
            this.columnHeaderAuthor.Text = "Tác giả";
            this.columnHeaderAuthor.Width = 120;
            // 
            // columnHeaderCategory
            // 
            this.columnHeaderCategory.Text = "Danh mục";
            this.columnHeaderCategory.Width = 100;
            // 
            // columnHeaderPublisher
            // 
            this.columnHeaderPublisher.Text = "Nhà xuất bản";
            this.columnHeaderPublisher.Width = 120;
            // 
            // columnHeaderPublicationYear
            // 
            this.columnHeaderPublicationYear.Text = "Năm xuất bản";
            this.columnHeaderPublicationYear.Width = 100;
            // 
            // columnHeaderStockQuantity
            // 
            this.columnHeaderStockQuantity.Text = "Số lượng tồn kho";
            this.columnHeaderStockQuantity.Width = 100;
            // 
            // columnHeaderStatus
            // 
            this.columnHeaderStatus.Text = "Trạng thái";
            this.columnHeaderStatus.Width = 100;
            // 
            // panelFunctionality
            // 
            this.panelFunctionality.Controls.Add(this.lvBooks);
            this.panelFunctionality.Location = new System.Drawing.Point(12, 90);
            this.panelFunctionality.Name = "panelFunctionality";
            this.panelFunctionality.Size = new System.Drawing.Size(776, 390);
            this.panelFunctionality.TabIndex = 5;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 54);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 20);
            this.txtSearch.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(268, 54);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnBackToBooks
            // 
            this.btnBackToBooks.Location = new System.Drawing.Point(636, 54);
            this.btnBackToBooks.Name = "btnBackToBooks";
            this.btnBackToBooks.Size = new System.Drawing.Size(150, 23);
            this.btnBackToBooks.TabIndex = 5;
            this.btnBackToBooks.Text = "Quay lại danh sách sách";
            this.btnBackToBooks.UseVisualStyleBackColor = true;
            this.btnBackToBooks.Click += new System.EventHandler(this.btnBackToBooks_Click);
            // 
            // cbSearchCriteria
            // 
            this.cbSearchCriteria = new System.Windows.Forms.ComboBox();
            this.cbSearchCriteria.FormattingEnabled = true;
            this.cbSearchCriteria.Location = new System.Drawing.Point(350, 54); 
            this.cbSearchCriteria.Name = "cbSearchCriteria";
            this.cbSearchCriteria.Size = new System.Drawing.Size(121, 21);
            this.cbSearchCriteria.TabIndex = 1;
            this.Controls.Add(this.cbSearchCriteria);
            // 
            // AdminForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.cbSearchCriteria);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnBackToBooks);
            this.Controls.Add(this.panelFunctionality);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.btnManageLoans);
            this.Controls.Add(this.btnManageBooks);
            this.Controls.Add(this.btnManageAccounts);
            this.Name = "AdminForm";
            this.Text = "Quản lý Admin";
            this.panelFunctionality.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button btnManageAccounts;
        private System.Windows.Forms.Button btnManageBooks;
        private System.Windows.Forms.Button btnManageLoans;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelFunctionality;
        private System.Windows.Forms.ListView lvBooks;
        private System.Windows.Forms.ColumnHeader columnHeaderTitle;
        private System.Windows.Forms.ColumnHeader columnHeaderAuthor;
        private System.Windows.Forms.ColumnHeader columnHeaderCategory;
        private System.Windows.Forms.ColumnHeader columnHeaderPublisher;
        private System.Windows.Forms.ColumnHeader columnHeaderPublicationYear;
        private System.Windows.Forms.ColumnHeader columnHeaderStockQuantity;
        private System.Windows.Forms.ColumnHeader columnHeaderStatus;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnBackToBooks;
        private System.Windows.Forms.ComboBox cbSearchCriteria;
    }
}