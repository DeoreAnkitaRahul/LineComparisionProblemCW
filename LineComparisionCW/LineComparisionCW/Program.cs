namespace LineComparisionCW
{
    class Program
    {
       public static void Main(string[] args)
        {
            CalculateLength obj_One = new CalculateLength(2, 3, 4, 5);
            double length_One = obj_One.Calculate();
            CalculateLength obj_Two = new CalculateLength(2, 3, 4, 5);
            double length_Two = obj_Two.Calculate();
            if (length_One.Equals(length_Two))
            {
                Console.WriteLine("Length of both lines are equal");
            }
            else
            {
                Console.WriteLine("Length of both lines are not equal");
            }
            Console.ReadKey();
        }
    }
}