using FactoryImplementation.Models.Interfaces;
using FactoryImplementation.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryImplementation.Models.Abstract {
    abstract class Document : IDocument
    {
        private readonly IPrinter _printer;

        public List<Page> Pages { get; set; } = new List<Page>();


        public void AddPage(Page page) {
            this.Pages.Add(page);
        }

        public void AddPage(Page page, int index) {
            this.Pages.Insert(index, page);
        }

        public void Print() {
            _printer.Print(this.GetType().ToString().Split(".")[2]);
            foreach (Page page in this.Pages) { page.Print(); }
        }
    }
}
