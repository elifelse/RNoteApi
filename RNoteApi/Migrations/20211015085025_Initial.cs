using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RNoteApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "Id", "Content", "CreateTime", "ModifiedTime", "Title" },
                values: new object[] { 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", new DateTime(2021, 10, 15, 11, 50, 25, 2, DateTimeKind.Local).AddTicks(7831), null, "Sample Note 1" });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "Id", "Content", "CreateTime", "ModifiedTime", "Title" },
                values: new object[] { 2, "Sed sit amet risus nec enim molestie consectetur.", new DateTime(2021, 10, 15, 11, 50, 25, 4, DateTimeKind.Local).AddTicks(5267), null, "Sample Note 2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notes");
        }
    }
}
