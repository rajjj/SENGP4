using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Deliverables4
{
    class Paper
    {
        //Paper class consists of a string
        private string paperTitle;

        //List to view all keywords with that paper
        private List<Keyword> k;

        //List to view all authors assoicated with given paper
        private List<Author> a;

        //Create a paper object, consists of a string.
        public Paper(string paperTitle)
        {
            this.paperTitle = paperTitle;
            k = new List<Keyword>();
            a = new List<Author>();
        }

        //Add a keyword to the paper
        public void AddKeyword(Keyword newkeyword)
        {
            k.Add(newkeyword);

        }

        //Add a Author to the paper
        public void addAuthor(Author newAuthor)
        {
            a.Add(newAuthor);

        }

        //changes keyword list into keyword array and returns the array
        public Keyword[] getKeywords()
        {
            Keyword[] array = k.ToArray();
            return array;
        }

        //changes author list into author array and returns the array
        public Author[] getAuthor()
        {
            Author[] authorArray = a.ToArray();
            return authorArray;
        }
        public String getPaperTitle()
        {
            return paperTitle;
            
        }

        //public bool findKeyword()
        //{
           // return true;
       // }
    }
}
