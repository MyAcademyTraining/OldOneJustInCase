using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using TestDriven;

namespace UnitTestProject1
{
//    [TestClass]
//    public class UnitTest1
//    {
//        [TestCase(-1)]
//        [TestCase(10)]
//        public void IdShouldBeCreated()
//        {
//            // Arange
//            var sut = new Task();
//            NUnit.Framework.Assert.DoesNotThrow(() => sut.id = value);
//        }

//    }

    [TestFixture]

    public class Description
    {

        [TestCase(null)]
        [TestCase("")]
        public void DescrptionShouldThrowEceptionWhenNullIsPassing()
        {
            var sut = new Task("");
            NUnit.Framework.Assert.Throws<ArgumentNullException>(() => sut.Descrition = value);
        }


    }
}
