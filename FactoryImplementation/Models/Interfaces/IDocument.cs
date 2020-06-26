using FactoryImplementation.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryImplementation.Models.Interfaces {
    interface IDocument {
        //public string Type { get; set; }
        List<Page> Pages { get; set; }

        void AddPage(Page page);

        void Print() {
            Printer.Print(Type);
            foreach (Page page in this.Pages) { page.Print(); }
        }
    }
}
