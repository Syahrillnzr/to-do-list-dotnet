namespace To_do_list_Dotnet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakeDatesNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TodoItems", "DateStart", c => c.DateTime());
            AlterColumn("dbo.TodoItems", "DateEnd", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TodoItems", "DateEnd", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TodoItems", "DateStart", c => c.DateTime(nullable: false));
        }
    }
}
