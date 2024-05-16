using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelApp2.Migrations
{
    /// <inheritdoc />
    public partial class Hotel_DBContext_Migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "H_d_AvailabilityStatuses",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusName = table.Column<string>(type: "varchar(9)", unicode: false, maxLength: 9, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__H_d_Avai__3214EC0786D3303E", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "H_d_BookingStatuses",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_H_d_BookingStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "H_d_CleaningStatuses",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(9)", unicode: false, maxLength: 9, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__H_d_Clea__3214EC0703801B84", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "H_d_Countries",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_H_d_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "H_d_FeedbackStatuses",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_H_d_FeedbackStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "H_d_LivingStatuses",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_H_d_LivingStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "H_d_PaymentMethods",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(9)", unicode: false, maxLength: 9, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__H_d_Paym__3214EC0717517676", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "H_d_PaymentStatuses",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__H_d_Paym__3214EC07C7AD45A9", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "H_d_SalaryStatuses",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_H_d_SalaryStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "H_d_UserRoles",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_H_d_UserRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "H_StaffFunction",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    SalaryRate = table.Column<decimal>(type: "numeric(5,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__H_StaffF__3214EC07138C2955", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HDRoomTypes",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Capacity = table.Column<byte>(type: "tinyint", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HDRoomTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "H_GuestBooking",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PassportNumber = table.Column<string>(type: "varchar(9)", unicode: false, maxLength: 9, nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CountryId = table.Column<byte>(type: "tinyint", nullable: false),
                    City = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_H_GuestBooking", x => x.Id);
                    table.ForeignKey(
                        name: "FK_H_GuestBooking_H_d_Countries",
                        column: x => x.CountryId,
                        principalTable: "H_d_Countries",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "H_GuestLiving",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PassportNumber = table.Column<string>(type: "varchar(9)", unicode: false, maxLength: 9, nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CountryId = table.Column<byte>(type: "tinyint", nullable: false),
                    City = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_H_GuestLiving", x => x.Id);
                    table.ForeignKey(
                        name: "FK_H_GuestLiving_H_d_Countries",
                        column: x => x.CountryId,
                        principalTable: "H_d_Countries",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "H_Hotel",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Phone = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    CountryId = table.Column<byte>(type: "tinyint", nullable: false),
                    City = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__H_Hotel__3214EC07D8361C31", x => x.Id);
                    table.ForeignKey(
                        name: "FK_H_Hotel_H_d_Countries",
                        column: x => x.CountryId,
                        principalTable: "H_d_Countries",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "H_Staff",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: true),
                    IDNP = table.Column<string>(type: "varchar(13)", unicode: false, maxLength: 13, nullable: true),
                    PassportNumber = table.Column<string>(type: "varchar(9)", unicode: false, maxLength: 9, nullable: false),
                    Phone = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    FunctionId = table.Column<byte>(type: "tinyint", nullable: false),
                    HireDate = table.Column<DateTime>(type: "date", nullable: false),
                    HotelId = table.Column<byte>(type: "tinyint", nullable: false),
                    NrContract = table.Column<short>(name: "Nr.Contract", type: "smallint", nullable: false),
                    CountryId = table.Column<byte>(type: "tinyint", nullable: false),
                    City = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__H_Staff__3214EC07309C16B8", x => x.Id);
                    table.ForeignKey(
                        name: "FK_H_Staff_H_d_Countries",
                        column: x => x.CountryId,
                        principalTable: "H_d_Countries",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__H_Staff__IdFunct__3A81B327",
                        column: x => x.FunctionId,
                        principalTable: "H_StaffFunction",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__H_Staff__IdHotel__3D5E1FD2",
                        column: x => x.HotelId,
                        principalTable: "H_Hotel",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HRooms",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AvailabilityStatusId = table.Column<byte>(type: "tinyint", nullable: false),
                    CleaningStatusId = table.Column<byte>(type: "tinyint", nullable: false),
                    TypeId = table.Column<byte>(type: "tinyint", nullable: false),
                    HotelId = table.Column<byte>(type: "tinyint", nullable: false),
                    Etaj = table.Column<byte>(type: "tinyint", nullable: false),
                    NrRooms = table.Column<byte>(type: "tinyint", nullable: false),
                    HDRoomTypeId = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HRooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HRooms_HDRoomTypes_HDRoomTypeId",
                        column: x => x.HDRoomTypeId,
                        principalTable: "HDRoomTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HRooms_H_Hotel_HotelId",
                        column: x => x.HotelId,
                        principalTable: "H_Hotel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HRooms_H_d_AvailabilityStatuses_AvailabilityStatusId",
                        column: x => x.AvailabilityStatusId,
                        principalTable: "H_d_AvailabilityStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HRooms_H_d_CleaningStatuses_CleaningStatusId",
                        column: x => x.CleaningStatusId,
                        principalTable: "H_d_CleaningStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "H_AttendanceOperation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnterDate = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    ExitDate = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    StaffId = table.Column<short>(type: "smallint", nullable: false),
                    WorkedHours = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__H_Attend__3214EC0756AD179C", x => x.Id);
                    table.ForeignKey(
                        name: "FK__H_Attenda__IdSta__59FA5E80",
                        column: x => x.StaffId,
                        principalTable: "H_Staff",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "H_Salary",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(type: "numeric(8,2)", nullable: true),
                    StaffId = table.Column<short>(type: "smallint", nullable: false),
                    StatusId = table.Column<byte>(type: "tinyint", nullable: false),
                    DateModified = table.Column<DateTime>(type: "smalldatetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_H_Salary", x => x.Id);
                    table.ForeignKey(
                        name: "FK_H_Salary_H_Staff",
                        column: x => x.StaffId,
                        principalTable: "H_Staff",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_H_Salary_H_d_SalaryStatuses",
                        column: x => x.StatusId,
                        principalTable: "H_d_SalaryStatuses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "H_Users",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    Password = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    StaffId = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__H_UserHo__3214EC0746BFC850", x => x.Id);
                    table.ForeignKey(
                        name: "FK_H_UserHotel_H_Staff",
                        column: x => x.StaffId,
                        principalTable: "H_Staff",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "H_Booking",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    CheckInDate = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    CheckOutDate = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    Amount = table.Column<decimal>(type: "numeric(8,2)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    RoomId = table.Column<short>(type: "smallint", nullable: false),
                    StatusId = table.Column<byte>(type: "tinyint", nullable: false),
                    GuestId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__H_Bookin__3214EC070B9D7CEA", x => x.Id);
                    table.ForeignKey(
                        name: "FK_H_Booking_H_Booking",
                        column: x => x.GuestId,
                        principalTable: "H_GuestBooking",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_H_Booking_H_d_BookingStatuses",
                        column: x => x.StatusId,
                        principalTable: "H_d_BookingStatuses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__H_Booking__IdRoo__4AB81AF0",
                        column: x => x.RoomId,
                        principalTable: "HRooms",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "H_c_UserRoles",
                columns: table => new
                {
                    IdUser = table.Column<byte>(type: "tinyint", nullable: false),
                    IdRole = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_H_c_UserRoles", x => new { x.IdUser, x.IdRole });
                    table.ForeignKey(
                        name: "FK_H_c_UserRoles_H_Users",
                        column: x => x.IdUser,
                        principalTable: "H_Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_H_c_UserRoles_H_d_UserRoles",
                        column: x => x.IdRole,
                        principalTable: "H_d_UserRoles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "H_Cleaning",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<byte>(type: "tinyint", nullable: false),
                    Date = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    RoomId = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_H_Cleaning", x => x.Id);
                    table.ForeignKey(
                        name: "FK_H_Cleaning_H_Room",
                        column: x => x.RoomId,
                        principalTable: "HRooms",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_H_Cleaning_H_UserHotel",
                        column: x => x.UserId,
                        principalTable: "H_Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "H_Feedback",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Date = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    StatusId = table.Column<byte>(type: "tinyint", nullable: false),
                    Rate = table.Column<byte>(type: "tinyint", nullable: false),
                    UserId = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__H_Feedba__3214EC07719CC297", x => x.Id);
                    table.ForeignKey(
                        name: "FK_H_Feedback_H_Feedback",
                        column: x => x.StatusId,
                        principalTable: "H_d_FeedbackStatuses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_H_Feedback_H_Users",
                        column: x => x.UserId,
                        principalTable: "H_Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "H_UsersAction",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Date = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    UserId = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__H_Action__3214EC07A009E948", x => x.Id);
                    table.ForeignKey(
                        name: "FK__H_ActionU__IdUse__571DF1D5",
                        column: x => x.UserId,
                        principalTable: "H_Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "H_Living",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    CheckInDate = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    CheckOutDate = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    Amount = table.Column<decimal>(type: "numeric(8,2)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    RoomId = table.Column<short>(type: "smallint", nullable: false),
                    StatusId = table.Column<byte>(type: "tinyint", nullable: false),
                    BookingId = table.Column<int>(type: "int", nullable: true),
                    GuestId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_H_Living", x => x.Id);
                    table.ForeignKey(
                        name: "FK_H_Living_H_Booking",
                        column: x => x.BookingId,
                        principalTable: "H_Booking",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_H_Living_H_GuestLiving",
                        column: x => x.GuestId,
                        principalTable: "H_GuestLiving",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_H_Living_H_Room",
                        column: x => x.RoomId,
                        principalTable: "HRooms",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_H_Living_H_d_LivingStatuses",
                        column: x => x.StatusId,
                        principalTable: "H_d_LivingStatuses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "H_Payment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MethodId = table.Column<byte>(type: "tinyint", nullable: false),
                    StatusId = table.Column<byte>(type: "tinyint", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Amount = table.Column<decimal>(type: "numeric(8,2)", nullable: true),
                    BookingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__H_Paymen__3214EC07C8F99E29", x => x.Id);
                    table.ForeignKey(
                        name: "FK__H_Payment__IdBoo__6383C8BA",
                        column: x => x.BookingId,
                        principalTable: "H_Booking",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__H_Payment__Payme__60A75C0F",
                        column: x => x.MethodId,
                        principalTable: "H_d_PaymentMethods",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__H_Payment__Payme__619B8048",
                        column: x => x.StatusId,
                        principalTable: "H_d_PaymentStatuses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "H_FeedbackAnswer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Date = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    FeedbackId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__H_Feedba__3214EC07220CBDA6", x => x.Id);
                    table.ForeignKey(
                        name: "FK__H_Feedbac__IdFee__66603565",
                        column: x => x.FeedbackId,
                        principalTable: "H_Feedback",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__H_Feedbac__IdUse__6754599E",
                        column: x => x.UserId,
                        principalTable: "H_Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_H_AttendanceOperation_StaffId",
                table: "H_AttendanceOperation",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_H_Booking_GuestId",
                table: "H_Booking",
                column: "GuestId");

            migrationBuilder.CreateIndex(
                name: "IX_H_Booking_RoomId",
                table: "H_Booking",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_H_Booking_StatusId",
                table: "H_Booking",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_H_c_UserRoles_IdRole",
                table: "H_c_UserRoles",
                column: "IdRole");

            migrationBuilder.CreateIndex(
                name: "IX_H_Cleaning_RoomId",
                table: "H_Cleaning",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_H_Cleaning_UserId",
                table: "H_Cleaning",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_H_Feedback_StatusId",
                table: "H_Feedback",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_H_Feedback_UserId",
                table: "H_Feedback",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_H_FeedbackAnswer_FeedbackId",
                table: "H_FeedbackAnswer",
                column: "FeedbackId");

            migrationBuilder.CreateIndex(
                name: "IX_H_FeedbackAnswer_UserId",
                table: "H_FeedbackAnswer",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_H_GuestBooking_CountryId",
                table: "H_GuestBooking",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_H_GuestLiving_CountryId",
                table: "H_GuestLiving",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_H_Hotel_CountryId",
                table: "H_Hotel",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "UQ__H_Hotel__5C7E359E32AAA165",
                table: "H_Hotel",
                column: "Phone",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_H_Living_BookingId",
                table: "H_Living",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_H_Living_GuestId",
                table: "H_Living",
                column: "GuestId");

            migrationBuilder.CreateIndex(
                name: "IX_H_Living_RoomId",
                table: "H_Living",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_H_Living_StatusId",
                table: "H_Living",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_H_Payment_BookingId",
                table: "H_Payment",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_H_Payment_MethodId",
                table: "H_Payment",
                column: "MethodId");

            migrationBuilder.CreateIndex(
                name: "IX_H_Payment_StatusId",
                table: "H_Payment",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_H_Salary_StaffId",
                table: "H_Salary",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_H_Salary_StatusId",
                table: "H_Salary",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_H_Staff_CountryId",
                table: "H_Staff",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_H_Staff_FunctionId",
                table: "H_Staff",
                column: "FunctionId");

            migrationBuilder.CreateIndex(
                name: "IX_H_Staff_HotelId",
                table: "H_Staff",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "UQ__H_Staff__45809E710E3DCE59",
                table: "H_Staff",
                column: "PassportNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__H_Staff__5C7E359E17539529",
                table: "H_Staff",
                column: "Phone",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__H_Staff__B87DC94DE5F86280",
                table: "H_Staff",
                column: "IDNP",
                unique: true,
                filter: "[IDNP] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UQ__H_StaffF__7A54611B6CFEEF65",
                table: "H_StaffFunction",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_H_Users_StaffId",
                table: "H_Users",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "UQ__H_UserHo__4156FB312BB59C60",
                table: "H_Users",
                column: "Login",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_H_UsersAction_UserId",
                table: "H_UsersAction",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_HRooms_AvailabilityStatusId",
                table: "HRooms",
                column: "AvailabilityStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_HRooms_CleaningStatusId",
                table: "HRooms",
                column: "CleaningStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_HRooms_HDRoomTypeId",
                table: "HRooms",
                column: "HDRoomTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_HRooms_HotelId",
                table: "HRooms",
                column: "HotelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "H_AttendanceOperation");

            migrationBuilder.DropTable(
                name: "H_c_UserRoles");

            migrationBuilder.DropTable(
                name: "H_Cleaning");

            migrationBuilder.DropTable(
                name: "H_FeedbackAnswer");

            migrationBuilder.DropTable(
                name: "H_Living");

            migrationBuilder.DropTable(
                name: "H_Payment");

            migrationBuilder.DropTable(
                name: "H_Salary");

            migrationBuilder.DropTable(
                name: "H_UsersAction");

            migrationBuilder.DropTable(
                name: "H_d_UserRoles");

            migrationBuilder.DropTable(
                name: "H_Feedback");

            migrationBuilder.DropTable(
                name: "H_GuestLiving");

            migrationBuilder.DropTable(
                name: "H_d_LivingStatuses");

            migrationBuilder.DropTable(
                name: "H_Booking");

            migrationBuilder.DropTable(
                name: "H_d_PaymentMethods");

            migrationBuilder.DropTable(
                name: "H_d_PaymentStatuses");

            migrationBuilder.DropTable(
                name: "H_d_SalaryStatuses");

            migrationBuilder.DropTable(
                name: "H_d_FeedbackStatuses");

            migrationBuilder.DropTable(
                name: "H_Users");

            migrationBuilder.DropTable(
                name: "H_GuestBooking");

            migrationBuilder.DropTable(
                name: "H_d_BookingStatuses");

            migrationBuilder.DropTable(
                name: "HRooms");

            migrationBuilder.DropTable(
                name: "H_Staff");

            migrationBuilder.DropTable(
                name: "HDRoomTypes");

            migrationBuilder.DropTable(
                name: "H_d_AvailabilityStatuses");

            migrationBuilder.DropTable(
                name: "H_d_CleaningStatuses");

            migrationBuilder.DropTable(
                name: "H_StaffFunction");

            migrationBuilder.DropTable(
                name: "H_Hotel");

            migrationBuilder.DropTable(
                name: "H_d_Countries");
        }
    }
}
