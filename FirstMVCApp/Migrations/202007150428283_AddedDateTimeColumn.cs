namespace FirstMVCApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDateTimeColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.KanbanCard", "DeadlineDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.KanbanCard", "DeadlineDate");
        }
    }
}
