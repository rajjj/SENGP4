using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Deliverables4;

namespace Deliverable4UnitTests
{
    [TestClass]
    public class Story2_SystemTests
    {
        /// <summary>
        /// test a single valid keyword
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            //Create Keyword and Paper
            Keyword expectedKeyword = new Keyword("Testing");
            Paper expectedPaper = new Paper("Some Paper About Testing");

            //Add keyword to paper
            expectedPaper.AddKeyword(expectedKeyword);

            //A mapping system to store the papers in 
            SystematicMappingSystem sms = new SystematicMappingSystem();
            //Add paper to the system
            sms.AddPaper(expectedPaper);

            List<Keyword> keyWordsList = sms.GetKeywordsFromPaper("Some Paper About Testing");
            Assert.IsTrue(expectedKeyword.Equals(keyWordsList.First()) && keyWordsList.Count() == 1);
        }

        /// <summary>
        /// test a multiple valid keyword
        /// </summary>
        [TestMethod]
        public void TestMethod2()
        {
            //Create Keyword and Paper
            Keyword[] expectedKeywords = { new Keyword("Testing1"), new Keyword("Testing2"), new Keyword("Testing3"), new Keyword("Testing4") };
            Paper expectedPaper = new Paper("Some Paper About Testing");

            //Add keywords to paper
            foreach (Keyword keyword in expectedKeywords)
            {
                expectedPaper.AddKeyword(keyword);
            }

            //A mapping system to store the papers in 
            SystematicMappingSystem sms = new SystematicMappingSystem();
            //Add paper to the system
            sms.AddPaper(expectedPaper);

            List<Keyword> keyWordsList = sms.GetKeywordsFromPaper("Some Paper About Testing");
            Assert.IsTrue(expectedKeywords[0].Equals(keyWordsList.First()) && keyWordsList.Count() == 4);
        }

        /// <summary>
        /// test with a null string
        /// </summary>
        [TestMethod, ExpectedExceptionAttribute(typeof(ArgumentNullException), "Invalid Keyword")]
        public void TestMethod3()
        {
            //Create Keyword and Paper
            Keyword expectedKeyword = new Keyword(null);
            Paper expectedPaper = new Paper("Some Paper About Testing");

            //Add keyword to paper
            expectedPaper.AddKeyword(expectedKeyword);

            //A mapping system to store the papers in 
            SystematicMappingSystem sms = new SystematicMappingSystem();
            //Add paper to the system
            sms.AddPaper(expectedPaper);

            List<Keyword> keyWordsList = sms.GetKeywordsFromPaper("Some Paper About Testing");
            Assert.Fail();
        }

        /// <summary>
        /// test with a large string
        /// </summary>
        [TestMethod]
        public void TestMethod4()
        {
            //Create Keyword and Paper
            Keyword expectedKeyword = new Keyword("abcdefghijklmnopqrstuvwxyznowiknowmyabcsnexttimewontyousingwithme");
            Paper expectedPaper = new Paper("Some Paper About Testing");

            //Add keyword to paper
            expectedPaper.AddKeyword(expectedKeyword);

            //A mapping system to store the papers in 
            SystematicMappingSystem sms = new SystematicMappingSystem();
            //Add paper to the system
            sms.AddPaper(expectedPaper);

            List<Keyword> keyWordsList = sms.GetKeywordsFromPaper("Some Paper About Testing");
            Assert.IsTrue(keyWordsList.Count() == 1);
        }
    }
}
