using FactoryImplementation.Creators;
using FactoryImplementation.Creators.Abstract;
using FactoryImplementation.Models.Interfaces;
using System;

namespace FactoryImplementation {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello Factory!");

            DocumentCreator cv = new CVCreator();
            IDocument cvInstance = cv.CreateDocument();
            cvInstance.Print();
        }
    }
}
