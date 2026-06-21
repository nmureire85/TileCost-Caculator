namespace TileCost_Caculator;

class Program
{
    static void Main(string[] args)
    {
        const int FLOORING_PER_HOUR = 20;
        const double COST_OF_FLOORING_PER_HOUR = 86.00;
        const double PI = 3.14159;
        const string TRIANGLE = "triangle";
        const string SQUARE = "square";
        const string CIRCLE = "circle";

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

        double area = 0;
        if (shapeOfNonRectangularRoom == TRIANGLE)
        {
            Console.Write("Enter Base of triangle: ");
            int baseofTriangle = int.Parse(Console.ReadLine());

            Console.Write("Enter height of triangle: ");
            int heightOfTriangle = int.Parse(Console.ReadLine());

            area = (baseofTriangle * heightOfTriangle) / 2;
        }

        if (shapeOfNonRectangularRoom == CIRCLE)
        {
            Console.Write("Radius of cirlcle: ");
            int radius = int.Parse(Console.ReadLine());

            area = PI * radius * radius;
        }

        if (shapeOfNonRectangularRoom == SQUARE)

        {
            Console.Write("Enter side length of square: ");
            int side1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second side length of square: ");
            int side2 = int.Parse(Console.ReadLine());

            area = side1 * side2;
        }

        double costPerUnitOfRoom = COST_OF_FLOORING_PER_HOUR / FLOORING_PER_HOUR;
        double totalLabourCost = calculateLabourCost(area, costPerUnitOfRoom);

        Console.Write($"The total labour cost for {shapeOfNonRectangularRoom} is: {totalLabourCost}.");


        if (shapeOfNonRectangularRoom != SQUARE && shapeOfNonRectangularRoom != CIRCLE &&
            shapeOfNonRectangularRoom != TRIANGLE)
        {
            Console.Write($"The shape entered  is not supported !!!!. Please try again.");
        }
    }


    static double calculateLabourCost(double areaOfShape, double costPerUnitOfRoom)
    {
        return areaOfShape * costPerUnitOfRoom;
    }
}