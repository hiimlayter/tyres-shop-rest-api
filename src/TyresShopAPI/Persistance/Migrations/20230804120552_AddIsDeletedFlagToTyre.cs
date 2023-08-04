using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TyresShopAPI.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class AddIsDeletedFlagToTyre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Tyres",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Tyres");
        }
    }
}
