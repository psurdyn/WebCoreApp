using System;
using System.Collections.Generic;

namespace StudentsApp.Backend.Models
{
    public partial class Student
    {
        public int IdStudent { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IndexNumber { get; set; }
    }
}
