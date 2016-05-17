using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author: Chinatsu Kawakami
 * Date: May 16th, 2016
 * Date Modified: May 16th, 2016
 * Student Id: 300821245
 * Description: This program demonstrates GitHub and version control
 * best practices. We also explore Unit Testing
 * 
 * Version: 0.5 -Added Lesson1UnitTest
 */
namespace COMP123S2016_LessonB1
{/**
  * This is the driver class for our program
  * 
  * @class Program
  *
  */
   public class Program
    {
        /**
         *Main Method for Program
         *
         *@param {string[]}args
         *@constructror Main
         *
         */
        static void Main(string[] args)
        {
            GetUserName();
        }

        /**
         * This method read UseName from the Console
         * 
         * @method GetUserName
         * @return {string} UserName
         */
        public static string GetUserName()
        {   //initialize variables
            string UserName = "";
            OutPutStringToConsole("Enter UserName: ",true);
            UserName = Console.ReadLine();

            Console.WriteLine("\n===================\n");
            Console.WriteLine("You Entered: "+UserName+"\n");
            return UserName;
        }
        /**
         * This method writes a strint to console Parameters allows the user to
         * choose to add a newline character
         * 
         * @method OutPutstringToConsole
         * @param {string} outputString
         * @param {bool} hasNewLine
         * @return{string} outputString
         */
        public static string OutPutStringToConsole(string outputString, bool hasNewLine)
        {
            if(hasNewLine)
            {
                Console.WriteLine(outputString);
            }else
            {
                Console.Write(outputString);
            }
           
           
            return outputString;
        }
    }
}
