namespace Quản_Lý_Thư_Viện_Sách.Presentation.Admin
{
    partial class AddEditBookForm
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
            this.txtTieuDe = new System.Windows.Forms.TextBox();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.txtNhaXuatBan = new System.Windows.Forms.TextBox();
            this.txtSoLuongTonKho = new System.Windows.Forms.TextBox();
            this.dtpNamXuatBan = new System.Windows.Forms.DateTimePicker();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblTacGia = new System.Windows.Forms.Label();
            this.lblNhaXuatBan = new System.Windows.Forms.Label();
            this.lblNamXuatBan = new System.Windows.Forms.Label();
            this.lblSoLuongTonKho = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblDanhMuc = new System.Windows.Forms.Label();
            this.txtDanhMuc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // 
            // txtTieuDe
            // 
            this.txtTieuDe.Location = new System.Drawing.Point(150, 30);
            this.txtTieuDe.Name = "txtTieuDe";
            this.txtTieuDe.Size = new System.Drawing.Size(200, 22);
            this.txtTieuDe.TabIndex = 0;

            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(150, 70);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(200, 22);
            this.txtTacGia.TabIndex = 1;

            // 
            // txtDanhMuc
            // 
            this.txtDanhMuc.Location = new System.Drawing.Point(150, 110);
            this.txtDanhMuc.Name = "txtDanhMuc";
            this.txtDanhMuc.Size = new System.Drawing.Size(200, 22);
            this.txtDanhMuc.TabIndex = 2; 

            // 
            // txtNhaXuatBan
            // 
            this.txtNhaXuatBan.Location = new System.Drawing.Point(150, 150);
            this.txtNhaXuatBan.Name = "txtNhaXuatBan";
            this.txtNhaXuatBan.Size = new System.Drawing.Size(200, 22);
            this.txtNhaXuatBan.TabIndex = 3;

            // 
            // dtpNamXuatBan
            // 
            this.dtpNamXuatBan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNamXuatBan.CustomFormat = "yyyy";
            this.dtpNamXuatBan.Location = new System.Drawing.Point(150, 190);
            this.dtpNamXuatBan.Name = "dtpNamXuatBan";
            this.dtpNamXuatBan.Size = new System.Drawing.Size(200, 22);
            this.dtpNamXuatBan.TabIndex = 4;

            // 
            // txtSoLuongTonKho
            // 
            this.txtSoLuongTonKho.Location = new System.Drawing.Point(150, 230);
            this.txtSoLuongTonKho.Name = "txtSoLuongTonKho";
            this.txtSoLuongTonKho.Size = new System.Drawing.Size(200, 22);
            this.txtSoLuongTonKho.TabIndex = 5;

            // 
            // cboTrangThai
            // 
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Location = new System.Drawing.Point(150, 270);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(200, 24);
            this.cboTrangThai.TabIndex = 6;

            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(150, 320);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Location = new System.Drawing.Point(30, 30);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(55, 17);
            this.lblTieuDe.TabIndex = 8;
            this.lblTieuDe.Text = "Tiêu đề:";

            // 
            // lblTacGia
            // 
            this.lblTacGia.AutoSize = true;
            this.lblTacGia.Location = new System.Drawing.Point(30, 70);
            this.lblTacGia.Name = "lblTacGia";
            this.lblTacGia.Size = new System.Drawing.Size(57, 17);
            this.lblTacGia.TabIndex = 9;
            this.lblTacGia.Text = "Tác giả:";

            // 
            // lblDanhMuc
            // 
            this.lblDanhMuc.AutoSize = true;
            this.lblDanhMuc.Location = new System.Drawing.Point(30, 110);
            this.lblDanhMuc.Name = "lblDanhMuc";
            this.lblDanhMuc.Size = new System.Drawing.Size(78, 17);
            this.lblDanhMuc.TabIndex = 10;
            this.lblDanhMuc.Text = "Danh mục:";

            // 
            // lblNhaXuatBan
            // 
            this.lblNhaXuatBan.AutoSize = true;
            this.lblNhaXuatBan.Location = new System.Drawing.Point(30, 150);
            this.lblNhaXuatBan.Name = "lblNhaXuatBan";
            this.lblNhaXuatBan.Size = new System.Drawing.Size(101, 17);
            this.lblNhaXuatBan.TabIndex = 11;
            this.lblNhaXuatBan.Text = "Nhà xuất bản:";

            // 
            // lblNamXuatBan
            // 
            this.lblNamXuatBan.AutoSize = true;
            this.lblNamXuatBan.Location = new System.Drawing.Point(30, 190);
            this.lblNamXuatBan.Name = "lblNamXuatBan";
            this.lblNamXuatBan.Size = new System.Drawing.Size(105, 17);
            this.lblNamXuatBan.TabIndex = 12;
            this.lblNamXuatBan.Text = "Năm xuất bản:";

            // 
            // lblSoLuongTonKho
            // 
            this.lblSoLuongTonKho.AutoSize = true;
            this.lblSoLuongTonKho.Location = new System.Drawing.Point(30, 230);
            this.lblSoLuongTonKho.Name = "lblSoLuongTonKho";
            this.lblSoLuongTonKho.Size = new System.Drawing.Size(127, 17);
            this.lblSoLuongTonKho.TabIndex = 13;
            this.lblSoLuongTonKho.Text = "Số lượng tồn kho:";

            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(30, 270);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(78, 17);
            this.lblTrangThai.TabIndex = 14;
            this.lblTrangThai.Text = "Trạng thái:";

            // 
            // AddEditBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 380);
            this.Controls.Add(this.lblTrangThai);
            this.Controls.Add(this.lblSoLuongTonKho);
            this.Controls.Add(this.lblNamXuatBan);
            this.Controls.Add(this.lblNhaXuatBan);
            this.Controls.Add(this.lblDanhMuc);
            this.Controls.Add(this.lblTacGia);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboTrangThai);
            this.Controls.Add(this.txtSoLuongTonKho);
            this.Controls.Add(this.dtpNamXuatBan);
            this.Controls.Add(this.txtNhaXuatBan);
            this.Controls.Add(this.txtDanhMuc);
            this.Controls.Add(this.txtTacGia);
            this.Controls.Add(this.txtTieuDe);
            this.Name = "AddEditBookForm";
            this.Text = "Thêm/Sửa Sách";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox txtTieuDe;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.TextBox txtNhaXuatBan;
        private System.Windows.Forms.TextBox txtSoLuongTonKho;
        private System.Windows.Forms.DateTimePicker dtpNamXuatBan;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblTacGia;
        private System.Windows.Forms.Label lblNhaXuatBan;
        private System.Windows.Forms.Label lblNamXuatBan;
        private System.Windows.Forms.Label lblSoLuongTonKho;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblDanhMuc;
        private System.Windows.Forms.TextBox txtDanhMuc;
    }
}