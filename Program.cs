namespace Algorithms_Knowledge_Base
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var sol = new Arrays.TwoSumSolution();

            Console.WriteLine(string.Join(", ", sol.TwoSum(new int[] { 2, 7, 11, 15 }, 9)));
        }
    }
}
