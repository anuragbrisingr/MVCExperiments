namespace FirstMVCApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedKanbanBoardAndOneToManyWithColumn : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KanbanBoard",
                c => new
                    {
                        KanbanBoardID = c.Guid(nullable: false),
                        KanbanBoardName = c.String(nullable: false, maxLength: 25),
                    })
                .PrimaryKey(t => t.KanbanBoardID);
            
            AddColumn("dbo.KanbanColumn", "KanbanBoardId", c => c.Guid(nullable: false));
            CreateIndex("dbo.KanbanColumn", "KanbanBoardId");
            AddForeignKey("dbo.KanbanColumn", "KanbanBoardId", "dbo.KanbanBoard", "KanbanBoardID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.KanbanColumn", "KanbanBoardId", "dbo.KanbanBoard");
            DropIndex("dbo.KanbanColumn", new[] { "KanbanBoardId" });
            DropColumn("dbo.KanbanColumn", "KanbanBoardId");
            DropTable("dbo.KanbanBoard");
        }
    }
}
