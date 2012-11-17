using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Deliverables4
{
    class SystematicMappingSystem
    {
        List<Paper> papers = new List<Paper>();


        //Add a paper to end of list
        public void AddPaper(Paper somePaper)
        {
            papers.Add(somePaper);
        }

         public  List<Keyword> GetKeywordsFromPaper(string p)
        {
            foreach (Paper paper in papers)
            {
                if (paper.getPaperTitle() == p)
                {
                    return new List<Keyword>(paper.getKeywords());
                }
            }

            // paper p does not exist.
            throw new ArgumentException("paper " + p + " not found");
        }
    

        //Search through with Keyword
        public int SearchByKeyword(Keyword expectedKeyword)
        {
            int count = 0;
            //String to compare to
            String expected = expectedKeyword.getKeyword();

            foreach (Paper p in papers)
            {
                Keyword[] temparray = p.getKeywords();
                for (int i = 0; i < temparray.Length; i++)
                {
                    if (temparray[i].getKeyword().Equals(expected))
                    {
                        count++;
                    }

                }
            }
            return count;
        }
        public List<Paper> searchAuthorPublications(Author chosenAuthor)
        {
            // int numPublications = 0;
            List<Paper> authorPublication = new List<Paper>();
            foreach (Paper p in papers)
            {

                Author[] temparray = p.getAuthor();
                for (int i = 0; i < temparray.Length; i++)
                {
                    if (temparray[i].getName().Equals(chosenAuthor.getName()))
                    {
                        authorPublication.Add(p);
                    }
                }
            }
            return authorPublication;
        }
    }
}
