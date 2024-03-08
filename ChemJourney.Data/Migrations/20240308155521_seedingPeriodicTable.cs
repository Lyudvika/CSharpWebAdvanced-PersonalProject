using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChemJourney.Data.Migrations
{
    public partial class seedingPeriodicTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Elements",
                columns: new[] { "Id", "AtomicMass", "BoilingPoint", "ChemicalGroupBlockId", "MeltingPoint", "Name", "OxidationStates", "StandardState", "Symbol" },
                values: new object[,]
                {
                    { 1, 1.008, 20.280000000000001, 1, 13.81, "Hydrogen", "+1, -1", "Gas", "H" },
                    { 2, 4.0026000000000002, 4.2199999999999998, 10, 0.94999999999999996, "Helium", "0", "Gas", "He" },
                    { 3, 7.0, 1615.0, 2, 453.64999999999998, "Lithium", "+1", "Solid", "Li" },
                    { 4, 9.0121830000000003, 2744.0, 3, 1560.0, "Beryllium", "+2", "Solid", "Be" },
                    { 5, 10.81, 4273.0, 8, 2348.0, "Boron", "+3", "Solid", "B" },
                    { 6, 12.010999999999999, 4098.0, 1, 3823.0, "Carbon", "+4, +2, -4", "Solid", "C" },
                    { 7, 14.007, 77.359999999999999, 1, 63.149999999999999, "Nitrogen", "+5, +4, +3, +2, +1, -1, -2, -3", "Gas", "N" },
                    { 8, 15.999000000000001, 90.200000000000003, 1, 54.359999999999999, "Oxygen", "-2", "Gas", "O" },
                    { 9, 18.9984, 85.030000000000001, 9, 53.530000000000001, "Fluorine", "-1", "Gas", "F" },
                    { 10, 20.18, 27.07, 10, 24.559999999999999, "Neon", "0", "Gas", "Ne" },
                    { 11, 22.989769299999999, 1156.0, 2, 370.94999999999999, "Sodium", "+1", "Solid", "Na" },
                    { 12, 24.305, 1363.0, 3, 923.0, "Magnesium", "+2", "Solid", "Mg" },
                    { 13, 26.981538, 2792.0, 7, 933.43700000000001, "Aluminum", "+3", "Solid", "Al" },
                    { 14, 28.085000000000001, 3538.0, 8, 1687.0, "Silicon", "+4, +2, -4", "Solid", "Si" },
                    { 15, 30.973762000000001, 553.64999999999998, 1, 317.30000000000001, "Phosphorus", "+5, +3, -3", "Solid", "P" },
                    { 16, 32.07, 717.75, 1, 388.36000000000001, "Sulfur", "+6, +4, -2", "Solid", "S" },
                    { 17, 35.450000000000003, 239.11000000000001, 9, 171.65000000000001, "Chlorine", "+7, +5, +1, -1", "Gas", "Cl" },
                    { 18, 39.899999999999999, 87.299999999999997, 10, 83.799999999999997, "Argon", "0", "Gas", "Ar" },
                    { 19, 39.098300000000002, 1032.0, 2, 336.52999999999997, "Potassium", "+1", "Solid", "K" },
                    { 20, 40.079999999999998, 1757.0, 3, 1115.0, "Calcium", "+2", "Solid", "Ca" },
                    { 21, 44.955910000000003, 3109.0, 6, 1814.0, "Scandium", "+3", "Solid", "Sc" },
                    { 22, 47.866999999999997, 3560.0, 6, 1941.0, "Titanium", "+4, +3, +2", "Solid", "Ti" },
                    { 23, 50.941499999999998, 3680.0, 6, 2183.0, "Vanadium", "+5, +4, +3, +2", "Solid", "V" },
                    { 24, 51.996000000000002, 2944.0, 6, 2180.0, "Chromium", "+6, +3, +2", "Solid", "Cr" },
                    { 25, 54.938040000000001, 2334.0, 6, 1519.0, "Manganese", "+7, +4, +3, +2", "Solid", "Mn" },
                    { 26, 55.840000000000003, 3134.0, 6, 1811.0, "Iron", "+3, +2", "Solid", "Fe" },
                    { 27, 58.933190000000003, 3200.0, 6, 1768.0, "Cobalt", "+3, +2", "Solid", "Co" },
                    { 28, 58.692999999999998, 3186.0, 6, 1728.0, "Nickel", "+3, +2", "Solid", "Ni" },
                    { 29, 63.549999999999997, 2835.0, 6, 1357.77, "Copper", "+2, +1", "Solid", "Cu" },
                    { 30, 65.400000000000006, 1180.0, 6, 692.67999999999995, "Zinc", "+2", "Solid", "Zn" },
                    { 31, 69.722999999999999, 2477.0, 7, 302.91000000000003, "Gallium", "+3", "Solid", "Ga" },
                    { 32, 72.629999999999995, 3106.0, 8, 1211.4000000000001, "Germanium", "+4, +2", "Solid", "Ge" },
                    { 33, 74.921589999999995, 887.0, 8, 1090.0, "Arsenic", "+5, +3, -3", "Solid", "As" },
                    { 34, 78.969999999999999, 958.0, 1, 493.64999999999998, "Selenium", "+6, +4, -2", "Solid", "Se" },
                    { 35, 79.900000000000006, 331.94999999999999, 9, 265.94999999999999, "Bromine", "+7, +1, -1", "Liquid", "Br" },
                    { 36, 83.799999999999997, 119.93000000000001, 10, 115.79000000000001, "Krypton", "0", "Gas", "Kr" },
                    { 37, 85.468000000000004, 961.0, 2, 312.45999999999998, "Rubidium", "+1", "Solid", "Rb" },
                    { 38, 87.620000000000005, 1655.0, 3, 1050.0, "Strontium", "+2", "Solid", "Sr" },
                    { 39, 88.905839999999998, 3618.0, 6, 1795.0, "Yttrium", "+3", "Solid", "Y" },
                    { 40, 91.219999999999999, 4682.0, 6, 2128.0, "Zirconium", "+4", "Solid", "Zr" },
                    { 41, 92.906369999999995, 5017.0, 6, 2750.0, "Niobium", "+5, +3", "Solid", "Nb" },
                    { 42, 95.950000000000003, 4912.0, 6, 2896.0, "Molybdenum", "+6", "Solid", "Mo" }
                });

            migrationBuilder.InsertData(
                table: "Elements",
                columns: new[] { "Id", "AtomicMass", "BoilingPoint", "ChemicalGroupBlockId", "MeltingPoint", "Name", "OxidationStates", "StandardState", "Symbol" },
                values: new object[,]
                {
                    { 43, 96.906360000000006, 4538.0, 6, 2430.0, "Technetium", "+7, +6, +4", "Solid", "Tc" },
                    { 44, 101.09999999999999, 4423.0, 6, 2607.0, "Ruthenium", "+3", "Solid", "Ru" },
                    { 45, 102.9055, 3968.0, 6, 2237.0, "Rhodium", "+3", "Solid", "Rh" },
                    { 46, 106.42, 3236.0, 6, 1828.05, "Palladium", "+3, +2", "Solid", "Pd" },
                    { 47, 107.86799999999999, 2435.0, 6, 1234.9300000000001, "Silver", "+1", "Solid", "Ag" },
                    { 48, 112.41, 1040.0, 6, 594.22000000000003, "Cadmium", "+2", "Solid", "Cd" },
                    { 49, 114.818, 2345.0, 7, 429.75, "Indium", "+3", "Solid", "In" },
                    { 50, 118.70999999999999, 2875.0, 7, 505.07999999999998, "Tin", "+4, +2", "Solid", "Sn" },
                    { 51, 121.76000000000001, 1860.0, 8, 903.77999999999997, "Antimony", "+5, +3, -3", "Solid", "Sb" },
                    { 52, 127.59999999999999, 1261.0, 8, 722.65999999999997, "Tellurium", "+6, +4, -2", "Solid", "Te" },
                    { 53, 126.9045, 457.55000000000001, 9, 386.85000000000002, "Iodine", "+7, +5, +1, -1", "Solid", "I" },
                    { 54, 131.28999999999999, 165.03, 10, 161.36000000000001, "Xenon", "0", "Gas", "Xe" },
                    { 55, 132.905452, 944.0, 2, 301.58999999999997, "Cesium", "+1", "Solid", "Cs" },
                    { 56, 137.33000000000001, 2170.0, 3, 1000.0, "Barium", "+2", "Solid", "Ba" },
                    { 57, 138.90549999999999, 3737.0, 4, 1191.0, "Lanthanum", "+3", "Solid", "La" },
                    { 58, 140.11600000000001, 3697.0, 4, 1071.0, "Cerium", "+4, +3", "Solid", "Ce" },
                    { 59, 140.90765999999999, 3793.0, 4, 1204.0, "Praseodymium", "+3", "Solid", "Pr" },
                    { 60, 144.24000000000001, 3347.0, 4, 1294.0, "Neodymium", "+3", "Solid", "Nd" },
                    { 61, 144.91275999999999, 3273.0, 4, 1315.0, "Promethium", "+3", "Solid", "Pm" },
                    { 62, 150.40000000000001, 2067.0, 4, 1347.0, "Samarium", "+3, +2", "Solid", "Sm" },
                    { 63, 151.964, 1802.0, 4, 1095.0, "Europium", "+3, +2", "Solid", "Eu" },
                    { 64, 157.19999999999999, 3546.0, 4, 1586.0, "Gadolinium", "+3", "Solid", "Gd" },
                    { 65, 158.92535000000001, 3503.0, 4, 1629.0, "Terbium", "+3", "Solid", "Tb" },
                    { 66, 162.5, 2840.0, 4, 1685.0, "Dysprosium", "+3", "Solid", "Dy" },
                    { 67, 164.93033, 2973.0, 4, 1747.0, "Holmium", "+3", "Solid", "Ho" },
                    { 68, 167.25999999999999, 3141.0, 4, 1802.0, "Erbium", "+3", "Solid", "Er" },
                    { 69, 168.93422000000001, 2223.0, 4, 1818.0, "Thulium", "+3", "Solid", "Tm" },
                    { 70, 173.05000000000001, 1469.0, 4, 1092.0, "Ytterbium", "+3, +2", "Solid", "Yb" },
                    { 71, 174.96680000000001, 3675.0, 4, 1936.0, "Lutetium", "+3", "Solid", "Lu" },
                    { 72, 178.49000000000001, 4876.0, 6, 2506.0, "Hafnium", "Solid", "Solid", "Hf" },
                    { 73, 180.9479, 5731.0, 6, 3290.0, "Tantalum", "+5", "Solid", "Ta" },
                    { 74, 183.84, 5828.0, 6, 3695.0, "Tungsten", "+6", "Solid", "W" },
                    { 75, 186.20699999999999, 5869.0, 6, 3459.0, "Rhenium", "+7, +6, +4", "Solid", "Re" },
                    { 76, 190.19999999999999, 5285.0, 6, 3306.0, "Osmium", "+4, +3", "Solid", "Os" },
                    { 77, 192.22, 4701.0, 6, 2719.0, "Iridium", "+4, +3", "Solid", "Ir" },
                    { 78, 195.08000000000001, 4098.0, 6, 2041.55, "Platinum", "+4, +2", "Solid", "Pt" },
                    { 79, 196.96656999999999, 3129.0, 6, 1337.3299999999999, "Gold", "+3, +1", "Solid", "Au" },
                    { 80, 200.59, 629.88, 6, 234.31999999999999, "Mercury", "+2, +1", "Liquid", "Hg" },
                    { 81, 204.38300000000001, 1746.0, 7, 577.0, "Thallium", "+3, +1", "Solid", "Tl" },
                    { 82, 207.0, 2022.0, 7, 600.61000000000001, "Lead", "+4, +2", "Solid", "Pb" },
                    { 83, 208.9804, 1837.0, 7, 544.54999999999995, "Bismuth", "+5, +3", "Solid", "Bi" },
                    { 84, 208.98242999999999, 1235.0, 8, 527.0, "Polonium", "+4, +2", "Solid", "Po" }
                });

            migrationBuilder.InsertData(
                table: "Elements",
                columns: new[] { "Id", "AtomicMass", "BoilingPoint", "ChemicalGroupBlockId", "MeltingPoint", "Name", "OxidationStates", "StandardState", "Symbol" },
                values: new object[,]
                {
                    { 85, 209.98715000000001, null, 9, 575.0, "Astatine", "+7, +5, +3, +1, -1", "Solid", "At" },
                    { 86, 222.01758000000001, 211.44999999999999, 10, 202.0, "Radon", "0", "Gas", "Rn" },
                    { 87, 223.01973000000001, null, 2, 300.0, "Francium", "+1", "Solid", "Fr" },
                    { 88, 226.02540999999999, 1413.0, 3, 973.0, "Radium", "+2", "Solid", "Ra" },
                    { 89, 227.02775, 3471.0, 5, 1324.0, "Actinium", "+3", "Solid", "Ac" },
                    { 90, 232.03800000000001, 5061.0, 5, 2023.0, "Thorium", "+4", "Solid", "Th" },
                    { 91, 231.03587999999999, null, 5, 1845.0, "Protactinium", "+5, +4", "Solid", "Pa" },
                    { 92, 238.02889999999999, 4404.0, 5, 1408.0, "Uranium", "+6, +5, +4, +3", "Solid", "U" },
                    { 93, 237.04817199999999, 4175.0, 5, 917.0, "Neptunium", "+6, +5, +4, +3", "Solid", "Np" },
                    { 94, 244.0642, 3501.0, 5, 913.0, "Plutonium", "+6, +5, +4, +3", "Solid", "Pu" },
                    { 95, 243.06138000000001, 2284.0, 5, 1449.0, "Americium", "+6, +5, +4, +3", "Solid", "Am" },
                    { 96, 247.07034999999999, 3400.0, 5, 1618.0, "Curium", "+3", "Solid", "Cm" },
                    { 97, 247.07031000000001, null, 5, 1323.0, "Berkelium", "+4, +3", "Solid", "Bk" },
                    { 98, 251.07959, null, 5, 1173.0, "Californium", "+3", "Solid", "Cf" },
                    { 99, 252.083, null, 5, 1133.0, "Einsteinium", "+3", "Solid", "Es" },
                    { 100, 257.09510999999998, null, 5, 1800.0, "Fermium", "+3", "Solid", "Fm" },
                    { 101, 258.09843000000001, null, 5, 1100.0, "Mendelevium", "+3, +2", "Solid", "Md" },
                    { 102, 259.101, null, 5, 1100.0, "Nobelium", "+3, +2", "Solid", "No" },
                    { 103, 266.12, null, 5, 1900.0, "Lawrencium", "+3", "Solid", "Lr" },
                    { 104, 267.12200000000001, null, 6, null, "Rutherfordium", "+4", "Solid", "Rf" },
                    { 105, 268.12599999999998, null, 6, null, "Dubnium", "+5, +4, +3", "Solid", "Db" },
                    { 106, 269.12799999999999, null, 6, null, "Seaborgium", "+6, +5, +4, +3, 0", "Solid", "Sg" },
                    { 107, 270.13299999999998, null, 6, null, "Bohrium", "+7, +5, +4, +3", "Solid", "Bh" },
                    { 108, 269.1336, null, 6, null, "Hassium", "+8, +6, +5, +4, +3, +2", "Solid", "Hs" },
                    { 109, 277.154, null, 6, null, "Meitnerium", "+9, +8, +6, +4, +3, +1", "Solid", "Mt" },
                    { 110, 282.166, null, 6, null, "Darmstadtium", "+8, +6, +4, +2, 0", "Solid", "Ds" },
                    { 111, 282.16899999999998, null, 6, null, "Roentgenium", "+5, +3, +1, -1", "Solid", "Rg" },
                    { 112, 286.17899999999997, null, 6, null, "Copernicium", "+2, +1, 0", "Solid", "Cn" },
                    { 113, 286.18200000000002, null, 7, null, "Nihonium", "+3, +1", "Solid", "Nh" },
                    { 114, 290.19200000000001, null, 7, null, "Flerovium", "+6, +4, +2, +1, 0", "Solid", "Fl" },
                    { 115, 290.19600000000003, null, 7, null, "Moscovium", "+3, +1", "Solid", "Mc" },
                    { 116, 293.20499999999998, null, 7, null, "Livermorium", "+4, +2, -2", "Solid", "Lv" },
                    { 117, 294.21100000000001, null, 9, null, "Tennessine", "+5, +3, +1, -1", "Solid", "Ts" },
                    { 118, 295.21600000000001, null, 10, null, "Oganesson", "+6, +4, +2, +1, 0, -1", "Gas", "Og" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Elements",
                keyColumn: "Id",
                keyValue: 118);
        }
    }
}
