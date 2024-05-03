﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace HotelApp2.Models;

public partial class HHotel
{
    public byte Id { get; set; }

    public string Name { get; set; }

    public string Phone { get; set; }

    public string Email { get; set; }

    public byte CountryId { get; set; }

    public string City { get; set; }

    public string Address { get; set; }

    public virtual HDCountry Country { get; set; }

    public virtual ICollection<HRoom> HRooms { get; set; } = new List<HRoom>();

    public virtual ICollection<HStaff> HStaffs { get; set; } = new List<HStaff>();
}