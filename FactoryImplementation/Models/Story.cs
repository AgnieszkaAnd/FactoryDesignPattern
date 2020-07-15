using FactoryImplementation.Models.Abstract;
using FactoryImplementation.Models.Interfaces;
using FactoryImplementation.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryImplementation.Models {
    class Story : Document
    {

        //private readonly IPrinter _printer;

        public Story(IPrinter printer) : this(printer, "Introduction to place here", "To be defined", "To be continued") { }

        public Story(IPrinter printer, string introduction)
            : this(printer, introduction, "To be defined", "To be continued") {
        }

        public Story(IPrinter printer, string introduction, string main)
            : this(printer, introduction, main, "To be continued") {
        }

        public Story(IPrinter printer, string introduction, string main, string ending)
        {
            _printer = printer;
            Pages.Add(new Page(printer, "Introduction", introduction));
            Pages.Add(new Page(printer, "Main Content", main));
            Pages.Add(new Page(printer, "Ending", ending));
        }

        public override void PrintTitle() {
            _printer.Print(this.GetType().ToString().Split(".")[2]);
        }
    }
}
