using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SImpleCRUD.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "House",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(nullable: false),
                    Owner = table.Column<string>(nullable: false),
                    Size = table.Column<double>(nullable: false),
                    RoomNum = table.Column<int>(nullable: false),
                    HallNum = table.Column<int>(nullable: false),
                    BathNum = table.Column<int>(nullable: false),
                    year = table.Column<double>(nullable: false),
                    type = table.Column<string>(nullable: false),
                    floor = table.Column<int>(nullable: false),
                    price = table.Column<int>(nullable: false),
                    remark = table.Column<string>(nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_House", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "House");
        }
    }
}
