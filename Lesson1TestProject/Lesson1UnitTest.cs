using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using  COMP123S2016_LessonB1;

namespace Lesson1TestProject
{
    /**
     * This class is used ti test the Lesson1 Project
     * used for development only.
     * 
     * @class Lesson1UnitTest
     * 
     */
    [TestClass]
    public class Lesson1UnitTest
    {
        /**
         *Unit Test for OutPutStringToConsoleTestMethod of the program class 
         *@method OutPutStringToConsoleTestMethod
         */
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
