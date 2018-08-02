using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using taskManager.Models;
using Moq;
using System.Collections.Generic;

namespace taskManager.Tests
{
    [TestClass]
    public class TestTaskManager
    {
        [TestMethod]
        public void TestTaskManager_WhenAddTask_ShoudCallLog()
        {
            // Arrange
            var mockedLogger = new MockedLogger();
            var mockedIdProvider = new MockedIdProvider();

            var taskManager = new Tasker(mockedLogger,mockedIdProvider);

            var task = new Task("");

            // Act

            taskManager.save(task);

            //Assert
            Assert.IsTrue(mockedLogger.isLogCalled);
        }

        public class MockedLogger : Ilogger
        {
            public bool isLogCalled;
            public void Log(string message)
            {
                this.isLogCalled = true;
            }
        }

        public class MockedIdProvider : IIdProvider
        {
            public int Id
            {
                get
                {
                    return 1;
                }
            }
        }

        [TestMethod]
        public void TestTaskManager_WithMoq_WhenAddTask_ShoudCallLog()
        {
            // Arrange
            var mockedLogger = new Mock<Ilogger>();
            var mockedIdProvider = new Mock<IIdProvider>();

            var taskManager = new Tasker(mockedLogger.Object,mockedIdProvider.Object);

            mockedLogger.Setup(x => x.Log(It.IsAny<string>()));

            var task = new Task("");

            // Act
            taskManager.save(task);

            //Assert
            mockedLogger.Verify();
        }

        [TestMethod]
        public void TestTaskManager_WithMoq_WhenAllTasksCalles_ShoudCallLogTasksCount()
        {
            ICollection<Task> tasks = new List<Task>()
            {
                new Task("1"),
                new Task("2"),
                new Task("3"),
        };

            // Arrange
            var mockedLogger = new Mock<Ilogger>();
            var mockedIdProvider = new Mock<IIdProvider>();

            var taskManager = new Tasker(mockedLogger.Object, mockedIdProvider.Object);
            taskManager.Tasks = tasks;

           // mockedLogger.Setup(x => x.Log(It.IsAny<string>()));

            var task = new Task("");

            // Act
            taskManager.AllTasks();

            //Assert
            mockedLogger.Verify(x =>x.Log(It.IsAny<string>()),Times.Exactly(taskManager.Tasks.Count));
        }
        
        [TestMethod]
        public void TestTaskManager_WithMoq_WhenAddNullShouldThrowsArgNullException()
        {
            // Arrange
            var mockedLogger = new Mock<Ilogger>();
            var mockedIdProvider = new Mock<IIdProvider>();

            var taskManager = new Tasker(mockedLogger.Object, mockedIdProvider.Object);

            mockedLogger.Setup(x => x.Log(It.IsAny<string>())).Throws<ArgumentNullException>();
           // mockedLogger.Setup(x => x.Log(It.Is<string>(y=>y.Equals("TestString")))).Throws<ArgumentNullException>();

            var task = new Task("");

            // Act
            taskManager.save(task);

            //Assert
            mockedLogger.Verify();
        }

        [TestMethod]
        public void TestTaskManager_WithMoq_Add_ShouldCallIDProvider()
        {
            // Arrange
            var mockedLogger = new Mock<Ilogger>();
            var mockedIdProvider = new Mock<IIdProvider>();

            var taskManager = new Tasker(mockedLogger.Object, mockedIdProvider.Object);

            mockedIdProvider.Setup(x => x.Id).Returns(1);

            var task = new Task("");

            // Act
            taskManager.save(task);

            //Assert
            mockedIdProvider.Verify();
        }
    }
}
