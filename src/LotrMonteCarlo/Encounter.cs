namespace LotrMonteCarlo;

public class Encounter(string name, double encounterProbability, double surviveProbability, double dieProbability)
{
    public string Name { get; } = name;
    public double EncounterProbability { get; } = encounterProbability;
    public double SurviveProbability { get; } = surviveProbability;
    public double Die { get; } = dieProbability;
}
