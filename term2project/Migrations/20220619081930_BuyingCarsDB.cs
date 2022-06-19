using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace term2project.Migrations
{
    public partial class BuyingCarsDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "BuyingCar",
                newName: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "BuyingCar",
                newName: "Id");
        }
    }
}
