using ChemJourney.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChemJourney.Data.Seed
{
    public class SeedElementsEntityConfiguration : IEntityTypeConfiguration<Element>
    {
        public void Configure(EntityTypeBuilder<Element> builder)
        {
            builder.HasData(GenerateElements());
        }

        private Element[] GenerateElements()
        {
            ICollection<Element> elements = new HashSet<Element>();

            Element element;

            element = new Element()
            {
                Id = 1,
                Name = "Hydrogen",
                Symbol = "H",
                AtomicMass = 1.0080,
                MeltingPoint = 13.81,
                BoilingPoint = 20.28,
                StandardState = "Gas",
                ChemicalGroupBlockId = 1,
                OxidationStates = "+1, -1"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 2,
                Name = "Helium",
                Symbol = "He",
                AtomicMass = 4.00260,
                MeltingPoint = 0.95,
                BoilingPoint = 4.22,
                StandardState = "Gas",
                ChemicalGroupBlockId = 10,
                OxidationStates = "0"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 3,
                Name = "Lithium",
                Symbol = "Li",
                AtomicMass = 7.0,
                MeltingPoint = 453.65,
                BoilingPoint = 1615,
                StandardState = "Solid",
                ChemicalGroupBlockId = 2,
                OxidationStates = "+1"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 4,
                Name = "Beryllium",
                Symbol = "Be",
                AtomicMass = 9.012183,
                MeltingPoint = 1560,
                BoilingPoint = 2744,
                StandardState = "Solid",
                ChemicalGroupBlockId = 3,
                OxidationStates = "+2"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 5,
                Name = "Boron",
                Symbol = "B",
                AtomicMass = 10.81,
                MeltingPoint = 2348,
                BoilingPoint = 4273,
                StandardState = "Solid",
                ChemicalGroupBlockId = 8,
                OxidationStates = "+3"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 6,
                Name = "Carbon",
                Symbol = "C",
                AtomicMass = 12.011,
                MeltingPoint = 3823,
                BoilingPoint = 4098,
                StandardState = "Solid",
                ChemicalGroupBlockId = 1,
                OxidationStates = "+4, +2, -4"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 7,
                Name = "Nitrogen",
                Symbol = "N",
                AtomicMass = 14.007,
                MeltingPoint = 63.15,
                BoilingPoint = 77.36,
                StandardState = "Gas",
                ChemicalGroupBlockId = 1,
                OxidationStates = "+5, +4, +3, +2, +1, -1, -2, -3"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 8,
                Name = "Oxygen",
                Symbol = "O",
                AtomicMass = 15.999,
                MeltingPoint = 54.36,
                BoilingPoint = 90.2,
                StandardState = "Gas",
                ChemicalGroupBlockId = 1,
                OxidationStates = "-2"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 9,
                Name = "Fluorine",
                Symbol = "F",
                AtomicMass = 18.9984,
                MeltingPoint = 53.53,
                BoilingPoint = 85.03,
                StandardState = "Gas",
                ChemicalGroupBlockId = 9,
                OxidationStates = "-1"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 10,
                Name = "Neon",
                Symbol = "Ne",
                AtomicMass = 20.180,
                MeltingPoint = 24.56,
                BoilingPoint = 27.07,
                StandardState = "Gas",
                ChemicalGroupBlockId = 10,
                OxidationStates = "0"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 11,
                Name = "Sodium",
                Symbol = "Na",
                AtomicMass = 22.9897693,
                MeltingPoint = 370.95,
                BoilingPoint = 1156,
                StandardState = "Solid",
                ChemicalGroupBlockId = 2,
                OxidationStates = "+1"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 12,
                Name = "Magnesium",
                Symbol = "Mg",
                AtomicMass = 24.305,
                MeltingPoint = 923,
                BoilingPoint = 1363,
                StandardState = "Solid",
                ChemicalGroupBlockId = 3,
                OxidationStates = "+2"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 13,
                Name = "Aluminum",
                Symbol = "Al",
                AtomicMass = 26.981538,
                MeltingPoint = 933.437,
                BoilingPoint = 2792,
                StandardState = "Solid",
                ChemicalGroupBlockId = 7,
                OxidationStates = "+3"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 14,
                Name = "Silicon",
                Symbol = "Si",
                AtomicMass = 28.085,
                MeltingPoint = 1687,
                BoilingPoint = 3538,
                StandardState = "Solid",
                ChemicalGroupBlockId = 8,
                OxidationStates = "+4, +2, -4"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 15,
                Name = "Phosphorus",
                Symbol = "P",
                AtomicMass = 30.973762,
                MeltingPoint = 317.3,
                BoilingPoint = 553.65,
                StandardState = "Solid",
                ChemicalGroupBlockId = 1,
                OxidationStates = "+5, +3, -3"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 16,
                Name = "Sulfur",
                Symbol = "S",
                AtomicMass = 32.07,
                MeltingPoint = 388.36,
                BoilingPoint = 717.75,
                StandardState = "Solid",
                ChemicalGroupBlockId = 1,
                OxidationStates = "+6, +4, -2"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 17,
                Name = "Chlorine",
                Symbol = "Cl",
                AtomicMass = 35.45,
                MeltingPoint = 171.65,
                BoilingPoint = 239.11,
                StandardState = "Gas",
                ChemicalGroupBlockId = 9,
                OxidationStates = "+7, +5, +1, -1"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 18,
                Name = "Argon",
                Symbol = "Ar",
                AtomicMass = 39.9,
                MeltingPoint = 83.8,
                BoilingPoint = 87.3,
                StandardState = "Gas",
                ChemicalGroupBlockId = 10,
                OxidationStates = "0"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 19,
                Name = "Potassium",
                Symbol = "K",
                AtomicMass = 39.0983,
                MeltingPoint = 336.53,
                BoilingPoint = 1032,
                StandardState = "Solid",
                ChemicalGroupBlockId = 2,
                OxidationStates = "+1"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 20,
                Name = "Calcium",
                Symbol = "Ca",
                AtomicMass = 40.08,
                MeltingPoint = 1115,
                BoilingPoint = 1757,
                StandardState = "Solid",
                ChemicalGroupBlockId = 3,
                OxidationStates = "+2"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 21,
                Name = "Scandium",
                Symbol = "Sc",
                AtomicMass = 44.95591,
                MeltingPoint = 1814,
                BoilingPoint = 3109,
                StandardState = "Solid",
                ChemicalGroupBlockId = 6,
                OxidationStates = "+3"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 22,
                Name = "Titanium",
                Symbol = "Ti",
                AtomicMass = 47.867,
                MeltingPoint = 1941,
                BoilingPoint = 3560,
                StandardState = "Solid",
                ChemicalGroupBlockId = 6,
                OxidationStates = "+4, +3, +2"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 23,
                Name = "Vanadium",
                Symbol = "V",
                AtomicMass = 50.9415,
                MeltingPoint = 2183,
                BoilingPoint = 3680,
                StandardState = "Solid",
                ChemicalGroupBlockId = 6,
                OxidationStates = "+5, +4, +3, +2"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 24,
                Name = "Chromium",
                Symbol = "Cr",
                AtomicMass = 51.996,
                MeltingPoint = 2180,
                BoilingPoint = 2944,
                StandardState = "Solid",
                ChemicalGroupBlockId = 6,
                OxidationStates = "+6, +3, +2"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 25,
                Name = "Manganese",
                Symbol = "Mn",
                AtomicMass = 54.93804,
                MeltingPoint = 1519,
                BoilingPoint = 2334,
                StandardState = "Solid",
                ChemicalGroupBlockId = 6,
                OxidationStates = "+7, +4, +3, +2"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 26,
                Name = "Iron",
                Symbol = "Fe",
                AtomicMass = 55.84,
                MeltingPoint = 1811,
                BoilingPoint = 3134,
                StandardState = "Solid",
                ChemicalGroupBlockId = 6,
                OxidationStates = "+3, +2"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 27,
                Name = "Cobalt",
                Symbol = "Co",
                AtomicMass = 58.93319,
                MeltingPoint = 1768,
                BoilingPoint = 3200,
                StandardState = "Solid",
                ChemicalGroupBlockId = 6,
                OxidationStates = "+3, +2"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 28,
                Name = "Nickel",
                Symbol = "Ni",
                AtomicMass = 58.693,
                MeltingPoint = 1728,
                BoilingPoint = 3186,
                StandardState = "Solid",
                ChemicalGroupBlockId = 6,
                OxidationStates = "+3, +2"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 29,
                Name = "Copper",
                Symbol = "Cu",
                AtomicMass = 63.55,
                MeltingPoint = 1357.77,
                BoilingPoint = 2835,
                StandardState = "Solid",
                ChemicalGroupBlockId = 6,
                OxidationStates = "+2, +1"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 30,
                Name = "Zinc",
                Symbol = "Zn",
                AtomicMass = 65.4,
                MeltingPoint = 692.68,
                BoilingPoint = 1180,
                StandardState = "Solid",
                ChemicalGroupBlockId = 6,
                OxidationStates = "+2"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 31,
                Name = "Gallium",
                Symbol = "Ga",
                AtomicMass = 69.723,
                MeltingPoint = 302.91,
                BoilingPoint = 2477,
                StandardState = "Solid",
                ChemicalGroupBlockId = 7,
                OxidationStates = "+3"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 32,
                Name = "Germanium",
                Symbol = "Ge",
                AtomicMass = 72.63,
                MeltingPoint = 1211.4,
                BoilingPoint = 3106,
                StandardState = "Solid",
                ChemicalGroupBlockId = 8,
                OxidationStates = "+4, +2"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 33,
                Name = "Arsenic",
                Symbol = "As",
                AtomicMass = 74.92159,
                MeltingPoint = 1090,
                BoilingPoint = 887,
                StandardState = "Solid",
                ChemicalGroupBlockId = 8,
                OxidationStates = "+5, +3, -3"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 34,
                Name = "Selenium",
                Symbol = "Se",
                AtomicMass = 78.97,
                MeltingPoint = 493.65,
                BoilingPoint = 958,
                StandardState = "Solid",
                ChemicalGroupBlockId = 1,
                OxidationStates = "+6, +4, -2"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 35,
                Name = "Bromine",
                Symbol = "Br",
                AtomicMass = 79.90,
                MeltingPoint = 265.95,
                BoilingPoint = 331.95,
                StandardState = "Liquid",
                ChemicalGroupBlockId = 9,
                OxidationStates = "+7, +1, -1"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 36,
                Name = "Krypton",
                Symbol = "Kr",
                AtomicMass = 83.80,
                MeltingPoint = 115.79,
                BoilingPoint = 119.93,
                StandardState = "Gas",
                ChemicalGroupBlockId = 10,
                OxidationStates = "0"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 37,
                Name = "Rubidium",
                Symbol = "Rb",
                AtomicMass = 85.468,
                MeltingPoint = 312.46,
                BoilingPoint = 961,
                StandardState = "Solid",
                ChemicalGroupBlockId = 2,
                OxidationStates = "+1"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 38,
                Name = "Strontium",
                Symbol = "Sr",
                AtomicMass = 87.62,
                MeltingPoint = 1050,
                BoilingPoint = 1655,
                StandardState = "Solid",
                ChemicalGroupBlockId = 3,
                OxidationStates = "+2"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 39,
                Name = "Yttrium",
                Symbol = "Y",
                AtomicMass = 88.90584,
                MeltingPoint = 1795,
                BoilingPoint = 3618,
                StandardState = "Solid",
                ChemicalGroupBlockId = 6,
                OxidationStates = "+3"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 40,
                Name = "Zirconium",
                Symbol = "Zr",
                AtomicMass = 91.22,
                MeltingPoint = 2128,
                BoilingPoint = 4682,
                StandardState = "Solid",
                ChemicalGroupBlockId = 6,
                OxidationStates = "+4"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 41,
                Name = "Niobium",
                Symbol = "Nb",
                AtomicMass = 92.90637,
                MeltingPoint = 2750,
                BoilingPoint = 5017,
                StandardState = "Solid",
                ChemicalGroupBlockId = 6,
                OxidationStates = "+5, +3"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 42,
                Name = "Molybdenum",
                Symbol = "Mo",
                AtomicMass = 95.95,
                MeltingPoint = 2896,
                BoilingPoint = 4912,
                StandardState = "Solid",
                ChemicalGroupBlockId = 6,
                OxidationStates = "+6"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 43,
                Name = "Technetium",
                Symbol = "Tc",
                AtomicMass = 96.90636,
                MeltingPoint = 2430,
                BoilingPoint = 4538,
                StandardState = "Solid",
                ChemicalGroupBlockId = 6,
                OxidationStates = "+7, +6, +4"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 44,
                Name = "Ruthenium",
                Symbol = "Ru",
                AtomicMass = 101.1,
                MeltingPoint = 2607,
                BoilingPoint = 4423,
                StandardState = "Solid",
                ChemicalGroupBlockId = 6,
                OxidationStates = "+3"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 45,
                Name = "Rhodium",
                Symbol = "Rh",
                AtomicMass = 102.9055,
                MeltingPoint = 2237,
                BoilingPoint = 3968,
                StandardState = "Solid",
                ChemicalGroupBlockId = 6,
                OxidationStates = "+3"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 46,
                Name = "Palladium",
                Symbol = "Pd",
                AtomicMass = 106.42,
                MeltingPoint = 1828.05,
                BoilingPoint = 3236,
                StandardState = "Solid",
                ChemicalGroupBlockId = 6,
                OxidationStates = "+3, +2"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 47,
                Name = "Silver",
                Symbol = "Ag",
                AtomicMass = 107.868,
                MeltingPoint = 1234.93,
                BoilingPoint = 2435,
                StandardState = "Solid",
                ChemicalGroupBlockId = 6,
                OxidationStates = "+1"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 48,
                Name = "Cadmium",
                Symbol = "Cd",
                AtomicMass = 112.41,
                MeltingPoint = 594.22,
                BoilingPoint = 1040,
                StandardState = "Solid",
                ChemicalGroupBlockId = 6,
                OxidationStates = "+2"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 49,
                Name = "Indium",
                Symbol = "In",
                AtomicMass = 114.818,
                MeltingPoint = 429.75,
                BoilingPoint = 2345,
                StandardState = "Solid",
                ChemicalGroupBlockId = 7,
                OxidationStates = "+3"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 50,
                Name = "Tin",
                Symbol = "Sn",
                AtomicMass = 118.71,
                MeltingPoint = 505.08,
                BoilingPoint = 2875,
                StandardState = "Solid",
                ChemicalGroupBlockId = 7,
                OxidationStates = "+4, +2"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 51,
                Name = "Antimony",
                Symbol = "Sb",
                AtomicMass = 121.76,
                MeltingPoint = 903.78,
                BoilingPoint = 1860,
                StandardState = "Solid",
                ChemicalGroupBlockId = 8,
                OxidationStates = "+5, +3, -3"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 52,
                Name = "Tellurium",
                Symbol = "Te",
                AtomicMass = 127.6,
                MeltingPoint = 722.66,
                BoilingPoint = 1261,
                StandardState = "Solid",
                ChemicalGroupBlockId = 8,
                OxidationStates = "+6, +4, -2"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 53,
                Name = "Iodine",
                Symbol = "I",
                AtomicMass = 126.9045,
                MeltingPoint = 386.85,
                BoilingPoint = 457.55,
                StandardState = "Solid",
                ChemicalGroupBlockId = 9,
                OxidationStates = "+7, +5, +1, -1"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 54,
                Name = "Xenon",
                Symbol = "Xe",
                AtomicMass = 131.29,
                MeltingPoint = 161.36,
                BoilingPoint = 165.03,
                StandardState = "Gas",
                ChemicalGroupBlockId = 10,
                OxidationStates = "0"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 55,
                Name = "Cesium",
                Symbol = "Cs",
                AtomicMass = 132.905452,
                MeltingPoint = 301.59,
                BoilingPoint = 944,
                StandardState = "Solid",
                ChemicalGroupBlockId = 2,
                OxidationStates = "+1"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 56,
                Name = "Barium",
                Symbol = "Ba",
                AtomicMass = 137.33,
                MeltingPoint = 1000,
                BoilingPoint = 2170,
                StandardState = "Solid",
                ChemicalGroupBlockId = 3,
                OxidationStates = "+2"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 57,
                Name = "Lanthanum",
                Symbol = "La",
                AtomicMass = 138.9055,
                MeltingPoint = 1191,
                BoilingPoint = 3737,
                StandardState = "Solid",
                ChemicalGroupBlockId = 4,
                OxidationStates = "+3"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 58,
                Name = "Cerium",
                Symbol = "Ce",
                AtomicMass = 140.116,
                MeltingPoint = 1071,
                BoilingPoint = 3697,
                StandardState = "Solid",
                ChemicalGroupBlockId = 4,
                OxidationStates = "+4, +3"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 59,
                Name = "Praseodymium",
                Symbol = "Pr",
                AtomicMass = 140.90766,
                MeltingPoint = 1204,
                BoilingPoint = 3793,
                StandardState = "Solid",
                ChemicalGroupBlockId = 4,
                OxidationStates = "+3"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 60,
                Name = "Neodymium",
                Symbol = "Nd",
                AtomicMass = 144.24,
                MeltingPoint = 1294,
                BoilingPoint = 3347,
                StandardState = "Solid",
                ChemicalGroupBlockId = 4,
                OxidationStates = "+3"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 61,
                Name = "Promethium",
                Symbol = "Pm",
                AtomicMass = 144.91276,
                MeltingPoint = 1315,
                BoilingPoint = 3273,
                StandardState = "Solid",
                ChemicalGroupBlockId = 4,
                OxidationStates = "+3"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 62,
                Name = "Samarium",
                Symbol = "Sm",
                AtomicMass = 150.4,
                MeltingPoint = 1347,
                BoilingPoint = 2067,
                StandardState = "Solid",
                ChemicalGroupBlockId = 4,
                OxidationStates = "+3, +2"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 63,
                Name = "Europium",
                Symbol = "Eu",
                AtomicMass = 151.964,
                MeltingPoint = 1095,
                BoilingPoint = 1802,
                StandardState = "Solid",
                ChemicalGroupBlockId = 4,
                OxidationStates = "+3, +2"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 64,
                Name = "Gadolinium",
                Symbol = "Gd",
                AtomicMass = 157.2,
                MeltingPoint = 1586,
                BoilingPoint = 3546,
                StandardState = "Solid",
                ChemicalGroupBlockId = 4,
                OxidationStates = "+3"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 65,
                Name = "Terbium",
                Symbol = "Tb",
                AtomicMass = 158.92535,
                MeltingPoint = 1629,
                BoilingPoint = 3503,
                StandardState = "Solid",
                ChemicalGroupBlockId = 4,
                OxidationStates = "+3"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 66,
                Name = "Dysprosium",
                Symbol = "Dy",
                AtomicMass = 162.5,
                MeltingPoint = 1685,
                BoilingPoint = 2840,
                StandardState = "Solid",
                ChemicalGroupBlockId = 4,
                OxidationStates = "+3"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 67,
                Name = "Holmium",
                Symbol = "Ho",
                AtomicMass = 164.93033,
                MeltingPoint = 1747,
                BoilingPoint = 2973,
                StandardState = "Solid",
                ChemicalGroupBlockId = 4,
                OxidationStates = "+3"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 68,
                Name = "Erbium",
                Symbol = "Er",
                AtomicMass = 167.26,
                MeltingPoint = 1802,
                BoilingPoint = 3141,
                StandardState = "Solid",
                ChemicalGroupBlockId = 4,
                OxidationStates = "+3"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 69,
                Name = "Thulium",
                Symbol = "Tm",
                AtomicMass = 168.93422,
                MeltingPoint = 1818,
                BoilingPoint = 2223,
                StandardState = "Solid",
                ChemicalGroupBlockId = 4,
                OxidationStates = "+3"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 70,
                Name = "Ytterbium",
                Symbol = "Yb",
                AtomicMass = 173.05,
                MeltingPoint = 1092,
                BoilingPoint = 1469,
                StandardState = "Solid",
                ChemicalGroupBlockId = 4,
                OxidationStates = "+3, +2"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 71,
                Name = "Lutetium",
                Symbol = "Lu",
                AtomicMass = 174.9668,
                MeltingPoint = 1936,
                BoilingPoint = 3675,
                StandardState = "Solid",
                ChemicalGroupBlockId = 4,
                OxidationStates = "+3"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 72,
                Name = "Hafnium",
                Symbol = "Hf",
                AtomicMass = 178.49,
                MeltingPoint = 2506,
                BoilingPoint = 4876,
                StandardState = "Solid",
                ChemicalGroupBlockId = 6,
                OxidationStates = "Solid"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 73,
                Name = "Tantalum",
                Symbol = "Ta",
                AtomicMass = 180.9479,
                MeltingPoint = 3290,
                BoilingPoint = 5731,
                StandardState = "Solid",
                ChemicalGroupBlockId = 6,
                OxidationStates = "+5"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 74,
                Name = "Tungsten",
                Symbol = "W",
                AtomicMass = 183.84,
                MeltingPoint = 3695,
                BoilingPoint = 5828,
                StandardState = "Solid",
                ChemicalGroupBlockId = 6,
                OxidationStates = "+6"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 75,
                Name = "Rhenium",
                Symbol = "Re",
                AtomicMass = 186.207,
                MeltingPoint = 3459,
                BoilingPoint = 5869,
                StandardState = "Solid",
                ChemicalGroupBlockId = 6,
                OxidationStates = "+7, +6, +4"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 76,
                Name = "Osmium",
                Symbol = "Os",
                AtomicMass = 190.2,
                MeltingPoint = 3306,
                BoilingPoint = 5285,
                StandardState = "Solid",
                ChemicalGroupBlockId = 6,
                OxidationStates = "+4, +3"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 77,
                Name = "Iridium",
                Symbol = "Ir",
                AtomicMass = 192.22,
                MeltingPoint = 2719,
                BoilingPoint = 4701,
                StandardState = "Solid",
                ChemicalGroupBlockId = 6,
                OxidationStates = "+4, +3"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 78,
                Name = "Platinum",
                Symbol = "Pt",
                AtomicMass = 195.08,
                MeltingPoint = 2041.55,
                BoilingPoint = 4098,
                StandardState = "Solid",
                ChemicalGroupBlockId = 6,
                OxidationStates = "+4, +2"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 79,
                Name = "Gold",
                Symbol = "Au",
                AtomicMass = 196.96657,
                MeltingPoint = 1337.33,
                BoilingPoint = 3129,
                StandardState = "Solid",
                ChemicalGroupBlockId = 6,
                OxidationStates = "+3, +1"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 80,
                Name = "Mercury",
                Symbol = "Hg",
                AtomicMass = 200.59,
                MeltingPoint = 234.32,
                BoilingPoint = 629.88,
                StandardState = "Liquid",
                ChemicalGroupBlockId = 6,
                OxidationStates = "+2, +1"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 81,
                Name = "Thallium",
                Symbol = "Tl",
                AtomicMass = 204.383,
                MeltingPoint = 577,
                BoilingPoint = 1746,
                StandardState = "Solid",
                ChemicalGroupBlockId = 7,
                OxidationStates = "+3, +1"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 82,
                Name = "Lead",
                Symbol = "Pb",
                AtomicMass = 207,
                MeltingPoint = 600.61,
                BoilingPoint = 2022,
                StandardState = "Solid",
                ChemicalGroupBlockId = 7,
                OxidationStates = "+4, +2"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 83,
                Name = "Bismuth",
                Symbol = "Bi",
                AtomicMass = 208.9804,
                MeltingPoint = 544.55,
                BoilingPoint = 1837,
                StandardState = "Solid",
                ChemicalGroupBlockId = 7,
                OxidationStates = "+5, +3"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 84,
                Name = "Polonium",
                Symbol = "Po",
                AtomicMass = 208.98243,
                MeltingPoint = 527,
                BoilingPoint = 1235,
                StandardState = "Solid",
                ChemicalGroupBlockId = 8,
                OxidationStates = "+4, +2"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 85,
                Name = "Astatine",
                Symbol = "At",
                AtomicMass = 209.98715,
                MeltingPoint = 575,
                StandardState = "Solid",
                ChemicalGroupBlockId = 9,
                OxidationStates = "+7, +5, +3, +1, -1"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 86,
                Name = "Radon",
                Symbol = "Rn",
                AtomicMass = 222.01758,
                MeltingPoint = 202,
                BoilingPoint = 211.45,
                StandardState = "Gas",
                ChemicalGroupBlockId = 10,
                OxidationStates = "0"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 87,
                Name = "Francium",
                Symbol = "Fr",
                AtomicMass = 223.01973,
                MeltingPoint = 300,
                StandardState = "Solid",
                ChemicalGroupBlockId = 2,
                OxidationStates = "+1"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 88,
                Name = "Radium",
                Symbol = "Ra",
                AtomicMass = 226.02541,
                MeltingPoint = 973,
                BoilingPoint = 1413,
                StandardState = "Solid",
                ChemicalGroupBlockId = 3,
                OxidationStates = "+2"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 89,
                Name = "Actinium",
                Symbol = "Ac",
                AtomicMass = 227.02775,
                MeltingPoint = 1324,
                BoilingPoint = 3471,
                StandardState = "Solid",
                ChemicalGroupBlockId = 5,
                OxidationStates = "+3"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 90,
                Name = "Thorium",
                Symbol = "Th",
                AtomicMass = 232.038,
                MeltingPoint = 2023,
                BoilingPoint = 5061,
                StandardState = "Solid",
                ChemicalGroupBlockId = 5,
                OxidationStates = "+4"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 91,
                Name = "Protactinium",
                Symbol = "Pa",
                AtomicMass = 231.03588,
                MeltingPoint = 1845,
                StandardState = "Solid",
                ChemicalGroupBlockId = 5,
                OxidationStates = "+5, +4"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 92,
                Name = "Uranium",
                Symbol = "U",
                AtomicMass = 238.0289,
                MeltingPoint = 1408,
                BoilingPoint = 4404,
                StandardState = "Solid",
                ChemicalGroupBlockId = 5,
                OxidationStates = "+6, +5, +4, +3"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 93,
                Name = "Neptunium",
                Symbol = "Np",
                AtomicMass = 237.048172,
                MeltingPoint = 917,
                BoilingPoint = 4175,
                StandardState = "Solid",
                ChemicalGroupBlockId = 5,
                OxidationStates = "+6, +5, +4, +3"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 94,
                Name = "Plutonium",
                Symbol = "Pu",
                AtomicMass = 244.0642,
                MeltingPoint = 913,
                BoilingPoint = 3501,
                StandardState = "Solid",
                ChemicalGroupBlockId = 5,
                OxidationStates = "+6, +5, +4, +3"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 95,
                Name = "Americium",
                Symbol = "Am",
                AtomicMass = 243.06138,
                MeltingPoint = 1449,
                BoilingPoint = 2284,
                StandardState = "Solid",
                ChemicalGroupBlockId = 5,
                OxidationStates = "+6, +5, +4, +3"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 96,
                Name = "Curium",
                Symbol = "Cm",
                AtomicMass = 247.07035,
                MeltingPoint = 1618,
                BoilingPoint = 3400,
                StandardState = "Solid",
                ChemicalGroupBlockId = 5,
                OxidationStates = "+3"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 97,
                Name = "Berkelium",
                Symbol = "Bk",
                AtomicMass = 247.07031,
                MeltingPoint = 1323,
                StandardState = "Solid",
                ChemicalGroupBlockId = 5,
                OxidationStates = "+4, +3"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 98,
                Name = "Californium",
                Symbol = "Cf",
                AtomicMass = 251.07959,
                MeltingPoint = 1173,
                StandardState = "Solid",
                ChemicalGroupBlockId = 5,
                OxidationStates = "+3"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 99,
                Name = "Einsteinium",
                Symbol = "Es",
                AtomicMass = 252.083,
                MeltingPoint = 1133,
                StandardState = "Solid",
                ChemicalGroupBlockId = 5,
                OxidationStates = "+3"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 100,
                Name = "Fermium",
                Symbol = "Fm",
                AtomicMass = 257.09511,
                MeltingPoint = 1800,
                StandardState = "Solid",
                ChemicalGroupBlockId = 5,
                OxidationStates = "+3"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 101,
                Name = "Mendelevium",
                Symbol = "Md",
                AtomicMass = 258.09843,
                MeltingPoint = 1100,
                StandardState = "Solid",
                ChemicalGroupBlockId = 5,
                OxidationStates = "+3, +2"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 102,
                Name = "Nobelium",
                Symbol = "No",
                AtomicMass = 259.101,
                MeltingPoint = 1100,
                StandardState = "Solid",
                ChemicalGroupBlockId = 5,
                OxidationStates = "+3, +2"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 103,
                Name = "Lawrencium",
                Symbol = "Lr",
                AtomicMass = 266.12,
                MeltingPoint = 1900,
                StandardState = "Solid",
                ChemicalGroupBlockId = 5,
                OxidationStates = "+3"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 104,
                Name = "Rutherfordium",
                Symbol = "Rf",
                AtomicMass = 267.122,
                StandardState = "Solid",
                ChemicalGroupBlockId = 6,
                OxidationStates = "+4"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 105,
                Name = "Dubnium",
                Symbol = "Db",
                AtomicMass = 268.126,
                StandardState = "Solid",
                ChemicalGroupBlockId = 6,
                OxidationStates = "+5, +4, +3"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 106,
                Name = "Seaborgium",
                Symbol = "Sg",
                AtomicMass = 269.128,
                StandardState = "Solid",
                ChemicalGroupBlockId = 6,
                OxidationStates = "+6, +5, +4, +3, 0"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 107,
                Name = "Bohrium",
                Symbol = "Bh",
                AtomicMass = 270.133,
                StandardState = "Solid",
                ChemicalGroupBlockId = 6,
                OxidationStates = "+7, +5, +4, +3"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 108,
                Name = "Hassium",
                Symbol = "Hs",
                AtomicMass = 269.1336,
                StandardState = "Solid",
                ChemicalGroupBlockId = 6,
                OxidationStates = "+8, +6, +5, +4, +3, +2"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 109,
                Name = "Meitnerium",
                Symbol = "Mt",
                AtomicMass = 277.154,
                StandardState = "Solid",
                ChemicalGroupBlockId = 6,
                OxidationStates = "+9, +8, +6, +4, +3, +1"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 110,
                Name = "Darmstadtium",
                Symbol = "Ds",
                AtomicMass = 282.166,
                StandardState = "Solid",
                ChemicalGroupBlockId = 6,
                OxidationStates = "+8, +6, +4, +2, 0"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 111,
                Name = "Roentgenium",
                Symbol = "Rg",
                AtomicMass = 282.169,
                StandardState = "Solid",
                ChemicalGroupBlockId = 6,
                OxidationStates = "+5, +3, +1, -1"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 112,
                Name = "Copernicium",
                Symbol = "Cn",
                AtomicMass = 286.179,
                StandardState = "Solid",
                ChemicalGroupBlockId = 6,
                OxidationStates = "+2, +1, 0"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 113,
                Name = "Nihonium",
                Symbol = "Nh",
                AtomicMass = 286.182,
                StandardState = "Solid",
                ChemicalGroupBlockId = 7,
                OxidationStates = "+3, +1"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 114,
                Name = "Flerovium",
                Symbol = "Fl",
                AtomicMass = 290.192,
                StandardState = "Solid",
                ChemicalGroupBlockId = 7,
                OxidationStates = "+6, +4, +2, +1, 0"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 115,
                Name = "Moscovium",
                Symbol = "Mc",
                AtomicMass = 290.196,
                StandardState = "Solid",
                ChemicalGroupBlockId = 7,
                OxidationStates = "+3, +1"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 116,
                Name = "Livermorium",
                Symbol = "Lv",
                AtomicMass = 293.205,
                StandardState = "Solid",
                ChemicalGroupBlockId = 7,
                OxidationStates = "+4, +2, -2"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 117,
                Name = "Tennessine",
                Symbol = "Ts",
                AtomicMass = 294.211,
                StandardState = "Solid",
                ChemicalGroupBlockId = 9,
                OxidationStates = "+5, +3, +1, -1"
            };
            elements.Add(element);

            element = new Element()
            {
                Id = 118,
                Name = "Oganesson",
                Symbol = "Og",
                AtomicMass = 295.216,
                StandardState = "Gas",
                ChemicalGroupBlockId = 10,
                OxidationStates = "+6, +4, +2, +1, 0, -1"
            };
            elements.Add(element);

            return elements.ToArray();
        }
    }
}
