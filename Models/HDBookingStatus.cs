﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace HotelApp2.Models;

public partial class HDBookingStatus
{
    public byte Id { get; set; }

    public string Name { get; set; }

    public virtual ICollection<HBooking> HBookings { get; set; } = new List<HBooking>();
}