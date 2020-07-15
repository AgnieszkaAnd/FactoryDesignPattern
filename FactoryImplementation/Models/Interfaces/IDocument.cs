using FactoryImplementation.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryImplementation.Models.Interfaces {
    public interface IDocument {
        List<IPage> Pages { get; set; }

        void AddPage(IPage page);

        void Print();
    }
}
