using System;
using DocumentFormat.OpenXml.Bibliography;

namespace DateTimeType
{
    class Program
    {
        static void dayoftheweek()
        {
            DateTime dt = new DateTime(1998, 8, 27);
            Console.WriteLine("The day of the week for {0:d} is {1}.", dt, dt.DayOfWeek);
        }

        static void dayoftheweek2()
        {


            static int dayofweek(int d, int m, int y)
            {
                int[] t = { 0, 3, 2, 5, 0, 3, 5,
                                 1, 4, 6, 2, 4 };
                y -= (m < 3) ? 1 : 0;

                return (y + y / 4 - y / 100 + y / 400
                                 + t[m - 1] + d) % 7;
            }

            Console.Write("Input the Day: ");
            int Day = int.Parse(Console.ReadLine());
            Console.Write("Input the Month: ");
            int Month = int.Parse(Console.ReadLine());
            Console.Write("Input the Year: ");
            int Year = int.Parse(Console.ReadLine());
            Console.WriteLine(dayofweek(Day, Month, Year));
        }

        static void lifedays()
        {

            DateTime today = DateTime.Now.Date;
            DateTime date = new DateTime();
            date = DateTime.Parse(Console.ReadLine());
            TimeSpan life = today - date;
            Console.WriteLine(life.Days);

        }

        static void after40days()
        {

            DateTime Today = DateTime.Now.Date;
            Today = Today.AddDays(40);
            Console.WriteLine(Today.ToString("MM'/'dd'/'yyyy"));
        }

        static void checkdate()
        {
            Console.Write("Input the Day: ");
            int Day = int.Parse(Console.ReadLine());
            Console.Write("Input the Month: ");
            int Month = int.Parse(Console.ReadLine());
            Console.Write("Input the Year: ");
            int Year = int.Parse(Console.ReadLine());
            DateTime Date = new DateTime(Year,Month,Day);
            DateTime Today = DateTime.Now.Date;
            if(Date==Today)
            {
              Console.WriteLine("The formatted Date is :{0} The current date status : {1}", Date.ToString("dd/MM/yyyy"), true);
            }

            else
            {
                Console.WriteLine("The formatted Date is :{0} The current date status : {1}", Date.ToString("dd/MM/yyyy"), false);
            }
        }


        static void lastweekofyear()
        {
            Console.Write("Input the Day: ");
            int Day = int.Parse(Console.ReadLine());
            Console.Write("Input the Month: ");
            int Month = int.Parse(Console.ReadLine());
            Console.Write("Input the Year: ");
            int Year = int.Parse(Console.ReadLine());
            DateTime Date = new DateTime(Year, Month, Day);
            Console.WriteLine("The formatted Date is :{0}", Date.ToString("dd'/'MM'/'yyyy"));
            Console.WriteLine("The Last day of the year 2012 is : 31/12/{0}", Date.Year);
        }

        static void lastdayoftheweek()
        {
            Console.Write("Input the Day: ");
            int Day = int.Parse(Console.ReadLine());
            Console.Write("Input the Month: ");
            int Month = int.Parse(Console.ReadLine());
            Console.Write("Input the Year: ");
            int Year = int.Parse(Console.ReadLine());
            DateTime Date = new DateTime(Year, Month, Day);

            DayOfWeek day = (DayOfWeek.Sunday);



            if (Date.DayOfWeek != day)
            {
                double inputday = ((double)Date.DayOfWeek);
               DateTime lastday= Date.AddDays(7 - inputday);
               Console.WriteLine("The formatted Date is :{0}\n The last day of the week for the above date is:{1}",Date.ToString("dd'/'MM'/'yyyy"),lastday.ToString("dd'/'MM'/'yyyy"));
            }
        }


        static void Main(string[] args)
        {

            //dayoftheweek();
            //dayoftheweek2();
            //lifedays();
            //after40days();
            //checkdate();
           // lastdayoftheweek();


        }
    }
}
