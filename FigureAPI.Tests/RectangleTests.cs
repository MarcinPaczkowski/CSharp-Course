using NUnit.Framework;

namespace FigureAPI.Tests
{
    [TestFixture]
    public class RectangleTests
    {
        [Test]
        [TestCase(2d, 3d, UnitOfMeasureType.m, 6d)]
        [TestCase(3d, 3d, UnitOfMeasureType.m, 9d)]
        [TestCase(1d, 3d, UnitOfMeasureType.m, 3d)]
        [TestCase(4d, 4d, UnitOfMeasureType.m, 16d)]
        public void Area_GetValue_ReturnArea(double a, double b, UnitOfMeasureType unitOfMeasure, double result)
        {
            var rectangle = new Rectangle(a, b, unitOfMeasure);
            var area = rectangle.Area;
            Assert.That(area, Is.EqualTo(result));
        }

        [Test]
        public void Area_CalculateAreaIsImplemented_NoExceptionThrown()
        {
            var rectangle = new Rectangle(1, 1, UnitOfMeasureType.cm);
            Assert.That(() => rectangle.Area, Throws.Nothing);
        }
    }
}
