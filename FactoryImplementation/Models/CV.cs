using FactoryImplementation.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryImplementation.Models {
    class CV : IDocument {
        public List<Page> Pages { get; set; } = new List<Page>();

        public CV() : this("No name", "N/A", "N/A", "N/A") { }

        public CV(string personalData)
            : this(personalData, "N/A", "N/A", "N/A") {
        }

        public CV(string personalData, string education)
            : this(personalData, education, "N/A", "N/A") {
        }

        public CV(string personalData, string education, string experience)
            : this(personalData, education, experience, "N/A") {
        }

        public CV(string personalData, string education, string experience, string skills) {
            Pages.Add(new Page("Personal Data", personalData));
            Pages.Add(new Page("Education", education));
            Pages.Add(new Page("Experience", experience));
            Pages.Add(new Page("Skills", skills));
        }

        public void AddPage(Page page) {
            this.Pages.Add(page);
        }

        public void AddPage(Page page, int index) {
            this.Pages.Insert(index, page);
        }

    }
}
