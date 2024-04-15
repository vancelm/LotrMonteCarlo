
using System.Security.Cryptography.X509Certificates;

namespace LotrMonteCarlo;

internal class Program
{
    private static void Main(string[] args)
    {
        List<JourneyLeg> legs = new()
        {
            new("Leg One")
            {
                new Encounter("Hobbit", 0.5,  1,    0),
                new Encounter("Elf",    0.22, 0.98, 0.02),
                new Encounter("Human",  0.21, 0.95, 0.05),
                new Encounter("Dwarf",  0.06, 0.99, 0.01),
                new Encounter("Nazgul", 0.01, 0.35, 0.65),
            },
            new("Leg Two")
            {
                new Encounter("Elf",    0.45, 1,    0),
                new Encounter("Dwarf",  0.22, 0.99, 0.01),
                new Encounter("Human",  0.15, 0.95, 0.05),
                new Encounter("Orc",    0.07, 0.55, 0.45),
                new Encounter("Goblin", 0.07, 0.5,  0.5),
                new Encounter("Troll",  0.03, 0.45, 0.55),
                new Encounter("Balrog", 1,    0.1,  0.90),
            },
            new("Leg Three")
            {
                new Encounter("Elf",      0.2,   1,    0),
                new Encounter("Uruk-Hai", 0.17,  0.4,  0.6),
                new Encounter("Goblin",   0.14,  0.5,  0.5),
                new Encounter("Human",    0.11,  0.95, 0.05),
                new Encounter("Dwarf",    0.105, 0.99, 0.01),
                new Encounter("Orc",      0.095, 0.45, 0.55),
                new Encounter("Nazgul",   0.08,  0.2,  0.80),
            }
        };
    }
}