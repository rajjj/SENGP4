using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Deliverables4;

namespace Deliverable4UnitTests
{
    [TestClass]
    public class Story12_SystemTests
    {
        ///<summary>
        ///Test: Normal valid input 
        ///Info: Select an author and get his correct number of publications (single publication)
        /// </summary>
        [TestMethod]
        public void AuthorPublication_NormalPath()
        {
            Paper publication = new Paper("P1");
            Author chosenAuthor = new Author("name1");
            publication.addAuthor(chosenAuthor); // add author to paper
            SystematicMappingSystem sms = new SystematicMappingSystem();
            sms.AddPaper(publication); // add paper to the system
            int expected = chosenAuthor.numberOfPublications(sms, chosenAuthor); // get the number of papers author has wrote
            int actual = 1; // only 1 paper should exist 
            Assert.AreEqual(expected, actual);
        }
        ///<summary> 
        /// Test: Normal valid input 
        /// Info: Select an author and get his correct number of publications (multiple publications)
        /// </summary>

        [TestMethod]
        public void AuthorPublication_mutiplePublications()
        {
            Paper publication1 = new Paper("P1");
            Paper publication2 = new Paper("P2");
            Paper publication3 = new Paper("P3");
            Author chosenAuthor = new Author("name2");
            //add authors to papers
            publication1.addAuthor(chosenAuthor);
            publication2.addAuthor(chosenAuthor);
            publication3.addAuthor(chosenAuthor);
            SystematicMappingSystem sms = new SystematicMappingSystem();
            //add papers to the system
            sms.AddPaper(publication1);
            sms.AddPaper(publication2);
            sms.AddPaper(publication3);
            int expected = chosenAuthor.numberOfPublications(sms, chosenAuthor);
            int actual = 3; // author has written three papers
            Assert.AreEqual(expected, actual);

        }

        ///<summary>
        ///Test: Normal valid input 
        ///Info: Author has no publications
        /// </summary>

        [TestMethod]
        public void AuthorPublication_noPublications()
        {
            Paper publication = new Paper("P1");
            string noPublicationAuthor = "name";
            Author chosenAuthor = new Author(noPublicationAuthor);
            SystematicMappingSystem sms = new SystematicMappingSystem();
            sms.AddPaper(publication);
            int expected = chosenAuthor.numberOfPublications(sms, chosenAuthor);
            int actual = 0; // should be no papers
            Assert.AreEqual(expected, actual);
        }


        /// <summary>
        ///Test: Normal valid input 
        ///Info: Author does not exist 
        /// </summary>
        [TestMethod]
        public void AuthorPublication_authorDoesNotExist()
        {
            Paper publication = new Paper("P1");
            string fakeAuthor = "Joe";
            Author chosenAuthor = new Author(fakeAuthor);
            SystematicMappingSystem sms = new SystematicMappingSystem();
            sms.AddPaper(publication);
            int expected = chosenAuthor.numberOfPublications(sms, chosenAuthor);
            int actual = 0;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Test: invalid input 
        ///info: String of integers for author's name
        /// </summary>
        [TestMethod]
        public void AuthorPublication_invalidAuthorName_integer()
        {
            string invalidName = "123";
            Paper publication = new Paper("P1");
            Author chosenAuthor = new Author(invalidName);
            SystematicMappingSystem sms = new SystematicMappingSystem();
            sms.AddPaper(publication);
            int expected = chosenAuthor.numberOfPublications(sms, chosenAuthor);
            int actual = 0;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        ///Test: invalid input 
        ///info: Empty string for author's name
        /// </summary>
        [TestMethod]
        public void AuthorPublication_invalidAuthorName_EmptyString()
        {
            Paper publication = new Paper("P1");
            string invalidName = "";
            Author chosenAuthor = new Author(invalidName);
            SystematicMappingSystem sms = new SystematicMappingSystem();
            sms.AddPaper(publication);
            int expected = chosenAuthor.numberOfPublications(sms, chosenAuthor);
            int actual = 0;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Test: invalid input 
        ///info: Control characters for author's name
        /// </summary>
        [TestMethod]
        public void AuthorPublication_invalidAuthorName_controlCharacters()
        {
            Paper publication = new Paper("P1");
            string invalidName = "./(())())()()";
            Author chosenAuthor = new Author(invalidName);
            SystematicMappingSystem sms = new SystematicMappingSystem();
            sms.AddPaper(publication);
            int expected = chosenAuthor.numberOfPublications(sms, chosenAuthor);
            int actual = 0;
            Assert.AreEqual(expected, actual);
        }
    }
}
