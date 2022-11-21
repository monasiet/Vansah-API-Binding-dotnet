using OpenQA.Selenium;
using Vansah;
using System;
using System.Diagnostics;

namespace Solution {




    class Program {
        //Required
        private static IWebDriver driver = null;  // Required if screenshot is needed

        //Optional if IssueKey is provided
        private static String testFolderID = "1ba1372f-54ed-11ed-8e52-5658ef8eadd5"; //TestFolder ID to which test Execution is to be perform

        //Optional if TestFolder ID is provided
        private static String issueKey = "VAN-1"; //IssueKey to which test Execution is to be perform

        //Optional 
        private static String sprintName = "VAN Sprint 1"; //Sprint Name for current sprint for which test execution is to be perform

        //Optional
        private static String releaseName = "v1"; //Release Name linked with the current sprint and to the test case.

        //Optional
        private static String environment = "SYS"; //Environment Name to which test execution of a test case is to be perform

        //Required
        private static String testCase = "VAN-C3";


        static void Main(String[] args) {

            Console.WriteLine("Welcome to Vansah Binder");

            VansahNode testExecute = new VansahNode(testFolderID, issueKey);


            //Another way of setting up Test Folder and Jira Issue
            //VansahNode testExecute = new VansahNode();
            //testExecute.SetJIRA_ISSUE_KEY("VAN-1");
            //testExecute.SetTESTFOLDERS_ID("1ba1372f-54ed-11ed-8e52-5658ef8eadd5");


            //Setting Environment,Sprint and Release - Test Property
            testExecute.SetENVIRONMENT_NAME("UAT");
            testExecute.SetRELEASE_NAME("Release-1");
            testExecute.SetJIRA_ISSUE_KEY("ISSUE-1");

            //testExecute.AddtestRunFromJIRAIssue("VAN-C3");
            testExecute.AddTestRunFromTestFolder("VAN-C3");

            //Quick Test (TestCaseKey , Result ID)
            testExecute.AddQuickTestFromJiraIssue("TEST-C1",1);
            //testExecute.AddQuickTestFromTestFolders("TEST-C1", 1);
            
            //Add logs for each step function(ResultID, AcutalResultComment, TestStepID, screenshotTrueorFalse, chromedriver/OtherBroswerdriver);
             testExecute.AddTestLog(2, "This is From Java Binder Add test log", 1, false, driver);

            //Will update the current test log
            // testExecute.updateTestLog(1, "This is From Java Binder Update Test log", false, driver);

            //To remove the current test log
            // testExecute.RemoveTestLog();

            //To remove the current Test Run
            //testExecute.RemoveTestRun();

        }

    }
    
    
    
    }
    






}
