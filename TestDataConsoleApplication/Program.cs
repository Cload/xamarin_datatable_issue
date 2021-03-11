using System;
using System.Globalization;
using System.Threading;

namespace TestDataConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
            var dates = TestDateLib.DemoData.GetDateTimeFromDataTable();
            foreach (var date in dates)
            {
                Console.WriteLine(date.ToString());
            }
            Console.ReadKey();
        }
    }
}
