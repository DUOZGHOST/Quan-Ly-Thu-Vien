namespace Quản_Lý_Thư_Viện_Sách.Presentation.Admin
{
    partial class AddEditLoanForm
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
            this.labelTenDangNhap = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.labelTieuDeSach = new System.Windows.Forms.Label();
            this.txtTieuDeSach = new System.Windows.Forms.TextBox();
            this.labelNgayMuon = new System.Windows.Forms.Label();
            this.dtpNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.labelNgayTra = new System.Windows.Forms.Label();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labelTrangThai = new System.Windows.Forms.Label();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();

            // 
            // labelTenDangNhap 
            // 
            this.labelTenDangNhap.AutoSize = true;
            this.labelTenDangNhap.Location = new System.Drawing.Point(12, 15);
            this.labelTenDangNhap.Name = "labelTenDangNhap";
            this.labelTenDangNhap.Size = new System.Drawing.Size(91, 17);
            this.labelTenDangNhap.TabIndex = 0;
            this.labelTenDangNhap.Text = "Tên đăng nhập:";

            // 
            // txtTenDangNhap 
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(130, 12);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(200, 22);
            this.txtTenDangNhap.TabIndex = 1;

            // 
            // labelTieuDeSach
            // 
            this.labelTieuDeSach.AutoSize = true;
            this.labelTieuDeSach.Location = new System.Drawing.Point(12, 45);
            this.labelTieuDeSach.Name = "labelTieuDeSach";
            this.labelTieuDeSach.Size = new System.Drawing.Size(61, 17);
            this.labelTieuDeSach.TabIndex = 2;
            this.labelTieuDeSach.Text = "Tên sách:";

            // 
            // txtTieuDeSach
            // 
            this.txtTieuDeSach.Location = new System.Drawing.Point(130, 42);
            this.txtTieuDeSach.Name = "txtTieuDeSach";
            this.txtTieuDeSach.Size = new System.Drawing.Size(200, 22);
            this.txtTieuDeSach.TabIndex = 3;

            // 
            // labelNgayMuon
            // 
            this.labelNgayMuon.AutoSize = true;
            this.labelNgayMuon.Location = new System.Drawing.Point(12, 75);
            this.labelNgayMuon.Name = "labelNgayMuon";
            this.labelNgayMuon.Size = new System.Drawing.Size(85, 17);
            this.labelNgayMuon.TabIndex = 4;
            this.labelNgayMuon.Text = "Ngày Mượn:";

            // 
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayMuon.Location = new System.Drawing.Point(130, 72);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(200, 22);
            this.dtpNgayMuon.TabIndex = 5;

            // 
            // labelNgayTra
            // 
            this.labelNgayTra.AutoSize = true;
            this.labelNgayTra.Location = new System.Drawing.Point(12, 105);
            this.labelNgayTra.Name = "labelNgayTra";
            this.labelNgayTra.Size = new System.Drawing.Size(77, 17);
            this.labelNgayTra.TabIndex = 6;
            this.labelNgayTra.Text = "Ngày Trả:";

            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTra.Location = new System.Drawing.Point(130, 102);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(200, 22);
            this.dtpNgayTra.TabIndex = 7;

            // 
            // labelTrangThai
            // 
            this.labelTrangThai.AutoSize = true;
            this.labelTrangThai.Location = new System.Drawing.Point(12, 135);
            this.labelTrangThai.Name = "labelTrangThai";
            this.labelTrangThai.Size = new System.Drawing.Size(75, 17);
            this.labelTrangThai.TabIndex = 8;
            this.labelTrangThai.Text = "Trạng thái:";

            // 
            // cbTrangThai
            // 
            this.cbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Location = new System.Drawing.Point(130, 132);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(200, 24);
            this.cbTrangThai.TabIndex = 9;

            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(130, 180);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(205, 180);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // 
            // AddEditLoanForm
            // 
            this.ClientSize = new System.Drawing.Size(350, 220);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbTrangThai);
            this.Controls.Add(this.labelTrangThai);
            this.Controls.Add(this.dtpNgayTra);
            this.Controls.Add(this.labelNgayTra);
            this.Controls.Add(this.dtpNgayMuon);
            this.Controls.Add(this.labelNgayMuon);
            this.Controls.Add(this.txtTieuDeSach);
            this.Controls.Add(this.labelTieuDeSach);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.labelTenDangNhap);
            this.Name = "AddEditLoanForm";
            this.Text = "Thêm/Sửa Khoản Mượn";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label labelTenDangNhap;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label labelTieuDeSach;
        private System.Windows.Forms.TextBox txtTieuDeSach;
        private System.Windows.Forms.Label labelNgayMuon;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon;
        private System.Windows.Forms.Label labelNgayTra;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelTrangThai;
        private System.Windows.Forms.ComboBox cbTrangThai;
    }
}