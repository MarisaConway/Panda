using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pandas.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pandas",
                columns: table => new
                {
                    PandaId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(nullable: false),
                    Location = table.Column<string>(nullable: false),
                    Cuteness = table.Column<int>(nullable: false),
                    Weight = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Created_At = table.Column<DateTime>(nullable: false),
                    Updated_At = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pandas", x => x.PandaId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pandas");
        }
    }
}
