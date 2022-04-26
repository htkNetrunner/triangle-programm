
namespace myNewProgramm
{
    class program
    {
        static void Main(string[] args)
        {
            var triangle = new Triangle();

            var triangleType = triangle.determineTriangleType(triangle);

            Console.WriteLine(triangleType);
        }
    }
}
