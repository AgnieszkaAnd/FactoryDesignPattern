using FactoryImplementation.Creators;
using FactoryImplementation.Creators.Abstract;
using FactoryImplementation.Models.Interfaces;
using System;
using FactoryImplementation.View;

namespace FactoryImplementation {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Hello Factory!");

            IPrinter mainPrinter = new Printer();

            DocumentCreator cv = new CVCreator();
            IDocument cvInstance = cv.CreateDocument(mainPrinter);
            cvInstance.Print();

            DocumentCreator report = new ReportCreator();
            IDocument reportInstance = report.CreateDocument(mainPrinter);
            reportInstance.Print();

            DocumentCreator story = new StoryCreator();
            IDocument storyInstance = story.CreateDocument(mainPrinter);
            storyInstance.Print();
        }
    }
}
