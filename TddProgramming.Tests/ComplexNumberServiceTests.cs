using NUnit.Framework;

namespace TddProgramming.Tests
{
    [TestFixture]
    public class ComplexNumberServiceTests
    {
        private ComplexNumbersService _complexNumberService;
        [SetUp]
        public void Init()
        {
            _complexNumberService = new ComplexNumbersService();
        }


        [Test]
        public void Add_IsNotEqualNull_ReturnTrue()
        {
            var complexNumber1 = new ComplexNumber();
            var complexNumber2 = new ComplexNumber();

            var result = _complexNumberService.Add(complexNumber1, complexNumber2);
            Assert.That(result, Is.Not.Null);
        }

        [Test]
        [TestCase(1, 1, 2)]
        [TestCase(0, 0, 0)]
        [TestCase(0, -1, -1)]
        [TestCase(-3, -5, -8)]
        [TestCase(-3, 3, 0)]
        public void Add_AddRealPartOfComplexNumbers_ReturnNewComplexNumber(int a1, int a2, int expectedResult)
        {
            var complexNumber1 = new ComplexNumber
            {
                A = a1
            };
            var complexNumber2 = new ComplexNumber
            {
                A = a2
            };

            var result = _complexNumberService.Add(complexNumber1, complexNumber2);
            Assert.That(result.A, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(1, 1, 2)]
        [TestCase(0, 0, 0)]
        [TestCase(0, -1, -1)]
        [TestCase(-3, -5, -8)]
        [TestCase(-3, 3, 0)]
        public void Add_AddImaginaryPartOfComplexNumbers_ReturnNewComplexNumber(int bi1, int bi2, int expectedResult)
        {
            var complexNumber1 = new ComplexNumber
            {
                Bi = bi1
            };
            var complexNumber2 = new ComplexNumber
            {
                Bi = bi2
            };

            var result = _complexNumberService.Add(complexNumber1, complexNumber2);
            Assert.That(result.Bi, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Add_CheckIsParametersDifferentFromNull_NoThrowException()
        {
            Assert.That(() => _complexNumberService.Add(null, null), Throws.ArgumentNullException);
        }
    }
}
