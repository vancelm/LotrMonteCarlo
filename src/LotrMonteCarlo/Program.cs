
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
        };
    }
}