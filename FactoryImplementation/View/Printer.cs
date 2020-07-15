using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryImplementation.View {
    class Printer : IPrinter {
        public void Print(string text) {
            Console.WriteLine(text);
        }
    }
}
