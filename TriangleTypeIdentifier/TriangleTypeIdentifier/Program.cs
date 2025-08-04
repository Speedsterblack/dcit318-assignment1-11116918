
namespace TriangleTypeIdentifier
{
    internal class TriangleTypeIdentifier
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //Error handling using try..catch block
                try
                {
                    //Input request for  length 1
                    Console.Write("Please enter the length of the first side :  ");
                    String input1 = Console.ReadLine();
                    int length1 = Convert.ToInt32(input1);

                    //Input request for  length 2
                    Console.Write("Please enter the length of the second side :  ");
                    String input2 = Console.ReadLine();
                    int length2 = Convert.ToInt32(input2);

                    //Input request for  length 3
                    Console.Write("Please enter the length of the third side :  ");
                    String input3 = Console.ReadLine();
                    int length3 = Convert.ToInt32(input3);

                    //Check for triangle type
                    if (length1 == length2 && length2 == length3)
                    {
                        Console.WriteLine("All sides are equal therefore it is an Equilateral triangle.");
                    }
                    else if (length1 == length2 && length2 != length3)
                    {
                        Console.WriteLine("Two sides are equal therefore it is an Isosceles triangle.");
                    }
                    else
                    {
                        Console.WriteLine("All sides are different therefore it is a Scalene triangle.");
                    }
                    break; //Break loop
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("Please enter a number");
                    Console.WriteLine(fe.Message);
                    continue; // Continue loop
                }
            }
        }
    }
}
