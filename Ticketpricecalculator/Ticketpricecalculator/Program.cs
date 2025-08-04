namespace Ticketpricecalculator
{
    internal class TicketPriceCalculator
    {
        static void Main(string[] args)
        {
            //Variable initialization
            int ticketPrice = 10;
            int discount = 7;
            int age;
            int discountedAmount;


            while (true)
            {
                //Error handling using try..catch block
                try
                {
                    Console.WriteLine("Please input your age: ");
                    string input = Console.ReadLine();

                    // Convert user input to integer
                    age = Convert.ToInt32(input);

                    //Check required age for discount
                    if (age <= 12 || age >= 65)
                    {
                        discountedAmount = ticketPrice - discount;
                        Console.WriteLine("Your discounted price is Ghc" + discountedAmount);
                    }
                    else
                    {
                        Console.WriteLine("The price of your ticket is Ghc " + ticketPrice);
                    }

                    break; // Break loop
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("Age must be a number");
                    Console.WriteLine(fe.Message);
                    continue; // Continue loop
                }
            }
        }
    }
}