using Moq;
using NUnit.Framework;
using FactoryImplementation.View;
using FactoryImplementation.Creators;
using FactoryImplementation.Models;

namespace FactoryImplementationTests {

    [TestFixture]
    public class CreatorTestCases {

        private Mock<IPrinter> printerMock = new Mock<IPrinter>();


        [Test]
        public void CVCreatorReturnsNewCVTypeObject()
        {
            var result = new CVCreator().CreateDocument(printerMock.Object);
            Assert.AreEqual(typeof(CV), result.GetType());
        }

        [Test]
        public void ReportCreatorReturnsNewReportTypeObject() {
            var result = new ReportCreator().CreateDocument(printerMock.Object);
            Assert.AreEqual(typeof(Report), result.GetType());
        }

        [Test]
        public void StoryCreatorReturnsNewStoryTypeObject() {
            var result = new StoryCreator().CreateDocument(printerMock.Object);
            Assert.AreEqual(typeof(Story), result.GetType());
        }
    }
}