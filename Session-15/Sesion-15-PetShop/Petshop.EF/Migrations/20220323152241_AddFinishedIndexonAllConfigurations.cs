using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Petshop.EF.Migrations
{
    public partial class AddFinishedIndexonAllConfigurations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Finished",
                table: "Transaction",
                type: "bit",
                maxLength: 200,
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Finished",
                table: "PetFood",
                type: "bit",
                maxLength: 200,
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Finished",
                table: "Pet",
                type: "bit",
                maxLength: 200,
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Finished",
                table: "Employee",
                type: "bit",
                maxLength: 200,
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Finished",
                table: "Customer",
                type: "bit",
                maxLength: 200,
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_Finished",
                table: "Transaction",
                column: "Finished");

            migrationBuilder.CreateIndex(
                name: "IX_PetFood_Finished",
                table: "PetFood",
                column: "Finished");

            migrationBuilder.CreateIndex(
                name: "IX_Pet_Finished",
                table: "Pet",
                column: "Finished");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Finished",
                table: "Employee",
                column: "Finished");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Finished",
                table: "Customer",
                column: "Finished");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Transaction_Finished",
                table: "Transaction");

            migrationBuilder.DropIndex(
                name: "IX_PetFood_Finished",
                table: "PetFood");

            migrationBuilder.DropIndex(
                name: "IX_Pet_Finished",
                table: "Pet");

            migrationBuilder.DropIndex(
                name: "IX_Employee_Finished",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Customer_Finished",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Finished",
                table: "Transaction");

            migrationBuilder.DropColumn(
                name: "Finished",
                table: "PetFood");

            migrationBuilder.DropColumn(
                name: "Finished",
                table: "Pet");

            migrationBuilder.DropColumn(
                name: "Finished",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Finished",
                table: "Customer");
        }
    }
}
