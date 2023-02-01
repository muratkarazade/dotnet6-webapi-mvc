using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.Data.Migrations
{
    /// <inheritdoc />
    public partial class DALextesion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("2923a237-8a12-48bd-b543-cdd6d2047d4a"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("61eee573-f716-4f8b-8ad0-c7c010ec1d22"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("389817f9-b6ed-4ad6-a1c4-2b4d5a1a0ad2"), new Guid("94156901-724d-4025-9e53-ae772d0ce7f4"), "Visual Studio Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Admin", new DateTime(2023, 2, 1, 0, 10, 32, 439, DateTimeKind.Local).AddTicks(2585), null, null, new Guid("0b72d57c-84ff-4b14-8eb2-5bbef609523a"), false, null, null, "Visual Studio", 32 },
                    { new Guid("41ada0e1-4bd9-42a8-bc8c-f3834d220b47"), new Guid("2a956fe7-a026-4b02-8945-e7028bff0cbe"), "Asp.Net Core Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Admin", new DateTime(2023, 2, 1, 0, 10, 32, 439, DateTimeKind.Local).AddTicks(2577), null, null, new Guid("94a76b08-ae0d-4cec-80cd-c65fedbc2cdf"), false, null, null, "Asp.Net Core Mvc Project", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2a956fe7-a026-4b02-8945-e7028bff0cbe"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 1, 0, 10, 32, 439, DateTimeKind.Local).AddTicks(2932));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("94156901-724d-4025-9e53-ae772d0ce7f4"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 1, 0, 10, 32, 439, DateTimeKind.Local).AddTicks(2927));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("0b72d57c-84ff-4b14-8eb2-5bbef609523a"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 1, 0, 10, 32, 439, DateTimeKind.Local).AddTicks(3123));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("94a76b08-ae0d-4cec-80cd-c65fedbc2cdf"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 1, 0, 10, 32, 439, DateTimeKind.Local).AddTicks(3118));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("389817f9-b6ed-4ad6-a1c4-2b4d5a1a0ad2"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("41ada0e1-4bd9-42a8-bc8c-f3834d220b47"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("2923a237-8a12-48bd-b543-cdd6d2047d4a"), new Guid("2a956fe7-a026-4b02-8945-e7028bff0cbe"), "Asp.Net Core Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Admin", new DateTime(2023, 1, 31, 17, 55, 8, 405, DateTimeKind.Local).AddTicks(737), null, null, new Guid("94a76b08-ae0d-4cec-80cd-c65fedbc2cdf"), false, null, null, "Asp.Net Core Mvc Project", 15 },
                    { new Guid("61eee573-f716-4f8b-8ad0-c7c010ec1d22"), new Guid("94156901-724d-4025-9e53-ae772d0ce7f4"), "Visual Studio Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Admin", new DateTime(2023, 1, 31, 17, 55, 8, 405, DateTimeKind.Local).AddTicks(744), null, null, new Guid("0b72d57c-84ff-4b14-8eb2-5bbef609523a"), false, null, null, "Visual Studio", 32 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2a956fe7-a026-4b02-8945-e7028bff0cbe"),
                column: "CreatedDate",
                value: new DateTime(2023, 1, 31, 17, 55, 8, 405, DateTimeKind.Local).AddTicks(1100));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("94156901-724d-4025-9e53-ae772d0ce7f4"),
                column: "CreatedDate",
                value: new DateTime(2023, 1, 31, 17, 55, 8, 405, DateTimeKind.Local).AddTicks(1084));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("0b72d57c-84ff-4b14-8eb2-5bbef609523a"),
                column: "CreatedDate",
                value: new DateTime(2023, 1, 31, 17, 55, 8, 405, DateTimeKind.Local).AddTicks(1265));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("94a76b08-ae0d-4cec-80cd-c65fedbc2cdf"),
                column: "CreatedDate",
                value: new DateTime(2023, 1, 31, 17, 55, 8, 405, DateTimeKind.Local).AddTicks(1261));
        }
    }
}
