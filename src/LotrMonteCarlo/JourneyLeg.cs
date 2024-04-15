namespace LotrMonteCarlo;

public class JourneyLeg(string name) : List<Encounter>
{
    public string Name { get; } = name;
}
