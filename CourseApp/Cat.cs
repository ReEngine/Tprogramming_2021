namespace CourseApp
{
    using System;

    public class Cat
    {
        private string name;
        private double tailLength;

        public Cat(int age, string name, int tailLength)
        {
            this.Age = age;
            this.name = name;
            this.tailLength = tailLength;
        }

        public Cat()
        {
            this.Age = 0;
            this.Name = "Not named :c";
            this.TailLength = 0;
        }

        public int Age { get; set; }

        public string Name { get => name; set => name = value; }

        public double TailLength { get => tailLength; set => tailLength = value; }

        public void PrintInformation()
        {
            Console.WriteLine("Name: " + this.name + "\nAge: " + this.Age + "\nTail Length: " + this.tailLength);
        }

        public void Sound()
        {
            Console.WriteLine("Meow");
        }

        public int GetHumanAge()
        {
            return this.Age * 5;
        }
    }
}
