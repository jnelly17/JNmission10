namespace APImish10.Data
{
    public interface IBowlerRepository
    {
        IEnumerable<Bowlers> Bowlers { get; } 
        IEnumerable<Teams> Teams { get; }
    }
}
