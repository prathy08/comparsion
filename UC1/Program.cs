namespace UC1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of cooridinate x1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter the value of cooridinate y1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of cooridinate x2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of cooridinate y2");
            int y2 = Convert.ToInt32(Console.ReadLine());

            double LengthOfLine = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Line Comparison");
            Console.WriteLine("Length of Line:" + LengthOfLine);

            Console.ReadLine();
        }
    }
}