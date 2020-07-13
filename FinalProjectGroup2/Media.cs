using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectGroup2
{
    abstract class Media
    {
        public string Title { get; set; }
        public string MediaType { get; set; }
        public int SerialNumber;
        public int NumberOfLent { get; set; }
        public bool CurrentStatus { get; set; }
        public string CurrentBorrowMember { get; set; }

        public Media(string title, string mediaType)
        {
            Title = title;
            MediaType = mediaType;
            SerialNumber += SerialNumber;

            CurrentStatus = false;


        }
        public Media(String CurrentBorrowMember)
        {
            this.CurrentBorrowMember = CurrentBorrowMember;
            NumberOfLent += ++NumberOfLent;
            CurrentStatus = true;
        }
    }
}
