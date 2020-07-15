using FactoryImplementation.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using FactoryImplementation.View;

namespace FactoryImplementation.Creators.Abstract {
    public abstract class DocumentCreator {
        public abstract IDocument CreateDocument(IPrinter printer);
    }
}
