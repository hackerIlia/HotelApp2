﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace HotelApp2.Models;

public partial class HCleaning
{
    public int Id { get; set; }

    public byte UserId { get; set; }

    public DateTime Date { get; set; }

    public short RoomId { get; set; }

    public virtual HRoom Room { get; set; }

    public virtual HUser User { get; set; }
}