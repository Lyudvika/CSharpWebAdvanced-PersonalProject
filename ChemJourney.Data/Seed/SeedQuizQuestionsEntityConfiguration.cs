using ChemJourney.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChemJourney.Data.Seed
{
    public class SeedQuizQuestionsEntityConfiguration : IEntityTypeConfiguration<QuizQuestion>
    {
        public void Configure(EntityTypeBuilder<QuizQuestion> builder)
        {
            builder.HasData(GenerateQuizQuestions());
        }

        private QuizQuestion[] GenerateQuizQuestions()
        {
            ICollection<QuizQuestion> quizQuestions = new HashSet<QuizQuestion>();

            QuizQuestion currQuizQuestions;

            currQuizQuestions = new QuizQuestion()
            {
                Id = 1,
                QuestionText = "What is the primary function of a burette in analytical chemistry?",
                OptionOne = "Measure temperature",
                OptionTwo = "Measure volume",
                OptionThree = "Measure mass",
                OptionFour = "Measure pH",
                CorrectOption = "Measure volume",
                QuizId = 1,
            };
            quizQuestions.Add(currQuizQuestions);

            currQuizQuestions = new QuizQuestion()
            {
                Id = 2,
                QuestionText = "Which instrument is commonly used for separating components of a mixture based on their molecular size?",
                OptionOne = "Spectrophotometer",
                OptionTwo = "Centrifuge",
                OptionThree = "Gas chromatograph",
                OptionFour = "pH meter",
                CorrectOption = "pH meter",
                QuizId = 1,
            };
            quizQuestions.Add(currQuizQuestions);

            currQuizQuestions = new QuizQuestion()
            {
                Id = 3,
                QuestionText = "What does the term TITRATION refer to in analytical chemistry?",
                OptionOne = "Mixing two solutions to form a precipitate",
                OptionTwo = "Heating a substance to high temperatures",
                OptionThree = "Determining the concentration of a solution",
                OptionFour = "Measuring the electrical conductivity of a solution",
                CorrectOption = "Determining the concentration of a solution",
                QuizId = 1,
            };
            quizQuestions.Add(currQuizQuestions);

            currQuizQuestions = new QuizQuestion()
            {
                Id = 4,
                QuestionText = "Which indicator is commonly used in acid-base titrations to determine the endpoint?",
                OptionOne = "Phenolphthalein",
                OptionTwo = "Bromothymol blue",
                OptionThree = "Methyl orange",
                OptionFour = "Litmus",
                CorrectOption = "Phenolphthalein",
                QuizId = 1,
            };
            quizQuestions.Add(currQuizQuestions);

            currQuizQuestions = new QuizQuestion()
            {
                Id = 5,
                QuestionText = "What is the purpose of a standard solution in analytical chemistry?",
                OptionOne = "To clean laboratory equipment",
                OptionTwo = "To calibrate instruments",
                OptionThree = "To conduct experiments on a large scale",
                OptionFour = "To store chemicals safely",
                CorrectOption = "To calibrate instruments",
                QuizId = 1,
            };
            quizQuestions.Add(currQuizQuestions);

            currQuizQuestions = new QuizQuestion()
            {
                Id = 6,
                QuestionText = "Which technique is used to identify and quantify the elements present in a sample?",
                OptionOne = "Titration",
                OptionTwo = "Spectroscopy",
                OptionThree = "Chromatography",
                OptionFour = "Electrochemistry",
                CorrectOption = "Spectroscopy",
                QuizId = 1,
            };
            quizQuestions.Add(currQuizQuestions);

            currQuizQuestions = new QuizQuestion()
            {
                Id = 7,
                QuestionText = "What does the term PRECISION refer to in analytical chemistry?",
                OptionOne = "The closeness of measured values to the true value",
                OptionTwo = "The ability to reproduce results consistently",
                OptionThree = "The purity of a substance",
                OptionFour = "The range of values over which a measurement is accurate",
                CorrectOption = "The ability to reproduce results consistently",
                QuizId = 1,
            };
            quizQuestions.Add(currQuizQuestions);

            currQuizQuestions = new QuizQuestion()
            {
                Id = 8,
                QuestionText = "Which type of analytical technique involves passing light through a sample to measure its absorbance or emission?",
                OptionOne = "Titration",
                OptionTwo = "Chromatography",
                OptionThree = "Spectroscopy",
                OptionFour = "Electrochemistry",
                CorrectOption = "Spectroscopy",
                QuizId = 1,
            };
            quizQuestions.Add(currQuizQuestions);

            currQuizQuestions = new QuizQuestion()
            {
                Id = 9,
                QuestionText = "What is the purpose of a calibration curve in analytical chemistry?",
                OptionOne = "To determine the unknown concentration of a solution",
                OptionTwo = "To measure the pH of a solution",
                OptionThree = "To separate components of a mixture",
                OptionFour = "To identify elements present in a sample",
                CorrectOption = "To determine the unknown concentration of a solution",
                QuizId = 1,
            };
            quizQuestions.Add(currQuizQuestions);

            currQuizQuestions = new QuizQuestion()
            {
                Id = 10,
                QuestionText = "Which of the following is an example of a primary standard in analytical chemistry?",
                OptionOne = "Sodium chloride",
                OptionTwo = "Potassium dichromate",
                OptionThree = "Hydrochloric acid",
                OptionFour = "Acetic acid",
                CorrectOption = "Potassium dichromate",
                QuizId = 1,
            };
            quizQuestions.Add(currQuizQuestions);

            currQuizQuestions = new QuizQuestion()
            {
                Id = 11,
                QuestionText = "Which law describes the relationship between the pressure and volume of a gas at constant temperature?",
                OptionOne = "Boyle's law",
                OptionTwo = "Charles's law",
                OptionThree = "Gay-Lussac's law",
                OptionFour = "Dalton's law",
                CorrectOption = "Boyle's law",
                QuizId = 2,
            };
            quizQuestions.Add(currQuizQuestions);

            currQuizQuestions = new QuizQuestion()
            {
                Id = 12,
                QuestionText = "What is the heat capacity of a substance?",
                OptionOne = "The amount of heat required to raise its temperature by 1 Celsius",
                OptionTwo = "The ability to conduct electricity",
                OptionThree = "The mass per unit volume",
                OptionFour = "The rate of change of pressure with volume",
                CorrectOption = "The amount of heat required to raise its temperature by 1 Celsius",
                QuizId = 2,
            };
            quizQuestions.Add(currQuizQuestions);

            currQuizQuestions = new QuizQuestion()
            {
                Id = 13,
                QuestionText = "What is the term for the energy required to remove an electron from an atom or molecule in the gas phase?",
                OptionOne = "Ionization energy",
                OptionTwo = "Electron affinity",
                OptionThree = "Electronegativity",
                OptionFour = "Ionization potential",
                CorrectOption = "Ionization energy",
                QuizId = 2,
            };
            quizQuestions.Add(currQuizQuestions);

            currQuizQuestions = new QuizQuestion()
            {
                Id = 14,
                QuestionText = "Which law states that the total pressure of a mixture of gases is equal to the sum of the partial pressures of the individual gases?",
                OptionOne = "Boyle's law",
                OptionTwo = "Charles's law",
                OptionThree = "Avogadro's law",
                OptionFour = "Dalton's law",
                CorrectOption = "Dalton's law",
                QuizId = 2,
            };
            quizQuestions.Add(currQuizQuestions);

            currQuizQuestions = new QuizQuestion()
            {
                Id = 15,
                QuestionText = "What is the term for the point at which a reversible reaction proceeds in both directions at the same rate?",
                OptionOne = "Equilibrium",
                OptionTwo = "Activation energy",
                OptionThree = "Catalyst",
                OptionFour = "Rate-determining step",
                CorrectOption = "Equilibrium",
                QuizId = 2,
            };
            quizQuestions.Add(currQuizQuestions);

            currQuizQuestions = new QuizQuestion()
            {
                Id = 16,
                QuestionText = "Which quantity remains constant during an adiabatic process?",
                OptionOne = "Pressure",
                OptionTwo = "Volume",
                OptionThree = "Temperature",
                OptionFour = "Enthalpy",
                CorrectOption = "Temperature",
                QuizId = 2,
            };
            quizQuestions.Add(currQuizQuestions);

            currQuizQuestions = new QuizQuestion()
            {
                Id = 17,
                QuestionText = "What is the term for the change in enthalpy of a system at constant pressure?",
                OptionOne = "Internal energy",
                OptionTwo = "Heat capacity",
                OptionThree = "Enthalpy",
                OptionFour = "Entropy",
                CorrectOption = "Enthalpy",
                QuizId = 2,
            };
            quizQuestions.Add(currQuizQuestions);

            currQuizQuestions = new QuizQuestion()
            {
                Id = 18,
                QuestionText = "What does the term QUANTUM MECHANICS refer to in physical chemistry?",
                OptionOne = "The study of particles at the atomic and subatomic level",
                OptionTwo = "The study of chemical reactions in solution",
                OptionThree = "The behavior of gases",
                OptionFour = "The study of equilibrium systems",
                CorrectOption = "The study of particles at the atomic and subatomic level",
                QuizId = 2,
            };
            quizQuestions.Add(currQuizQuestions);

            currQuizQuestions = new QuizQuestion()
            {
                Id = 19,
                QuestionText = "Which law describes the relationship between the temperature and volume of a gas at constant pressure?",
                OptionOne = "Boyle's law",
                OptionTwo = "Charles's law",
                OptionThree = "Gay-Lussac's law",
                OptionFour = "Dalton's law",
                CorrectOption = "Charles's law",
                QuizId = 2,
            };
            quizQuestions.Add(currQuizQuestions);

            currQuizQuestions = new QuizQuestion()
            {
                Id = 20,
                QuestionText = "What is the term for the energy required to break a chemical bond?",
                OptionOne = "Ionization energy",
                OptionTwo = "Activation energy",
                OptionThree = "Heat of formation",
                OptionFour = "Bond dissociation energy",
                CorrectOption = "Activation energy",
                QuizId = 2,
            };
            quizQuestions.Add(currQuizQuestions);

            currQuizQuestions = new QuizQuestion()
            {
                Id = 21,
                QuestionText = "What is the general formula for an alkane?",
                OptionOne = "CnH2n",
                OptionTwo = "CnH2n+2",
                OptionThree = "CnH2n-2",
                OptionFour = "CnH2n-4",
                CorrectOption = "CnH2n",
                QuizId = 3,
            };
            quizQuestions.Add(currQuizQuestions);

            currQuizQuestions = new QuizQuestion()
            {
                Id = 22,
                QuestionText = "Which functional group is present in an alcohol?",
                OptionOne = "Carbonyl",
                OptionTwo = "Hydroxyl",
                OptionThree = "Carboxyl",
                OptionFour = "Amino",
                CorrectOption = "Hydroxyl",
                QuizId = 3,
            };
            quizQuestions.Add(currQuizQuestions);

            currQuizQuestions = new QuizQuestion()
            {
                Id = 23,
                QuestionText = "What is the term for a hydrocarbon chain with no double or triple bonds?",
                OptionOne = "Alkane",
                OptionTwo = "Alkene",
                OptionThree = "Alkyne",
                OptionFour = "Aromatic",
                CorrectOption = "Alkane",
                QuizId = 3,
            };
            quizQuestions.Add(currQuizQuestions);

            currQuizQuestions = new QuizQuestion()
            {
                Id = 24,
                QuestionText = "Which compound is known as the simplest alkene?",
                OptionOne = "Ethene",
                OptionTwo = "Propene",
                OptionThree = "Butene",
                OptionFour = "Methane",
                CorrectOption = "Ethene",
                QuizId = 3,
            };
            quizQuestions.Add(currQuizQuestions);

            currQuizQuestions = new QuizQuestion()
            {
                Id = 25,
                QuestionText = "What is the term for a molecule that has the same molecular formula but different structural arrangement of atoms?",
                OptionOne = "Isomer",
                OptionTwo = "Homolog",
                OptionThree = "Polymer",
                OptionFour = "Monomer",
                CorrectOption = "Isomer",
                QuizId = 3,
            };
            quizQuestions.Add(currQuizQuestions);

            currQuizQuestions = new QuizQuestion()
            {
                Id = 26,
                QuestionText = "Which type of reaction involves the addition of hydrogen to an unsaturated hydrocarbon?",
                OptionOne = "Substitution",
                OptionTwo = "Elimination",
                OptionThree = "Hydrogenation",
                OptionFour = "Halogenation",
                CorrectOption = "Hydrogenation",
                QuizId = 3,
            };
            quizQuestions.Add(currQuizQuestions);

            currQuizQuestions = new QuizQuestion()
            {
                Id = 27,
                QuestionText = "What is the term for a compound that contains a carbon-carbon double bond?",
                OptionOne = "Alkane",
                OptionTwo = "Alkene",
                OptionThree = "Alkyne",
                OptionFour = "Aromatic",
                CorrectOption = "Alkene",
                QuizId = 3,
            };
            quizQuestions.Add(currQuizQuestions);

            currQuizQuestions = new QuizQuestion()
            {
                Id = 28,
                QuestionText = "Which functional group is present in a carboxylic acid?",
                OptionOne = "Carbonyl",
                OptionTwo = "Hydroxyl",
                OptionThree = "Carboxyl",
                OptionFour = "Amino",
                CorrectOption = "Carboxyl",
                QuizId = 3,
            };
            quizQuestions.Add(currQuizQuestions);

            currQuizQuestions = new QuizQuestion()
            {
                Id = 29,
                QuestionText = "What is the term for a compound that contains a carbon-carbon triple bond?",
                OptionOne = "Alkane",
                OptionTwo = "Alkene",
                OptionThree = "Alkyne",
                OptionFour = "Aromatic",
                CorrectOption = "Alkyne",
                QuizId = 3,
            };
            quizQuestions.Add(currQuizQuestions);

            currQuizQuestions = new QuizQuestion()
            {
                Id = 30,
                QuestionText = "Which compound is commonly used as a solvent in organic chemistry due to its ability to dissolve a wide range of organic compounds?",
                OptionOne = "Ethanol",
                OptionTwo = "Acetone",
                OptionThree = "Methanol",
                OptionFour = "Isopropanol",
                CorrectOption = "Acetone",
                QuizId = 3,
            };
            quizQuestions.Add(currQuizQuestions);

            return quizQuestions.ToArray();
        }
    }
}
