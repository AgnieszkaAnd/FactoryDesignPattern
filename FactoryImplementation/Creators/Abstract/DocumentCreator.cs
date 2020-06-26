using FactoryImplementation.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryImplementation.Creators.Abstract {
    abstract class DocumentCreator {
        public abstract IDocument CreateDocument();
    }
}
