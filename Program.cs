namespace Assignment3._2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 4;
            double[] userArray = new double[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter element {i}");
                userArray[i] = Convert.ToDouble(Console.ReadLine());
            }
            double[] results = Methods.Calculations(userArray);
        }
    }

    public class Methods
    {
        public static double[] Calculations(params double[] numbers)
        {
            double sum = 0;
            Console.WriteLine("For numbers:");
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
                Console.Write(numbers[i] + ", ");
            }
            double average = sum / numbers.Length;
            Console.WriteLine($"The average is {average}");
            Console.WriteLine($"The sum is {sum}");
            return new double[] { average, sum };
        }
    }
}


