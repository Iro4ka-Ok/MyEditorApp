using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyEditorLibrary.Tests
{
    [TestClass]
    public class EditorServicesTests
    {
        [TestMethod]
        public void TestNonProcessedPhoto()
        {
            //setup
            const int countPhoto = 10;
            var workerSpeeds = new List<int> { 2, 3, 4 };
            const int expectedTotalMinutes = 10;
            var expectedProcessedImeges = new List<int> { 5, 3, 2 };

            //act
            var editorServices = new EditorServices(countPhoto, workerSpeeds);
            var result = editorServices.Process();

            //result
            Assert.AreEqual(expectedTotalMinutes, result.TotalMinutes);
            for(int i = 0; i < result.ProcessedImeges.Count; i++)
            {
                Assert.AreEqual(expectedProcessedImeges[i], result.ProcessedImeges[i]);
            }
        }

        [TestMethod]
        public void TestNonProcessedPhoto1()
        {
            //setup
            const int countPhoto = 16;
            var workerSpeeds = new List<int> { 1, 2, 3, 4 };
            const int expectedTotalMinutes = 8;
            var expectedProcessedImeges = new List<int> { 8, 4, 2, 2 };

            //act
            var editorServices = new EditorServices(countPhoto, workerSpeeds);
            var result = editorServices.Process();

            //result
            Assert.AreEqual(expectedTotalMinutes, result.TotalMinutes);
            for (int i = 0; i < result.ProcessedImeges.Count; i++)
            {
                Assert.AreEqual(expectedProcessedImeges[i], result.ProcessedImeges[i]);
            }
        }
    }
}
