using FactoryImplementation.Models.Abstract;
using FactoryImplementation.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryImplementation.Models {
    class CV : Document {

        public CV() : this("No name", "N/A", "N/A", "N/A") { }

        public CV(string personalData)
            : this(personalData, "N/A", "N/A", "N/A") {
        }

        public CV(string personalData, string education)
            : this(personalData, education, "N/A", "N/A") {
        }

        public CV(string personalData, string education, string experience)
            : this(personalData, education, experience, "N/A") {
        }

        public CV(string personalData, string education, string experience, string skills) {
            this._type = "CV";
            Pages.Add(new Page("Personal Data", personalData));
            Pages.Add(new Page("Education", education));
            Pages.Add(new Page("Experience", experience));
            Pages.Add(new Page("Skills", skills));
        }
    }
}
