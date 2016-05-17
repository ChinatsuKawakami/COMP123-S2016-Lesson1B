using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using  COMP123S2016_LessonB1;

namespace Lesson1TestProject
{
    [TestClass]
    public class Lesson1UnitTest
    {
        [TestMethod]
        public void OutPutStringToConsoleTestMethod()
        {
            
            //Arrange
            string outputString = "Enter UserName: ";
            bool hasNewLine = false;
            string actualResult;
            string expectResult = "Enter UserName: ";

            //Act
            actualResult = Program.OutPutStringToConsole(outputString, hasNewLine);
            //Assert
            Assert.AreEqual(expectResult, actualResult);

        }
    }
}
