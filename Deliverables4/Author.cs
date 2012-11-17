using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Deliverables4
{
    class Author
    {
        private string authorName;

        //Constuctor sets author name
        public Author(string authorName)
        {
            this.authorName = authorName;
        }

        //getter for author class
        public String getName()
        {
            return authorName;
        }

        /**This method returns the number of publication that the author has written
         * Note: his SystematicMappingSystem class has a method that returns the list 
         * of the authorspublications
         * **/

        public int numberOfPublications(SystematicMappingSystem sms, Author chosenAuthor)
        {

            int numPublications = 0;
            Paper[] publication = sms.searchAuthorPublications(chosenAuthor).ToArray();
            foreach (Paper p in publication)
            {
                numPublications++;
            }
            return numPublications;
        }
    }
}
