using System.Reflection;

namespace AdventOfCodeTrebuchet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var FILE_PATH = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? "", "Coordinates.txt");
            var sum = 0;
            var coordinates = FileManager.ReadFile(FILE_PATH);
            foreach (var cord in coordinates)
            {
                Console.WriteLine($"Coordinates: {cord.Coords}");
                sum += cord.Coords;
            }
            Console.WriteLine(sum);
        }
    }
}