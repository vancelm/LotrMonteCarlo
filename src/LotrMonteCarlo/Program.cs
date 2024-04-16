
namespace LotrMonteCarlo;

internal class Program
{
    private static void Main(string[] args)
    {
        List<JourneyLeg> legs = BuildLegs();
        RunSimulation(legs, 10000);
    }

    private static void RunSimulation(List<JourneyLeg> legs, int iterations)
    {
        int successCount = 0;
        for (int i = 0; i < iterations; i++)
        {
            Console.Write($"{i}, ");
            bool success = true;
            
            foreach(JourneyLeg leg in legs)
            {
                (string Encounter, bool Survived) result = RollDice(leg);
                Console.Write($"{result.Encounter}, ");
                
                if (result.Survived)
                {
                    Console.Write($"Survived, ");
                }
                else
                {
                    Console.Write($"Died, ");
                    success = false;
                }
            }

            if (success)
            {
                Console.WriteLine("Success");
                successCount++;
            }
            else
            {
                Console.WriteLine($"Fail");
            }
        }

        double successPercent = ((double)successCount) / iterations * 100;
        int failCount = iterations - successCount;
        double failPercent = ((double)failCount) / iterations * 100;

        Console.WriteLine($"Success: {successCount} ({successPercent}%)");
        Console.WriteLine($"Fail: {failCount} ({failPercent}%)");
    }

    private static (string Encounter, bool Survived) RollDice(JourneyLeg leg)
    {
        double roll = Random.Shared.NextDouble();
        double prev = 0;
        foreach(Encounter encounter in leg)
        {
            if (roll <= encounter.EncounterProbability + prev)
            {
                bool survived = Random.Shared.NextDouble() <= encounter.SurviveProbability;
                return (encounter.Name, survived);
            }

            prev += encounter.EncounterProbability;
        }

        return ("error", false);
    }

    private static List<JourneyLeg> BuildLegs() => new()
    {
        new("Leg One")
        {
            new Encounter("Hobbit", 0.5,  1),
            new Encounter("Elf",    0.22, 0.98),
            new Encounter("Human",  0.21, 0.95),
            new Encounter("Dwarf",  0.06, 0.99),
            new Encounter("Nazgul", 0.01, 0.35),
        },
        new("Leg Two")
        {
            new Encounter("Elf",    0.45, 1),
            new Encounter("Dwarf",  0.22, 0.99),
            new Encounter("Human",  0.15, 0.95),
            new Encounter("Orc",    0.07, 0.55),
            new Encounter("Goblin", 0.07, 0.5),
            new Encounter("Troll",  0.03, 0.45),
            new Encounter("Balrog", 1,    0.1),
        },
        new("Leg Three")
        {
            new Encounter("Elf",      0.2,   1),
            new Encounter("Uruk-Hai", 0.17,  0.4),
            new Encounter("Goblin",   0.14,  0.5),
            new Encounter("Human",    0.11,  0.95),
            new Encounter("Dwarf",    0.105, 0.99),
            new Encounter("Orc",      0.095, 0.45),
            new Encounter("Nazgul",   0.08,  0.2),
        },
        new("Leg Four")
        {
            new Encounter("Gollum",          0.45, 0.8),
            new Encounter("Orc",             0.2,  0.35),
            new Encounter("Goblin",          0.13, 0.35),
            new Encounter("Troll",           0.8,  0.40),
            new Encounter("Spider",          0.7,  0.25),
            new Encounter("Nazgul",          0.6,  0.15),
            new Encounter("Sooner Schooner", 0.1,  1),
        },
    };
}