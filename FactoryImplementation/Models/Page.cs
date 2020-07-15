using FactoryImplementation.Models.Interfaces;
using FactoryImplementation.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryImplementation.Models {
    public class Page : IPage {
        private string _title;
        private string _content;
        private readonly IPrinter _printer;

        public Page(IPrinter printer) : this(printer, "No title", "No content") { }

        public Page(IPrinter printer, string title) : this(printer, title, "No content") {
            this._title = title;
        }

        public Page(IPrinter printer, string title, string content)
        {
            _printer = printer;
            _title = title;
            _content = content;
        }

        public void Print() {
            _printer.Print(this._title);
        }
    }
}
