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

      
    }
}
