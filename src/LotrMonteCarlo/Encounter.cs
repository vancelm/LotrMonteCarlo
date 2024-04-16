namespace LotrMonteCarlo;

public class Encounter(string name, double encounterProbability, double surviveProbability)
{
    public string Name { get; } = name;
    public double EncounterProbability { get; } = encounterProbability;
    public double SurviveProbability { get; } = surviveProbability;
}
