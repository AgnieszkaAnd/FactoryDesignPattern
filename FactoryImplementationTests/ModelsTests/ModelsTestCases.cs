using System;
using System.Reflection.Metadata;
using Moq;
using NUnit.Framework;
using FactoryImplementation.View;
using FactoryImplementation.Creators;
using FactoryImplementation.Models;
using FactoryImplementation.Models.Interfaces;

namespace FactoryImplementationTests {

    [TestFixture]
    public class ModelsTestCases {

        private Mock<IPrinter> printerMock = new Mock<IPrinter>();
        private Mock<IPage> pageMock = new Mock<IPage>();
        private Mock<IPage> pageMock2 = new Mock<IPage>();
        private Mock<IPage> pageMock3 = new Mock<IPage>();


        // Test of abstract class methods implementations by using one of the derived classes instance (CV)
        [Test]
        public void AddPage_IncreasesCountOfPagesPropertiesByOne() {
            var document = new CV(printerMock.Object);
            var documentPagesCount = document.Pages.Count;
            
            document.AddPage(pageMock.Object);

            Assert.AreEqual(documentPagesCount+1, document.Pages.Count);
        }


        [Test]
        public void AddPageWithIndex_InsertsPageAtCorrectIndexInList() {
            var document = new CV(printerMock.Object);
            document.Pages.Add(pageMock.Object);
            document.Pages.Add(pageMock2.Object);
            document.Pages.Add(pageMock3.Object);

            document.AddPage(pageMock3.Object, 1);

            // IT FAILS - how to test that?
            Assert.AreEqual(document.Pages[0], pageMock.Object);
            Assert.AreEqual(document.Pages[1], pageMock3.Object);
            Assert.AreEqual(document.Pages[2], pageMock2.Object);
            Assert.AreEqual(document.Pages[3], pageMock3.Object);
        }


        [Test]
        public void Print_CallsPrintMethods() {
            var document = new CV(printerMock.Object);
            // Test if Print method displays correct results
            throw new NotImplementedException();
        }

    }
}