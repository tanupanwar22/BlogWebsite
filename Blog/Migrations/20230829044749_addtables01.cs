using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Migrations
{
    public partial class addtables01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    PostId = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    AuthorId = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    AuthorName = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Content = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Status = table.Column<string>(type: "NVARCHAR(256)", nullable: true),
                    Creation_Date = table.Column<DateTime>(type: "datetime", nullable: false),
                    Update_Date = table.Column<DateTime>(type: "datetime", nullable: false),
                    Published_Date = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => new { x.Id, x.PostId });
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Profession = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    IsAuther = table.Column<bool>(type: "bit", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime", nullable: false),
                    JoinedOn = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => new { x.Id, x.UserId });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
