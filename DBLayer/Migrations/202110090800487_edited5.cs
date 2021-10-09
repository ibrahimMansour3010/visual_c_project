namespace DBLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class edited5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "Name", c => c.String(maxLength: 50, unicode: true));
            AlterColumn("dbo.Items", "Name", c => c.String(maxLength: 50, unicode: true));
            AlterColumn("dbo.Stocks", "Name", c => c.String(maxLength: 50, unicode: true));
            CreateIndex("dbo.Categories", "Name", unique: true);
            CreateIndex("dbo.Items", "Name", unique: true);
            CreateIndex("dbo.Stocks", "Name", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Stocks", new[] { "Name" });
            DropIndex("dbo.Items", new[] { "Name" });
            DropIndex("dbo.Categories", new[] { "Name" });
            AlterColumn("dbo.Stocks", "Name", c => c.String());
            AlterColumn("dbo.Items", "Name", c => c.String());
            AlterColumn("dbo.Categories", "Name", c => c.String());
        }
    }
}
