namespace Date_Library_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {

            clsDate date1 = new clsDate(27, 1, 2024);

            Console.WriteLine("\nSystem Date: " + clsDate.DateToString(clsDate.GetSystemDate()));

            Console.WriteLine("\nMy Age In Days: " + clsDate.CalculateAgeInDays(new clsDate(8, 8, 2000)));

            Console.WriteLine("\nDate1:");

            date1.Print();

            date1.PrintMonthCalender();

            date1.IncreaseDateByOneMillennium();

            date1.DecreaseDateByOneMillennium();

            date1.Print();

            Console.WriteLine("\nDay Name: " + date1.GetDayShortName());

            Console.WriteLine("\nIs End of Week: " + date1.IsEndOfWeek());

            Console.WriteLine("\nIs Week End: " + date1.IsWeekEnd());

            Console.WriteLine("\nIs Business Day: " + date1.IsBusinessDay());

            Console.WriteLine("\nDays until end of week: " + date1.GetDaysUntilEndOfWeek());

            Console.WriteLine("\nDays until end of Month: " + date1.GetDaysUntilEndOfMonth());

            Console.WriteLine("\nDays until end of Year: " + date1.GetDaysUntilEndOfYear());

            Console.WriteLine("\n" + date1.FormatDate("-", "dd-mm-yyyy"));

            Console.WriteLine();

            clsPeriod period1 = new clsPeriod(date1, clsDate.GetSystemDate());

            period1.Print();

            Console.WriteLine("\nPeriod Length is: " + period1.GetPeriodLengthInDays());
            Console.WriteLine("Period Length (Including End Date) is: " + period1.GetPeriodLengthInDays(true));

            Console.WriteLine();

            clsPeriod period2 = new clsPeriod(new clsDate(1, 1, 2024), new clsDate(3, 3, 2024));

            period2.Print();

            Console.WriteLine("\nPeriod Length is: " + period2.GetPeriodLengthInDays());
            Console.WriteLine("Period Length (Including End Date) is: " + period2.GetPeriodLengthInDays(true));


            Console.WriteLine("\nIs OverLap: " + period1.IsOverlapWith(period2));

            Console.WriteLine("\nOverlap Days: " + period1.CountOverlapDaysWith(period2));

        }
    }
}