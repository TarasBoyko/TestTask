using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.RailFenceCipher.Tests
{
    // Tests RailFenceCipher class.
    [TestClass()]
    public class RailFenceCipherTests
    {
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
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

        // Tests RailFenceCipher.EncodeString method.
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
                    "RailFenceCipher\\DataSource.xml",
                    "Row",
                    DataAccessMethod.Sequential)]
        [TestMethod]
        public void EncodeStringTest()
        {
            string decodedString = Convert.ToString(TestContext.DataRow["decodedString"]);
            int numberOfRails = Convert.ToInt32(TestContext.DataRow["numberOfRails"]);
            string expectedResult = Convert.ToString(TestContext.DataRow["encodedString"]);

            string actualResult = RailFenceCipher.EncodeString(decodedString, numberOfRails);

            Assert.AreEqual(expectedResult, actualResult, "expected and actual results are not equal.\ndecodedString = " + decodedString + "\nnumberOfRails = " + numberOfRails);
        }

        // Tests RailFenceCipher.DecodeString method.
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "RailFenceCipher\\DataSource.xml",
            "Row",
            DataAccessMethod.Sequential)]
        [TestMethod]
        public void DecodeStringTest()
        {
            string encodedString = Convert.ToString(TestContext.DataRow["encodedString"]);
            int numberOfRails = Convert.ToInt32(TestContext.DataRow["numberOfRails"]);
            string expectedResult = Convert.ToString(TestContext.DataRow["decodedString"]);

            string actualResult = RailFenceCipher.DecodeString(encodedString, numberOfRails);

            Assert.AreEqual(expectedResult, actualResult, "expected and actual results are not equal.\ndecodedString = " + encodedString + "\nnumberOfRails = " + numberOfRails);
        }
    }
}