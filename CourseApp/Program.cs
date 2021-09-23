namespace CourseApp
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            const double b = 2.5;
            var funcalc = new FunctionCalculator();
            Console.WriteLine("Calculating task A\n");
            funcalc.CalculateTaskA(1.28, 3.28, 0.4, b);
            double[] nums = new double[] { 1.1, 2.4, 3.6, 1.7, 3.9 };
            Console.WriteLine("Calculating task B\n");
            funcalc.CalculateTaskB(nums, b);
            Console.ReadKey();
        }
    }
}