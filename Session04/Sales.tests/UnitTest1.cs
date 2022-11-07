using Xunit;

namespace Sales.tests ;

    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var salesGroup = new SalesGroupBuilder("0")
                    .WithSalesUnit(new SalesGroup("A"))
                    .WithSalesUnit(new SalesGroup("B"))
                    .WithSalesUnitAs(c=>c.WithSalesUnit(new SalesGroup("C1")), "C")
                .Build();
            Assert.Equal(3, salesGroup.Units.Count);
        }
    }