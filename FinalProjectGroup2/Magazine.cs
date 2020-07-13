using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectGroup2
{
    class Magazine:Book
    {
        public int IssueNumber { get; private set; }

        public Magazine(string title) : base(title, "Magazine")
        {
            IssueNumber = 500;
        }
    }
}
