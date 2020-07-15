using FactoryImplementation.Models.Abstract;
using FactoryImplementation.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryImplementation.Models {
    class Report : Document {

        public Report() : this("No name", "No content", DateTime.Now) { }

        public Report(string reportName)
            : this(reportName, "No content", DateTime.Now) {
        }

        public Report(string reportName, string content)
            : this(reportName, content, DateTime.Now) {
        }

        public Report(string reportName, string content, DateTime date) {
            Pages.Add(new Page("Name", reportName));
            Pages.Add(new Page("Content", content));
            Pages.Add(new Page("Date of generation", date.ToString()));
        }
    }
}
