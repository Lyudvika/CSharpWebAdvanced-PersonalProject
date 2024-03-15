using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChemJourney.Data.Migrations
{
    public partial class SeedQuizQuestions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "QuizQuestions",
                columns: new[] { "Id", "CorrectOption", "OptionFour", "OptionOne", "OptionThree", "OptionTwo", "QuestionText", "QuizId" },
                values: new object[,]
                {
                    { 1, "Measure volume", "Measure pH", "Measure temperature", "Measure mass", "Measure volume", "What is the primary function of a burette in analytical chemistry?", 1 },
                    { 2, "pH meter", "pH meter", "Spectrophotometer", "Gas chromatograph", "Centrifuge", "Which instrument is commonly used for separating components of a mixture based on their molecular size?", 1 },
                    { 3, "Determining the concentration of a solution", "Measuring the electrical conductivity of a solution", "Mixing two solutions to form a precipitate", "Determining the concentration of a solution", "Heating a substance to high temperatures", "What does the term TITRATION refer to in analytical chemistry?", 1 },
                    { 4, "Phenolphthalein", "Litmus", "Phenolphthalein", "Methyl orange", "Bromothymol blue", "Which indicator is commonly used in acid-base titrations to determine the endpoint?", 1 },
                    { 5, "To calibrate instruments", "To store chemicals safely", "To clean laboratory equipment", "To conduct experiments on a large scale", "To calibrate instruments", "What is the purpose of a standard solution in analytical chemistry?", 1 },
                    { 6, "Spectroscopy", "Electrochemistry", "Titration", "Chromatography", "Spectroscopy", "Which technique is used to identify and quantify the elements present in a sample?", 1 },
                    { 7, "The ability to reproduce results consistently", "The range of values over which a measurement is accurate", "The closeness of measured values to the true value", "The purity of a substance", "The ability to reproduce results consistently", "What does the term PRECISION refer to in analytical chemistry?", 1 },
                    { 8, "Spectroscopy", "Electrochemistry", "Titration", "Spectroscopy", "Chromatography", "Which type of analytical technique involves passing light through a sample to measure its absorbance or emission?", 1 },
                    { 9, "To determine the unknown concentration of a solution", "To identify elements present in a sample", "To determine the unknown concentration of a solution", "To separate components of a mixture", "To measure the pH of a solution", "What is the purpose of a calibration curve in analytical chemistry?", 1 },
                    { 10, "Potassium dichromate", "Acetic acid", "Sodium chloride", "Hydrochloric acid", "Potassium dichromate", "Which of the following is an example of a primary standard in analytical chemistry?", 1 },
                    { 11, "Boyle's law", "Dalton's law", "Boyle's law", "Gay-Lussac's law", "Charles's law", "Which law describes the relationship between the pressure and volume of a gas at constant temperature?", 2 },
                    { 12, "The amount of heat required to raise its temperature by 1 Celsius", "The rate of change of pressure with volume", "The amount of heat required to raise its temperature by 1 Celsius", "The mass per unit volume", "The ability to conduct electricity", "What is the heat capacity of a substance?", 2 },
                    { 13, "Ionization energy", "Ionization potential", "Ionization energy", "Electronegativity", "Electron affinity", "What is the term for the energy required to remove an electron from an atom or molecule in the gas phase?", 2 },
                    { 14, "Dalton's law", "Dalton's law", "Boyle's law", "Avogadro's law", "Charles's law", "Which law states that the total pressure of a mixture of gases is equal to the sum of the partial pressures of the individual gases?", 2 },
                    { 15, "Equilibrium", "Rate-determining step", "Equilibrium", "Catalyst", "Activation energy", "What is the term for the point at which a reversible reaction proceeds in both directions at the same rate?", 2 },
                    { 16, "Temperature", "Enthalpy", "Pressure", "Temperature", "Volume", "Which quantity remains constant during an adiabatic process?", 2 },
                    { 17, "Enthalpy", "Entropy", "Internal energy", "Enthalpy", "Heat capacity", "What is the term for the change in enthalpy of a system at constant pressure?", 2 },
                    { 18, "The study of particles at the atomic and subatomic level", "The study of equilibrium systems", "The study of particles at the atomic and subatomic level", "The behavior of gases", "The study of chemical reactions in solution", "What does the term QUANTUM MECHANICS refer to in physical chemistry?", 2 },
                    { 19, "Charles's law", "Dalton's law", "Boyle's law", "Gay-Lussac's law", "Charles's law", "Which law describes the relationship between the temperature and volume of a gas at constant pressure?", 2 },
                    { 20, "Activation energy", "Bond dissociation energy", "Ionization energy", "Heat of formation", "Activation energy", "What is the term for the energy required to break a chemical bond?", 2 },
                    { 21, "CnH2n", "CnH2n-4", "CnH2n", "CnH2n-2", "CnH2n+2", "What is the general formula for an alkane?", 3 },
                    { 22, "Hydroxyl", "Amino", "Carbonyl", "Carboxyl", "Hydroxyl", "Which functional group is present in an alcohol?", 3 },
                    { 23, "Alkane", "Aromatic", "Alkane", "Alkyne", "Alkene", "What is the term for a hydrocarbon chain with no double or triple bonds?", 3 },
                    { 24, "Ethene", "Methane", "Ethene", "Butene", "Propene", "Which compound is known as the simplest alkene?", 3 },
                    { 25, "Isomer", "Monomer", "Isomer", "Polymer", "Homolog", "What is the term for a molecule that has the same molecular formula but different structural arrangement of atoms?", 3 },
                    { 26, "Hydrogenation", "Halogenation", "Substitution", "Hydrogenation", "Elimination", "Which type of reaction involves the addition of hydrogen to an unsaturated hydrocarbon?", 3 },
                    { 27, "Alkene", "Aromatic", "Alkane", "Alkyne", "Alkene", "What is the term for a compound that contains a carbon-carbon double bond?", 3 },
                    { 28, "Carboxyl", "Amino", "Carbonyl", "Carboxyl", "Hydroxyl", "Which functional group is present in a carboxylic acid?", 3 },
                    { 29, "Alkyne", "Aromatic", "Alkane", "Alkyne", "Alkene", "What is the term for a compound that contains a carbon-carbon triple bond?", 3 },
                    { 30, "Acetone", "Isopropanol", "Ethanol", "Methanol", "Acetone", "Which compound is commonly used as a solvent in organic chemistry due to its ability to dissolve a wide range of organic compounds?", 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "QuizQuestions",
                keyColumn: "Id",
                keyValue: 30);
        }
    }
}
