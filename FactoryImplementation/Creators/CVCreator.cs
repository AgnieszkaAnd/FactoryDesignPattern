using FactoryImplementation.Creators.Abstract;
using FactoryImplementation.Models;
using FactoryImplementation.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryImplementation.Creators {
    class CVCreator : DocumentCreator {
        public override IDocument CreateDocument() {
            return new CV();
        }
    }
}
