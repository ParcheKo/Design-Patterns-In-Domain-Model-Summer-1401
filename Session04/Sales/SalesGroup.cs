using System.Collections.Generic;
using System.Linq;

namespace Sales
{
    public class SalesGroup : SalesUnit
    {
        public SalesGroup(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }

        public List<SalesUnit> Units { get; private set; } = new List<SalesUnit>();
        public override void PayCommission(int amount)
        {
            var eachShare = amount / Units.Count;
            foreach (var salesUnit in Units)
                salesUnit.PayCommission(eachShare);
        }
    }
}