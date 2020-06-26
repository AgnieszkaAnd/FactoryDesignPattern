using FactoryImplementation.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryImplementation.Models {
    class Story : IDocument {
        public List<Page> Pages { get; set; } = new List<Page>();


        public Story() : this("Introduction to place here", "To be defined", "To be continued") { }

        public Story(string introduction)
            : this(introduction, "To be defined", "To be continued") {
        }

        public Story(string introduction, string main)
            : this(introduction, main, "To be continued") {
        }

        public Story(string introduction, string main, string ending) {
            Pages.Add(new Page("Introduction", introduction));
            Pages.Add(new Page("Main Content", main));
            Pages.Add(new Page("Ending", ending));
        }

        public void AddPage(Page page) {
            this.Pages.Add(page);
        }

        public void AddPage(Page page, int index) {
            this.Pages.Insert(index, page);
        }
    }
}
