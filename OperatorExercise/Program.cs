namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert Number 1");
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
            Console.WriteLine(result);
        }
    }
}
