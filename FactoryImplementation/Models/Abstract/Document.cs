using FactoryImplementation.Models.Interfaces;
using FactoryImplementation.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryImplementation.Models.Abstract {
    public abstract class Document : IDocument
    {
        protected IPrinter _printer;

        public List<IPage> Pages { get; set; } = new List<IPage>();


        public void AddPage(IPage page) {
            this.Pages.Add(page);
        }

        public void AddPage(IPage page, int index) {
            this.Pages.Insert(index, page);
        }

        public void Print() {
            _printer.Print(this.GetType().ToString().Split(".")[2]);
            foreach (IPage page in this.Pages) { page.Print(); }
        }
    }
}
