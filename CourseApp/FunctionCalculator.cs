namespace CourseApp
{
    using System;

    public class FunctionCalculator
    {
        public void Calculate(double b, double x)
        {
            double top = 1 + Math.Pow(
                Math.Sin(Math.Pow(b, 3) + Math.Pow(x, 3)),
                2);
            double bottom = Math.Pow(
                Math.Pow(b, 3) + Math.Pow(x, 3),
                1 / 3);
            double y = top / bottom;
            Console.WriteLine(y);
        }

        public void CalculateTaskA(double xStart, double xEnd, double dX, double b)
        {
            for (double x = xStart; x < xEnd; x += dX)
            {
                Calculate(b, x);
            }
        }

        public void CalculateTaskB(double[] nums, double b)
        {
            foreach (double number in nums)
            {
                Calculate(b, number);
            }
        }
    }
}