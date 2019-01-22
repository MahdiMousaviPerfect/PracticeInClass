using System;
using System.Globalization;
namespace ConsoleApplication1.Classes
{
    public class DatesConverter
    {
        #region/سازنده كلاس تبديل تاريخ
        /// <summary>
        /// سازنده كلاس و پراپرتي ها
        /// </summary>
        /// <param name="سال"></param>
        /// <param name="ماه"></param>
        /// <param name="روز"></param>
        public DatesConverter(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }
        #endregion/سازنده كلاس تبديل تاريخ

        #region/Propertis
        /// <summary>
        /// سال
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// ماه
        /// </summary>
        public int Month { get; set; }

        /// <summary>
        /// روز
        /// </summary>
        public int Day { get; set; }
        #endregion/Propertis

        #region/متدهاي تبديل تاريخ
        /// <summary>
        /// متد تبديل تاريخ ميلادي به شمسي
        /// </summary>
        public void MiladiToShamsi()
        {
            PersianCalendar pc = new PersianCalendar();
            DateTime dt = new DateTime(year: Year, month: Month, day: Day);
            string result =
                $"Miladi To Shamsi:{ pc.GetYear(dt).ToString("0000/") } { pc.GetMonth(dt).ToString("00/") } { pc.GetDayOfMonth(dt).ToString("00") }";
            System.Console.Write(result);
        }

        /// <summary>
        /// متد تبديل تاريخ ميلادي به قمري
        /// </summary>
        public void MiladiToGhamari()
        {
            HijriCalendar hc = new HijriCalendar();
            DateTime dt = new DateTime(year: Year, month: Month, day: Day);
            string result =
                $"Miladi To Ghamari:{ hc.GetYear(dt).ToString("0000/") } { hc.GetMonth(dt).ToString("00/") } { hc.GetDayOfMonth(dt).ToString("00") }";
            System.Console.Write(result);
        }

        /// <summary>
        /// متد تبديل تاريخ ميلادي به هبري
        /// </summary>
        public void MiladiToHebrew()
        {
            HebrewCalendar hb = new HebrewCalendar();
            DateTime dt = new DateTime(year: Year, month: Month, day: Day);
            string result =
                $"Miladi To Hebrew:{ hb.GetYear(dt).ToString("0000/") } { hb.GetMonth(dt).ToString("00/") } { hb.GetDayOfMonth(dt).ToString("00") }";
            System.Console.Write(result);
        }

        /// <summary>
        /// متد تبديل تاريخ ميلادي به گريگوريان
        /// </summary>
        public void MiladiToGregorian()
        {
            GregorianCalendar gc = new GregorianCalendar();
            DateTime dt = new DateTime(year: Year, month: Month, day: Day);
            string result =
                $"Miladi To Gregorian:{ gc.GetYear(dt).ToString("0000/") } { gc.GetMonth(dt).ToString("00/") } { gc.GetDayOfMonth(dt).ToString("00") }";
            System.Console.Write(result);
        }
        #endregion/متدهاي تبديل تاريخ
    }
}
