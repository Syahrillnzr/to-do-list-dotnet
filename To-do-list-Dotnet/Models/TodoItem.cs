using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace To_do_list_Dotnet.Models
{

    public enum TaskStatus
    {
        [Display(Name = "Not Started")]
        NotStart = 0,

        [Display(Name = "In Progress")]
        InProgress = 1,

        [Display(Name = "Completed")]
        Completed = 2
    }


    public class TodoItem
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public string TaskDesc { get; set; }


        [DataType(DataType.Date)]
        public DateTime? DateStart { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DateEnd { get; set; }

        public TaskStatus TaskStatus { get; set; }
    }
}