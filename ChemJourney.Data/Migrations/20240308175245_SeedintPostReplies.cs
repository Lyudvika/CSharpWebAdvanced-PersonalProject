using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChemJourney.Data.Migrations
{
    public partial class SeedintPostReplies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PostReplies",
                columns: new[] { "Id", "AuthorId", "Content", "DateTime", "IsDeleted", "PostId" },
                values: new object[] { 1, new Guid("8a0f20bd-0612-4f85-98c1-45bac15088eb"), "Resonance in organic chemistry refers to the delocalization of electrons within a molecule, often represented by multiple resonance structures. This phenomenon enhances the stability of molecules by distributing electron density. An example is the resonance in benzene, where electrons are shared across all carbon atoms, contributing to the overall stability of the aromatic ring. Resonance is crucial for understanding molecular stability and reactivity in various organic compounds.", new DateTime(2024, 1, 5, 11, 30, 0, 0, DateTimeKind.Unspecified), false, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PostReplies",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
