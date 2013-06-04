namespace ScaffoldTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Manolo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Manoloes",
                c => new
                    {
                        ManoloID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ManoloID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Manoloes");
        }
    }
}
