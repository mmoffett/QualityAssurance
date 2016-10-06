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
           testapp = ApplicationUnderTest.Launch(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe\");
        }

        [TestMethod]
        //This Test is checking if the search bar can find whitworth
        public void SearchOnWhitworth()
        {
            this.UIMap.SearchOnWhitworth();
        }
        [TestMethod]
        //this test is checking if the map will let you search for a location in a different continent
        public void SearchOverSeas()
        {
            this.UIMap.SearchOverSeas();
        }
        [TestMethod]
        //this test is checking that the map will let you search on Cuba
        public void GoToCuba()
        {
            this.UIMap.GoToCuba();
        }
        [TestMethod]
        //this test attempts to go between two islands to check that the map will not let you drive across water
        public void interHawaii()
        {
            this.UIMap.InterHawaii();
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
