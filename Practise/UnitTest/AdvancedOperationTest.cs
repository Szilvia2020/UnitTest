using BL;
using System;
using NUnit.Framework;
using Moq;

namespace UnitTest
{
    public class AdvancedOperationTest
    {
        [Test]
        public void Test_Multiply_Ok()
        {
            var basicOperation = new Mock<IBasicOperation>();
            basicOperation.Setup(x => x.Add(It.IsAny<int>(), It.IsAny<int>())).Returns(1);

            var advancedOperation = new AdvancedOperation(basicOperation.Object);
            var resuts = advancedOperation.Multiply(5, 5);

            Assert.AreEqual(1, resuts);
            basicOperation.Verify(mock => mock.Add(It.IsAny<int>(), It.IsAny<int>()), Times.Exactly(5));
        }

        [Test]
        public void Test_Division_Ok()
        {
            var basicOperation = new Mock<IBasicOperation>();
            basicOperation.Setup(x => x.Subtraction(It.IsAny<int>(), It.IsAny<int>())).Returns(1);

            var advancedOperation = new AdvancedOperation(basicOperation.Object);
            var resuts = advancedOperation.Division(5, 5);

            Assert.AreEqual(1, resuts);
            basicOperation.Verify(mock => mock.Subtraction(It.IsAny<int>(), It.IsAny<int>()), Times.Exactly(1));
        }

        [Test]
        public void Test_Fibbonacci_OK()
        {
            var basicOperation = new Mock<IBasicOperation>();
            basicOperation.Setup(x => x.Add(It.IsAny<int>(), It.IsAny<int>())).Returns(1);
            basicOperation.Setup(x => x.Subtraction(It.IsAny<int>(), It.IsAny<int>())).Returns(1);

            var advancedOperation = new AdvancedOperation(basicOperation.Object);
            var resuts = advancedOperation.GetFibbonacci(5);

            Assert.AreEqual(1, resuts);
            basicOperation.Verify(mock => mock.Add(It.IsAny<int>(), It.IsAny<int>()), Times.Exactly(3));
            basicOperation.Verify(mock => mock.Subtraction(It.IsAny<int>(), It.IsAny<int>()), Times.Exactly(3));

        }
    }
}
