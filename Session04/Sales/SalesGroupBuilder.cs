using System;

namespace Sales
{
    public class SalesGroupBuilder
    {
        private readonly SalesGroup _organization;

        public SalesGroupBuilder(string name)
        {
            _organization = new SalesGroup(name);
        }
        public SalesGroupBuilder WithSalesUnit(SalesGroup salesGroup)
        {
            _organization.Units.Add(salesGroup);
            return this;
        }
        
        public SalesGroupBuilder WithSalesUnitAs(Action<SalesGroupBuilder> salesGroupBuilderConfig, string name)
        {
            SalesGroupBuilder salesGroupBuilder = new SalesGroupBuilder(name);
            salesGroupBuilderConfig(salesGroupBuilder);
            _organization.Units.Add(salesGroupBuilder.Build());
            return this;
        }

        public SalesGroup Build()
        {
            return _organization;
        }
    }
}