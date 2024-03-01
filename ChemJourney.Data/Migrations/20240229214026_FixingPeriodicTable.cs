using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChemJourney.Data.Migrations
{
    public partial class FixingPeriodicTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ElectronConfiguration",
                table: "Elements");

            migrationBuilder.AlterColumn<double>(
                name: "MeltingPoint",
                table: "Elements",
                type: "float",
                nullable: true,
                comment: "The melting point of the element",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true,
                oldComment: "The melting point of the element");

            migrationBuilder.AlterColumn<double>(
                name: "BoilingPoint",
                table: "Elements",
                type: "float",
                nullable: true,
                comment: "The boiling point of the element",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true,
                oldComment: "The boiling point of the element");

            migrationBuilder.AlterColumn<double>(
                name: "AtomicMass",
                table: "Elements",
                type: "float",
                nullable: false,
                comment: "The atomic mass of the element",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldComment: "The atomic mass of the element");

            migrationBuilder.InsertData(
                table: "ChemicalGroupBlock",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Nonmetal" },
                    { 2, "Alkali Metal" },
                    { 3, "Alkaline Earth Metal" },
                    { 4, "Lanthanide" },
                    { 5, "Actinide" },
                    { 6, "Transition Metal" },
                    { 7, "Post-Transition Metal" },
                    { 8, "Metalloid" },
                    { 9, "Halogen" },
                    { 10, "Noble Gas" }
                });

            migrationBuilder.InsertData(
                table: "Elements",
                columns: new[] { "Id", "AtomicMass", "BoilingPoint", "ChemicalGroupBlockId", "MeltingPoint", "Name", "OxidationStates", "StandartState", "Symbol" },
                values: new object[] { 1, 1.008, 20.280000000000001, 1, 13.81, "Hydrogen", "+1, -1", "Gas", "H" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ChemicalGroupBlock",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ChemicalGroupBlock",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ChemicalGroupBlock",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ChemicalGroupBlock",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ChemicalGroupBlock",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ChemicalGroupBlock",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ChemicalGroupBlock",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ChemicalGroupBlock",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ChemicalGroupBlock",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ChemicalGroupBlock",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<decimal>(
                name: "MeltingPoint",
                table: "Elements",
                type: "decimal(18,2)",
                nullable: true,
                comment: "The melting point of the element",
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true,
                oldComment: "The melting point of the element");

            migrationBuilder.AlterColumn<decimal>(
                name: "BoilingPoint",
                table: "Elements",
                type: "decimal(18,2)",
                nullable: true,
                comment: "The boiling point of the element",
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true,
                oldComment: "The boiling point of the element");

            migrationBuilder.AlterColumn<decimal>(
                name: "AtomicMass",
                table: "Elements",
                type: "decimal(18,2)",
                nullable: false,
                comment: "The atomic mass of the element",
                oldClrType: typeof(double),
                oldType: "float",
                oldComment: "The atomic mass of the element");

            migrationBuilder.AddColumn<string>(
                name: "ElectronConfiguration",
                table: "Elements",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                comment: "The electron configuration of the element");
        }
    }
}
