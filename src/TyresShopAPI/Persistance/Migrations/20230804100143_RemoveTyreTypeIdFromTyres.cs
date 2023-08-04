using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TyresShopAPI.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class RemoveTyreTypeIdFromTyres : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TyresTypeId",
                table: "Tyres");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TyresTypeId",
                table: "Tyres",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
