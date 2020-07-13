using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectGroup2
{
    class Movie:Media
    {
        public int RunTime { get; private set; }
        public Movie(string title) : base(title, "Movie")
        {
            RunTime = 5;
        }
    }
}
