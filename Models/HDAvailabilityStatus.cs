﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace HotelApp2.Models;

public partial class HDAvailabilityStatus
{
    public byte Id { get; set; }

    public string StatusName { get; set; }

    public virtual ICollection<HRoom> HRooms { get; set; } = new List<HRoom>();
}