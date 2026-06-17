namespace TileCost_Caculator;

class Program
{
    static void Main(string[] args)
    {
        int width;
        int height;
        int costPerUnitFlooring;
        double totalCostOfFlooring;
        int areaOfFlooring;
        
        Console.WriteLine("Welcome to the Tile Cost Caculator!. Brought to you by Nelson Construction LTD\nBefore we proceed, let us collect some input");
        Console.Write("Enter the width in ft: ");
        width = int.Parse(Console.ReadLine());
        
        Console.Write("Enter the height in ft: ");
        height = int.Parse(Console.ReadLine());
            
        Console.Write("Enter the cost per unit in pounds: ");
        costPerUnitFlooring = int.Parse(Console.ReadLine());
        
        areaOfFlooring = width * height;
        Console.WriteLine($"Area of flooring is {areaOfFlooring} ");
        
        totalCostOfFlooring = areaOfFlooring  * costPerUnitFlooring;    
        Console.Write($"The total cost of flooring is {totalCostOfFlooring} pounds.");
        
        
        
    }
}