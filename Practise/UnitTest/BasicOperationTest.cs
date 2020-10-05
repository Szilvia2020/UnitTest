using System;
using System.Collections.Generic;
using System.Text;
using BL;
using NUnit.Framework;


namespace UnitTest
{
    public class BasicOperationTest
    {
        [Test]

        public void Test_Add_OK()
        {
            var basicOperation = new BasicOperation();
            var resuts = basicOperation.Add(5, 5);

            Assert.AreEqual(10, resuts);
        }

        public void Test_Substraction_OK()
        {
            var basicOperation = new BasicOperation();
            var resuts = basicOperation.Subtraction(6, 2);

            Assert.AreEqual(4, resuts);
        }
    }
}
