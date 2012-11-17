using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Deliverables4
{
    class Keyword
    {
            private string keyword;

            //constructor sets the keyword
            public Keyword(string k)
            {
                if( k == null)
                {
                    throw new ArgumentNullException("Invalid Keyword");
                }

                this.keyword = k;
            }

            //getter method for keyword
            public String getKeyword()
            {
                return keyword;
            }
     }
}
