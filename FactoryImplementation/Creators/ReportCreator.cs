﻿using FactoryImplementation.Creators.Abstract;
using FactoryImplementation.Models;
using FactoryImplementation.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using FactoryImplementation.View;

namespace FactoryImplementation.Creators {
    class ReportCreator : DocumentCreator {
        public override IDocument CreateDocument(IPrinter printer) {
            return new Report(printer);
        }
    }
}
