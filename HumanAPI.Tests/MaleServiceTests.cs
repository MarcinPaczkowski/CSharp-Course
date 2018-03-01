using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HumanAPI.Models;
using HumanAPI.Services;
using NUnit.Framework;

namespace HumanAPI.Tests
{
    [TestFixture]
    public class MaleServiceTests
    {
        [Test]
        public void Urinate_IsLengthMoreThanZero_MoreThanZero()
        {
            var male = new Male();
            var maleService = new MaleService();
            var result = maleService.Urinate(male);
            Assert.That(result.Length, Is.GreaterThan(0));
        }
    }
}
