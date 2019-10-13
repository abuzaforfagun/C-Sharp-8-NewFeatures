using System;

namespace C_Sharp_8_New_Features
{
    public class ReadonlyMembers
    {
        public struct MyDatetime
        {
            public DateTime Date { get; set; }

            public readonly DateTime AddDays(int day)
            {
                return Date.AddDays(day);
            }

        }
        public void test()
        {
            MyDatetime date = new MyDatetime();
            date.Date = new DateTime(2010, 10, 10);
            Console.WriteLine($"Date: {date.Date.ToShortDateString()}");

            var newDate = date.AddDays(5);
            Console.WriteLine($"Date: {date.Date.ToShortDateString()}");
            Console.WriteLine($"New Date: {newDate.Date.ToShortDateString()}");
        }
    }
}
