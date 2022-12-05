namespace Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTableSachMuon : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SachMuons",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        MaSach = c.Long(nullable: false),
                        MaDocGia = c.Long(nullable: false),
                        SoLuong = c.Int(nullable: false),
                        NgayTao = c.DateTime(nullable: false),
                        NgayCapNhat = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SachMuons");
        }
    }
}
