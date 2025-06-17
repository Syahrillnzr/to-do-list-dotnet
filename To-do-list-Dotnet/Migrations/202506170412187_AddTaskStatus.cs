namespace To_do_list_Dotnet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTaskStatus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TodoItems", "TaskStatus", c => c.Int(nullable: false));
            DropColumn("dbo.TodoItems", "IsDone");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TodoItems", "IsDone", c => c.Boolean(nullable: false));
            DropColumn("dbo.TodoItems", "TaskStatus");
        }
    }
}
