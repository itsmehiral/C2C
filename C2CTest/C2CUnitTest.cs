using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using C2C;

namespace C2CTest
{
    [TestClass]
    public class C2CUnitTest
    {
        private  Mock<ICamera> _mock;

        //Negative test case. Check if camera is null then throw exception
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestThrowExceptionIfCameraIsNull()
        {
            ZoomInCommand obj = new ZoomInCommand(null);
            obj.ExecuteCommand();
        }

        //ZoomIn
        [TestMethod]
        public void TestZoomIn()
        {
            _mock = new Mock<ICamera>();
            ZoomInCommand obj = new ZoomInCommand(_mock.Object);
            obj.ExecuteCommand();
            _mock.Verify(a => a.ZoomIn(), Times.Once);           
        }

        //ZoomOut
        [TestMethod]
        public void TestZoomOut()
        {
            _mock = new Mock<ICamera>();
            ZoomOutCommand obj = new ZoomOutCommand(_mock.Object);
            obj.ExecuteCommand();
            _mock.Verify(a => a.ZoomOut(), Times.Once);
        }

    }
}
