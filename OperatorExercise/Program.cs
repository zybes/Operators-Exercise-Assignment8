using System.Security.Cryptography.X509Certificates;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Insert Number 1");
             double num1 = Convert.ToDouble(Console.ReadLine());

             Console.WriteLine("Insert Operator");
             string op = Console.ReadLine();

             Console.WriteLine("Insert Number 2");
             double num2 = Convert.ToDouble(Console.ReadLine());

             double result = 0;

             if (op == "+")
                 result = num1 + num2;
             else if (op == "-")
                 result = num1 - num2;
             else if (op == "*")
                 result = num1 * num2;
             else if (op == "/")
                 result = num1 / num2;
             Console.WriteLine(result); */

            //The modulo operator returns the remainder of the division operation

            /* int a = 17;
            int b = 4;
            int quotient = 1;

            int mod = a % b;
            Console.WriteLine("17/4 is 4 remainder 1"); */


            //Math PI operation

            
            double radius, area;
            Console.WriteLine("What is the radius of your circle?");
            radius = double.Parse(Console.ReadLine());
            AreaOfCircle(radius);
        }

        public static void AreaOfCircle(double radius)
        {
           var ans = Math.PI* Math.Pow(radius, 2);

            Console.WriteLine($"The area of the circle with radius {radius} is {ans}");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
