using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mercury.Migrations
{
    /// <inheritdoc />
    public partial class changeProductModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "948526e8-1620-4365-8a6b-ec37517d275e",
                column: "ConcurrencyStamp",
                value: "badf4f8a-a621-445f-b60d-e6c47c26b0a8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "afea407f-e991-43f2-953a-1dabbf9bb024",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0ad4da96-fa2d-4e9b-b31e-c3bede20a4ee", "AQAAAAEAACcQAAAAECEMFRYgodri2KPfzXwKN45xqu9oCsJZEtrjBPM241hUYwXJTrs03W42c+Aq9qyJpg==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("35830bab-542d-4e42-8277-65800bc26053"),
                column: "DateAddet",
                value: new DateTime(2023, 3, 6, 13, 47, 58, 108, DateTimeKind.Utc).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("3be10c44-818a-46ce-a08b-74780181e903"),
                column: "DateAddet",
                value: new DateTime(2023, 3, 6, 13, 47, 58, 108, DateTimeKind.Utc).AddTicks(2239));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("69c7a66e-00ed-44ea-9ad3-3d8e5c0aecdb"),
                column: "DateAddet",
                value: new DateTime(2023, 3, 6, 13, 47, 58, 108, DateTimeKind.Utc).AddTicks(2141));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("bc7322d6-c85a-4453-b3b3-9a1a27ccb3f2"),
                column: "DateAddet",
                value: new DateTime(2023, 3, 6, 13, 47, 58, 108, DateTimeKind.Utc).AddTicks(2206));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "948526e8-1620-4365-8a6b-ec37517d275e",
                column: "ConcurrencyStamp",
                value: "9afec324-3bc9-4ea2-8693-93d27740f285");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "afea407f-e991-43f2-953a-1dabbf9bb024",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a1ca1236-7d5c-451c-9fcb-229d89d9bc2b", "AQAAAAEAACcQAAAAEGAQMbFpDowcBeYkebqf5w+OJ4qqGgIFJAEmWKJeq2O56uOCybHv8EeiNoBPoAcq/Q==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("35830bab-542d-4e42-8277-65800bc26053"),
                column: "DateAddet",
                value: new DateTime(2023, 3, 2, 7, 2, 55, 784, DateTimeKind.Utc).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("3be10c44-818a-46ce-a08b-74780181e903"),
                column: "DateAddet",
                value: new DateTime(2023, 3, 2, 7, 2, 55, 784, DateTimeKind.Utc).AddTicks(5083));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("69c7a66e-00ed-44ea-9ad3-3d8e5c0aecdb"),
                column: "DateAddet",
                value: new DateTime(2023, 3, 2, 7, 2, 55, 784, DateTimeKind.Utc).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("bc7322d6-c85a-4453-b3b3-9a1a27ccb3f2"),
                column: "DateAddet",
                value: new DateTime(2023, 3, 2, 7, 2, 55, 784, DateTimeKind.Utc).AddTicks(5053));
        }
    }
}
