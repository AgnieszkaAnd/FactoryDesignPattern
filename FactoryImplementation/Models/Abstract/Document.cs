using FactoryImplementation.Models.Interfaces;
using FactoryImplementation.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryImplementation.Models.Abstract {
    abstract class Document : IDocument
    {
        protected IPrinter _printer;

        public List<Page> Pages { get; set; } = new List<Page>();


        public void AddPage(Page page) {
            this.Pages.Add(page);
        }

        public void AddPage(Page page, int index) {
            this.Pages.Insert(index, page);
        }

        public void Print() {
            foreach (Page page in this.Pages) { page.Print(); }
        }

        public abstract void PrintTitle();
    }
}
