using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace Waze2
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {
        private ApplicationUnderTest testapp;
        public CodedUITest1()
        {
        }
        [TestInitialize]
        public void Initialize()
        {
            testapp = ApplicationUnderTest.Launch(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe");
            // this.UIMap.OpenWazeWebsite();
            //this.UIMap.OpenWaze2();

        }

        [TestMethod]
        //This Test is checking if the search bar can find whitworth. This should work
        public void SearchOnWhitworth()
        {
            // this.UIMap.SearchOnWhitworth();
            // this.UIMap.Whitworth2();
            this.UIMap.Whitworth3();


        }
        [TestMethod]
        //this test is checking if the map will let you search for a location in a different continent. This Should Fail
        public void SearchOverSeas()
        {
            this.UIMap.SearchOverSeas();
        }
        [TestMethod]
        //this test is checking that the map will let you search on Cuba. This Should Fail
        public void GoToCuba()
        {
            this.UIMap.GoToCuba();
        }
        [TestMethod]
        //this test attempts to go between two islands to check that the map will not let you drive across water. This should fail
        public void interHawaii()
        {
            this.UIMap.InterHawaii();
        }
        [TestMethod]
        //This test checks to see how it reacts to searching the same thing over and over again. This should work (how long until it fails)
        public void stressTest()
        {
            for (int i = 0; i < 100; i++)
            {
                this.UIMap.GoToCostco();
            }
        }
        [TestMethod]
        //This searches for directions between two on campus buildings. This should work
        public void betweenBuildings()
        {
            this.UIMap.BetweenBuildings();
        }
        [TestMethod]
        //This is testing the response to going out of the country. We expect this test to succeed
        public void CountrySwap()
        {
            this.UIMap.GoToCanada();
        }
        [TestMethod]
        //This is testing how waze responds to ferrys in a route. It should succeed
        public void ferryRun()
        {
            this.UIMap.FerryRun();
        }
        [TestMethod]
        //This tests how waze deals with military bases. We expect that it should be able to find a route.
        public void baseTry()
        {
            this.UIMap.FortSearch();
        }
        [TestMethod]
        //This tests how far the program can search north/south. We expect it to succeed or give the error message on over 1000 miles
        public void NS()
        {
            this.UIMap.WhitToScripps();
            this.UIMap.WhitToSantaClara();
            this.UIMap.WhitToSanDiego();
        }
        [TestMethod]
        //This tests how far the program can search east/west. We expect this distance to fail
        public void EW()
        {
            this.UIMap.EastWest();
        }
        [TestCleanup()]
        public void myTestCleanUp()
        {

            
        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if ((this.map == null))
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
