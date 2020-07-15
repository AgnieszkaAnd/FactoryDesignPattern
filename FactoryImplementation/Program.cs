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

            DocumentCreator report = new ReportCreator();
            IDocument reportInstance = report.CreateDocument();
            reportInstance.Print();

            DocumentCreator story = new StoryCreator();
            IDocument storyInstance = story.CreateDocument();
            storyInstance.Print();
        }
    }
}
