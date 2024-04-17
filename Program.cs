namespace Opgave_012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaring of variables
            string   dollar;
            string rate = "7,035";
        
            double kroner, rate1, dollar1;

            //Cleansing of the console screen
            Console.Clear();

            //Greeting of customers
            Console.WriteLine(" Goodday and welcome to Clinton´s dollar to danish kroner exchange agency");
            Console.Write(" How much dollar would you like to change: ");

            //Read customer's input on screen
            dollar = Console.ReadLine();
            dollar1 = double.Parse(dollar);

            //Convert the value of rate to a double
            double number = Convert.ToDouble(rate);
            rate1 = double.Parse(rate);

            //Inform the customer about the exchange rate
            Console.Write(" The exchage rate is 7.035 per dollar.");

            //Calculations
            kroner = dollar1 / (rate1 / 100);

            //Write out to screen what the customer get for the amount he/she wants to change
            Console.WriteLine();
            Console.Write(" With the rate at {0:N2}, you get {1:N2} kroner when you change {2:N2} dollar.", rate1, kroner, dollar1);

            Console.ReadKey();
        }
    }
}
