using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace To_do_list_Dotnet.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<TodoItem> TodoItems { get; set; }

        public ApplicationDbContext() : base("MyTodoListConnection") { }
    }
}