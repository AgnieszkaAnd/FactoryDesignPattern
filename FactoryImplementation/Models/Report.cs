using FactoryImplementation.Models.Abstract;
using FactoryImplementation.Models.Interfaces;
using FactoryImplementation.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryImplementation.Models {
    class Report : Document
    {

        //private readonly IPrinter _printer;

        public Report(IPrinter printer) : this(printer, "No name", "No content", DateTime.Now) { }

        public Report(IPrinter printer, string reportName)
            : this(printer, reportName, "No content", DateTime.Now) {
        }

        public Report(IPrinter printer, string reportName, string content)
            : this(printer, reportName, content, DateTime.Now) {
        }

        public Report(IPrinter printer, string reportName, string content, DateTime date)
        {
            _printer = printer;
            Pages.Add(new Page("Name", reportName));
            Pages.Add(new Page("Content", content));
            Pages.Add(new Page("Date of generation", date.ToString()));
        }
    }
}
