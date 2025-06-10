using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace To_do_list_Dotnet.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public string TaskDesc { get; set; }
        public bool IsDone { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
    }
}