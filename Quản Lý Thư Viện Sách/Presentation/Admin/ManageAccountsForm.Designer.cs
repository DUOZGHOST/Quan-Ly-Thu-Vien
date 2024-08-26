namespace Quản_Lý_Thư_Viện_Sách.Presentation.Admin
{
    partial class ManageAccountsForm
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
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.listViewAccounts = new System.Windows.Forms.ListView();
            this.columnHeaderUsername = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderAddress = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderPhoneNumber = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderIsAdmin = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderIsActive = new System.Windows.Forms.ColumnHeader();
            this.btnPreviousPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // btnAddAccount
            this.btnAddAccount.Location = new System.Drawing.Point(12, 12);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(150, 30);
            this.btnAddAccount.TabIndex = 0;
            this.btnAddAccount.Text = "Thêm tài khoản";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);

            // btnEditAccount
            this.btnEditAccount.Location = new System.Drawing.Point(168, 12);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(150, 30);
            this.btnEditAccount.TabIndex = 1;
            this.btnEditAccount.Text = "Chỉnh sửa tài khoản";
            this.btnEditAccount.UseVisualStyleBackColor = true;
            this.btnEditAccount.Click += new System.EventHandler(this.btnEditAccount_Click);

            // btnDeleteAccount
            this.btnDeleteAccount.Location = new System.Drawing.Point(324, 12);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(150, 30);
            this.btnDeleteAccount.TabIndex = 2;
            this.btnDeleteAccount.Text = "Xóa tài khoản";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);

            // listViewAccounts
            this.listViewAccounts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderUsername,
            this.columnHeaderAddress,
            this.columnHeaderPhoneNumber,
            this.columnHeaderIsAdmin,
            this.columnHeaderIsActive});
            this.listViewAccounts.FullRowSelect = true;
            this.listViewAccounts.GridLines = true;
            this.listViewAccounts.Location = new System.Drawing.Point(12, 58);
            this.listViewAccounts.Name = "listViewAccounts";
            this.listViewAccounts.Size = new System.Drawing.Size(760, 380);
            this.listViewAccounts.TabIndex = 3;
            this.listViewAccounts.UseCompatibleStateImageBehavior = false;
            this.listViewAccounts.View = System.Windows.Forms.View.Details;

            // columnHeaderUsername
            this.columnHeaderUsername.Text = "Tên đăng nhập";
            this.columnHeaderUsername.Width = 120;

            // columnHeaderAddress
            this.columnHeaderAddress.Text = "Địa chỉ";
            this.columnHeaderAddress.Width = 200;

            // columnHeaderPhoneNumber
            this.columnHeaderPhoneNumber.Text = "Số điện thoại";
            this.columnHeaderPhoneNumber.Width = 120;

            // columnHeaderIsAdmin
            this.columnHeaderIsAdmin.Text = "Loại tài khoản";
            this.columnHeaderIsAdmin.Width = 100;

            // columnHeaderIsActive
            this.columnHeaderIsActive.Text = "Trạng thái";
            this.columnHeaderIsActive.Width = 100;

            // btnNextPage
            this.btnNextPage.Location = new System.Drawing.Point(654, 12);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(120, 30);
            this.btnNextPage.TabIndex = 5;
            this.btnNextPage.Text = "Trang tiếp";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);

            // btnPreviousPage
            this.btnPreviousPage.Location = new System.Drawing.Point(528, 12);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(120, 30);
            this.btnPreviousPage.TabIndex = 6;
            this.btnPreviousPage.Text = "Trang trước";
            this.btnPreviousPage.UseVisualStyleBackColor = true;
            this.btnPreviousPage.Click += new System.EventHandler(this.btnPreviousPage_Click);

            // ManageAccountsForm
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPreviousPage);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.listViewAccounts);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.btnEditAccount);
            this.Controls.Add(this.btnAddAccount);
            this.Name = "ManageAccountsForm";
            this.Text = "Quản lý tài khoản";
            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Button btnEditAccount;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.ListView listViewAccounts;
        private System.Windows.Forms.ColumnHeader columnHeaderUsername;
        private System.Windows.Forms.ColumnHeader columnHeaderAddress;
        private System.Windows.Forms.ColumnHeader columnHeaderPhoneNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderIsAdmin;
        private System.Windows.Forms.ColumnHeader columnHeaderIsActive;
        private System.Windows.Forms.Button btnPreviousPage;
        private System.Windows.Forms.Button btnNextPage;
    }
}