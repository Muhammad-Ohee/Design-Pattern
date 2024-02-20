//Console.WriteLine("Hello, OS");

namespace ReportGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Client Code

            Report report;
            ReportDirector reportDirector = new ReportDirector();

            //PDF Generator
            PDFReport pdfReport = new PDFReport();
            report = reportDirector.MakeReport(pdfReport);
            report.DisplayReport();

            Console.WriteLine("---------------------------");

            // Excel Generator
            ExcelReport excelReport = new ExcelReport();
            report = reportDirector.MakeReport(excelReport);
            report.DisplayReport();
        }
    }
}

