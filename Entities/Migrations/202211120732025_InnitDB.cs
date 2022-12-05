namespace Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InnitDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DocGias",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        HoVaTen = c.String(),
                        NgaySinh = c.DateTime(nullable: false),
                        DienThoai = c.String(),
                        Email = c.String(),
                        DiaChi = c.String(),
                        GioiTinh = c.String(),
                        NgayTao = c.DateTime(nullable: false),
                        NgayCapNhat = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Muons",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        DocGiaID = c.Int(nullable: false),
                        NgayMuon = c.DateTime(nullable: false),
                        NgayHenTra = c.DateTime(nullable: false),
                        NgayTao = c.DateTime(nullable: false),
                        NgayCapNhat = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.NguoiDungs",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        HoVaTen = c.String(),
                        TenDangNhap = c.String(),
                        MatKhau = c.String(),
                        NgaySinh = c.DateTime(nullable: false),
                        DienThoai = c.String(),
                        Email = c.String(),
                        DiaChi = c.String(),
                        GioiTinh = c.Int(nullable: false),
                        NgayTao = c.DateTime(nullable: false),
                        NgayCapNhat = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Saches",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        TenSach = c.String(),
                        TacGia = c.String(),
                        NhaXuatBan = c.String(),
                        NamXuatBan = c.Int(nullable: false),
                        DonGia = c.Int(nullable: false),
                        SoLuong = c.Int(nullable: false),
                        NgayTao = c.DateTime(nullable: false),
                        NgayCapNhat = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tras",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        MuonID = c.Int(nullable: false),
                        NgayTra = c.DateTime(nullable: false),
                        TienPhat = c.Int(nullable: false),
                        NgayTao = c.DateTime(nullable: false),
                        NgayCapNhat = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tras");
            DropTable("dbo.Saches");
            DropTable("dbo.NguoiDungs");
            DropTable("dbo.Muons");
            DropTable("dbo.DocGias");
        }
    }
}
