using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToDoList.Models.DataModels
{
    public class User
    {
        [Key]
        public string EmployeeId { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
    }
}