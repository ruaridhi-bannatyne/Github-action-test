using Xunit;

namespace Tests
{
    public class Tests
    {
       [Fact]
        public void PassingTest()
        {
            Assert.Equal(1, 1);
        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equal(2, 2);
        }
    }
}