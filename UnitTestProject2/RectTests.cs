using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Rect
{
    [TestClass]
    public class RectTests
    {

        [TestMethod]
        public void CreateCorrectReact_Passing()
        {
            IRectMethod rectMethod = new Mock<IRectMethod>().Object;
            new Rect(1, 1, rectMethod);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void CreateArgumentException_Passing()
        {
            IRectMethod rectMethod = new Mock<IRectMethod>().Object;
            new Rect(-2, -2, rectMethod);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentNullException))]
        public void GenerateError_ThrowsErr()
        {
            new Rect(3, 2, (IRectMethod)null);
        }
    }
}
