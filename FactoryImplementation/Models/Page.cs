using FactoryImplementation.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryImplementation.Models {
    class Page {
        private string _title;
        private string _content;

        public Page() : this("No title", "No content") { }

        public Page(string title) : this(title, "No content") {
            this._title = title;
        }

        public Page(string title, string content) {
            this._title = title;
            this._content = content;
        }

        public void Print() {
            Printer.Print(this._title);
        }
    }
}
