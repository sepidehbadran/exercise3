// See https://aka.ms/new-console-template for more information
using System.Security.AccessControl;

    class Program {
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the Salary:");
        int Rights = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Tax Percentage:");
        double Tax = Convert.ToDouble(Console.ReadLine());
        Tax = Rights * (Tax / 100);
        double Insurance1 = 0.07 * Rights;
        double Insurance2 = 0.85 * Rights;
        double Insurance3 = 0.1 * Rights;
        double Tota1 = Rights - Tax;
        Console.WriteLine("Choose one Insurance from below:");
        Console.WriteLine("Press 1 for: 7%");
        Console.WriteLine("Press 2 for: 8/5%");
        Console.WriteLine("Press 3 for: 10%");
        int Number = Convert.ToInt16(Console.ReadLine());
        double Result = (Number == 1) ? Tota1 - Insurance1 :
            (Number == 2) ? Tota1 - Insurance2 :
            (Number == 3) ? Tota1 - Insurance3 :
        throw new Exception(" Wrong number!!!!");
        Console.WriteLine("Tota1 is: " + Result);
    }
}


