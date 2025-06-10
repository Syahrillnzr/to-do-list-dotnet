namespace To_do_list_Dotnet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStartDateToTodoItem : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TodoItems", "TaskName", c => c.String());
            AddColumn("dbo.TodoItems", "TaskDesc", c => c.String());
            AddColumn("dbo.TodoItems", "DateStart", c => c.DateTime(nullable: false));
            AddColumn("dbo.TodoItems", "DateEnd", c => c.DateTime(nullable: false));
            DropColumn("dbo.TodoItems", "Task");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TodoItems", "Task", c => c.String());
            DropColumn("dbo.TodoItems", "DateEnd");
            DropColumn("dbo.TodoItems", "DateStart");
            DropColumn("dbo.TodoItems", "TaskDesc");
            DropColumn("dbo.TodoItems", "TaskName");
        }
    }
}
