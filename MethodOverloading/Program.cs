namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            var x = 29;
            var y = 55;

            var answer = Add(x, y);

            var a = 32.0m;
            var b = 45.0m;

            var decimalAnswer = Add(a, b);

            var thirdAnswer = Add(0, 0, true);

            Console.WriteLine($"int add: {answer} decimal add: {decimalAnswer}");
            Console.WriteLine(thirdAnswer);
        }
    public static int Add(int x, int y) 
        { 
            return x + y;
        }
        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }
        public static string Add(int x, int y, bool boolInput)
        {
            int sum = x + y;  
            if (boolInput == true && sum == 0)
            {
                return $"{sum} dollar";
            }
            if (boolInput == true && sum < 0)
            {
                return $"{sum} dollars";
            }
            else
            {
                 return $"{sum} dollars";
            }
                

            }
        }




    }


