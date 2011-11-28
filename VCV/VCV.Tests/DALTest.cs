using VCV;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace VCV.Tests
{
    
    
    /// <summary>
    ///This is a test class for DALTest and is intended
    ///to contain all DALTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DALTest
    {


        private TestContext testContextInstance;

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

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Add
        ///</summary>
        [TestMethod()]
        public void AddTest()
        {
            DAL target = new DAL(); // TODO: Initialize to an appropriate value
            Guid Id = new Guid(); // TODO: Initialize to an appropriate value
            IPoint Current = null; // TODO: Initialize to an appropriate value
            DateTime DeviceTime = new DateTime(); // TODO: Initialize to an appropriate value
            List<IObject> expected = null; // TODO: Initialize to an appropriate value
            List<IObject> actual;
            actual = target.Add(Id, Current, DeviceTime);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
