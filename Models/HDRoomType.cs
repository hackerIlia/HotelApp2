﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotelApp2.Models;

public partial class HDRoomType
{
    public byte Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    [Range(1,5,ErrorMessage = "Capacity can be from 1 up to 5 people")]
    public byte Capacity { get; set; }
    [Required]
    [Range(0.01, (double)decimal.MaxValue, ErrorMessage = "Price can't be equal to zero")]
    public decimal Price { get; set; }
}