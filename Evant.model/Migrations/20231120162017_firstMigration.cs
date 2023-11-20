using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Evant.model.Migrations
{
    public partial class firstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hall",
                columns: table => new
                {
                    HallId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNamber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContainSites = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hall", x => x.HallId);
                });

            migrationBuilder.CreateTable(
                name: "InventionEvent",
                columns: table => new
                {
                    InventionEventId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HallId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountPeople = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Payment = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventionEvent", x => x.InventionEventId);
                });

            migrationBuilder.CreateTable(
                name: "InventionMenu",
                columns: table => new
                {
                    InventionEventId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ManaId = table.Column<int>(type: "int", nullable: true),
                    CountProduct = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventionMenu", x => x.InventionEventId);
                });

            migrationBuilder.CreateTable(
                name: "Inviter",
                columns: table => new
                {
                    InviterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InviterName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InviterPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InviterMail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inviter", x => x.InviterId);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    ManaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mana = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManaStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kashrut = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.ManaId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hall");

            migrationBuilder.DropTable(
                name: "InventionEvent");

            migrationBuilder.DropTable(
                name: "InventionMenu");

            migrationBuilder.DropTable(
                name: "Inviter");

            migrationBuilder.DropTable(
                name: "Menu");
        }
    }
}
