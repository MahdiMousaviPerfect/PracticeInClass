namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DatesConverter dc = new DatesConverter(2019, 01, 22);// روز سه شنبه مورخ 2 بهمن 1397
            dc.MiladiToShamsi();
            System.Console.WriteLine(System.Environment.NewLine);
            dc.MiladiToGhamari();
            System.Console.WriteLine(System.Environment.NewLine);
            dc.MiladiToHebrew();
            System.Console.WriteLine(System.Environment.NewLine);
            dc.MiladiToGregorian();
            System.Console.WriteLine(System.Environment.NewLine);
            System.Console.Write("Press [Enter] To Exit Program!");
            System.Console.ReadLine();
            // end/end
        }
    }
}
