namespace FirstMVCApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedProgressPercentage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.KanbanCard", "ProgressPercentage", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.KanbanCard", "ProgressPercentage");
        }
    }
}
