﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DMA_AU24_LAB2_Group4.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Concerts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Concerts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Performances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PerformanceDateAndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Venue = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ConcertId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Performances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Performances_Concerts_ConcertId",
                        column: x => x.ConcertId,
                        principalTable: "Concerts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PerformanceId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bookings_Performances_PerformanceId",
                        column: x => x.PerformanceId,
                        principalTable: "Performances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Concerts",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { 1, "Experience the best of Ed Sheeran live!", "Ed Sheeran World Tour" },
                    { 2, "A musical journey through Taylor Swift's iconic albums.", "Taylor Swift Eras Tour" },
                    { 3, "Kendrick in his absolute prime, destroying his enemies.", "Kendrick Lamar GNX Summer World Tour" },
                    { 4, "Bruno Mars isn't just a performer; he's a showman. His world tours are legendary, delivering unforgettable experiences that blend incredible musicianship, dazzling choreography, and a pure party atmosphere.", "Bruno Mars Die With A Smile World Tour" },
                    { 5, "A celebration of Beyoncé's iconic Renaissance album.", "Beyoncé Renaissance World Tour" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Password" },
                values: new object[,]
                {
                    { 1, "john.doe@example.com", "John", "Doe", "hashed_password_1" },
                    { 2, "jane.smith@example.com", "Jane", "Smith", "hashed_password_2" }
                });

            migrationBuilder.InsertData(
                table: "Performances",
                columns: new[] { "Id", "City", "ConcertId", "Country", "PerformanceDateAndTime", "Venue" },
                values: new object[,]
                {
                    { 1, "New York", 1, "USA", new DateTime(2025, 6, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), "Madison Square Garden" },
                    { 2, "Los Angeles", 1, "USA", new DateTime(2025, 6, 3, 20, 0, 0, 0, DateTimeKind.Unspecified), "Staples Center" },
                    { 3, "Stockholm", 1, "Sweden", new DateTime(2025, 6, 5, 18, 0, 0, 0, DateTimeKind.Unspecified), "Globen" },
                    { 4, "London", 2, "UK", new DateTime(2025, 7, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), "Wembley Stadium" },
                    { 5, "London", 2, "UK", new DateTime(2025, 7, 12, 19, 0, 0, 0, DateTimeKind.Unspecified), "O2 Arena" },
                    { 6, "Berlin", 2, "Germany", new DateTime(2025, 8, 15, 20, 0, 0, 0, DateTimeKind.Unspecified), "Olympiastadion" },
                    { 7, "Paris", 3, "France", new DateTime(2025, 8, 17, 20, 0, 0, 0, DateTimeKind.Unspecified), "Stade de France" },
                    { 8, "Mexico City", 3, "Mexico", new DateTime(2025, 9, 20, 19, 0, 0, 0, DateTimeKind.Unspecified), "Estadio Azteca" },
                    { 9, "Santiago", 3, "Chile", new DateTime(2025, 9, 22, 20, 0, 0, 0, DateTimeKind.Unspecified), "Estadio Monumental" },
                    { 10, "Milano", 4, "Italy", new DateTime(2025, 10, 22, 20, 0, 0, 0, DateTimeKind.Unspecified), "San Siro" },
                    { 11, "Rome", 4, "Italy", new DateTime(2025, 10, 24, 20, 0, 0, 0, DateTimeKind.Unspecified), "Stadio Olimpico" },
                    { 12, "Lisbon", 5, "Portugal", new DateTime(2025, 11, 22, 20, 0, 0, 0, DateTimeKind.Unspecified), "Estádio da Luz" },
                    { 13, "Barcelona", 5, "Spain", new DateTime(2025, 11, 24, 20, 0, 0, 0, DateTimeKind.Unspecified), "Estadi Olímpic Lluís Companys" },
                    { 14, "Porto", 5, "Portugal", new DateTime(2025, 12, 22, 20, 0, 0, 0, DateTimeKind.Unspecified), "Estádio do Dragão" }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "CustomerId", "PerformanceId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 3 },
                    { 3, 1, 4 },
                    { 4, 2, 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_CustomerId",
                table: "Bookings",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_PerformanceId",
                table: "Bookings",
                column: "PerformanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Performances_ConcertId",
                table: "Performances",
                column: "ConcertId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Performances");

            migrationBuilder.DropTable(
                name: "Concerts");
        }
    }
}