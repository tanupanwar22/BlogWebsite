using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Migrations
{
    public partial class altertable04 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PostDraft",
                columns: table => new
                {
                    PostId = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    AuthorId = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    AuthorName = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    Content = table.Column<string>(type: "nVARCHAR(max)", nullable: false),
                    Status = table.Column<string>(type: "NVARCHAR(256)", nullable: true),
                    Creation_Date = table.Column<DateTime>(type: "datetime", nullable: false),
                    Update_Date = table.Column<DateTime>(type: "datetime", nullable: false),
                    Published_Date = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostDraft", x => x.PostId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostDraft");
        }
    }
}
