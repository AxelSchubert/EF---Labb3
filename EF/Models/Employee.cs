using System;
using System.Collections.Generic;

namespace EF.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string FullName { get; set; } = null!;

    public string Occupation { get; set; } = null!;

    public string? ContactInfo { get; set; }

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
}
