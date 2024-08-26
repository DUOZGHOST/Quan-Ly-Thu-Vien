namespace Quản_Lý_Thư_Viện_Sách.Presentation.User
{
    partial class ReturnBookForm
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cboSearchCriteria = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstLoans = new System.Windows.Forms.ListView();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 20);
            this.txtSearch.TabIndex = 0;
            // 
            // cboSearchCriteria
            // 
            this.cboSearchCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearchCriteria.FormattingEnabled = true;
            this.cboSearchCriteria.Items.AddRange(new object[] {
            "Tên sách",
            "Tác giả",
            "Tên tài khoản"});
            this.cboSearchCriteria.Location = new System.Drawing.Point(218, 12);
            this.cboSearchCriteria.Name = "cboSearchCriteria";
            this.cboSearchCriteria.Size = new System.Drawing.Size(121, 21);
            this.cboSearchCriteria.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(345, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lstLoans
            // 
            this.lstLoans.FullRowSelect = true;
            this.lstLoans.GridLines = true;
            this.lstLoans.HideSelection = false;
            this.lstLoans.Location = new System.Drawing.Point(12, 39);
            this.lstLoans.Name = "lstLoans";
            this.lstLoans.Size = new System.Drawing.Size(500, 300);
            this.lstLoans.TabIndex = 3;
            this.lstLoans.UseCompatibleStateImageBehavior = false;
            this.lstLoans.View = System.Windows.Forms.View.Details;
            this.lstLoans.Columns.Add("ID", 50);
            this.lstLoans.Columns.Add("Tên sách", 200);
            this.lstLoans.Columns.Add("Tên tài khoản", 100);
            this.lstLoans.Columns.Add("Ngày mượn", 100);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(345, 345);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "Trả sách";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // ReturnBookForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 390);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lstLoans);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cboSearchCriteria);
            this.Controls.Add(this.txtSearch);
            this.Name = "ReturnBookForm";
            this.Text = "Trả sách";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cboSearchCriteria;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView lstLoans;
        private System.Windows.Forms.Button btnReturn;
    }
}