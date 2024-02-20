using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace ReportGenerator
{
    class PDFReport : ReportBuilder
    {
        public override void SetReportType()
        {
            reportObject.ReportType = "PDF";
        }

        public override void SetHeader()
        {
            reportObject.ReportHeader = "PDF Header";
        }

        public override void SetContent()
        {
            reportObject.ReportContent = "PDF Content";
        }

        public override void SetFooter()
        {
            reportObject.ReportFooter = "PDF Footer";
        }
    }
}
