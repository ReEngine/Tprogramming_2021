namespace CourseApp.Tests
{
    using Xunit;

    public class SubTests
    {
        [Fact]
        public void SubIntsNegNegPos()
        {
            int a = -3;
            int b = -4;
            int expected = 1;

            int actual = new Calculator().Sub(a, b);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SubIntsNegPosNeg()
        {
            int a = -3;
            int b = 2;
            int expected = -5;

            int actual = new Calculator().Sub(a, b);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SubIntsPosNegPos()
        {
            int a = 5;
            int b = -4;
            int expected = 9;

            int actual = new Calculator().Sub(a, b);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SubIntsPosPosPos()
        {
            int a = 3;
            int b = 2;
            int expected = 1;

            int actual = new Calculator().Sub(a, b);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SubIntsNulNulNul()
        {
            int a = 0;
            int b = 0;
            int expected = 0;

            int actual = new Calculator().Sub(a, b);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SubBytesOverflow()
        {
            byte a = 0;
            byte b = 1;

            Assert.Throws<System.OverflowException>(() => new Calculator().Sub(a, b));
        }
    }
}
