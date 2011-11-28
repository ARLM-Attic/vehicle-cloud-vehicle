using VCV;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace VCV.Tests
{
    /// <summary>
    ///This is a test class for PointTest and is intended
    ///to contain all PointTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PointTest
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
        ///A test for GetDistance
        ///</summary>
        [TestMethod()]
        public void GetDistanceTest()
        {
            // distance between Richmond, Virginia USA and São Paulo, Brazil    
            // Google Earth says this should be about 7527.806 km

            Point richmond = new Point();
            richmond.Latitude = 37.542979;
            richmond.Longitude = -77.469092;

            IPoint saopaulo = new Point();
            saopaulo.Latitude = -23.548943;
            saopaulo.Longitude = -46.638818;

            //double expected = 7527.806;
            double actual;
            actual = richmond.GetDistance(saopaulo);
            Assert.IsTrue(7525.90 > actual);
            Assert.IsTrue(actual > 7525.80);
        }
    }
}
