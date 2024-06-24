namespace SIP_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double investment;
            Console.WriteLine("What whould like To invest Per Month");
            investment = double.Parse(Console.ReadLine());

            double Ainterest;  // annual interest
            Console.WriteLine("what would like To persent on year");
            Ainterest = double.Parse(Console.ReadLine());

            double Minterest;
            Minterest = Ainterest / 12 / 100; //monthly interest


            int year;
            Console.WriteLine("how many year");
            year = int.Parse(Console.ReadLine());

            int Month;
            Month = 12 * year;

            //vaireable declear for ^ value because to after simple to wright formula
            double i;
            i = Math.Pow(1 + Minterest, Month);

            //(SIP) Systematic Investment Plan (formula M = P × ({[1 + i]^n – 1} / i)  
            double totalamount; totalamount = investment * ((i - 1) / Minterest);

            Console.WriteLine($"amount with intrest{totalamount}");


            //double total=Totalamount+


            //int TotalIamount;  TotalIamount = amount * TotalMonth;





            //Console.WriteLine("You over all invest Amount is " + TotalIamount);

            //double totalamount = principal * Math.Pow(1 + (interestRate / compoundFrequency), compoundFrequency * years);
        }
    }
}
