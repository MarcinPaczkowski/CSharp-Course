using HealthApp.Enums;
using HealthApp.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthApp.Tests
{
    [TestFixture]
    public class HelthServiceTests
    {
        private HealthService _healthService;

        [SetUp]
        public void Init()
        {
            _healthService = new HealthService();
        }

        [Test]
        public void GetHealthTypeByWeight_IsImplemented_ReturnNothing()
        {
            Assert.That(() =>  _healthService.GetHealthTypeByWeight(80), Throws.Nothing);
        }

        [Test]
        [TestCase(60,HealthType.VeryGood)]
        [TestCase(70, HealthType.VeryGood)]
        [TestCase(55, HealthType.Good)]
        [TestCase(59, HealthType.Good)]
        [TestCase(71, HealthType.Good)]
        [TestCase(74, HealthType.Good)]
        [TestCase(50, HealthType.Common)]
        [TestCase(54, HealthType.Common)]
        [TestCase(75, HealthType.Common)]
        [TestCase(79, HealthType.Common)]
        [TestCase(45, HealthType.Bad)]
        [TestCase(49, HealthType.Bad)]
        [TestCase(80, HealthType.Bad)]
        [TestCase(84, HealthType.Bad)]
        [TestCase(44, HealthType.VeryBad)]
        [TestCase(85, HealthType.VeryBad)]
        public void GetHealthTypeByWeight_IsCalculatedProperly_ReturnProperHealthType(int weight, HealthType healthType)
        {
            var calculatedHealthType = _healthService.GetHealthTypeByWeight(weight);
            Assert.That(calculatedHealthType, Is.EqualTo(healthType));
        }

        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        public void GetHealthTypeByWeight_WeightIsLessOrEqualZero_ReturnException(int weight)
        {
            Assert.That(() => _healthService.GetHealthTypeByWeight(weight), Throws.Exception);
        }
    }
}
