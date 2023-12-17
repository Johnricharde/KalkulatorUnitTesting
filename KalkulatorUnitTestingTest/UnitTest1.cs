using KalkulatorUnitTesting;
namespace KalkulatorUnitTestingTest
{
    public class UnitTest1
    {
        // Test "LeggSammen()" Scenarios
        [Fact]
        public void LeggSammen5_4()
        {
            var _kalkulator = new Kalkulator();
            int sum = _kalkulator.LeggSammen(5,4);

            Assert.Equal(9, sum);
        }
        [Fact]
        public void LeggSammen5_0()
        {
            var _kalkulator = new Kalkulator();
            int sum = _kalkulator.LeggSammen(5, 0);

            Assert.Equal(5, sum);
        }
        [Fact]
        public void LeggSammenNegative5_Negative4()
        {
            var _kalkulator = new Kalkulator();
            int sum = _kalkulator.LeggSammen(-5, -4);

            Assert.Equal(-9, sum);
        }
        [Fact]
        public void LeggSammen5_Negative4()
        {
            var _kalkulator = new Kalkulator();
            int sum = _kalkulator.LeggSammen(5, -4);

            Assert.Equal(1, sum);
        }
        // Test "TrekkFra()" Scenarios
        [Fact]
        public void TrekkFra5_4()
        {
            var _kalkulator = new Kalkulator();
            int sum = _kalkulator.TrekkFra(5, 4);

            Assert.Equal(1, sum);
        }
        [Fact]
        public void TrekkFra5_0()
        {
            var _kalkulator = new Kalkulator();
            int sum = _kalkulator.TrekkFra(5, 0);

            Assert.Equal(5, sum);
        }
        [Fact]
        public void TrekkFra5_Negative4()
        {
            var _kalkulator = new Kalkulator();
            int sum = _kalkulator.TrekkFra(5, -4);

            Assert.Equal(9, sum);
        }
        [Fact]
        public void TrekkFraNegative5_Negative4()
        {
            var _kalkulator = new Kalkulator();
            int sum = _kalkulator.TrekkFra(-5, -4);

            Assert.Equal(-1, sum);
        }
        // Test "Multipliser()" Scenarios
        [Fact]
        public void Multipliser5_4()
        {
            var _kalkulator = new Kalkulator();
            int sum = _kalkulator.Multipliser(5, 4);

            Assert.Equal(20, sum);
        }
        [Fact]
        public void Multipliser5_0()
        {
            var _kalkulator = new Kalkulator();
            int sum = _kalkulator.Multipliser(5, 0);

            Assert.Equal(0, sum);
        }
        [Fact]
        public void Multipliser5_Negative4()
        {
            var _kalkulator = new Kalkulator();
            int sum = _kalkulator.Multipliser(5, -4);

            Assert.Equal(-20, sum);
        }
        [Fact]
        public void MultipliserNegative5_Negative4()
        {
            var _kalkulator = new Kalkulator();
            int sum = _kalkulator.Multipliser(-5, -4);

            Assert.Equal(20, sum);
        }
        // Test "DividerTest()" Scenarios
        [Fact]
        public void Divider8_4()
        {
            var _kalkulator = new Kalkulator();
            int sum = _kalkulator.Divider(8, 4);

            Assert.Equal(2, sum);
        }
        [Fact]
        public void Divider8_0()
        {
            var _kalkulator = new Kalkulator();

            Assert.Throws<ArgumentException>(() =>
            {
                int result = _kalkulator.Divider(8, 0);
            });
        }
        [Fact]
        public void Divider8_Negative4()
        {
            var _kalkulator = new Kalkulator();
            int sum = _kalkulator.Divider(8, -4);

            Assert.Equal(-2, sum);
        }
        [Fact]
        public void DividerNegative8_Negative4()
        {
            var _kalkulator = new Kalkulator();
            int sum = _kalkulator.Divider(-8, -4);

            Assert.Equal(2, sum);
        }
    }
}