using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameLibraryApi.Migrations
{
    /// <inheritdoc />
    public partial class Init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "ItemDetails",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ItemDetails",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27b99ca8-e6b6-4a26-9b55-aa69ac3b2357", "AQAAAAIAAYagAAAAENncquti+HUcF0hocarn5HomnAlwSSLG3rfrlJaZlcBlLEXpvavnQfVpLg9GL+dmfg==", "2b2960e5-46fb-4e40-969d-4471b356a996" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 19, 20, 7, 44, 384, DateTimeKind.Utc).AddTicks(7679), new DateTime(2024, 9, 19, 20, 7, 44, 384, DateTimeKind.Utc).AddTicks(7682) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 19, 20, 7, 44, 384, DateTimeKind.Utc).AddTicks(7736), new DateTime(2024, 9, 19, 20, 7, 44, 384, DateTimeKind.Utc).AddTicks(7736) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 19, 20, 7, 44, 384, DateTimeKind.Utc).AddTicks(7748), new DateTime(2024, 9, 19, 20, 7, 44, 384, DateTimeKind.Utc).AddTicks(7749) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 19, 20, 7, 44, 384, DateTimeKind.Utc).AddTicks(7759), new DateTime(2024, 9, 19, 20, 7, 44, 384, DateTimeKind.Utc).AddTicks(7760) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 19, 20, 7, 44, 384, DateTimeKind.Utc).AddTicks(7773), new DateTime(2024, 9, 19, 20, 7, 44, 384, DateTimeKind.Utc).AddTicks(7773) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 19, 20, 7, 44, 384, DateTimeKind.Utc).AddTicks(7790), new DateTime(2024, 9, 19, 20, 7, 44, 384, DateTimeKind.Utc).AddTicks(7791) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 19, 20, 7, 44, 384, DateTimeKind.Utc).AddTicks(7803), new DateTime(2024, 9, 19, 20, 7, 44, 384, DateTimeKind.Utc).AddTicks(7803) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 19, 20, 7, 44, 384, DateTimeKind.Utc).AddTicks(7813), new DateTime(2024, 9, 19, 20, 7, 44, 384, DateTimeKind.Utc).AddTicks(7814) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 19, 20, 7, 44, 384, DateTimeKind.Utc).AddTicks(7824), new DateTime(2024, 9, 19, 20, 7, 44, 384, DateTimeKind.Utc).AddTicks(7825) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 19, 20, 7, 44, 384, DateTimeKind.Utc).AddTicks(7838), new DateTime(2024, 9, 19, 20, 7, 44, 384, DateTimeKind.Utc).AddTicks(7838) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "ItemDetails",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ItemDetails",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1025c3d1-0289-4356-9be0-1c5a24eacade", "AQAAAAIAAYagAAAAEKcGVX3S272ZO8A4Qf++mSdgrkxcuplaHstSxRvOx9y2UXd9gUykrEZf62fzylRuvg==", "096884d0-6aff-46ec-94c1-c158ddbab6f8" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 19, 19, 59, 27, 693, DateTimeKind.Utc).AddTicks(9013), new DateTime(2024, 9, 19, 19, 59, 27, 693, DateTimeKind.Utc).AddTicks(9016) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 19, 19, 59, 27, 693, DateTimeKind.Utc).AddTicks(9030), new DateTime(2024, 9, 19, 19, 59, 27, 693, DateTimeKind.Utc).AddTicks(9031) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 19, 19, 59, 27, 693, DateTimeKind.Utc).AddTicks(9042), new DateTime(2024, 9, 19, 19, 59, 27, 693, DateTimeKind.Utc).AddTicks(9042) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 19, 19, 59, 27, 693, DateTimeKind.Utc).AddTicks(9056), new DateTime(2024, 9, 19, 19, 59, 27, 693, DateTimeKind.Utc).AddTicks(9056) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 19, 19, 59, 27, 693, DateTimeKind.Utc).AddTicks(9068), new DateTime(2024, 9, 19, 19, 59, 27, 693, DateTimeKind.Utc).AddTicks(9068) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 19, 19, 59, 27, 693, DateTimeKind.Utc).AddTicks(9091), new DateTime(2024, 9, 19, 19, 59, 27, 693, DateTimeKind.Utc).AddTicks(9092) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 19, 19, 59, 27, 693, DateTimeKind.Utc).AddTicks(9104), new DateTime(2024, 9, 19, 19, 59, 27, 693, DateTimeKind.Utc).AddTicks(9104) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 19, 19, 59, 27, 693, DateTimeKind.Utc).AddTicks(9116), new DateTime(2024, 9, 19, 19, 59, 27, 693, DateTimeKind.Utc).AddTicks(9116) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 19, 19, 59, 27, 693, DateTimeKind.Utc).AddTicks(9128), new DateTime(2024, 9, 19, 19, 59, 27, 693, DateTimeKind.Utc).AddTicks(9128) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 19, 19, 59, 27, 693, DateTimeKind.Utc).AddTicks(9141), new DateTime(2024, 9, 19, 19, 59, 27, 693, DateTimeKind.Utc).AddTicks(9141) });
        }
    }
}
