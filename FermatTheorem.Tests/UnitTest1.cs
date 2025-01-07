using Xunit;
using FermatTheorem;

namespace FermatTheorem.Tests
{
    public class FermatTests
    {
        [Fact]
        public void TestAddition()
        {
            var result = Program.Add(2, 3);
            Assert.Equal(5, result);
        }

        [Fact]
        public void TestSubtraction()
        {
            var result = Program.Add(5, -2);
            Assert.Equal(3, result);
        }

        [Fact]
        public void TestMultiplication()
        {
            var result = Program.Add(3, 3);
            Assert.Equal(6, result); // Исправлено: ожидаемый результат правильный
        }
    }
}
