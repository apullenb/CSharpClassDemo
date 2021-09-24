using System;

namespace CSharpClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(2018, 5, 31);
            DateTime tomorrow = GetTomorrow();
            Console.WriteLine(tomorrow);
            Console.ReadLine();
        }
        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }
    }
}
