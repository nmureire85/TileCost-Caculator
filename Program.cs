namespace TileCost_Caculator;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(
            "Welcome to the Tile Cost Caculator!. Brought to you by Nelson Construction LTD\nBefore we proceed, let us collect some input");

        Console.Write("Enter the width in ft: ");
        int width = int.Parse(Console.ReadLine());

        Console.Write("Enter the height in ft: ");
        int height = int.Parse(Console.ReadLine());

        Console.Write("Enter the cost per unit in pounds: ");
        int costPerUnitFlooring = int.Parse(Console.ReadLine());

        int areaOfFlooring = width * height;
        Console.WriteLine($"Area of flooring is {areaOfFlooring} sq ft ");

        double totalCostOfFlooring = areaOfFlooring * costPerUnitFlooring;
        Console.Write($"The total cost of flooring is: ${totalCostOfFlooring}.");

        Console.Write("\nEnter shape of non-rectangular room: ");
        string shapeOfNonRectangularRoom = Console.ReadLine();

        const int FLOORING_PER_HOUR = 20;
        const double COST_OF_FLOORING_PER_HOUR = 86.00;
        const double PI = 3.14159;

        if (shapeOfNonRectangularRoom == "triangle")
        {
            Console.Write("Enter Base of triangle: ");
            int baseofTriangle = int.Parse(Console.ReadLine());

            Console.Write("Enter height of triangle: ");
            int heightOfTriangle = int.Parse(Console.ReadLine());

            double costPerUnitOfTriangularRoom = COST_OF_FLOORING_PER_HOUR / FLOORING_PER_HOUR;

            double areaOfTriangle = (baseofTriangle * heightOfTriangle) / 2;

            double totalLabourCostForTriangularRoom = areaOfTriangle * costPerUnitOfTriangularRoom;

            Console.Write($"The total labour cost for triangular room is: ${totalLabourCostForTriangularRoom}");
        }

        if (shapeOfNonRectangularRoom == "circle")
        {
            Console.Write("Radius of cirlcle: ");
            int radius = int.Parse(Console.ReadLine());

            double costPerUnitOfCircularRoom = COST_OF_FLOORING_PER_HOUR / FLOORING_PER_HOUR;

            double areaOfCircle = PI * radius * radius;

            double totalLabourCostForCircleRoom = areaOfCircle * costPerUnitOfCircularRoom;

            Console.Write($"The total labour cost for circular room is: ${totalLabourCostForCircleRoom}");
        }

        if (shapeOfNonRectangularRoom == "square")

        {
            Console.Write("Enter side length of square: ");
            int side1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second side length of square: ");
            int side2 = int.Parse(Console.ReadLine());

            double costPerUnitOfSquareRoom = COST_OF_FLOORING_PER_HOUR / FLOORING_PER_HOUR;

            double areaOfSquare = side1 * side2;

            double totalLabourCostForSquareRoom = areaOfSquare * costPerUnitOfSquareRoom;

            Console.Write($"The total labour cost for square room is: ${totalLabourCostForSquareRoom}");
        }

        if (shapeOfNonRectangularRoom != "square" && shapeOfNonRectangularRoom != "circle" &&
            shapeOfNonRectangularRoom != "triangle")
        {
            Console.Write($"The shape entered  is not supported !!!!. Please try again.");
        }
    }
}