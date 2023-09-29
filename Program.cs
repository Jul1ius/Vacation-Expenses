using System;

namespace Vacation_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalExp = 0;
            string season = Console.ReadLine();
            string accType = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            if (season == "Winter")
            {
                if (accType == "Hotel")
                    totalExp = days * 40 * 0.90;
                else if (accType == "Camping")
                    totalExp = days * 10 * 0.90;
            }
            else if (season == "Autumn")
            {
                if (accType == "Hotel")
                    totalExp = days * 20 * 0.70;
                else if (accType == "Camping")
                    totalExp = days * 15 * 0.70;
            }
            else if (season == "Spring")
            {
                if (accType == "Hotel")
                    totalExp = days * 30 * 0.80;
                else if (accType == "Camping")
                    totalExp = days * 10 * 0.80;
            }
            else if (season == "Summer")
            {
                if (accType == "Hotel")
                    totalExp = days * 50;
                else if (accType == "Camping")
                    totalExp = days * 30;
            }
            Console.WriteLine($"{totalExp:F2}");
        }
    }
}
