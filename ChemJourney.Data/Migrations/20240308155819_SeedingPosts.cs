using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChemJourney.Data.Migrations
{
    public partial class SeedingPosts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Content", "DateTime", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { 1, new Guid("2d42ee05-aabf-44fa-91c8-d4f7cd258e44"), 1, "Can someone explain the concept of resonance in organic chemistry and provide examples to illustrate its significance in the stability of molecules?", new DateTime(2024, 1, 5, 10, 30, 0, 0, DateTimeKind.Unspecified), false, "Decoding Organic Resonance" },
                    { 2, new Guid("fdeb91a2-491f-40b6-83f6-b0ff231f9253"), 2, "I'm struggling to grasp the concept of Gibbs free energy. How does it relate to spontaneity in chemical reactions, and what are the key factors that affect it?", new DateTime(2023, 3, 5, 15, 30, 0, 0, DateTimeKind.Unspecified), false, "Demystifying Gibbs Free Energy" },
                    { 3, new Guid("fdeb91a2-491f-40b6-83f6-b0ff231f9253"), 3, "What are the main differences between coordination compounds and complex ions? How do ligands influence the properties of coordination compounds?", new DateTime(2024, 2, 20, 20, 0, 0, 0, DateTimeKind.Unspecified), false, "Unraveling Coordination Compounds" },
                    { 4, new Guid("8a0f20bd-0612-4f85-98c1-45bac15088eb"), 4, "I need help understanding the principles behind chromatography techniques. How does high-performance liquid chromatography (HPLC) differ from gas chromatography (GC), and in what situations would one be preferred over the other?", new DateTime(2023, 3, 5, 10, 30, 0, 0, DateTimeKind.Unspecified), false, "HPLC vs. GC: Need Guidance" },
                    { 5, new Guid("8a0f20bd-0612-4f85-98c1-45bac15088eb"), 5, "Could someone explain the role of enzymes in biochemical reactions? How do factors like pH and temperature affect enzyme activity, and are there any real-world applications of this knowledge?", new DateTime(2024, 1, 21, 18, 35, 0, 0, DateTimeKind.Unspecified), false, "Cracking the Enzyme Code" },
                    { 6, new Guid("8a0f20bd-0612-4f85-98c1-45bac15088eb"), 6, "I recently came across the term 'nanotechnology' in the context of chemistry. Can someone shed light on how nanotechnology intersects with chemistry, and what are some notable applications or advancements in this interdisciplinary field?", new DateTime(2024, 1, 1, 8, 30, 0, 0, DateTimeKind.Unspecified), false, "Nanotechnology" }
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
        }
    }
}
