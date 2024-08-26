namespace Quản_Lý_Thư_Viện_Sách.Presentation.User
{
    partial class UserForm
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
            this.btnUpdateAccount = new System.Windows.Forms.Button();
            this.btnBorrowBook = new System.Windows.Forms.Button();
            this.btnReturnBook = new System.Windows.Forms.Button();
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
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.Location = new System.Drawing.Point(12, 12);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.Size = new System.Drawing.Size(150, 30);
            this.btnUpdateAccount.TabIndex = 0;
            this.btnUpdateAccount.Text = "Cập nhật tài khoản";
            this.btnUpdateAccount.UseVisualStyleBackColor = true;
            this.btnUpdateAccount.Click += new System.EventHandler(this.btnUpdateAccount_Click);
            // 
            // btnBorrowBook
            // 
            this.btnBorrowBook.Location = new System.Drawing.Point(168, 12);
            this.btnBorrowBook.Name = "btnBorrowBook";
            this.btnBorrowBook.Size = new System.Drawing.Size(150, 30);
            this.btnBorrowBook.TabIndex = 1;
            this.btnBorrowBook.Text = "Mượn sách";
            this.btnBorrowBook.UseVisualStyleBackColor = true;
            this.btnBorrowBook.Click += new System.EventHandler(this.btnBorrowBook_Click);
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.Location = new System.Drawing.Point(324, 12);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(150, 30);
            this.btnReturnBook.TabIndex = 2;
            this.btnReturnBook.Text = "Trả sách";
            this.btnReturnBook.UseVisualStyleBackColor = true;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(480, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(150, 30);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panelFunctionality
            // 
            this.panelFunctionality.Controls.Add(this.lvBooks);
            this.panelFunctionality.Location = new System.Drawing.Point(12, 90);
            this.panelFunctionality.Name = "panelFunctionality";
            this.panelFunctionality.Size = new System.Drawing.Size(776, 390);
            this.panelFunctionality.TabIndex = 4;
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
            this.columnHeaderCategory.Width = 80;
            // 
            // columnHeaderPublisher
            // 
            this.columnHeaderPublisher.Text = "Nhà xuất bản";
            this.columnHeaderPublisher.Width = 95;
            // 
            // columnHeaderPublicationYear
            // 
            this.columnHeaderPublicationYear.Text = "Năm xuất bản";
            this.columnHeaderPublicationYear.Width = 95;
            // 
            // columnHeaderStockQuantity
            // 
            this.columnHeaderStockQuantity.Text = "Số lượng tồn kho";
            this.columnHeaderStockQuantity.Width = 120;
            // 
            // columnHeaderStatus
            // 
            this.columnHeaderStatus.Text = "Trạng thái";
            this.columnHeaderStatus.Width = 100;
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
            // UserForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnBackToBooks);
            this.Controls.Add(this.panelFunctionality);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnReturnBook);
            this.Controls.Add(this.btnBorrowBook);
            this.Controls.Add(this.btnUpdateAccount);
            this.Name = "UserForm";
            this.Text = "Quản lý User";
            this.panelFunctionality.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnUpdateAccount;
        private System.Windows.Forms.Button btnBorrowBook;
        private System.Windows.Forms.Button btnReturnBook;
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
    }
}