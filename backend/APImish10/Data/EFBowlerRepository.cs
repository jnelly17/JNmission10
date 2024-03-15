namespace APImish10.Data
{
    public class EFBowlerRepository : IBowlerRepository
    {
        private BowlerContext _bowlerContext;
        public EFBowlerRepository(BowlerContext temp) //i need a context file but do I?
        {
            _bowlerContext = temp;
        }
        public IEnumerable<Bowlers> Bowlers => _bowlerContext.Bowlers;
        public IEnumerable<Teams> Teams => _bowlerContext.Teams;

    }
}
