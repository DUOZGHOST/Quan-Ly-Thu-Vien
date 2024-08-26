using System;

namespace Quản_Lý_Thư_Viện_Sách.Presentation.Admin
{
    partial class ReportForm
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
            this.lblNgayBaoCao = new System.Windows.Forms.Label();
            this.lblTongSoSach = new System.Windows.Forms.Label();
            this.lblTongSoSachDaMuon = new System.Windows.Forms.Label();
            this.lblTongSoSachConLai = new System.Windows.Forms.Label();
            this.lblTongSoSachQuaHan = new System.Windows.Forms.Label();
            this.lblTongSoTaiKhoan = new System.Windows.Forms.Label();
            this.lblTongSoTaiKhoanHoatDong = new System.Windows.Forms.Label();
            this.lblTongSoTaiKhoanKhongHoatDong = new System.Windows.Forms.Label();
            this.lstChiTietSachMuons = new System.Windows.Forms.ListView();
            this.btnGeneratePdf = new System.Windows.Forms.Button();
            this.lblChiTietSachMuons = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNgayBaoCao
            // 
            this.lblNgayBaoCao.AutoSize = true;
            this.lblNgayBaoCao.Location = new System.Drawing.Point(12, 9);
            this.lblNgayBaoCao.Name = "lblNgayBaoCao";
            this.lblNgayBaoCao.Size = new System.Drawing.Size(97, 17);
            this.lblNgayBaoCao.TabIndex = 0;
            this.lblNgayBaoCao.Text = "Ngay bao cao:";
            // 
            // lblTongSoSach
            // 
            this.lblTongSoSach.AutoSize = true;
            this.lblTongSoSach.Location = new System.Drawing.Point(12, 36);
            this.lblTongSoSach.Name = "lblTongSoSach";
            this.lblTongSoSach.Size = new System.Drawing.Size(105, 17);
            this.lblTongSoSach.TabIndex = 1;
            this.lblTongSoSach.Text = "Tong so sach:";
            // 
            // lblTongSoSachDaMuon
            // 
            this.lblTongSoSachDaMuon.AutoSize = true;
            this.lblTongSoSachDaMuon.Location = new System.Drawing.Point(12, 63);
            this.lblTongSoSachDaMuon.Name = "lblTongSoSachDaMuon";
            this.lblTongSoSachDaMuon.Size = new System.Drawing.Size(147, 17);
            this.lblTongSoSachDaMuon.TabIndex = 2;
            this.lblTongSoSachDaMuon.Text = "Tong so luong sach da muon:";
            // 
            // lblTongSoSachConLai
            // 
            this.lblTongSoSachConLai.AutoSize = true;
            this.lblTongSoSachConLai.Location = new System.Drawing.Point(12, 90);
            this.lblTongSoSachConLai.Name = "lblTongSoSachConLai";
            this.lblTongSoSachConLai.Size = new System.Drawing.Size(138, 17);
            this.lblTongSoSachConLai.TabIndex = 3;
            this.lblTongSoSachConLai.Text = "Tong so luong sach con lai:";
            // 
            // lblTongSoSachQuaHan
            // 
            this.lblTongSoSachQuaHan.AutoSize = true;
            this.lblTongSoSachQuaHan.Location = new System.Drawing.Point(12, 117);
            this.lblTongSoSachQuaHan.Name = "lblTongSoSachQuaHan";
            this.lblTongSoSachQuaHan.Size = new System.Drawing.Size(157, 17);
            this.lblTongSoSachQuaHan.TabIndex = 4;
            this.lblTongSoSachQuaHan.Text = "Tong so luong sach qua han:";
            // 
            // lblTongSoTaiKhoan
            // 
            this.lblTongSoTaiKhoan.AutoSize = true;
            this.lblTongSoTaiKhoan.Location = new System.Drawing.Point(12, 144);
            this.lblTongSoTaiKhoan.Name = "lblTongSoTaiKhoan";
            this.lblTongSoTaiKhoan.Size = new System.Drawing.Size(129, 17);
            this.lblTongSoTaiKhoan.TabIndex = 5;
            this.lblTongSoTaiKhoan.Text = "Tong so tai khoan:";
            // 
            // lblTongSoTaiKhoanHoatDong
            // 
            this.lblTongSoTaiKhoanHoatDong.AutoSize = true;
            this.lblTongSoTaiKhoanHoatDong.Location = new System.Drawing.Point(12, 171);
            this.lblTongSoTaiKhoanHoatDong.Name = "lblTongSoTaiKhoanHoatDong";
            this.lblTongSoTaiKhoanHoatDong.Size = new System.Drawing.Size(186, 17);
            this.lblTongSoTaiKhoanHoatDong.TabIndex = 6;
            this.lblTongSoTaiKhoanHoatDong.Text = "Tong so tai khoan hoat dong:";
            // 
            // lblTongSoTaiKhoanKhongHoatDong
            // 
            this.lblTongSoTaiKhoanKhongHoatDong.AutoSize = true;
            this.lblTongSoTaiKhoanKhongHoatDong.Location = new System.Drawing.Point(12, 198);
            this.lblTongSoTaiKhoanKhongHoatDong.Name = "lblTongSoTaiKhoanKhongHoatDong";
            this.lblTongSoTaiKhoanKhongHoatDong.Size = new System.Drawing.Size(218, 17);
            this.lblTongSoTaiKhoanKhongHoatDong.TabIndex = 7;
            this.lblTongSoTaiKhoanKhongHoatDong.Text = "Tong so tai khoan khong hoat dong:";
            // 
            // lstChiTietSachMuons
            // 
            this.lstChiTietSachMuons.Location = new System.Drawing.Point(300, 30);
            this.lstChiTietSachMuons.Name = "lstChiTietSachMuons";
            this.lstChiTietSachMuons.Size = new System.Drawing.Size(450, 250);
            this.lstChiTietSachMuons.TabIndex = 10;
            this.lstChiTietSachMuons.UseCompatibleStateImageBehavior = false;
            this.lstChiTietSachMuons.View = System.Windows.Forms.View.Details;
            // 
            // btnGeneratePdf
            // 
            this.btnGeneratePdf.Location = new System.Drawing.Point(12, 250);
            this.btnGeneratePdf.Name = "btnGeneratePdf";
            this.btnGeneratePdf.Size = new System.Drawing.Size(150, 30);
            this.btnGeneratePdf.TabIndex = 11;
            this.btnGeneratePdf.Text = "Tạo báo cáo PDF";
            this.btnGeneratePdf.UseVisualStyleBackColor = true;
            this.btnGeneratePdf.Click += new System.EventHandler(this.btnGeneratePdf_Click);
            // 
            // lblChiTietSachMuons
            // 
            this.lblChiTietSachMuons.AutoSize = true;
            this.lblChiTietSachMuons.Location = new System.Drawing.Point(300, 9);
            this.lblChiTietSachMuons.Name = "lblChiTietSachMuons";
            this.lblChiTietSachMuons.Size = new System.Drawing.Size(122, 17);
            this.lblChiTietSachMuons.TabIndex = 13;
            this.lblChiTietSachMuons.Text = "Chi tiết sách mượn:";
            // 
            // ReportForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGeneratePdf);
            this.Controls.Add(this.lstChiTietSachMuons);
            this.Controls.Add(this.lblTongSoTaiKhoanKhongHoatDong);
            this.Controls.Add(this.lblTongSoTaiKhoanHoatDong);
            this.Controls.Add(this.lblTongSoTaiKhoan);
            this.Controls.Add(this.lblTongSoSachQuaHan);
            this.Controls.Add(this.lblTongSoSachConLai);
            this.Controls.Add(this.lblTongSoSachDaMuon);
            this.Controls.Add(this.lblTongSoSach);
            this.Controls.Add(this.lblNgayBaoCao);
            this.Controls.Add(this.lblChiTietSachMuons);
            this.Name = "ReportForm";
            this.Text = "Báo cáo";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNgayBaoCao;
        private System.Windows.Forms.Label lblTongSoSach;
        private System.Windows.Forms.Label lblTongSoSachDaMuon;
        private System.Windows.Forms.Label lblTongSoSachConLai;
        private System.Windows.Forms.Label lblTongSoSachQuaHan;
        private System.Windows.Forms.Label lblTongSoTaiKhoan;
        private System.Windows.Forms.Label lblTongSoTaiKhoanHoatDong;
        private System.Windows.Forms.Label lblTongSoTaiKhoanKhongHoatDong;
        private System.Windows.Forms.ListView lstChiTietSachMuons;
        private System.Windows.Forms.Button btnGeneratePdf;
        private System.Windows.Forms.Label lblChiTietSachMuons;
    }
}