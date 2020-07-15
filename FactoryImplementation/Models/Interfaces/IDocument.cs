using FactoryImplementation.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryImplementation.Models.Interfaces {
    interface IDocument {
        List<Page> Pages { get; set; }

        void AddPage(Page page);

        void Print();

        void PrintTitle();
    }
}
