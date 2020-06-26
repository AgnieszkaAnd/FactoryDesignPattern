using FactoryImplementation.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryImplementation.Models {
    class Report : IDocument {

        public List<Page> Pages { get; set; } = new List<Page>();


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

        public void AddPage(Page page) {
            this.Pages.Add(page);
        }

        public void AddPage(Page page, int index) {
            this.Pages.Insert(index, page);
        }
    }
}
