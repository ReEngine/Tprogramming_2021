namespace CourseApp.Tests
{
    using Xunit;

    public class AddTests
    {
        [Fact]
        public void AddIntsNegNegNeg()
        {
            int a = -3;
            int b = -4;
            int expected = -7;

            int actual = new Calculator().Add(a, b);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AddIntsNegPosNeg()
        {
            int a = -3;
            int b = 2;
            int expected = -1;

            int actual = new Calculator().Add(a, b);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AddIntsNegPosPos()
        {
            int a = -3;
            int b = 4;
            int expected = 1;

            int actual = new Calculator().Add(a, b);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AddIntsPosNegNeg()
        {
            int a = 4;
            int b = -5;
            int expected = -1;

            int actual = new Calculator().Add(a, b);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AddIntsPosNegPos()
        {
            int a = 5;
            int b = -4;
            int expected = 1;

            int actual = new Calculator().Add(a, b);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AddIntsPosPosPos()
        {
            int a = 3;
            int b = 2;
            int expected = 5;

            int actual = new Calculator().Add(a, b);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AddIntsNegPosNul()
        {
            int a = -3;
            int b = 3;
            int expected = 0;

            int actual = new Calculator().Add(a, b);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AddIntsPosNegNul()
        {
            int a = 3;
            int b = -3;
            int expected = 0;

            int actual = new Calculator().Add(a, b);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AddIntsNulNulNul()
        {
            int a = 0;
            int b = 0;
            int expected = 0;

            int actual = new Calculator().Add(a, b);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AddBytesOverflow()
        {
            byte a = 255;
            byte b = 255;

            Assert.Throws<System.OverflowException>(() => new Calculator().Add(a, b));
        }
    }
}
