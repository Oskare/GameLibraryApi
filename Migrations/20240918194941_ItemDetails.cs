using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GameLibraryApi.Migrations
{
    /// <inheritdoc />
    public partial class ItemDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ItemDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ItemId = table.Column<int>(type: "integer", nullable: false),
                    Detail = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemDetails", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b5046a9-d8b8-4a3f-b6c3-4413303b937a", "AQAAAAIAAYagAAAAEB7eVEPjskDS2SrvyruNXCmjQn61wjUCJwfiIFwX9gc7ubEPVl3BHcOArm8YyhmPXQ==", "efebf897-daa8-4166-b853-c6a162080300" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 18, 19, 49, 40, 700, DateTimeKind.Utc).AddTicks(8350), new DateTime(2024, 9, 18, 19, 49, 40, 700, DateTimeKind.Utc).AddTicks(8353) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 18, 19, 49, 40, 700, DateTimeKind.Utc).AddTicks(8366), new DateTime(2024, 9, 18, 19, 49, 40, 700, DateTimeKind.Utc).AddTicks(8367) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 18, 19, 49, 40, 700, DateTimeKind.Utc).AddTicks(8377), new DateTime(2024, 9, 18, 19, 49, 40, 700, DateTimeKind.Utc).AddTicks(8377) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 18, 19, 49, 40, 700, DateTimeKind.Utc).AddTicks(8388), new DateTime(2024, 9, 18, 19, 49, 40, 700, DateTimeKind.Utc).AddTicks(8388) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 18, 19, 49, 40, 700, DateTimeKind.Utc).AddTicks(8400), new DateTime(2024, 9, 18, 19, 49, 40, 700, DateTimeKind.Utc).AddTicks(8400) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 18, 19, 49, 40, 700, DateTimeKind.Utc).AddTicks(8415), new DateTime(2024, 9, 18, 19, 49, 40, 700, DateTimeKind.Utc).AddTicks(8416) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 18, 19, 49, 40, 700, DateTimeKind.Utc).AddTicks(8427), new DateTime(2024, 9, 18, 19, 49, 40, 700, DateTimeKind.Utc).AddTicks(8427) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 18, 19, 49, 40, 700, DateTimeKind.Utc).AddTicks(8472), new DateTime(2024, 9, 18, 19, 49, 40, 700, DateTimeKind.Utc).AddTicks(8472) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 18, 19, 49, 40, 700, DateTimeKind.Utc).AddTicks(8483), new DateTime(2024, 9, 18, 19, 49, 40, 700, DateTimeKind.Utc).AddTicks(8483) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 18, 19, 49, 40, 700, DateTimeKind.Utc).AddTicks(8495), new DateTime(2024, 9, 18, 19, 49, 40, 700, DateTimeKind.Utc).AddTicks(8495) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemDetails");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ee9da16-97f0-44ae-a7fa-842d69c65dc9", "AQAAAAIAAYagAAAAEOGW8Vk/NajjpWbPtp56pg2Sv6WO7T2yHXptoDgfYfmlTcly3zvdrMLZI6L7OF9lvQ==", "43116597-151d-411e-8953-a5d897ed780e" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 18, 18, 4, 0, 291, DateTimeKind.Utc).AddTicks(4705), new DateTime(2024, 9, 18, 18, 4, 0, 291, DateTimeKind.Utc).AddTicks(4708) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 18, 18, 4, 0, 291, DateTimeKind.Utc).AddTicks(4721), new DateTime(2024, 9, 18, 18, 4, 0, 291, DateTimeKind.Utc).AddTicks(4722) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 18, 18, 4, 0, 291, DateTimeKind.Utc).AddTicks(4790), new DateTime(2024, 9, 18, 18, 4, 0, 291, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 18, 18, 4, 0, 291, DateTimeKind.Utc).AddTicks(4803), new DateTime(2024, 9, 18, 18, 4, 0, 291, DateTimeKind.Utc).AddTicks(4803) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 18, 18, 4, 0, 291, DateTimeKind.Utc).AddTicks(4816), new DateTime(2024, 9, 18, 18, 4, 0, 291, DateTimeKind.Utc).AddTicks(4816) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 18, 18, 4, 0, 291, DateTimeKind.Utc).AddTicks(4836), new DateTime(2024, 9, 18, 18, 4, 0, 291, DateTimeKind.Utc).AddTicks(4836) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 18, 18, 4, 0, 291, DateTimeKind.Utc).AddTicks(4848), new DateTime(2024, 9, 18, 18, 4, 0, 291, DateTimeKind.Utc).AddTicks(4849) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 18, 18, 4, 0, 291, DateTimeKind.Utc).AddTicks(4859), new DateTime(2024, 9, 18, 18, 4, 0, 291, DateTimeKind.Utc).AddTicks(4860) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 18, 18, 4, 0, 291, DateTimeKind.Utc).AddTicks(4870), new DateTime(2024, 9, 18, 18, 4, 0, 291, DateTimeKind.Utc).AddTicks(4870) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 18, 18, 4, 0, 291, DateTimeKind.Utc).AddTicks(4882), new DateTime(2024, 9, 18, 18, 4, 0, 291, DateTimeKind.Utc).AddTicks(4883) });
        }
    }
}
