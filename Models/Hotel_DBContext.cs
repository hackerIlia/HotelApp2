﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HotelApp2.Models;

public partial class Hotel_DBContext : DbContext
{
    public Hotel_DBContext(DbContextOptions<Hotel_DBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<HAttendanceOperation> HAttendanceOperations { get; set; }

    public virtual DbSet<HBooking> HBookings { get; set; }

    public virtual DbSet<HCleaning> HCleanings { get; set; }

    public virtual DbSet<HDAvailabilityStatus> HDAvailabilityStatuses { get; set; }

    public virtual DbSet<HDBookingStatus> HDBookingStatuses { get; set; }

    public virtual DbSet<HDCleaningStatus> HDCleaningStatuses { get; set; }

    public virtual DbSet<HDCountry> HDCountries { get; set; }

    public virtual DbSet<HDFeedbackStatus> HDFeedbackStatuses { get; set; }

    public virtual DbSet<HDLivingStatus> HDLivingStatuses { get; set; }

    public virtual DbSet<HDPaymentMethod> HDPaymentMethods { get; set; }

    public virtual DbSet<HDPaymentStatus> HDPaymentStatuses { get; set; }

    public virtual DbSet<HDRoomType> HDRoomTypes { get; set; }

    public virtual DbSet<HDSalaryStatus> HDSalaryStatuses { get; set; }

    public virtual DbSet<HDUserRole> HDUserRoles { get; set; }

    public virtual DbSet<HFeedback> HFeedbacks { get; set; }

    public virtual DbSet<HFeedbackAnswer> HFeedbackAnswers { get; set; }

    public virtual DbSet<HGuestBooking> HGuestBookings { get; set; }

    public virtual DbSet<HGuestLiving> HGuestLivings { get; set; }

    public virtual DbSet<HHotel> HHotels { get; set; }

    public virtual DbSet<HLiving> HLivings { get; set; }

    public virtual DbSet<HPayment> HPayments { get; set; }

    public virtual DbSet<HRoom> HRooms { get; set; }

    public virtual DbSet<HSalary> HSalaries { get; set; }

    public virtual DbSet<HStaff> HStaffs { get; set; }

    public virtual DbSet<HStaffFunction> HStaffFunctions { get; set; }

    public virtual DbSet<HUser> HUsers { get; set; }

    public virtual DbSet<HUsersAction> HUsersActions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<HAttendanceOperation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__H_Attend__3214EC0756AD179C");

            entity.ToTable("H_AttendanceOperation");

            entity.Property(e => e.EnterDate).HasColumnType("smalldatetime");
            entity.Property(e => e.ExitDate).HasColumnType("smalldatetime");

            entity.HasOne(d => d.Staff).WithMany(p => p.HAttendanceOperations)
                .HasForeignKey(d => d.StaffId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__H_Attenda__IdSta__59FA5E80");
        });

        modelBuilder.Entity<HBooking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__H_Bookin__3214EC070B9D7CEA");

            entity.ToTable("H_Booking");

            entity.Property(e => e.Amount).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.CheckInDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CheckOutDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Comments).HasMaxLength(256);

            entity.HasOne(d => d.Guest).WithMany(p => p.HBookings)
                .HasForeignKey(d => d.GuestId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_H_Booking_H_Booking");

            entity.HasOne(d => d.Room).WithMany(p => p.HBookings)
                .HasForeignKey(d => d.RoomId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__H_Booking__IdRoo__4AB81AF0");

            entity.HasOne(d => d.Status).WithMany(p => p.HBookings)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_H_Booking_H_d_BookingStatuses");
        });

        modelBuilder.Entity<HCleaning>(entity => 
        {
            entity.HasKey(e => e.Id).HasName("PK_H_Cleaning");

            entity.ToTable("H_Cleaning");

            entity.Property(e => e.Date).HasColumnType("smalldatetime");

            entity.HasOne(d => d.Room).WithMany(p => p.HCleanings)
                .HasForeignKey(d => d.RoomId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_H_Cleaning_H_Room");

            entity.HasOne(d => d.User).WithMany(p => p.HCleanings)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_H_Cleaning_H_UserHotel");
        });

        modelBuilder.Entity<HDAvailabilityStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__H_d_Avai__3214EC0786D3303E");

            entity.ToTable("H_d_AvailabilityStatuses");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.StatusName)
                .HasMaxLength(9)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HDBookingStatus>(entity =>
        {
            entity.ToTable("H_d_BookingStatuses");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(8)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HDCleaningStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__H_d_Clea__3214EC0703801B84");

            entity.ToTable("H_d_CleaningStatuses");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Name)
                .HasMaxLength(9)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HDCountry>(entity =>
        {
            entity.ToTable("H_d_Countries");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HDFeedbackStatus>(entity =>
        {
            entity.ToTable("H_d_FeedbackStatuses");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HDLivingStatus>(entity =>
        {
            entity.ToTable("H_d_LivingStatuses");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(11)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HDPaymentMethod>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__H_d_Paym__3214EC0717517676");

            entity.ToTable("H_d_PaymentMethods");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Name)
                .HasMaxLength(9)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HDPaymentStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__H_d_Paym__3214EC07C7AD45A9");

            entity.ToTable("H_d_PaymentStatuses");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Name)
                .HasMaxLength(6)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HDRoomType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__H_RoomTy__3214EC07BED2BCC0");

            entity.ToTable("H_d_RoomType");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(18)
                .IsUnicode(false);
            entity.Property(e => e.Price).HasColumnType("numeric(6, 2)");
        });

        modelBuilder.Entity<HDSalaryStatus>(entity =>
        {
            entity.ToTable("H_d_SalaryStatuses");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(8)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HDUserRole>(entity =>
        {
            entity.ToTable("H_d_UserRoles");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(18)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HFeedback>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__H_Feedba__3214EC07719CC297");

            entity.ToTable("H_Feedback");

            entity.Property(e => e.Date).HasColumnType("smalldatetime");
            entity.Property(e => e.Text).HasMaxLength(256);

            entity.HasOne(d => d.Status).WithMany(p => p.HFeedbacks)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_H_Feedback_H_Feedback");

            entity.HasOne(d => d.User).WithMany(p => p.HFeedbacks)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_H_Feedback_H_Users");
        });

        modelBuilder.Entity<HFeedbackAnswer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__H_Feedba__3214EC07220CBDA6");

            entity.ToTable("H_FeedbackAnswer");

            entity.Property(e => e.Date).HasColumnType("smalldatetime");
            entity.Property(e => e.Text).HasMaxLength(256);

            entity.HasOne(d => d.Feedback).WithMany(p => p.HFeedbackAnswers)
                .HasForeignKey(d => d.FeedbackId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__H_Feedbac__IdFee__66603565");

            entity.HasOne(d => d.User).WithMany(p => p.HFeedbackAnswers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__H_Feedbac__IdUse__6754599E");
        });

        modelBuilder.Entity<HGuestBooking>(entity =>
        {
            entity.ToTable("H_GuestBooking");

            entity.Property(e => e.City)
                .IsRequired()
                .HasMaxLength(25);
            entity.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(30);
            entity.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(30);
            entity.Property(e => e.PassportNumber)
                .IsRequired()
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.HasOne(d => d.Country).WithMany(p => p.HGuestBookings)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_H_GuestBooking_H_d_Countries");
        });

        modelBuilder.Entity<HGuestLiving>(entity =>
        {
            entity.ToTable("H_GuestLiving");

            entity.Property(e => e.City)
                .IsRequired()
                .HasMaxLength(25);
            entity.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(30);
            entity.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(30);
            entity.Property(e => e.PassportNumber)
                .IsRequired()
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.HasOne(d => d.Country).WithMany(p => p.HGuestLivings)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_H_GuestLiving_H_d_Countries");
        });

        modelBuilder.Entity<HHotel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__H_Hotel__3214EC07D8361C31");

            entity.ToTable("H_Hotel");

            entity.HasIndex(e => e.Phone, "UQ__H_Hotel__5C7E359E32AAA165").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Address)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.City)
                .IsRequired()
                .HasMaxLength(25);
            entity.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(20);
            entity.Property(e => e.Phone)
                .IsRequired()
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.HasOne(d => d.Country).WithMany(p => p.HHotels)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_H_Hotel_H_d_Countries");
        });

        modelBuilder.Entity<HLiving>(entity =>
        {
            entity.ToTable("H_Living");

            entity.Property(e => e.Amount).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.CheckInDate).HasColumnType("smalldatetime");
            entity.Property(e => e.CheckOutDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Comments).HasMaxLength(256);

            entity.HasOne(d => d.Booking).WithMany(p => p.HLivings)
                .HasForeignKey(d => d.BookingId)
                .HasConstraintName("FK_H_Living_H_Booking");

            entity.HasOne(d => d.Guest).WithMany(p => p.HLivings)
                .HasForeignKey(d => d.GuestId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_H_Living_H_GuestLiving");

            entity.HasOne(d => d.Room).WithMany(p => p.HLivings)
                .HasForeignKey(d => d.RoomId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_H_Living_H_Room");

            entity.HasOne(d => d.Status).WithMany(p => p.HLivings)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_H_Living_H_d_LivingStatuses");
        });

        modelBuilder.Entity<HPayment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__H_Paymen__3214EC07C8F99E29");

            entity.ToTable("H_Payment");

            entity.Property(e => e.Amount).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.Date).HasColumnType("smalldatetime");

            entity.HasOne(d => d.Booking).WithMany(p => p.HPayments)
                .HasForeignKey(d => d.BookingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__H_Payment__IdBoo__6383C8BA");

            entity.HasOne(d => d.Method).WithMany(p => p.HPayments)
                .HasForeignKey(d => d.MethodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__H_Payment__Payme__60A75C0F");

            entity.HasOne(d => d.Status).WithMany(p => p.HPayments)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__H_Payment__Payme__619B8048");
        });

        modelBuilder.Entity<HRoom>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__H_Room__3214EC07FABC2CA1");

            entity.ToTable("H_Room");

            entity.Property(e => e.Number)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.AvailabilityStatus).WithMany(p => p.HRooms)
                .HasForeignKey(d => d.AvailabilityStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__H_Room__Availabi__440B1D61");

            entity.HasOne(d => d.CleaningStatus).WithMany(p => p.HRooms)
                .HasForeignKey(d => d.CleaningStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__H_Room__Cleaning__44FF419A");

            entity.HasOne(d => d.Hotel).WithMany(p => p.HRooms)
                .HasForeignKey(d => d.HotelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__H_Room__IdHotel__46E78A0C");

            entity.HasOne(d => d.Type).WithMany(p => p.HRooms)
                .HasForeignKey(d => d.TypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__H_Room__IdType__45F365D3");
        });

        modelBuilder.Entity<HSalary>(entity =>
        {
            entity.ToTable("H_Salary");

            entity.Property(e => e.Amount).HasColumnType("numeric(8, 2)");
            entity.Property(e => e.DateModified).HasColumnType("smalldatetime");

            entity.HasOne(d => d.Staff).WithMany(p => p.HSalaries)
                .HasForeignKey(d => d.StaffId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_H_Salary_H_Staff");

            entity.HasOne(d => d.Status).WithMany(p => p.HSalaries)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_H_Salary_H_d_SalaryStatuses");
        });

        modelBuilder.Entity<HStaff>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__H_Staff__3214EC07309C16B8");

            entity.ToTable("H_Staff");

            entity.HasIndex(e => e.PassportNumber, "UQ__H_Staff__45809E710E3DCE59").IsUnique();

            entity.HasIndex(e => e.Phone, "UQ__H_Staff__5C7E359E17539529").IsUnique();

            entity.HasIndex(e => e.Idnp, "UQ__H_Staff__B87DC94DE5F86280").IsUnique();

            entity.Property(e => e.Address)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.City)
                .IsRequired()
                .HasMaxLength(25);
            entity.Property(e => e.DateOfBirth).HasColumnType("date");
            entity.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FirstName).HasMaxLength(30);
            entity.Property(e => e.HireDate).HasColumnType("date");
            entity.Property(e => e.Idnp)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("IDNP");
            entity.Property(e => e.LastName).HasMaxLength(30);
            entity.Property(e => e.NrContract).HasColumnName("Nr.Contract");
            entity.Property(e => e.PassportNumber)
                .IsRequired()
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .IsRequired()
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.HasOne(d => d.Country).WithMany(p => p.HStaffs)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_H_Staff_H_d_Countries");

            entity.HasOne(d => d.Function).WithMany(p => p.HStaffs)
                .HasForeignKey(d => d.FunctionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__H_Staff__IdFunct__3A81B327");

            entity.HasOne(d => d.Hotel).WithMany(p => p.HStaffs)
                .HasForeignKey(d => d.HotelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__H_Staff__IdHotel__3D5E1FD2");
        });

        modelBuilder.Entity<HStaffFunction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__H_StaffF__3214EC07138C2955");

            entity.ToTable("H_StaffFunction");

            entity.HasIndex(e => e.Name, "UQ__H_StaffF__7A54611B6CFEEF65").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SalaryRate).HasColumnType("numeric(5, 2)");
        });

        modelBuilder.Entity<HUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__H_UserHo__3214EC0746BFC850");

            entity.ToTable("H_Users");

            entity.HasIndex(e => e.Login, "UQ__H_UserHo__4156FB312BB59C60").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FirstName).HasMaxLength(30);
            entity.Property(e => e.LastName).HasMaxLength(30);
            entity.Property(e => e.Login)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Staff).WithMany(p => p.HUsers)
                .HasForeignKey(d => d.StaffId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_H_UserHotel_H_Staff");

            entity.HasMany(d => d.IdRoles).WithMany(p => p.IdUsers)
                .UsingEntity<Dictionary<string, object>>(
                    "HCUserRole",
                    r => r.HasOne<HDUserRole>().WithMany()
                        .HasForeignKey("IdRole")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_H_c_UserRoles_H_d_UserRoles"),
                    l => l.HasOne<HUser>().WithMany()
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_H_c_UserRoles_H_Users"),
                    j =>
                    {
                        j.HasKey("IdUser", "IdRole");
                        j.ToTable("H_c_UserRoles");
                    });
        });

        modelBuilder.Entity<HUsersAction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__H_Action__3214EC07A009E948");

            entity.ToTable("H_UsersAction");

            entity.Property(e => e.Date).HasColumnType("smalldatetime");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.HasOne(d => d.User).WithMany(p => p.HUsersActions)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__H_ActionU__IdUse__571DF1D5");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}