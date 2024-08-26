namespace Quản_Lý_Thư_Viện_Sách.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        TenDangNhap = c.String(nullable: false, maxLength: 50),
                        DiaChi = c.String(nullable: false, maxLength: 255),
                        SoDienThoai = c.String(nullable: false, maxLength: 15),
                        MatKhau = c.String(nullable: false, maxLength: 100),
                        LaAdmin = c.Boolean(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.TenDangNhap);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        TieuDe = c.String(nullable: false, maxLength: 200),
                        TacGia = c.String(nullable: false, maxLength: 100),
                        DanhMuc = c.String(nullable: false, maxLength: 100),
                        NhaXuatBan = c.String(nullable: false, maxLength: 100),
                        NamXuatBan = c.DateTime(nullable: false),
                        SoLuongTonKho = c.Int(nullable: false),
                        TrangThai = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.TieuDe);
            
            CreateTable(
                "dbo.ChiTietSachMuons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TenDangNhap = c.String(),
                        TieuDeSach = c.String(),
                        NgayMuon = c.DateTime(nullable: false),
                        NgayTra = c.DateTime(),
                        TrangThai = c.String(),
                        Report_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Reports", t => t.Report_Id)
                .Index(t => t.Report_Id);
            
            CreateTable(
                "dbo.Loans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TenDangNhap = c.String(nullable: false, maxLength: 50),
                        TieuDe = c.String(nullable: false, maxLength: 200),
                        NgayMuon = c.DateTime(nullable: false),
                        NgayTra = c.DateTime(),
                        TrangThai = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accounts", t => t.TenDangNhap)
                .ForeignKey("dbo.Books", t => t.TieuDe)
                .Index(t => t.TenDangNhap)
                .Index(t => t.TieuDe);
            
            CreateTable(
                "dbo.Reports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NgayBaoCao = c.DateTime(nullable: false),
                        TongSoSach = c.Int(nullable: false),
                        TongSoSachDaMuon = c.Int(nullable: false),
                        TongSoSachConLai = c.Int(nullable: false),
                        TongSoSachQuaHan = c.Int(nullable: false),
                        TongSoTaiKhoan = c.Int(nullable: false),
                        TongSoTaiKhoanHoatDong = c.Int(nullable: false),
                        TongSoTaiKhoanKhongHoatDong = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ChiTietSachMuons", "Report_Id", "dbo.Reports");
            DropForeignKey("dbo.Loans", "TieuDe", "dbo.Books");
            DropForeignKey("dbo.Loans", "TenDangNhap", "dbo.Accounts");
            DropIndex("dbo.Loans", new[] { "TieuDe" });
            DropIndex("dbo.Loans", new[] { "TenDangNhap" });
            DropIndex("dbo.ChiTietSachMuons", new[] { "Report_Id" });
            DropTable("dbo.Reports");
            DropTable("dbo.Loans");
            DropTable("dbo.ChiTietSachMuons");
            DropTable("dbo.Books");
            DropTable("dbo.Accounts");
        }
    }
}
