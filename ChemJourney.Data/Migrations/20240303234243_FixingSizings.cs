using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChemJourney.Data.Migrations
{
    public partial class FixingSizings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Posts",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                comment: "Title of the post.",
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldComment: "Title of the post.");

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CategoryId", "Content", "DateTime", "Title", "WriterId" },
                values: new object[,]
                {
                    { 1, 1, "Can someone explain the concept of resonance in organic chemistry and provide examples to illustrate its significance in the stability of molecules?", new DateTime(2024, 3, 3, 23, 42, 42, 474, DateTimeKind.Utc).AddTicks(8167), "Decoding Organic Resonance", new Guid("0c732953-0a4f-400c-b82a-142a89e37de6") },
                    { 2, 2, "I'm struggling to grasp the concept of Gibbs free energy. How does it relate to spontaneity in chemical reactions, and what are the key factors that affect it?", new DateTime(2024, 3, 3, 23, 42, 42, 474, DateTimeKind.Utc).AddTicks(8187), "Demystifying Gibbs Free Energy", new Guid("0c732953-0a4f-400c-b82a-142a89e37de6") },
                    { 3, 3, "What are the main differences between coordination compounds and complex ions? How do ligands influence the properties of coordination compounds?", new DateTime(2024, 3, 3, 23, 42, 42, 474, DateTimeKind.Utc).AddTicks(8190), "Unraveling Coordination Compounds", new Guid("0c732953-0a4f-400c-b82a-142a89e37de6") },
                    { 4, 4, "I need help understanding the principles behind chromatography techniques. How does high-performance liquid chromatography (HPLC) differ from gas chromatography (GC), and in what situations would one be preferred over the other?", new DateTime(2024, 3, 3, 23, 42, 42, 474, DateTimeKind.Utc).AddTicks(8192), "HPLC vs. GC: Need Guidance", new Guid("466ef5f1-5313-4a18-a5ab-702f27231479") },
                    { 5, 5, "Could someone explain the role of enzymes in biochemical reactions? How do factors like pH and temperature affect enzyme activity, and are there any real-world applications of this knowledge?", new DateTime(2024, 3, 3, 23, 42, 42, 474, DateTimeKind.Utc).AddTicks(8197), "Cracking the Enzyme Code", new Guid("fea4df6c-fe3f-4947-b0de-06717b262e1e") },
                    { 6, 6, "I recently came across the term 'nanotechnology' in the context of chemistry. Can someone shed light on how nanotechnology intersects with chemistry, and what are some notable applications or advancements in this interdisciplinary field?", new DateTime(2024, 3, 3, 23, 42, 42, 474, DateTimeKind.Utc).AddTicks(8201), "Nanotechnology", new Guid("466ef5f1-5313-4a18-a5ab-702f27231479") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Posts",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                comment: "Title of the post.",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldComment: "Title of the post.");
        }
    }
}
