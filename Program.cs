namespace Algorithms_Knowledge_Base
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var sol = new SlidingWindow.CharacterReplacement();

            var res = sol.CharacterReplacementMethod("AABABBA", 1);

            //Console.WriteLine(res);            
        }
    }
}
