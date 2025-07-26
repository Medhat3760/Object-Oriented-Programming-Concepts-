namespace Date_Library_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {

            clsDate date1 = new clsDate(27,1,2024);

            Console.WriteLine("\nSystem Date: " + clsDate.DateToString(clsDate.GetSystemDate()));

            Console.WriteLine("\nMy Age In Days:" + clsDate.CalculateAgeInDays(new clsDate(8,8,2000)));

            Console.WriteLine("\nDate1:");

            date1.Print();

            date1.PrintMonthCalender();

            date1.IncreaseDateByOneMillennium();

            date1.DecreaseDateByOneMillennium();

            date1.Print();

            Console.WriteLine("\nDay Name: "+ date1.GetDayShortName());

            Console.WriteLine("\nIs End of Week: " + date1.IsEndOfWeek());

            Console.WriteLine("\nIs Week End: " + date1.IsWeekEnd());

            Console.WriteLine("\nIs Business Day: " + date1.IsBusinessDay());

            Console.WriteLine("\nDays until end of week: " + date1.GetDaysUntilEndOfWeek());

            Console.WriteLine("\nDays until end of Month: " + date1.GetDaysUntilEndOfMonth());

            Console.WriteLine("\nDays until end of Year: " + date1.GetDaysUntilEndOfYear());

            Console.WriteLine("\n"+date1.FormatDate("-", "dd-mm-yyyy"));
        }
    }
}