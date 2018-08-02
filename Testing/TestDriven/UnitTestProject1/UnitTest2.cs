using System;
using NUnit.Framework;
using NUnit.Compatibility;
using TestDriven;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest2
    {
        
        public void Ctor_ShouldAssignDescriptionWhenInvoked()
        {
            //Arrange
            var expected = "Valid Description";
            var sut = new Task(expected);
            //Act
            Assert.AreEqual(expected,sut);
            
        }
    }
}
