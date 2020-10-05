using System;
using System.Collections.Generic;
using System.Text;
using BL;
using Moq;
using NUnit.Framework;

namespace UnitTest
{
    public class ExpertOperationTest
    {
        [Test]
        public void Test_Expert_Ok()
        {
            var advancedOperation = new Mock<IAdvancedOperation>();
            advancedOperation.Setup(x => x.Multiply(It.IsAny<int>(), It.IsAny<int>())).Returns(1);

            var expertOperation = new ExpertOperation(advancedOperation.Object);
            var resuts = expertOperation.Exponentiation(2, 5);

            Assert.AreEqual(1, resuts);
            advancedOperation.Verify(mock => mock.Multiply(It.IsAny<int>(), It.IsAny<int>()), Times.Exactly(4));
        }

        [Test]
        public void Test_Power_Ok()
        {
            var advancedOperation = new Mock<IAdvancedOperation>();
            advancedOperation.Setup(x => x.Multiply(It.IsAny<int>(), It.IsAny<int>())).Returns(1);

            var expertOperation = new ExpertOperation(advancedOperation.Object);
            var resuts = expertOperation.Power(5, 1);

            Assert.AreEqual(true, resuts);
            advancedOperation.Verify(mock => mock.Multiply(It.IsAny<int>(), It.IsAny<int>()), Times.Exactly(1));
        }

        [Test]
        public void Test_Power_NOk()
        {
            var advancedOperation = new Mock<IAdvancedOperation>();
            advancedOperation.Setup(x => x.Multiply(It.IsAny<int>(), It.IsAny<int>())).Returns(1);

            var expertOperation = new ExpertOperation(advancedOperation.Object);
            var resuts = expertOperation.Power(5, 2);

            Assert.AreEqual(false, resuts);
            advancedOperation.Verify(mock => mock.Multiply(It.IsAny<int>(), It.IsAny<int>()), Times.Exactly(1));
        }

        [Test]
        public void Test_Power2_Ok()
        {
            var expertOperation = new ExpertOperation(new AdvancedOperation(new BasicOperation()));
            var resuts = expertOperation.Power2(2, 4);

            Assert.AreEqual(true, resuts);
        }

        [Test]
        public void Test_Power2_NOk()
        {
            var expertOperation = new ExpertOperation(new AdvancedOperation(new BasicOperation()));
            var resuts = expertOperation.Power(5, 2);

            Assert.AreEqual(false, resuts);
        }
    }
}
