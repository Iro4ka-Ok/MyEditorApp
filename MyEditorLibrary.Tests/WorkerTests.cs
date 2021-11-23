using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyEditorLibrary.Tests
{
    [TestClass]
    public class WorkerTests
    {
        [TestMethod]
        public void TestProcessedPhoto()
        {
            //setup
            const int speed = 2;
            const int time = 2;
            const int expectedSumPhoto = 1;

            //act
            Worker worker = new Worker(speed);
            worker.PrintProcessOfPhoto(time);

            //result
            Assert.AreEqual(expectedSumPhoto, worker.sumPhoto);
        }

        [TestMethod]
        public void TestNonProcessedPhoto()
        {
            //setup
            const int speed = 3;
            const int time = 2;
            const int expectedSumPhoto = 0;

            //act
            Worker worker = new Worker(speed);
            worker.PrintProcessOfPhoto(time);

            //result
            Assert.AreEqual(expectedSumPhoto, worker.sumPhoto);
        }
    }
}
