﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace HotelApp2.Models;

public partial class HDSalaryStatus
{
    public byte Id { get; set; }

    public string Name { get; set; }

    public virtual ICollection<HSalary> HSalaries { get; set; } = new List<HSalary>();
}