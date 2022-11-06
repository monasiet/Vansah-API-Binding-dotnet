using OpenQA.Selenium;
using Practice;
using System;
using System.Diagnostics;

namespace Solution {




    class Program {
        private static WebDriver driver;

        static void Main(String[] args) {

            Console.WriteLine("This is my first program");

            VansahNode testExecute = new VansahNode("1ba1372f-54ed-11ed-8e52-5658ef8eadd5", "VAN-1", "VAN Sprint 1", "v1", "SYS");
            //testExecute.AddtestRunFromJIRAIssue("VAN-C3");
            testExecute.AddTestRunFromTestFolder("VAN-C3");
            for (int i = 1; i <= 3; i++)
            {

                //Add logs for each step function(ResultID, AcutalResultComment, TestStepID, screenshotTrueorFalse, chromedriver/OtherBroswerdriver);
                testExecute.AddtestLog(2, "This is From Java Binder Add test log", i, false, driver);

                //Will update the current test log
               // testExecute.updateTestLog(1, "This is From Java Binder Update Test log", false, driver);

                //To remove the current test log
               // testExecute.RemoveTestLog();

            }
            //testExecute.RemoveTestRun();
        }
    
    
    
    }
    






}
