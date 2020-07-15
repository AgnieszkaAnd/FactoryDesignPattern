using FactoryImplementation.Models.Abstract;
using FactoryImplementation.Models.Interfaces;
using FactoryImplementation.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryImplementation.Models {
    class CV : Document
    {


        public CV(IPrinter printer) : this(printer, "No name", "N/A", "N/A", "N/A")
        {
        }

        public CV(IPrinter printer, string personalData)
            : this(printer, personalData, "N/A", "N/A", "N/A")
        {
        }

        public CV(IPrinter printer, string personalData, string education)
            : this(printer, personalData, education, "N/A", "N/A")
        {
        }

        public CV(IPrinter printer, string personalData, string education, string experience)
            : this(printer, personalData, education, experience, "N/A")
        {
        }

        public CV(IPrinter printer, string personalData, string education, string experience, string skills)
        {
            _printer = printer;
            Pages.Add(new Page(printer, "Personal Data", personalData));
            Pages.Add(new Page(printer, "Education", education));
            Pages.Add(new Page(printer, "Experience", experience));
            Pages.Add(new Page(printer, "Skills", skills));
        }

        public override void PrintTitle()
        {
            _printer.Print(this.GetType().ToString().Split(".")[2]);
        }
    }
}
