using KalkulatorUnitTesting;
namespace KalkulatorUnitTestingTest
{
    public class UnitTest1
    {
        [Fact]
        public void LeggSammenTest()
        {
            var _kalkulator = new Kalkulator();
            int sum = _kalkulator.LeggSammen(5,4);

            Assert.Equal(9, sum);
        }
        [Fact]
        public void TrekkFraTest()
        {
            var _kalkulator = new Kalkulator();
            int sum = _kalkulator.TrekkFra(5, 4);

            Assert.Equal(1, sum);
        }
        [Fact]
        public void MultipliserTest()
        {
            var _kalkulator = new Kalkulator();
            int sum = _kalkulator.Multipliser(5, 4);

            Assert.Equal(20, sum);
        }
        [Fact]
        public void DividerTest()
        {
            var _kalkulator = new Kalkulator();
            int sum = _kalkulator.Divider(8, 4);

            Assert.Equal(2, sum);
        }
    }
}