using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGenerator
{
    class ExcelReport : ReportBuilder
    {
        public override void SetReportType()
        {
            reportObject.ReportType = "Excel";
        }

        public override void SetHeader()
        {
            reportObject.ReportHeader = "Excel Header";
        }

        public override void SetContent()
        {
            reportObject.ReportContent = "Excel Content";
        }

        public override void SetFooter()
        {
            reportObject.ReportFooter = "Excel Footer";
        }
    }
}
